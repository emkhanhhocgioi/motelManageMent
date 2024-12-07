using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using motelManageMent.Model;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace motelManageMent.Controller
{
    internal class CustomerController
    {

        private DbConnection db;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private string query = "SELECT * FROM Customer";
        public CustomerController() {
            db = new DbConnection();
            connection = db.getConnection();
            adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
     
        }

        public void InsertNewCustomer(string name,int Rid,DateTime dob ,int gender,int roomid, byte[] FimageData, byte[] BimageData)
        {
            if (connection != null)
            {
                try
                {
                    db.openConnection(connection);
                    string query = "INSERT INTO Customer (CustomerName, ResidentID, DOB, Gender, RoomID, FrontIDImage, BackIDImage) " +
                        "VALUES (@CustomerName, @ResidentID, @DOB, @Gender, @RoomID, @FrontIDImage, @BackIDImage)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@CustomerName", name);
                    cmd.Parameters.AddWithValue("@ResidentID", Rid);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@RoomID", roomid);
                    cmd.Parameters.AddWithValue("@FrontIDImage", FimageData);
                    cmd.Parameters.AddWithValue("@BackIDImage", BimageData);

                    cmd.ExecuteNonQuery();
         

                    MessageBox.Show("Đã thêm khách hàng mới vào danh sách !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    db.closeConnection(connection);
                }
            }
            else
            {
                Console.WriteLine("Could not connect to the database.");
            }

        }
        public List<Customer> GetCustomerList()
        {
            if (connection != null)
            {
                try
                {
                 
                    string query = "SELECT CustomerID, CustomerName, ResidentID, DOB, Gender, RoomID, FrontIDImage, BackIDImage FROM Customer";

                    adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    ds = new DataSet();
                    adapter.Fill(ds, "Customer");

                    List<Customer> customers = new List<Customer>();

                    
                    foreach (DataRow row in ds.Tables["Customer"].Rows)
                    {
                        
                        Customer customer = new Customer
                        {
                            CustomerID = Convert.ToInt32(row["CustomerID"]),
                            CustomerName = row["CustomerName"].ToString(),
                            ResidentID = Convert.ToInt32(row["ResidentID"]),  
                            DOB = Convert.ToDateTime(row["DOB"]),
                            Gender = Convert.ToInt32(row["Gender"]),  
                            RoomID = Convert.ToInt32(row["RoomID"]),
                            FImage = row["FrontIDImage"] as byte[],  
                            BImage = row["BackIDImage"] as byte[]  
                        };

                       
                        customers.Add(customer);
                    }

                    return customers;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                    return new List<Customer>();
                }
            }
            else
            {
           
                Console.WriteLine("Could not connect to the database.");
                return new List<Customer>();
            }
        }

    }

}

