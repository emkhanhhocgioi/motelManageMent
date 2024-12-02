using System;
using System.Data;
using System.Data.SqlClient;

namespace motelManageMent.Controller
{
    internal class DbConnection
    {
        public string connectionString = "Data Source=1180-2AA1;Initial Catalog=MotelManagement;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection getConnection()
        {
            try
            {
       
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to the database: " + ex.Message);
                return null;
            }
        }

        
        public void openConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening the connection: " + ex.Message);
            }
        }

       
        public void closeConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing the connection: " + ex.Message);
            }
        }
    }
}
