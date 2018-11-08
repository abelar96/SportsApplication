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
    public class IncidentDB
    {
        
        public IncidentDB() { }

        public List<Incident> GetOpenIncidents()
        {
            SqlCommand aCommand = new SqlCommand();

            aCommand.Connection = TechSupportDB.GetConnection();


            string selectStatement ="Select ProductCode, DateOpened,Customers.Name,Technicians.Name AS Technician,Title FROM Incidents left outer join Technicians on Incidents.TechID = Technicians.TechID inner JOIN Customers on Incidents.CustomerID = Customers.CustomerID WHERE DateClosed is NULL";

            aCommand.CommandText = selectStatement;
                
                
                
            aCommand.CommandType = CommandType.Text;

            List<Incident> listOfIncidents = new List<Incident>();
            try
            {
                aCommand.Connection.Open();


                SqlDataReader aReader = aCommand.ExecuteReader
                       (CommandBehavior.CloseConnection);

                while (aReader.Read())
                {
                    Incident anIncident = new Incident();
                    anIncident.ProductCode = aReader["ProductCode"].ToString();
                    anIncident.DateOpened = (DateTime)aReader["DateOpened"];
                    anIncident.CustomerName = aReader["Technician"].ToString();
                    anIncident.TechName = aReader["Technician"].ToString();
                    anIncident.Title = aReader["Title"].ToString();
                    
                    

                    listOfIncidents.Add(anIncident);



                }

            
            

                return listOfIncidents;
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

   
        public List<Incident> GetOpenTechnicianIncidents(int techID)
        {

            SqlCommand aCommand = new SqlCommand();
            aCommand.Connection = TechSupportDB.GetConnection();

            string selectStatement = "Select ProductCode, DateOpened,Customers.Name,Technicians.Name AS Technician,Title FROM Incidents left outer join Technicians on Incidents.TechID = Technicians.TechID inner JOIN Customers on Incidents.CustomerID = Customers.CustomerID WHERE DateClosed is NULL AND Technicians.TechID = @TechID";

            aCommand.CommandText = selectStatement;
           

            aCommand.CommandType = CommandType.Text;
            SqlParameter inputTechID = new SqlParameter("@TechID", techID);

            aCommand.Parameters.Add(inputTechID);

            List<Incident> listOfIncidents = new List<Incident>();
            try
            {
                aCommand.Connection.Open();


                SqlDataReader aReader = aCommand.ExecuteReader
                       (CommandBehavior.CloseConnection);


                Incident anIncident = new Incident();

                if (aReader.HasRows)
                {
                    while (aReader.Read())
                    {
                        anIncident.ProductCode = aReader["ProductCode"].ToString();
                        anIncident.DateOpened = (DateTime)aReader["DateOpened"];
                        anIncident.CustomerName = aReader["Technician"].ToString();
                        anIncident.TechName = aReader["Technician"].ToString();
                        anIncident.Title = aReader["Title"].ToString();

                        listOfIncidents.Add(anIncident);
                    }
                }

                  else
                {
                    aReader.Close(); 
                    
                    anIncident = null;
                    
                   
                }

                return listOfIncidents;
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











