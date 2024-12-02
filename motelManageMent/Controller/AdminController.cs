using motelManageMent.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace motelManageMent.Controller
{
    internal class AdminController
    {
        private DbConnection db;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private string query = "SELECT * FROM accounts"; 
        public AdminController()
        {
            db = new DbConnection();
            connection = db.getConnection();
            adapter = new SqlDataAdapter(query, connection); 
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
        }

        public Admin login(string gmail, string password)
        {
            if (connection != null)
            {
                try
                {
                    db.openConnection(connection);

                    string query = "SELECT * FROM accounts WHERE Email = @gmail";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@gmail", gmail);

                
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "accounts");

                    DataTable dt = ds.Tables["accounts"];

                
                    if (dt.Rows.Count == 1)
                    {
                        DataRow row = dt.Rows[0];

                     
                        string dbPassword = row["Password"].ToString();

                    
                        if (dbPassword == password)
                        {
                            Admin newad = new Admin(row["AccountID"].ToString(), row["Username"].ToString(), row["Password"].ToString() ,row["Email"].ToString(), row["Phone"].ToString());
                        

                           


                            return newad;
                        }
                        else
                        {
                            MessageBox.Show("Sai thông tin đăng nhập");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản hoặc có nhiều tài khoản trùng lặp.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    db.closeConnection(connection);
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối với cơ sở dữ liệu.");
            }
            return null; // Trả về false nếu đăng nhập thất bại
        }


        public void SignUp(string uname, string password, string gmail, string phonenum)
        {
            if (connection != null)
            {
                try
                {
                    db.openConnection(connection);

                  
                    adapter.Fill(ds, "accounts");

                
                    DataRow row = ds.Tables["accounts"].NewRow();
                    row["Username"] = uname;
                    row["Password"] = password;
                    row["Email"] = gmail;
                    row["Phone"] = int.Parse( phonenum ); 
                    ds.Tables["accounts"].Rows.Add(row);

                   
                    adapter.Update(ds, "accounts");

                    MessageBox.Show("Account successfully created.");
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
    }
}
