using motelManageMent.Controller;
using motelManageMent.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace motelManageMent
{
    public partial class CheckoutDetails : Form
    {
        private int id;
        private int rid;
        private DateTime cDate;
        private Customer customer;
        private Room room;
        private static DateTime endate;
        private static int totalcost;
        private static AdminDashboard f;
        public CheckoutDetails(Room r, Customer c, int id, int rid, DateTime cDate,AdminDashboard admf )
        {
            InitializeComponent();
            this.room = r;
            this.customer = c;
            this.room = r;
            this.id = id;
            this.rid = rid;
            this.cDate = cDate;
            totalcost = calculateTotalCost(cDate, endate, r.RoomNumber);
            endate = DateTime.Now;
            f = admf;


            label1.Text = "Tên Khách Hàng: " + c.CustomerName;
            label2.Text = "CCCD: " + c.ResidentID;
            label3.Text = "DOB: " + c.DOB;
            label4.Text = "Số Điện Thoại: " + c.PhoneNumber;

            label5.Text = "Phòng số: " + r.Id;
            label6.Text = "Thời Gian Đặt Phòng: " + cDate;
            label7.Text = "Thời gian Thanh Toán: " + endate;
            label9.Text = calculateTotalCost(cDate, endate, r.RoomNumber).ToString();
          
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public int calculateTotalCost(DateTime a, DateTime b, int money)
        {
            TimeSpan different = b - a;
            int totalHours = (int)Math.Floor(different.TotalHours);
            int totalCost = money * totalHours;
            return totalCost;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
        
                BookedController bookedController = new BookedController();
                bookedController.checkOutRooms(id,rid,endate,totalcost);
                this.Dispose() ;
                f.renderOrderGridView();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
