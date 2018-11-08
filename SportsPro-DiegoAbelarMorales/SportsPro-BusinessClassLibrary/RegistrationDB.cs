using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsPro_DatabaseClassLibrary;
using System.Data.SqlClient;
using System.Data;

namespace SportsPro_BusinessClassLibrary
{
    public class RegistrationDB
    {


        public void AddRegistration(Registration registration)
        {

            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = TechSupportDB.GetConnection();

            insertCommand.CommandText = "Insert INTO Registrations ( CustomerID, ProductCode, RegistrationDate) VALUES ( @CustomerID,@ProductCode,@RegistrationDate)";


            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@CustomerID", registration.CustomerID);
            insertCommand.Parameters.AddWithValue("@ProductCode", registration.ProductCode);
            insertCommand.Parameters.AddWithValue("@RegistrationDate", registration.RegistrationDate);

            try
            {
                insertCommand.Connection.Open();
                insertCommand.ExecuteNonQuery();

            }

            catch(SqlException ex)
            {
                throw ex; 


            }
            finally
            {
                insertCommand.Connection.Close();
            }




        }


        public bool ProductRegistration(int customerID, string productCode)
        {
            Registration aRegistration = new Registration();

            SqlCommand aCommand = new SqlCommand();
            aCommand.Connection = TechSupportDB.GetConnection();

            aCommand.CommandText = "Select CustomerID, ProductCode FROM Registrations WHERE CustomerID = @CustomerID AND ProductCode = @ProductCode";
            aCommand.CommandType = CommandType.Text;

            aCommand.Parameters.AddWithValue("@CustomerID", customerID);
            aCommand.Parameters.AddWithValue("@ProductCode", productCode);

            try
            {
                aCommand.Connection.Open();
                SqlDataReader aReader = aCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (aReader.Read())
                {

                    aRegistration.CustomerID = (int)aReader["CustomerID"];
                    aRegistration.ProductCode = aReader["ProductCode"].ToString();

                    return true; 
                }

                else
                {
                    aRegistration = null;
                    return false;
                    
                }

            }


            catch (SqlException ex)
            {
                throw ex; 

            }
            finally
            {
                aCommand.Connection.Close(); 

            }





        }

        








    }
}
