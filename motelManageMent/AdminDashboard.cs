using motelManageMent.Controller;
using motelManageMent.Model;
using motelManageMent.Service;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace motelManageMent
{
    public partial class AdminDashboard : Form
    {
        private string username = "";
        private string id = "";
        private string phone = "";
        private static int selecteRoomID;
        private int selectedCustomerID;
        private int selectedRoomID2;
        private static int searchCusomerInt = 0;
        private static int searchRoomInt = 0;
        private static int checkouBID;
        private static int checkoutRoomID;
        private static int checkoutCID;

        private static DateTime cDate;


        //list<>
        private static List<Room> rooms;
        private static List<Customer> customers;
        private static List<Bookeds> bookedlist;
        private static AdminDashboard admf;

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

            //serchres 
            listView1.View = View.List;
            listView2.View = View.List;
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

            comboBox2.Items.Add(new KeyValuePair<int, string>(0, "Phòng trống"));
            comboBox2.Items.Add(new KeyValuePair<int, string>(1, "Phòng đang cho thuê"));
            comboBox2.Items.Add(new KeyValuePair<int, string>(2, "Phòng đang bảo trì"));

            comboBox2.SelectedIndex = 0;

            RoomGridView.ReadOnly = true;
            OrderGrid.CellFormatting += grid_CellFormatting;

            CustomerGrid.ReadOnly = true;
            CustomerGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            admf = this;

            HideTabHeader(tabControl1);

            chart3.Series.Clear();


        }
        private void HideTabHeader(TabControl tabControl)
        {
            tabControl.Appearance = TabAppearance.Normal;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.DrawItem += (s, e) => { };
        }
        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == DBNull.Value)
            {

                e.Value = "N/A";
                e.FormattingApplied = true;
            }
        }
        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

            Rectangle rect = e.Bounds;


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
                rooms = rcl.RenderRooms();

                RoomGridView.DataSource = rooms;

                RoomGridView.Columns["Id"].HeaderText = "Room ID";
                RoomGridView.Columns["RoomType"].HeaderText = "Room Type";
                RoomGridView.Columns["RoomNumber"].HeaderText = "Price";
                RoomGridView.Columns["IsOccupied"].HeaderText = "Room status";
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
                customers = customercl.GetCustomerList();

                CustomerGrid.DataSource = customers;


            }
            catch (Exception ex)
            {
            }

        }
        public void renderOrderGridView()
        {
            try
            {
                BookedController booked = new BookedController();
                bookedlist = booked.RenderOrders();
                OrderGrid.DataSource = bookedlist;

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
            renderOrderGridView();
            ChartRender();
            listView1.ItemActivate += ListView1_ItemActivate;
            listView2.ItemActivate += ListView2_ItemActivate;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    RenderRoomGridView();
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
                int ocupied = ((KeyValuePair<int, string>)comboBox2.SelectedItem).Key;
                MessageBox.Show("" + ocupied);

                if (selecteRoomID == 0)
                {
                    MessageBox.Show("Please select a room to update.");
                    return;
                }

                rcl.UpdateRoom(selecteRoomID, type, number, ocupied);

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

                int roomId = int.Parse(phonecustomertxt.Text);
                byte[] FimageData = getPhoto(pictureBox1);
                byte[] BimageData = getPhoto(pictureBox2);

                CustomerController customerController = new CustomerController();
                customerController.InsertNewCustomer(cname, rid, dt, gender, roomId, FimageData, BimageData);
                renderCustomerGridView();
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
                            case "PhoneNumber":
                                customer.PhoneNumber = Convert.ToInt32(cellValue);

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

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (searchCustomer.Text.Length > 0)
            {
                listView1.Visible = true;
                try
                {
                    SearchHelper searchHelper = new SearchHelper();
                    CustomerController customerController = new CustomerController();
                    List<Customer> customers = customerController.GetCustomerList();
                    string[] searchdata = searchHelper.SearchChing(customers, searchCustomer.Text);
                    listView1.Clear();

                    foreach (string data in searchdata)
                    {

                        if (!listView1.Items.ContainsKey(data))
                        {
                            ListViewItem item = new ListViewItem(data);
                            item.Name = data;
                            listView1.Items.Add(item);
                        }
                    }


                }
                catch (Exception ex)
                {

                }

            }

        }
        private void ListView1_ItemActivate(object sender, EventArgs e)
        {

            ListViewItem clickedItem = listView1.SelectedItems[0];
            searchCustomer.Text = clickedItem.Text;
            string[] parts = clickedItem.Text.Split(':');
            searchCusomerInt = int.Parse(parts[0]);
            listView1.Visible = false;

        }
        private void ListView2_ItemActivate(object sender, EventArgs e)
        {

            ListViewItem clickedItem = listView2.SelectedItems[0];
            RoomSearchBox.Text = clickedItem.Text;
            string[] parts = clickedItem.Text.Split(':');
            string[] split2 = parts[1].Split('|');

            searchRoomInt = int.Parse(split2[0]);

            listView2.Visible = false;

        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (RoomSearchBox.Text.Length > 0)
            {
                listView2.Visible = true;
                try
                {
                    SearchHelper searchHelper = new SearchHelper();
                    RoomController roomController = new RoomController();
                    List<Room> roomList = roomController.RenderRooms();
                    string[] searchData = searchHelper.SearchRoom(roomList, RoomSearchBox.Text);

                    listView2.Clear();

                    foreach (string data in searchData)
                    {

                        if (!listView2.Items.ContainsKey(data))
                        {
                            ListViewItem item = new ListViewItem(data);
                            item.Name = data;
                            listView2.Items.Add(item);
                        }
                    }


                }
                catch (Exception ex)
                {

                }

            }
        }

        private void addorder_Click(object sender, EventArgs e)
        {
            try
            {

                if (searchCusomerInt == 0 && searchRoomInt == 0)
                {

                    MessageBox.Show("Vui lòng nhập đủ dữ liệu");
                }
                else
                {
                    BookedController bookedController = new BookedController();
                    bookedController.createNewOrder(searchRoomInt, searchCusomerInt);
                    renderOrderGridView();
                    RenderRoomGridView();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = new Customer();
                Room r = new Room();

                foreach (Customer customer in customers)
                {
                    if (customer.CustomerID == checkoutCID)
                    {
                        c = customer;

                        break;
                    }

                }
                foreach (Room room in rooms)
                {
                    if (room.Id == checkoutRoomID)
                    {
                        r = room;
                        break;
                    }
                }
                CheckoutDetails newCheckout = new CheckoutDetails(r, c, checkouBID, checkoutRoomID, cDate, admf);
                newCheckout.Visible = true;

            }
            catch (Exception ex)
            {

            }
        }
        private void OrderGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = OrderGrid.Rows[e.RowIndex];


                checkouBID = int.Parse(row.Cells["BID"].Value.ToString());
                checkoutRoomID = int.Parse(row.Cells["RoomID"].Value.ToString());
                checkoutCID = int.Parse(row.Cells["CustomerID"].Value.ToString());
                DateTime.TryParse(row.Cells["Createtime"].Value.ToString(), out cDate);

            }
        }
        public void ChartRender()
        {
       
            chart3.Series.Clear();

    
            Dictionary<string, int> monthData = new Dictionary<string, int>()
    {
        { "January", 5000 }, { "February", 7000 }, { "March", 6000 },
        { "April", 8000 }, { "May", 9000 }, { "June", 11000 },
        { "July", 10500 }, { "August", 12000 }, { "September", 13000 },
        { "October", 15000 }, { "November", 16000 }, { "December", 17000 }
    };

      
            foreach (var month in monthData)
            {
                Series series = new Series(month.Key);
                series.ChartType = SeriesChartType.Column;
                series.Points.AddXY(month.Key, month.Value); 
                series["PointWidth"] = "0.5"; 
                chart3.Series.Add(series); 
            }

            
            ChartArea chartArea = chart3.ChartAreas[0];
            chartArea.AxisX.Interval = 1; 
            chartArea.AxisX.IsMarginVisible = false;
            chartArea.AxisX.Title = "Months"; 
            chartArea.AxisY.Title = "Money ($)"; 

  
            chartArea.AxisX.MajorGrid.LineWidth = 0;
            chartArea.AxisX.LabelStyle.Angle = -45; 
        }

        public void CharRender2()
        {

        }
        






        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void chart3_Click(object sender, EventArgs e)
        {
            
        }
    }



}
