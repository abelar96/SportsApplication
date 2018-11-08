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
    public class ProductDB
    {

        public List<Product> GetProductsList()
        {

            List<Product> listOfProducts = new List<Product>();

            SqlCommand aCommand = new SqlCommand();

            aCommand.Connection = TechSupportDB.GetConnection();

            aCommand.CommandText = "SELECT Name, ProductCode FROM Products";

            aCommand.CommandType = CommandType.Text;

            try
            {
                aCommand.Connection.Open();
                SqlDataReader aReader = aCommand.ExecuteReader(CommandBehavior.CloseConnection);
                while (aReader.Read())
                {
                    Product aProduct = new Product();

                    aProduct.Name = aReader["Name"].ToString();
                    //aProduct.Name = aReader["ProductCode"].ToString();\
                    aProduct.ProductCode = aReader["ProductCode"].ToString();
                    listOfProducts.Add(aProduct);

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
            return listOfProducts;


        }

        public Product GetProductName(String productCode)
        {

            Product aProduct = new Product();

            SqlCommand aCommand = new SqlCommand();

            aCommand.Connection = TechSupportDB.GetConnection();
            aCommand.CommandText = " select Name from Products Where ProductCode = @ProductCode ";
            aCommand.CommandType = CommandType.Text;

            aCommand.Parameters.AddWithValue("@ProductCode", productCode);

            try
            {
                aCommand.Connection.Open();
                SqlDataReader aReader = aCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (aReader.Read())
                {
                    aProduct.Name = aReader["Name"].ToString();
                    aProduct.ProductCode = aReader["ProductCode"].ToString(); 


                }

                else
                {
                    aProduct = null;
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

            return aProduct;

        }

        }
    }
