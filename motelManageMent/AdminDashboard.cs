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
using System.Reflection;
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
        private static int yearpointer;
        private static int monthpointer;
        private static DateTime cDate;

        //search order checker
        private static bool searchname = false;
        private static bool datecheck = false;
        private static bool datecheck2 = false;
        private static bool isAll = false;


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
            //button images

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

            int currentYear = DateTime.Now.Year;

            for (int i = 2021; i <= currentYear; i++)
            {
                comboBox4.Items.Add(i);

            }
            comboBox4.SelectedIndex = comboBox4.Items.Count - 1;
            for (int i = 1; i <= 12; i++)
            {
                comboBox3.Items.Add(i);
            }



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
                CalculationHelper calc = new CalculationHelper();
                rooms = rcl.RenderRooms();

                RoomGridView.DataSource = rooms;

                RoomGridView.Columns["Id"].HeaderText = "Room ID";
                RoomGridView.Columns["RoomType"].HeaderText = "Room Type";
                RoomGridView.Columns["RoomNumber"].HeaderText = "Price";
                RoomGridView.Columns["IsOccupied"].HeaderText = "Room status";

                RoomSum.Text = "Tổng số phòng : " + calc.sumRoom(rooms).ToString();

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
                CalculationHelper calc = new CalculationHelper();
                CustomerGrid.DataSource = customers;
                CustomerSum.Text = "Tổng số Khách Hàng : " + calc.sumCustomer(customers).ToString();

            }
            catch (Exception ex)
            {
            }

        }
        public void renderOrderGridView()
        {
            try
            {
                if (isAll == true)
                {
                    BookedController booked = new BookedController();
                    bookedlist = booked.RenderOrders();

                    OrderGrid.DataSource = bookedlist;
                    CalculationHelper calc = new CalculationHelper();

                    orderSum.Text = "Tổng số đơn hàng : " + calc.sumOrder(bookedlist).ToString();
                }
                else
                {
                    BookedController booked = new BookedController();
                    bookedlist = booked.RenderOrders();
                    List<Bookeds> filteredList = new List<Bookeds>();
                    foreach (Bookeds b in bookedlist)
                    {
                        if (b.OrderStatus == 0)
                        {
                            filteredList.Add(b);
                        }

                    }
                    OrderGrid.DataSource = filteredList;
                    CalculationHelper calc = new CalculationHelper();

                    orderSum.Text = "Tổng số đơn hàng : " + calc.sumOrder(bookedlist).ToString();
                }


            }
            catch (Exception ex)
            {
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            label3.Text = username;


            renderCustomerGridView();
            RenderRoomGridView();
            renderOrderGridView();
            ChartRender();
            renderSumvalue();
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
            else if (searchCustomer.Text.Equals(""))
            {
                listView1.Visible = false;
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
            else if (RoomSearchBox.Text.Equals(""))
            {
                listView2.Visible = false;
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

            CalculationHelper calculationHelper = new CalculationHelper();
            Dictionary<string, int> monthData = calculationHelper.doanhthutochart(bookedlist);

            foreach (var month in monthData)
            {
                Series series = new Series(month.Key);
                series.ChartType = SeriesChartType.Column;
                series.Points.AddXY(month.Key, month.Value);
                series["PointWidth"] = "0.5";


                foreach (DataPoint dp in series.Points)
                {
                    dp.IsValueShownAsLabel = true;
                    dp.Label = dp.YValues[0].ToString();
                }

                chart3.Series.Add(series);
            }

            ChartArea chartArea = chart3.ChartAreas[0];
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.IsMarginVisible = false;
            chartArea.AxisX.Title = "Tháng";
            chartArea.AxisY.Title = "Doanh thu (VND)";

            chartArea.AxisX.MajorGrid.LineWidth = 0;
            chartArea.AxisX.LabelStyle.Angle = -45;


            chartArea.AxisY.LabelStyle.Format = "#,##0";
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 8);
            chartArea.AxisY.LabelStyle.Font = new Font("Arial", 8);
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
        public void renderSumvalue()
        {
            try
            {
                CalculationHelper calc = new CalculationHelper();
                sumDoanhthu.Text = "Tổng Doanh Thu: " + calc.doanhthutest(bookedlist).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi xảy ra: " + ex.Message);

            }
        }



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthpointer = Convert.ToInt32(comboBox3.SelectedItem);


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearpointer = Convert.ToInt32(comboBox4.SelectedItem);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                CalculationHelper calc = new CalculationHelper();

                if (monthpointer > 0 || yearpointer > 0)
                {

                    sumDoanhthu.Text = "Tổng Doanh Thu: " + calc.SumDoanhThu(bookedlist, monthpointer, yearpointer).ToString();
                    sumOrdermonth.Visible = true;
                    sumOrdermonth.Text = "Tổng Đơn theo tháng:" + calc.sumOrderMonth(bookedlist, monthpointer, yearpointer).ToString();

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tháng và năm hợp lệ!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            renderSumvalue();
            monthpointer = 0;
            yearpointer = 0;
            comboBox3.SelectedIndex = 0 - 1;
            comboBox4.SelectedIndex = comboBox4.Items.Count - 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime a = ordertimesearcha.Value;
                DateTime b = ordertimesearchb.Value;
                SearchHelper search = new SearchHelper();
                search.sortTableUsing(bookedlist, sortName.Text, OrderGrid, searchname, datecheck, datecheck2, a, b);





            }
            catch (Exception ex)
            {
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ordertimesearcha_ValueChanged(object sender, EventArgs e)
        {
            datecheck = true;
        }

        private void ordertimesearchb_ValueChanged(object sender, EventArgs e)
        {
            datecheck2 = true;
        }

        private void sortName_TextChanged(object sender, EventArgs e)
        {
            searchname = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            datecheck = false;
            datecheck2 = false;
            searchname = false;
            sortName.Text = "(tên hoặc sdt)";
            ordertimesearcha.Value = DateTime.Now;
            ordertimesearchb.Value = DateTime.Now;
            renderOrderGridView();
            checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                isAll = true;
            }
            else
            {
                isAll = false;
            }

            // Cập nhật giao diện
            renderOrderGridView();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                List<Customer> cs = new List<Customer>();
                foreach (Customer c in customers)
                {
                    if (c.CustomerName.Contains(customermnsearch.Text) || c.PhoneNumber.ToString().Contains(customermnsearch.Text) || c.ResidentID.ToString().Contains(customermnsearch.Text))
                    {
                        cs.Add(c);
                    }
                }
                CustomerGrid.DataSource = cs;
            }
            catch (Exception ex)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customermnsearch.Text = "";
            renderCustomerGridView();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                List<Room> cs = new List<Room>();
                foreach (Room c in rooms)
                {
                    if (c.Id.ToString().Contains(textBox1.Text))
                    {
                        cs.Add(c);
                    }
                }
                RoomGridView.DataSource = cs;
            }
            catch (Exception ex)
            {

            }
        }
    }



}
