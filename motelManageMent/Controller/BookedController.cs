using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using motelManageMent.Model;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace motelManageMent.Controller
{
    internal class BookedController
    {
        private DbConnection db;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet ds;


        public BookedController() {
            db = new DbConnection();
            connection = db.getConnection();
           
        }

        public void createNewOrder(int rid ,int cid)
        {
            if (connection != null)
            {
                try
                {

                    string insertQuery = "INSERT INTO booked (RoomID, CustomerID, Createtime, orderstatus) " +
                                 "VALUES (@RoomID, @CustomerID, @Createtime,@Endtime, @orderstatus)";

                    SqlCommand cmd = new SqlCommand(insertQuery, connection);

                    cmd.Parameters.AddWithValue("@RoomID", rid);
                    cmd.Parameters.AddWithValue("@CustomerID", cid);
                    DateTime now = DateTime.Now;
                    cmd.Parameters.AddWithValue("@Createtime", now);
                    cmd.Parameters.AddWithValue("@Endtime", null);
                    cmd.Parameters.AddWithValue("@orderstatus", 0);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm vào danh sách !");
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

        }

        public void RenderCustomers(DataGridView grid)
        {
            if (connection != null)
            {
                try
                {
                    string query = "SELECT dbo.Customer.CustomerName, dbo.Customer.ResidentID, dbo.Customer.PhoneNumber," +
                        " dbo.Rooms.RoomType, dbo.booked.Createtime, dbo.booked.Endtime, dbo.booked.orderstatus " +
                        "FROM dbo.Customer " +
                        "INNER JOIN dbo.booked ON dbo.Customer.customerID = dbo.booked.CustomerID " +
                        "INNER JOIN dbo.Rooms ON dbo.booked.RoomID = dbo.Rooms.RoomID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "booked");

           
                    grid.DataSource = ds.Tables["booked"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Connection is null.");
            }
        }




        public void deleteOrder(int id)
        {
            if (connection != null)
            {
                try
                {
                    string query = "DELETE FROM booked WHERE BID = @BID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@BID", id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đơn đặt phòng đã được xóa thành công !.");
                    }
                    else
                    {
                        MessageBox.Show("Không có đơn hàng nào được tìm thấy với ID trên");
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
   

    }
}
