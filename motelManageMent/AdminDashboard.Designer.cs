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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
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
            button5 = new Button();
            customermnsearch = new TextBox();
            button14 = new Button();
            label13 = new Label();
            CustomerGrid = new DataGridView();
            tabPage4 = new TabPage();
            panel8 = new Panel();
            listView1 = new ListView();
            button13 = new Button();
            checkBox1 = new CheckBox();
            ordertimesearcha = new DateTimePicker();
            label26 = new Label();
            sortName = new TextBox();
            button12 = new Button();
            button7 = new Button();
            listView2 = new ListView();
            RoomSearchBox = new TextBox();
            label18 = new Label();
            label17 = new Label();
            searchCustomer = new TextBox();
            addorder = new Button();
            label16 = new Label();
            OrderGrid = new DataGridView();
            label27 = new Label();
            label28 = new Label();
            ordertimesearchb = new DateTimePicker();
            tabPage5 = new TabPage();
            panel9 = new Panel();
            label21 = new Label();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel10 = new Panel();
            sumOrdermonth = new Label();
            button11 = new Button();
            button10 = new Button();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            sumDoanhthu = new Label();
            orderSum = new Label();
            CustomerSum = new Label();
            RoomSum = new Label();
            label20 = new Label();
            panel2 = new Panel();
            button15 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            comboBox5 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button16 = new Button();
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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 726);
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
            panel4.Controls.Add(button16);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(comboBox5);
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
            UpdateRoomBtn.Image = (Image)resources.GetObject("UpdateRoomBtn.Image");
            UpdateRoomBtn.Location = new Point(402, 179);
            UpdateRoomBtn.Name = "UpdateRoomBtn";
            UpdateRoomBtn.RightToLeft = RightToLeft.No;
            UpdateRoomBtn.Size = new Size(89, 38);
            UpdateRoomBtn.TabIndex = 8;
            UpdateRoomBtn.Text = "đổi thông tin phòng";
            UpdateRoomBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            UpdateRoomBtn.UseVisualStyleBackColor = true;
            UpdateRoomBtn.Click += UpdateRoomBtn_Click;
            // 
            // DeleteRoomBtn
            // 
            DeleteRoomBtn.Image = (Image)resources.GetObject("DeleteRoomBtn.Image");
            DeleteRoomBtn.Location = new Point(307, 179);
            DeleteRoomBtn.Name = "DeleteRoomBtn";
            DeleteRoomBtn.Size = new Size(89, 38);
            DeleteRoomBtn.TabIndex = 7;
            DeleteRoomBtn.Text = "xóa phòng";
            DeleteRoomBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteRoomBtn.UseVisualStyleBackColor = true;
            DeleteRoomBtn.Click += DeleteRoomBtn_Click;
            // 
            // InsertRoomBtn
            // 
            InsertRoomBtn.FlatAppearance.BorderColor = Color.Black;
            InsertRoomBtn.FlatAppearance.BorderSize = 3;
            InsertRoomBtn.Image = (Image)resources.GetObject("InsertRoomBtn.Image");
            InsertRoomBtn.Location = new Point(212, 179);
            InsertRoomBtn.Name = "InsertRoomBtn";
            InsertRoomBtn.Size = new Size(89, 38);
            InsertRoomBtn.TabIndex = 6;
            InsertRoomBtn.Text = "thêm phòng";
            InsertRoomBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            label8.Location = new Point(75, 303);
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
            button9.BackgroundImageLayout = ImageLayout.Center;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(580, 308);
            button9.Name = "button9";
            button9.Size = new Size(114, 54);
            button9.TabIndex = 24;
            button9.Text = "D.s Khách Hàng";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Azure;
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(438, 308);
            button8.Name = "button8";
            button8.Size = new Size(121, 54);
            button8.TabIndex = 23;
            button8.Text = "Thêm";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
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
            label7.Location = new Point(75, 35);
            label7.Name = "label7";
            label7.Size = new Size(163, 15);
            label7.TabIndex = 5;
            label7.Text = "Mặt trước căn cước công dân";
            label7.Click += label7_Click;
            // 
            // button6
            // 
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(122, 533);
            button6.Name = "button6";
            button6.Size = new Size(75, 34);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // uploadcustomerBtn
            // 
            uploadcustomerBtn.Image = (Image)resources.GetObject("uploadcustomerBtn.Image");
            uploadcustomerBtn.Location = new Point(122, 267);
            uploadcustomerBtn.Name = "uploadcustomerBtn";
            uploadcustomerBtn.Size = new Size(75, 33);
            uploadcustomerBtn.TabIndex = 3;
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
            panel7.Controls.Add(button5);
            panel7.Controls.Add(customermnsearch);
            panel7.Controls.Add(button14);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(CustomerGrid);
            panel7.Location = new Point(1, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(815, 687);
            panel7.TabIndex = 0;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(569, 68);
            button5.Name = "button5";
            button5.Size = new Size(33, 33);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // customermnsearch
            // 
            customermnsearch.Location = new Point(240, 68);
            customermnsearch.Multiline = true;
            customermnsearch.Name = "customermnsearch";
            customermnsearch.Size = new Size(285, 33);
            customermnsearch.TabIndex = 4;
            // 
            // button14
            // 
            button14.Image = (Image)resources.GetObject("button14.Image");
            button14.Location = new Point(531, 68);
            button14.Name = "button14";
            button14.Size = new Size(32, 33);
            button14.TabIndex = 3;
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
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
            CustomerGrid.Location = new Point(3, 106);
            CustomerGrid.Name = "CustomerGrid";
            CustomerGrid.Size = new Size(809, 570);
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
            panel8.Controls.Add(listView1);
            panel8.Controls.Add(button13);
            panel8.Controls.Add(checkBox1);
            panel8.Controls.Add(ordertimesearcha);
            panel8.Controls.Add(label26);
            panel8.Controls.Add(sortName);
            panel8.Controls.Add(button12);
            panel8.Controls.Add(button7);
            panel8.Controls.Add(listView2);
            panel8.Controls.Add(RoomSearchBox);
            panel8.Controls.Add(label18);
            panel8.Controls.Add(label17);
            panel8.Controls.Add(searchCustomer);
            panel8.Controls.Add(addorder);
            panel8.Controls.Add(label16);
            panel8.Controls.Add(OrderGrid);
            panel8.Controls.Add(label27);
            panel8.Controls.Add(label28);
            panel8.Controls.Add(ordertimesearchb);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(820, 699);
            panel8.TabIndex = 0;
            panel8.Paint += panel8_Paint;
            // 
            // listView1
            // 
            listView1.Location = new Point(96, 90);
            listView1.Name = "listView1";
            listView1.Size = new Size(202, 209);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.Visible = false;
            // 
            // button13
            // 
            button13.Image = Properties.Resources.refresh_arrow;
            button13.Location = new Point(751, 231);
            button13.Name = "button13";
            button13.Size = new Size(36, 34);
            button13.TabIndex = 24;
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(628, 240);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 19);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "hiện đã thanh toán";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ordertimesearcha
            // 
            ordertimesearcha.Location = new Point(260, 239);
            ordertimesearcha.Name = "ordertimesearcha";
            ordertimesearcha.Size = new Size(143, 23);
            ordertimesearcha.TabIndex = 19;
            ordertimesearcha.ValueChanged += ordertimesearcha_ValueChanged;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(219, 241);
            label26.Name = "label26";
            label26.Size = new Size(35, 15);
            label26.TabIndex = 18;
            label26.Text = "Ngày";
            // 
            // sortName
            // 
            sortName.Location = new Point(57, 239);
            sortName.Multiline = true;
            sortName.Name = "sortName";
            sortName.Size = new Size(156, 26);
            sortName.TabIndex = 15;
            sortName.Text = "(tên hoặc sdt)";
            sortName.TextChanged += sortName_TextChanged;
            // 
            // button12
            // 
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.Location = new Point(11, 231);
            button12.Name = "button12";
            button12.Size = new Size(40, 34);
            button12.TabIndex = 14;
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button7
            // 
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(694, 69);
            button7.Name = "button7";
            button7.Size = new Size(80, 49);
            button7.TabIndex = 13;
            button7.Text = "Check out";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // listView2
            // 
            listView2.Location = new Point(403, 90);
            listView2.Name = "listView2";
            listView2.Size = new Size(202, 209);
            listView2.TabIndex = 11;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.Visible = false;
            // 
            // RoomSearchBox
            // 
            RoomSearchBox.Location = new Point(403, 69);
            RoomSearchBox.Name = "RoomSearchBox";
            RoomSearchBox.Size = new Size(202, 23);
            RoomSearchBox.TabIndex = 10;
            RoomSearchBox.TextChanged += textBox1_TextChanged_1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(304, 69);
            label18.Name = "label18";
            label18.Size = new Size(74, 15);
            label18.TabIndex = 9;
            label18.Text = "Chọn phòng";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(5, 72);
            label17.Name = "label17";
            label17.Size = new Size(85, 15);
            label17.TabIndex = 7;
            label17.Text = "KHÁCH HÀNG";
            // 
            // searchCustomer
            // 
            searchCustomer.Location = new Point(96, 69);
            searchCustomer.Name = "searchCustomer";
            searchCustomer.Size = new Size(202, 23);
            searchCustomer.TabIndex = 3;
            searchCustomer.TextChanged += textBox1_TextChanged;
            // 
            // addorder
            // 
            addorder.Image = (Image)resources.GetObject("addorder.Image");
            addorder.Location = new Point(611, 69);
            addorder.Name = "addorder";
            addorder.Size = new Size(77, 49);
            addorder.TabIndex = 2;
            addorder.Text = "Đặt phòng";
            addorder.TextImageRelation = TextImageRelation.ImageBeforeText;
            addorder.UseVisualStyleBackColor = true;
            addorder.Click += addorder_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.FlatStyle = FlatStyle.Flat;
            label16.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(247, 5);
            label16.Name = "label16";
            label16.Size = new Size(262, 37);
            label16.TabIndex = 1;
            label16.Text = "Quản Lý Đặt Phòng";
            // 
            // OrderGrid
            // 
            OrderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGrid.Location = new Point(6, 268);
            OrderGrid.Name = "OrderGrid";
            OrderGrid.Size = new Size(799, 411);
            OrderGrid.TabIndex = 12;
            OrderGrid.CellClick += OrderGrid_CellClick;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.Location = new Point(409, 228);
            label27.Name = "label27";
            label27.Size = new Size(28, 37);
            label27.TabIndex = 21;
            label27.Text = "-";
            label27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(435, 239);
            label28.Name = "label28";
            label28.Size = new Size(35, 15);
            label28.TabIndex = 23;
            label28.Text = "Ngày";
            // 
            // ordertimesearchb
            // 
            ordertimesearchb.Location = new Point(476, 239);
            ordertimesearchb.Name = "ordertimesearchb";
            ordertimesearchb.Size = new Size(146, 23);
            ordertimesearchb.TabIndex = 22;
            ordertimesearchb.ValueChanged += ordertimesearchb_ValueChanged;
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
            panel9.Controls.Add(label21);
            panel9.Controls.Add(chart3);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(label20);
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(816, 690);
            panel9.TabIndex = 0;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.FlatStyle = FlatStyle.Flat;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(161, 68);
            label21.Name = "label21";
            label21.Size = new Size(166, 21);
            label21.TabIndex = 13;
            label21.Text = "Biểu Đồ Doanh Thu :";
            // 
            // chart3
            // 
            chartArea1.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart3.Legends.Add(legend1);
            chart3.Location = new Point(3, 92);
            chart3.Name = "chart3";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart3.Series.Add(series1);
            chart3.Size = new Size(526, 595);
            chart3.TabIndex = 4;
            chart3.Text = "chart3";
            chart3.Click += chart3_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(sumOrdermonth);
            panel10.Controls.Add(button11);
            panel10.Controls.Add(button10);
            panel10.Controls.Add(comboBox4);
            panel10.Controls.Add(comboBox3);
            panel10.Controls.Add(label24);
            panel10.Controls.Add(label23);
            panel10.Controls.Add(label22);
            panel10.Controls.Add(sumDoanhthu);
            panel10.Controls.Add(orderSum);
            panel10.Controls.Add(CustomerSum);
            panel10.Controls.Add(RoomSum);
            panel10.Location = new Point(535, 92);
            panel10.Name = "panel10";
            panel10.Size = new Size(278, 594);
            panel10.TabIndex = 3;
            // 
            // sumOrdermonth
            // 
            sumOrdermonth.AutoSize = true;
            sumOrdermonth.Location = new Point(25, 287);
            sumOrdermonth.Name = "sumOrdermonth";
            sumOrdermonth.Size = new Size(44, 15);
            sumOrdermonth.TabIndex = 13;
            sumOrdermonth.Text = "label25";
            sumOrdermonth.Visible = false;
            // 
            // button11
            // 
            button11.Location = new Point(131, 125);
            button11.Name = "button11";
            button11.Size = new Size(61, 23);
            button11.TabIndex = 12;
            button11.Text = "Đặt Lại";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(198, 125);
            button10.Name = "button10";
            button10.Size = new Size(58, 23);
            button10.TabIndex = 11;
            button10.Text = "Rút Gọn";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(131, 86);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(125, 23);
            comboBox4.TabIndex = 10;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(133, 45);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(123, 23);
            comboBox3.TabIndex = 9;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(5, 89);
            label24.Name = "label24";
            label24.Size = new Size(123, 15);
            label24.TabIndex = 8;
            label24.Text = "Doanh Thu Theo Năm";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(5, 48);
            label23.Name = "label23";
            label23.Size = new Size(136, 15);
            label23.TabIndex = 6;
            label23.Text = "Doanh Thu Theo Tháng :";
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
            // sumDoanhthu
            // 
            sumDoanhthu.AutoSize = true;
            sumDoanhthu.FlatStyle = FlatStyle.Flat;
            sumDoanhthu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sumDoanhthu.Location = new Point(25, 302);
            sumDoanhthu.Name = "sumDoanhthu";
            sumDoanhthu.Size = new Size(145, 21);
            sumDoanhthu.TabIndex = 4;
            sumDoanhthu.Text = "Tổng Doanh Thu :";
            // 
            // orderSum
            // 
            orderSum.AutoSize = true;
            orderSum.Location = new Point(25, 251);
            orderSum.Name = "orderSum";
            orderSum.Size = new Size(44, 15);
            orderSum.TabIndex = 2;
            orderSum.Text = "label21";
            // 
            // CustomerSum
            // 
            CustomerSum.AutoSize = true;
            CustomerSum.Location = new Point(25, 216);
            CustomerSum.Name = "CustomerSum";
            CustomerSum.Size = new Size(44, 15);
            CustomerSum.TabIndex = 1;
            CustomerSum.Text = "label21";
            // 
            // RoomSum
            // 
            RoomSum.AutoSize = true;
            RoomSum.Location = new Point(25, 179);
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
            label20.Location = new Point(311, 0);
            label20.Name = "label20";
            label20.Size = new Size(229, 30);
            label20.TabIndex = 2;
            label20.Text = "Thống Kê Doanh Thu";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(button15);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 726);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint_1;
            // 
            // button15
            // 
            button15.Image = (Image)resources.GetObject("button15.Image");
            button15.Location = new Point(54, 49);
            button15.Name = "button15";
            button15.Size = new Size(92, 84);
            button15.TabIndex = 8;
            button15.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(0, 560);
            button4.Name = "button4";
            button4.Size = new Size(200, 108);
            button4.TabIndex = 7;
            button4.Text = "Thống kê";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(0, 446);
            button3.Name = "button3";
            button3.Size = new Size(200, 108);
            button3.TabIndex = 6;
            button3.Text = "Đặt phòng";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 332);
            button2.Name = "button2";
            button2.Size = new Size(200, 108);
            button2.TabIndex = 5;
            button2.Text = "Quản Lý Khách Hàng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 218);
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
            label3.Location = new Point(79, 136);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(582, 248);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(30, 23);
            comboBox5.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(535, 251);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 13;
            label1.Text = "Thứ tự";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 238);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 32);
            textBox1.TabIndex = 14;
            // 
            // button16
            // 
            button16.Image = (Image)resources.GetObject("button16.Image");
            button16.Location = new Point(460, 238);
            button16.Name = "button16";
            button16.Size = new Size(44, 33);
            button16.TabIndex = 15;
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 720);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Panel panel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private Panel panel10;
        private Button button11;
        private Button button10;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label sumDoanhthu;
        private Label orderSum;
        private Label CustomerSum;
        private Label RoomSum;
        private Label label20;
        private Label label21;
        private Label sumOrdermonth;
        private Button button12;
        private TextBox sortName;
        private Label label26;
        private DateTimePicker ordertimesearcha;
        private CheckBox checkBox1;
        private Label label27;
        private Label label28;
        private DateTimePicker ordertimesearchb;
        private Button button13;
        private TextBox customermnsearch;
        private Button button14;
        private Button button5;
        private Label label3;
        private Button button15;
        private Label label1;
        private ComboBox comboBox5;
        private TextBox textBox1;
        private Button button16;
    }
}