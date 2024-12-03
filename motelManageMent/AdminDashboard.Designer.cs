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
            panel1 = new Panel();
            panel3 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel4 = new Panel();
            comboBox1 = new ComboBox();
            UpdateRoomBtn = new Button();
            DeleteRoomBtn = new Button();
            InsertRoomBtn = new Button();
            RoomGridView = new DataGridView();
            label5 = new Label();
            NumberTxt = new TextBox();
            label4 = new Label();
            CreateRoomTitle = new Label();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RoomGridView).BeginInit();
            panel2.SuspendLayout();
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
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(UpdateRoomBtn);
            panel4.Controls.Add(DeleteRoomBtn);
            panel4.Controls.Add(InsertRoomBtn);
            panel4.Controls.Add(RoomGridView);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(NumberTxt);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(CreateRoomTitle);
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(813, 689);
            panel4.TabIndex = 0;
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
            UpdateRoomBtn.Location = new Point(400, 152);
            UpdateRoomBtn.Name = "UpdateRoomBtn";
            UpdateRoomBtn.Size = new Size(89, 38);
            UpdateRoomBtn.TabIndex = 8;
            UpdateRoomBtn.Text = "UPDATE ROOM";
            UpdateRoomBtn.UseVisualStyleBackColor = true;
            UpdateRoomBtn.Click += UpdateRoomBtn_Click;
            // 
            // DeleteRoomBtn
            // 
            DeleteRoomBtn.Location = new Point(305, 152);
            DeleteRoomBtn.Name = "DeleteRoomBtn";
            DeleteRoomBtn.Size = new Size(89, 38);
            DeleteRoomBtn.TabIndex = 7;
            DeleteRoomBtn.Text = "DELETE ROOM";
            DeleteRoomBtn.UseVisualStyleBackColor = true;
            DeleteRoomBtn.Click += DeleteRoomBtn_Click;
            // 
            // InsertRoomBtn
            // 
            InsertRoomBtn.Location = new Point(210, 152);
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
            label5.Size = new Size(89, 15);
            label5.TabIndex = 4;
            label5.Text = "Room Number:";
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
            // CreateRoomTitle
            // 
            CreateRoomTitle.AutoSize = true;
            CreateRoomTitle.Location = new Point(342, 23);
            CreateRoomTitle.Name = "CreateRoomTitle";
            CreateRoomTitle.Size = new Size(38, 15);
            CreateRoomTitle.TabIndex = 0;
            CreateRoomTitle.Text = "label4";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(816, 689);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(0, 364);
            button3.Name = "button3";
            button3.Size = new Size(200, 108);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(0, 250);
            button2.Name = "button2";
            button2.Size = new Size(200, 108);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 136);
            button1.Name = "button1";
            button1.Size = new Size(200, 108);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label CreateRoomTitle;
        private Label label5;
        private TextBox NumberTxt;
        private Label label4;
        private Button UpdateRoomBtn;
        private Button DeleteRoomBtn;
        private Button InsertRoomBtn;
        private DataGridView RoomGridView;
        private ComboBox comboBox1;
    }
}