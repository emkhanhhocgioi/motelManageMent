using motelManageMent.Controller;
using motelManageMent.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace motelManageMent
{
    public partial class AdminDashboard : Form
    {
        private string username = "";
        private string id = "";
        private string phone = "";
        private static int selecteRoomID;
        private int selectedCustomerID;

        public AdminDashboard(Admin adm)
        {

            InitializeComponent();

            username = adm.Name;
            id = adm.Id;
            phone = adm.Phone;
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new Size(400, 30);
            this.tabControl1.SizeMode = TabSizeMode.Fixed;
            this.tabControl1.Location = new Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(824, 717);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new DrawItemEventHandler(this.TabControl1_DrawItem);

            this.tabPage1.BackColor = Color.LightYellow;
            this.tabPage1.Location = new Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new Padding(3);
            this.tabPage1.Size = new Size(816, 689);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trang 1";
            this.tabPage1.UseVisualStyleBackColor = true;

            // TabPage2 settings
            this.tabPage2.BackColor = Color.LightGreen;
            this.tabPage2.Location = new Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new Padding(3);
            this.tabPage2.Size = new Size(816, 689);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trang 2";
            this.tabPage2.UseVisualStyleBackColor = true;

            //Room Type Combobox
            comboBox1.Items.Add(("2 phòng ngủ/1 phòng khách"));
            comboBox1.Items.Add(("1 phòng ngủ/1 phòng khách"));
            comboBox1.Items.Add(("1 phòng gác lửng"));

            comboBox1.SelectedIndex = 0;

            RoomGridView.ReadOnly = true;


            CustomerGrid.ReadOnly = true;
            CustomerGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            HideTabHeader(tabControl1);
            renderromtocombobox();
        }
        private void HideTabHeader(TabControl tabControl)
        {
            tabControl.Appearance = TabAppearance.Normal;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.DrawItem += (s, e) => { };
        }
        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Tab item rectangle
            Rectangle rect = e.Bounds;

            // Highlight current tab
            if (e.Index == tabControl1.SelectedIndex)
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, rect);
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                                      new Font("Arial", 10, FontStyle.Bold),
                                      Brushes.Black, rect.X + 3, rect.Y + 6);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Gray, rect);
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                                      new Font("Arial", 10, FontStyle.Regular),
                                      Brushes.White, rect.X + 3, rect.Y + 6);
            }

            // Draw tab borders
            e.Graphics.DrawRectangle(Pens.Black, rect);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RenderRoomGridView()
        {
            try
            {
                RoomController rcl = new RoomController();
                List<Room> rooms = rcl.RenderRooms();

                RoomGridView.DataSource = rooms;

                RoomGridView.Columns["Id"].HeaderText = "Room ID";
                RoomGridView.Columns["RoomType"].HeaderText = "Room Type";
                RoomGridView.Columns["RoomNumber"].HeaderText = "Room Number";
            }
            catch (Exception ex)
            {
            }
        }
        public void renderCustomerGridView()
        {
            try
            {
                CustomerController customercl = new CustomerController();
                List<Customer> customers = customercl.GetCustomerList();

                CustomerGrid.DataSource = customers;


            }
            catch (Exception ex)
            {
            }

        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            label3.Text = username;
            label2.Text = id;

            renderCustomerGridView();
            RenderRoomGridView();



        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedValue = comboBox1.SelectedItem.ToString();
            //MessageBox.Show($"Giá trị thực của mục được chọn: {selectedValue}");
        }



        private void InsertRoomBtn_Click(object sender, EventArgs e)
        {
            RoomController rcl = new RoomController();

            try
            {
                string type = comboBox1.SelectedItem.ToString();

                int number = int.Parse(NumberTxt.Text);

                rcl.InsertRoom(type, number);
                RenderRoomGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DeleteRoomBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RoomController rcl = new RoomController();
                DialogResult result = MessageBox.Show("Are you sure you want to delete?",
                                       "Confirm Deletion",
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    rcl.DeleteRooms(selecteRoomID);
                }
                else if (result == DialogResult.No)
                {

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

            }
        }

        private void RoomGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Get the clicked row index
                int rowIndex = e.RowIndex;


                selecteRoomID = Convert.ToInt32(RoomGridView.Rows[rowIndex].Cells["Id"].Value);




            }
        }

        private void UpdateRoomBtn_Click(object sender, EventArgs e)
        {
            RoomController rcl = new RoomController();

            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select a room type.");
                    return;
                }

                string type = comboBox1.SelectedItem.ToString();
                int number = int.Parse(NumberTxt.Text);

                // Assuming 'selectedRoomID' is properly assigned earlier in your code
                if (selecteRoomID == 0)
                {
                    MessageBox.Show("Please select a room to update.");
                    return;
                }

                rcl.UpdateRoom(selecteRoomID, type, number);
                RenderRoomGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private byte[] getPhoto(PictureBox ptbox)
        {
            MemoryStream stream = new MemoryStream();
            ptbox.Image.Save(stream, ptbox.Image.RawFormat);
            return stream.GetBuffer();
        }
        private void uploadcustomerBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);



                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }
        private void renderromtocombobox()
        {
            try
            {
                RoomController roomController = new RoomController();
                List<Room> rooms = roomController.RenderRooms();

                foreach (Room room in rooms)
                {
                    RoomCombox.Items.Add(new KeyValuePair<string, int>($"Phòng số: {room.RoomNumber}/Kiểu phòng: {room.RoomType}", room.Id
 ));


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        public int GetGender()
        {
            if (MaleCb.Checked)
            {

                return 0;
            }
            if (WomenCb.Checked)
            {

                return 1;
            }
            return 2;

        }
        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                string cname = CustomerNameTxt.Text;
                int rid = int.Parse(RIDtxt.Text);
                DateTime dt = DOBpicker.Value;
                int gender = GetGender();
                KeyValuePair<string, int> selectedRoom = (KeyValuePair<string, int>)RoomCombox.SelectedItem;
                string roomInfo = selectedRoom.Key;
                int roomId = selectedRoom.Value;
                byte[] FimageData = getPhoto(pictureBox1);
                byte[] BimageData = getPhoto(pictureBox2);

                CustomerController customerController = new CustomerController();
                customerController.InsertNewCustomer(cname, rid, dt, gender, roomId, FimageData, BimageData);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void CustomerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  
            {
                int rowIndex = e.RowIndex;

             
                Customer customer = new Customer();

          
                for (int columnIndex = 0; columnIndex < CustomerGrid.Columns.Count; columnIndex++)
                {
              
                    string columnName = CustomerGrid.Columns[columnIndex].Name;

             
                    if (CustomerGrid.Rows[rowIndex].Cells[columnIndex].Value != DBNull.Value)
                    {
                        var cellValue = CustomerGrid.Rows[rowIndex].Cells[columnIndex].Value;

                        
                        switch (columnName)
                        {
                            case "CustomerID":
                                customer.CustomerID = Convert.ToInt32(cellValue);
                                break; 
                            case "CustomerName":
                                customer.CustomerName = cellValue.ToString();
                                break; 
                            case "ResidentID":
                                customer.ResidentID = Convert.ToInt32(cellValue);
                                break; 
                            case "DOB":
                                customer.DOB = Convert.ToDateTime(cellValue);
                                break; 
                            case "Gender":
                                customer.Gender = Convert.ToInt32(cellValue);  
                                break;
                            case "RoomID":
                                customer.RoomID = Convert.ToInt32(cellValue);
                                break; 
                            case "FImage":
                                customer.FImage = (byte[])cellValue; 
                                break; 
                            case "BImage":
                                customer.BImage = (byte[])cellValue; 
                                break; 
                            default:
                                break;
                        }
                    }
                }
                CustomerData ctd = new CustomerData(customer);
                ctd.Visible = true;
              


            }
        }
    }



}
