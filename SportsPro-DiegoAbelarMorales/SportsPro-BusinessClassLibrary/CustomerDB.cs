using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SportsPro_DatabaseClassLibrary;
using System.Data;

namespace SportsPro_BusinessClassLibrary
{
    public class CustomerDB
    {

        public List<Customer> GetCustomerList()
        {


            List<Customer> listOfCustomers = new List<Customer>();

            SqlCommand aCommand = new SqlCommand();

            aCommand.Connection = TechSupportDB.GetConnection();

            aCommand.CommandText = "SELECT CustomerID, Name FROM Customers";

            aCommand.CommandType = CommandType.Text;

            try
            {

                aCommand.Connection.Open();
                SqlDataReader aReader = aCommand.ExecuteReader
                (CommandBehavior.CloseConnection);

                while (aReader.Read())
                {

                    Customer aCustomer = new Customer();

                    aCustomer.CustomerID = (int)aReader["CustomerID"];
                    aCustomer.Name = aReader["Name"].ToString();
                    listOfCustomers.Add(aCustomer);

                }

                aReader.Close();

            }

            catch (SqlException ex)
            {
                throw ex; 
            }

            finally
            {
                aCommand.Connection.Close();
            }
            return listOfCustomers; 





        }

        public Customer GetCustomerName(int customerID)
        {

            Customer aCustomer = new Customer();

            SqlCommand aCommand = new SqlCommand();

            aCommand.Connection = TechSupportDB.GetConnection();
            aCommand.CommandText = " select Name from Customers Where CustomerID = @CustomerID ";
            aCommand.CommandType = CommandType.Text;

            aCommand.Parameters.AddWithValue("@CustomerID", customerID);

            try
            {
                aCommand.Connection.Open();
                SqlDataReader aReader = aCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (aReader.Read())
                {
                    aCustomer.Name = aReader["Name"].ToString();


                }

                else
                {
                    aCustomer = null;
                }

                aReader.Close();
   

            }
        
            catch (SqlException ex)
            {
                throw ex; 
            }

            finally
            {
                aCommand.Connection.Close();
            }

            return aCustomer; 




        }

    }
}
