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
using System.Windows.Forms.DataVisualization.Charting;

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

                    string insertQuery = "INSERT INTO booked (RoomID, CustomerID, Createtime,Endtime, orderstatus,orderSum) " +
                                 "VALUES (@RoomID, @CustomerID, @Createtime,@Endtime, @orderstatus,@orderSum)";

                    SqlCommand cmd = new SqlCommand(insertQuery, connection);

                    cmd.Parameters.AddWithValue("@RoomID", rid);
                    cmd.Parameters.AddWithValue("@CustomerID", cid);
                    DateTime now = DateTime.Now;
                    cmd.Parameters.AddWithValue("@Createtime", now);
                    cmd.Parameters.AddWithValue("@Endtime", DBNull.Value);
                    cmd.Parameters.AddWithValue("@orderstatus", 0); 
                    cmd.Parameters.AddWithValue("@orderSum", DBNull.Value);
                    cmd.ExecuteNonQuery();
                    changeRoomStatus(rid);
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
        public void changeRoomStatus(int id)
        {
            try
            {
                db.openConnection(connection);
                string updateQuery = "UPDATE Rooms SET IsOccupied = 1 WHERE   RoomID  = @RoomID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomID", id);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Room marked as occupied.");
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
        public void changeRoomStatusToFree(int id)
        {
            try
            {
                db.openConnection(connection);
                string updateQuery = "UPDATE Rooms SET IsOccupied = 0 WHERE RoomID = @RoomID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomID", id);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Room marked as unoccupied.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
        public void checkOutRooms(int id,int rid,DateTime checkouttime ,int total)
        {
            try
            { 
               

                string updateQuery = "UPDATE booked  SET orderstatus = 1, Endtime = @Endtime ,orderSum = @orderSum WHERE BID = @BID";
                changeRoomStatusToFree(rid);
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@BID", id);
                    cmd.Parameters.AddWithValue("@Endtime", checkouttime);
                    cmd.Parameters.AddWithValue("@orderSum", total);
                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }

        public List<Bookeds> RenderOrders()
        {
            List<Bookeds> bookingsList = new List<Bookeds>();

            if (connection != null)
            {
                try
                {
                    string query = "SELECT b.BID, " +
                "c.CustomerID, " +
                "c.CustomerName, " +
                "c.ResidentID, " +
                "c.PhoneNumber, " +
                "b.RoomID, " +
                "r.RoomType, " +
                "b.Createtime, " +
                "b.Endtime, " +
                "b.orderstatus, " +
                "b.orderSum " + 
                "FROM dbo.Customer c " +
                "INNER JOIN dbo.booked b ON c.CustomerID = b.CustomerID " +
                "INNER JOIN dbo.Rooms r ON b.RoomID = r.RoomID " 
               ;


                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "booked");

                    foreach (DataRow row in ds.Tables["booked"].Rows)
                    {
                        Bookeds booking = new Bookeds
                        {
                            BID = row["BID"] == DBNull.Value ? 0 : Convert.ToInt32(row["BID"]),
                            CustomerID = row["CustomerID"] == DBNull.Value ? 0 : Convert.ToInt32(row["CustomerID"]),
                            CustomerName = row["CustomerName"] == DBNull.Value ? string.Empty : row["CustomerName"].ToString(),
                            ResidentID = row["ResidentID"] == DBNull.Value ? string.Empty : row["ResidentID"].ToString(),
                            PhoneNumber = row["PhoneNumber"] == DBNull.Value ? string.Empty : row["PhoneNumber"].ToString(),
                            RoomID = row["RoomID"] == DBNull.Value ? 0 : Convert.ToInt32(row["RoomID"]),
                            RoomType = row["RoomType"] == DBNull.Value ? string.Empty : row["RoomType"].ToString(),
                            CreateTime = row["Createtime"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["Createtime"]),
                            EndTime = row["Endtime"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["Endtime"]),
                            OrderStatus = row["orderstatus"] == DBNull.Value ? 0 : Convert.ToInt32(row["orderstatus"]),
                            OrderSum = row["orderSum"] == DBNull.Value ? 0 : Convert.ToInt32(row["orderSum"])
                        };

                        bookingsList.Add(booking);
                    }
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

            return bookingsList;
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
