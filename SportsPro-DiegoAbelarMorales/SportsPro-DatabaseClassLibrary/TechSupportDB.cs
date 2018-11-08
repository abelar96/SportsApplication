using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SportsPro_DatabaseClassLibrary
{
    public static class TechSupportDB
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection aConnection = new SqlConnection();

            aConnection.ConnectionString = "Data Source = cissql.matrix.txstate.edu\\cis3325summr2018; Initial Catalog = TechSupport; Integrated Security = True";

            return aConnection; 



        }

    }
}
