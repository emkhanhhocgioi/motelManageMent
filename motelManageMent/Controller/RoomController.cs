using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using motelManageMent.Model;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace motelManageMent.Controller
{
    internal class RoomController
    {
        private DbConnection db;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private string query = "SELECT * FROM Rooms";
        public RoomController()
        {
            db = new DbConnection();
            connection = db.getConnection();
            adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
        }
        public void DeleteRooms(int id)
        {
            if (connection != null) {
                try {
                    string query = "DELETE FROM Rooms WHERE RoomID = @RoomID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@RoomID", id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Phòng đã được xóa thành công !.");
                    }
                    else
                    {
                        MessageBox.Show("Không có phòng được tìm thấy với ID trên");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Could not connect to the database.");
            }

        }
        public void UpdateRoom(int id, string type, int number,int ocupied)
        {
            try
            {
              
                db.openConnection(connection);
                string query = "UPDATE Rooms SET RoomType = @RoomType, RoomNumber = @RoomNumber WHERE RoomID = @RoomID";

                // Create SqlCommand and add parameters
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomType", type);
                    cmd.Parameters.AddWithValue("@RoomNumber", number);
                    cmd.Parameters.AddWithValue("@RoomID", id);
                    cmd.Parameters.AddWithValue("@IsOccupied", ocupied);

     
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Room updated successfully.");
                      
                    }
                    else
                    {
                        MessageBox.Show("No room found with the given ID.");
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
                db.closeConnection(connection);
            }

        }



        public void InsertRoom(string type,int number)
        {
            if (connection != null)
            {
                try
                {
                    db.openConnection(connection);
                    adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    ds = new DataSet();
                    adapter.Fill(ds, "Rooms");


                    DataRow row = ds.Tables["Rooms"].NewRow();
                    row["RoomType"] = type;
                    row["RoomNumber"] = number;
                    row["IsOccupied"] = 0;
                    ds.Tables["Rooms"].Rows.Add(row);


                    adapter.Update(ds, "Rooms");

                    MessageBox.Show("Phòng được tạo thành công.");
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

        public List<Room> RenderRooms()
        {
            if (connection != null)
            {
                try
                {
                    string query = "SELECT RoomID, RoomType, RoomNumber, IsOccupied FROM Rooms";

                    adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    ds = new DataSet();
                    adapter.Fill(ds, "Rooms");

                    List<Room> rooms = new List<Room>();

                    foreach (DataRow row in ds.Tables["Rooms"].Rows)
                    {
                        Room room = new Room
                        {
                            Id = row["RoomID"] != DBNull.Value ? Convert.ToInt32(row["RoomID"]) : 0, 
                            RoomType = row["RoomType"] != DBNull.Value ? row["RoomType"].ToString() : "Unknown", 
                            RoomNumber = row["RoomNumber"] != DBNull.Value ? Convert.ToInt32(row["RoomNumber"]) : 0,
                            IsOccupied = row["IsOccupied"] != DBNull.Value ? Convert.ToInt32(row["IsOccupied"]) : 0,
                        };
                        rooms.Add(room);
                    }

                    return rooms;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                    return new List<Room>();
                }
            }
            else
            {
                Console.WriteLine("Could not connect to the database.");
                return new List<Room>();
            }
        }


    }



}
