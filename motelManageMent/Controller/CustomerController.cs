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
        public void DeleteCustomer(int id)
        {
            if (connection != null)
            {
                try
                {
                    string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@CustomerID", id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Khách hàng đã được xóa thành công !.");
                    }
                    else
                    {
                        MessageBox.Show("Không có Khách hàng nào được tìm thấy với ID trên");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Could not connect to the database.");
            }

        }
        public void UpdateCustomer(int customerID, string name, int residentID, DateTime dob, int gender, int phoneNumber, byte[] frontImage, byte[] backImage)
        {
            try
            {
             
                db.openConnection(connection);

                string query = @"
            UPDATE Customer
            SET 
                CustomerName = @CustomerName,
                ResidentID = @ResidentID,
                DOB = @DOB,
                Gender = @Gender,
                PhoneNumber = @PhoneNumber,
                FrontIDImage = @FrontIDImage,
                BackIDImage = @BackIDImage
            WHERE 
                CustomerID = @CustomerID;
        ";


                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@CustomerName", name);
                    cmd.Parameters.AddWithValue("@ResidentID", residentID);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                  
                    cmd.Parameters.AddWithValue("@FrontIDImage", frontImage ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@BackIDImage", backImage ?? (object)DBNull.Value);

        
                    int rowsAffected = cmd.ExecuteNonQuery();

         
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No customer found with the given ID.");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
   
                MessageBox.Show("Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
          
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the database connection is always closed
                db.closeConnection(connection);
            }
        }


        public void InsertNewCustomer(string name,int Rid,DateTime dob ,int gender,int roomid, byte[] FimageData, byte[] BimageData)
        {
            if (connection != null)
            {
                try
                {
                    db.openConnection(connection);
                    string query = "INSERT INTO Customer (CustomerName, ResidentID, DOB, Gender, PhoneNumber, FrontIDImage, BackIDImage) " +
                        "VALUES (@CustomerName, @ResidentID, @DOB, @Gender, @PhoneNumber, @FrontIDImage, @BackIDImage)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@CustomerName", name);
                    cmd.Parameters.AddWithValue("@ResidentID", Rid);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@PhoneNumber", roomid);
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
                 
                    string query = "SELECT CustomerID, CustomerName, ResidentID, DOB, Gender, PhoneNumber, FrontIDImage, BackIDImage FROM Customer";

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
                            PhoneNumber = Convert.ToInt32(row["PhoneNumber"]),
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

