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
            RoomGridView.CellContentClick += RoomGridView_CellContentClick;


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
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            label3.Text = username;
            label2.Text = id;

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
    }
}
