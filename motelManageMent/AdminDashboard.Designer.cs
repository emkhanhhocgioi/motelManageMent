using System.Windows.Forms;

namespace motelManageMent
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            panel3 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel4 = new Panel();
            label19 = new Label();
            label15 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            UpdateRoomBtn = new Button();
            DeleteRoomBtn = new Button();
            InsertRoomBtn = new Button();
            RoomGridView = new DataGridView();
            label5 = new Label();
            NumberTxt = new TextBox();
            label4 = new Label();
            tabPage2 = new TabPage();
            panel5 = new Panel();
            label6 = new Label();
            phonecustomertxt = new TextBox();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            button9 = new Button();
            button8 = new Button();
            label14 = new Label();
            WomenCb = new CheckBox();
            MaleCb = new CheckBox();
            DOBpicker = new DateTimePicker();
            RIDtxt = new TextBox();
            CustomerNameTxt = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            button6 = new Button();
            uploadcustomerBtn = new Button();
            tabPage3 = new TabPage();
            panel6 = new Panel();
            panel7 = new Panel();
            label13 = new Label();
            CustomerGrid = new DataGridView();
            tabPage4 = new TabPage();
            panel8 = new Panel();
            button7 = new Button();
            listView2 = new ListView();
            RoomSearchBox = new TextBox();
            label18 = new Label();
            label17 = new Label();
            listView1 = new ListView();
            searchCustomer = new TextBox();
            addorder = new Button();
            label16 = new Label();
            OrderGrid = new DataGridView();
            tabPage5 = new TabPage();
            panel9 = new Panel();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel10 = new Panel();
            comboBox3 = new ComboBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            orderSum = new Label();
            CustomerSum = new Label();
            RoomSum = new Label();
            label20 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            comboBox4 = new ComboBox();
            label24 = new Label();
            comboBox5 = new ComboBox();
            label25 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RoomGridView).BeginInit();
            tabPage2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerGrid).BeginInit();
            tabPage4.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGrid).BeginInit();
            tabPage5.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 723);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(tabControl1);
            panel3.Location = new Point(202, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(824, 720);
            panel3.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(0, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(824, 717);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel4);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(816, 689);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSlateGray;
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(UpdateRoomBtn);
            panel4.Controls.Add(DeleteRoomBtn);
            panel4.Controls.Add(InsertRoomBtn);
            panel4.Controls.Add(RoomGridView);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(NumberTxt);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(813, 689);
            panel4.TabIndex = 0;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.FlatStyle = FlatStyle.Flat;
            label19.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            label19.Location = new Point(284, 8);
            label19.Name = "label19";
            label19.Size = new Size(170, 30);
            label19.TabIndex = 12;
            label19.Text = "Quản Lý Phòng";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(114, 138);
            label15.Name = "label15";
            label15.Size = new Size(80, 15);
            label15.TabIndex = 11;
            label15.Text = "Room Status :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(210, 138);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(279, 23);
            comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(210, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // UpdateRoomBtn
            // 
            UpdateRoomBtn.Location = new Point(402, 179);
            UpdateRoomBtn.Name = "UpdateRoomBtn";
            UpdateRoomBtn.Size = new Size(89, 38);
            UpdateRoomBtn.TabIndex = 8;
            UpdateRoomBtn.Text = "UPDATE ROOM";
            UpdateRoomBtn.UseVisualStyleBackColor = true;
            UpdateRoomBtn.Click += UpdateRoomBtn_Click;
            // 
            // DeleteRoomBtn
            // 
            DeleteRoomBtn.Location = new Point(307, 179);
            DeleteRoomBtn.Name = "DeleteRoomBtn";
            DeleteRoomBtn.Size = new Size(89, 38);
            DeleteRoomBtn.TabIndex = 7;
            DeleteRoomBtn.Text = "DELETE ROOM";
            DeleteRoomBtn.UseVisualStyleBackColor = true;
            DeleteRoomBtn.Click += DeleteRoomBtn_Click;
            // 
            // InsertRoomBtn
            // 
            InsertRoomBtn.Location = new Point(212, 179);
            InsertRoomBtn.Name = "InsertRoomBtn";
            InsertRoomBtn.Size = new Size(89, 38);
            InsertRoomBtn.TabIndex = 6;
            InsertRoomBtn.Text = "INSERT ROOM";
            InsertRoomBtn.UseVisualStyleBackColor = true;
            InsertRoomBtn.Click += InsertRoomBtn_Click;
            // 
            // RoomGridView
            // 
            RoomGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomGridView.Location = new Point(16, 277);
            RoomGridView.Name = "RoomGridView";
            RoomGridView.Size = new Size(789, 402);
            RoomGridView.TabIndex = 5;
            RoomGridView.CellClick += RoomGridView_CellClick;
            RoomGridView.CellContentClick += RoomGridView_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 109);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 4;
            label5.Text = "Giá phòng :";
            // 
            // NumberTxt
            // 
            NumberTxt.Location = new Point(210, 109);
            NumberTxt.Name = "NumberTxt";
            NumberTxt.Size = new Size(279, 23);
            NumberTxt.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 77);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 2;
            label4.Text = "Room Type:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(816, 689);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SlateGray;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(phonecustomertxt);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(button9);
            panel5.Controls.Add(button8);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(WomenCb);
            panel5.Controls.Add(MaleCb);
            panel5.Controls.Add(DOBpicker);
            panel5.Controls.Add(RIDtxt);
            panel5.Controls.Add(CustomerNameTxt);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(uploadcustomerBtn);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(820, 693);
            panel5.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(262, 8);
            label6.Name = "label6";
            label6.Size = new Size(229, 30);
            label6.TabIndex = 30;
            label6.Text = "Quản Lý Khách Hàng";
            // 
            // phonecustomertxt
            // 
            phonecustomertxt.Location = new Point(424, 243);
            phonecustomertxt.Name = "phonecustomertxt";
            phonecustomertxt.Size = new Size(291, 23);
            phonecustomertxt.TabIndex = 29;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Azure;
            pictureBox2.Location = new Point(6, 321);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(316, 207);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 303);
            label8.Name = "label8";
            label8.Size = new Size(153, 15);
            label8.TabIndex = 27;
            label8.Text = "Mặt sau căn cước công dân";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Azure;
            pictureBox1.Location = new Point(3, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 207);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // button9
            // 
            button9.Location = new Point(539, 308);
            button9.Name = "button9";
            button9.Size = new Size(113, 54);
            button9.TabIndex = 24;
            button9.Text = "D.S Khách Hàng";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(424, 308);
            button8.Name = "button8";
            button8.Size = new Size(109, 54);
            button8.TabIndex = 23;
            button8.Text = "Thêm";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(325, 246);
            label14.Name = "label14";
            label14.Size = new Size(82, 15);
            label14.TabIndex = 21;
            label14.Text = "Số điện thoại :";
            // 
            // WomenCb
            // 
            WomenCb.AutoSize = true;
            WomenCb.Location = new Point(632, 202);
            WomenCb.Name = "WomenCb";
            WomenCb.Size = new Size(42, 19);
            WomenCb.TabIndex = 18;
            WomenCb.Text = "Nữ";
            WomenCb.UseVisualStyleBackColor = true;
            // 
            // MaleCb
            // 
            MaleCb.AutoSize = true;
            MaleCb.Location = new Point(424, 202);
            MaleCb.Name = "MaleCb";
            MaleCb.Size = new Size(52, 19);
            MaleCb.TabIndex = 17;
            MaleCb.Text = "Nam";
            MaleCb.UseVisualStyleBackColor = true;
            // 
            // DOBpicker
            // 
            DOBpicker.Location = new Point(424, 150);
            DOBpicker.Name = "DOBpicker";
            DOBpicker.Size = new Size(200, 23);
            DOBpicker.TabIndex = 16;
            // 
            // RIDtxt
            // 
            RIDtxt.Location = new Point(424, 105);
            RIDtxt.Name = "RIDtxt";
            RIDtxt.Size = new Size(291, 23);
            RIDtxt.TabIndex = 13;
            // 
            // CustomerNameTxt
            // 
            CustomerNameTxt.Location = new Point(424, 53);
            CustomerNameTxt.Name = "CustomerNameTxt";
            CustomerNameTxt.Size = new Size(291, 23);
            CustomerNameTxt.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(325, 202);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 11;
            label12.Text = "Giới tính :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(325, 156);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 10;
            label11.Text = "Ngày Sinh :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(325, 109);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 9;
            label10.Text = "Số CCCD:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(325, 61);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 8;
            label9.Text = "Tên Khách Hàng :";
            label9.Click += label9_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 23);
            label7.Name = "label7";
            label7.Size = new Size(163, 15);
            label7.TabIndex = 5;
            label7.Text = "Mặt trước căn cước công dân";
            // 
            // button6
            // 
            button6.Location = new Point(6, 534);
            button6.Name = "button6";
            button6.Size = new Size(75, 22);
            button6.TabIndex = 4;
            button6.Text = "tải ảnh lên";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // uploadcustomerBtn
            // 
            uploadcustomerBtn.Location = new Point(6, 266);
            uploadcustomerBtn.Name = "uploadcustomerBtn";
            uploadcustomerBtn.Size = new Size(75, 22);
            uploadcustomerBtn.TabIndex = 3;
            uploadcustomerBtn.Text = "tải ảnh lên";
            uploadcustomerBtn.UseVisualStyleBackColor = true;
            uploadcustomerBtn.Click += uploadcustomerBtn_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(816, 689);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(816, 693);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.SlateGray;
            panel7.Controls.Add(label13);
            panel7.Controls.Add(CustomerGrid);
            panel7.Location = new Point(1, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(815, 687);
            panel7.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            label13.Location = new Point(271, 20);
            label13.Name = "label13";
            label13.Size = new Size(254, 30);
            label13.TabIndex = 2;
            label13.Text = "Danh Sách Khách Hàng";
            // 
            // CustomerGrid
            // 
            CustomerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerGrid.Location = new Point(3, 74);
            CustomerGrid.Name = "CustomerGrid";
            CustomerGrid.Size = new Size(809, 602);
            CustomerGrid.TabIndex = 0;
            CustomerGrid.CellContentClick += CustomerGrid_CellClick;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(panel8);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(816, 689);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.SlateGray;
            panel8.Controls.Add(button7);
            panel8.Controls.Add(listView2);
            panel8.Controls.Add(RoomSearchBox);
            panel8.Controls.Add(label18);
            panel8.Controls.Add(label17);
            panel8.Controls.Add(listView1);
            panel8.Controls.Add(searchCustomer);
            panel8.Controls.Add(addorder);
            panel8.Controls.Add(label16);
            panel8.Controls.Add(OrderGrid);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(820, 690);
            panel8.TabIndex = 0;
            // 
            // button7
            // 
            button7.Location = new Point(6, 114);
            button7.Name = "button7";
            button7.Size = new Size(66, 47);
            button7.TabIndex = 13;
            button7.Text = "Check out";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // listView2
            // 
            listView2.Location = new Point(476, 85);
            listView2.Name = "listView2";
            listView2.Size = new Size(202, 146);
            listView2.TabIndex = 11;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.Visible = false;
            // 
            // RoomSearchBox
            // 
            RoomSearchBox.Location = new Point(476, 66);
            RoomSearchBox.Name = "RoomSearchBox";
            RoomSearchBox.Size = new Size(202, 23);
            RoomSearchBox.TabIndex = 10;
            RoomSearchBox.TextChanged += textBox1_TextChanged_1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(377, 66);
            label18.Name = "label18";
            label18.Size = new Size(74, 15);
            label18.TabIndex = 9;
            label18.Text = "Chọn phòng";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(78, 69);
            label17.Name = "label17";
            label17.Size = new Size(85, 15);
            label17.TabIndex = 7;
            label17.Text = "KHÁCH HÀNG";
            // 
            // listView1
            // 
            listView1.Location = new Point(169, 85);
            listView1.Name = "listView1";
            listView1.Size = new Size(202, 146);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.Visible = false;
            // 
            // searchCustomer
            // 
            searchCustomer.Location = new Point(169, 66);
            searchCustomer.Name = "searchCustomer";
            searchCustomer.Size = new Size(202, 23);
            searchCustomer.TabIndex = 3;
            searchCustomer.TextChanged += textBox1_TextChanged;
            // 
            // addorder
            // 
            addorder.Location = new Point(6, 61);
            addorder.Name = "addorder";
            addorder.Size = new Size(66, 47);
            addorder.TabIndex = 2;
            addorder.Text = "Đặt phòng";
            addorder.UseVisualStyleBackColor = true;
            addorder.Click += addorder_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.FlatStyle = FlatStyle.Flat;
            label16.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            label16.Location = new Point(279, 11);
            label16.Name = "label16";
            label16.Size = new Size(214, 30);
            label16.TabIndex = 1;
            label16.Text = "Quản Lý Đặt Phòng";
            // 
            // OrderGrid
            // 
            OrderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGrid.Location = new Point(55, 178);
            OrderGrid.Name = "OrderGrid";
            OrderGrid.Size = new Size(706, 458);
            OrderGrid.TabIndex = 12;
            OrderGrid.CellClick += OrderGrid_CellClick;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(panel9);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(816, 689);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.BackColor = Color.SlateGray;
            panel9.Controls.Add(chart4);
            panel9.Controls.Add(chart3);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(label20);
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(817, 693);
            panel9.TabIndex = 0;
            // 
            // chart3
            // 
            chartArea4.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart3.Legends.Add(legend4);
            chart3.Location = new Point(13, 44);
            chart3.Name = "chart3";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chart3.Series.Add(series4);
            chart3.Size = new Size(492, 337);
            chart3.TabIndex = 4;
            chart3.Text = "chart3";
            chart3.Click += chart3_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(comboBox5);
            panel10.Controls.Add(label25);
            panel10.Controls.Add(comboBox4);
            panel10.Controls.Add(label24);
            panel10.Controls.Add(comboBox3);
            panel10.Controls.Add(label23);
            panel10.Controls.Add(label22);
            panel10.Controls.Add(label21);
            panel10.Controls.Add(orderSum);
            panel10.Controls.Add(CustomerSum);
            panel10.Controls.Add(RoomSum);
            panel10.Location = new Point(511, 44);
            panel10.Name = "panel10";
            panel10.Size = new Size(303, 635);
            panel10.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(147, 48);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(148, 23);
            comboBox3.TabIndex = 7;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(25, 51);
            label23.Name = "label23";
            label23.Size = new Size(116, 15);
            label23.TabIndex = 6;
            label23.Text = " rút gọn theo tháng :";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.FlatStyle = FlatStyle.Flat;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(101, 14);
            label22.Name = "label22";
            label22.Size = new Size(80, 21);
            label22.TabIndex = 5;
            label22.Text = "Thông số";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.FlatStyle = FlatStyle.Flat;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(25, 594);
            label21.Name = "label21";
            label21.Size = new Size(145, 21);
            label21.TabIndex = 4;
            label21.Text = "Tổng Doanh Thu :";
            // 
            // orderSum
            // 
            orderSum.AutoSize = true;
            orderSum.Location = new Point(25, 244);
            orderSum.Name = "orderSum";
            orderSum.Size = new Size(44, 15);
            orderSum.TabIndex = 2;
            orderSum.Text = "label21";
            // 
            // CustomerSum
            // 
            CustomerSum.AutoSize = true;
            CustomerSum.Location = new Point(25, 209);
            CustomerSum.Name = "CustomerSum";
            CustomerSum.Size = new Size(44, 15);
            CustomerSum.TabIndex = 1;
            CustomerSum.Text = "label21";
            // 
            // RoomSum
            // 
            RoomSum.AutoSize = true;
            RoomSum.Location = new Point(25, 172);
            RoomSum.Name = "RoomSum";
            RoomSum.Size = new Size(44, 15);
            RoomSum.TabIndex = 0;
            RoomSum.Text = "label21";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.FlatStyle = FlatStyle.Flat;
            label20.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            label20.Location = new Point(290, 11);
            label20.Name = "label20";
            label20.Size = new Size(229, 30);
            label20.TabIndex = 2;
            label20.Text = "Thống Kê Doanh Thu";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 726);
            panel2.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(0, 598);
            button5.Name = "button5";
            button5.Size = new Size(200, 108);
            button5.TabIndex = 8;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(0, 478);
            button4.Name = "button4";
            button4.Size = new Size(200, 108);
            button4.TabIndex = 7;
            button4.Text = "Thống kê";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(0, 364);
            button3.Name = "button3";
            button3.Size = new Size(200, 108);
            button3.TabIndex = 6;
            button3.Text = "Đặt phòng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 250);
            button2.Name = "button2";
            button2.Size = new Size(200, 108);
            button2.TabIndex = 5;
            button2.Text = "Quản Lý Khách Hàng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(0, 136);
            button1.Name = "button1";
            button1.Size = new Size(200, 108);
            button1.TabIndex = 4;
            button1.Text = "Quản lý phòng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 104);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 104);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 50);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // chart4
            // 
            chartArea3.Name = "ChartArea1";
            chart4.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart4.Legends.Add(legend3);
            chart4.Location = new Point(13, 387);
            chart4.Name = "chart4";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart4.Series.Add(series3);
            chart4.Size = new Size(492, 292);
            chart4.TabIndex = 5;
            chart4.Text = "chart4";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(147, 86);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(148, 23);
            comboBox4.TabIndex = 9;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(25, 89);
            label24.Name = "label24";
            label24.Size = new Size(116, 15);
            label24.TabIndex = 8;
            label24.Text = " rút gọn theo tháng :";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(147, 126);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(148, 23);
            comboBox5.TabIndex = 11;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(25, 129);
            label25.Name = "label25";
            label25.Size = new Size(116, 15);
            label25.TabIndex = 10;
            label25.Text = " rút gọn theo tháng :";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 720);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "Form2";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RoomGridView).EndInit();
            tabPage2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerGrid).EndInit();
            tabPage4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGrid).EndInit();
            tabPage5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button4;
        private Panel panel3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel4;
        private Label label5;
        private TextBox NumberTxt;
        private Label label4;
        private Button UpdateRoomBtn;
        private Button DeleteRoomBtn;
        private Button InsertRoomBtn;
        private DataGridView RoomGridView;
        private ComboBox comboBox1;
        private Panel panel5;
        private Button uploadcustomerBtn;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Button button6;
        private TextBox RIDtxt;
        private TextBox CustomerNameTxt;
        private CheckBox WomenCb;
        private CheckBox MaleCb;
        private DateTimePicker DOBpicker;
        private Label label14;
        private Button button9;
        private Button button8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label8;
        private TabPage tabPage3;
        private Panel panel6;
        private Panel panel7;
        private DataGridView CustomerGrid;
        private ComboBox comboBox2;
        private Label label15;
        private TextBox phonecustomertxt;
        private TabPage tabPage4;
        private Panel panel8;
        private Button addorder;
        private Label label16;
        private TextBox searchCustomer;
        private ListView listView1;
        private Label label17;
        private Label label18;
        private TextBox RoomSearchBox;
        private ListView listView2;
        private DataGridView OrderGrid;
        private Button button7;
        private Label label6;
        private Label label19;
        private Label label13;
        private TabPage tabPage5;
        private Panel panel9;
        private Label label20;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel10;
        private Label label21;
        private Label orderSum;
        private Label CustomerSum;
        private Label RoomSum;
        private Label label22;
        private Label label23;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private ComboBox comboBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private ComboBox comboBox5;
        private Label label25;
        private ComboBox comboBox4;
        private Label label24;
    }
}