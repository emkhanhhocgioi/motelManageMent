using motelManageMent.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace motelManageMent
{
    public partial class CustomerData : Form
    {
        public CustomerData(Customer ctd)
        {
            InitializeComponent();
            label2.Text += ctd.CustomerName;
            label3.Text += ctd.ResidentID;
            label4.Text += ctd.DOB;
            if(ctd.Gender == 0)
            {
                label5.Text += "Nam";
            }
            else
            {
                label5.Text += "Nữ";
            }
          
            label6.Text += ctd.RoomID;


       
            if (ctd.FImage != null && ctd.FImage.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(ctd.FImage))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
        
                pictureBox1.Image = null;
            }

 
            if (ctd.BImage != null && ctd.BImage.Length > 0)
            {
                using (MemoryStream ms2 = new MemoryStream(ctd.BImage))
                {
                    pictureBox2.Image = Image.FromStream(ms2);
                }
            }
            else
            {
         
                pictureBox2.Image = null;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }
    }
}
