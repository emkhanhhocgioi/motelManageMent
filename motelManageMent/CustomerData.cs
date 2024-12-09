using motelManageMent.Controller;
using motelManageMent.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace motelManageMent
{
    public partial class CustomerData : Form
    {
        public Customer customer;
        public CustomerData(Customer ctd)
        {
            InitializeComponent();
            customer = ctd;
            namtxt.Text += ctd.CustomerName;
            cccdtxt.Text += ctd.ResidentID;
            dobtxt.Value = ctd.DOB;

            comboBox1.Items.Add(new KeyValuePair<int, string>(0, "Nam"));
            comboBox1.Items.Add(new KeyValuePair<int, string>(1, "Nữ"));
            if (ctd.Gender == 0)
            {
                comboBox1.SelectedValue = 0;
            }
            else
            {
                comboBox1.SelectedValue = 1;
            }
            label7.Text = ctd.FImage.ToString();
            label8.Text = ctd.BImage.ToString();

            phonetxt.Text += ctd.PhoneNumber;

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
        }
        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            try
            {
                if (pictureBox.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);  
                        return ms.GetBuffer();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving image: " + ex.Message);
            }
            return null; 
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
   
                if (string.IsNullOrWhiteSpace(namtxt.Text) || string.IsNullOrWhiteSpace(cccdtxt.Text) || string.IsNullOrWhiteSpace(phonetxt.Text))
                {
                    MessageBox.Show("Please fill all the required fields.");
                    return;
                }

    
                int id = customer.CustomerID;
                string name = namtxt.Text;
                int resid = int.Parse(cccdtxt.Text);
                DateTime dob = dobtxt.Value;
                int gender = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
                int phone = int.Parse(phonetxt.Text);

         
                byte[] FI = customer.FImage;
                byte[] BI = customer.BImage;

          
                CustomerController customerController = new CustomerController();
                customerController.UpdateCustomer(id, name, resid, dob, gender, phone, FI, BI);

        
                MessageBox.Show("Customer updated successfully.");
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show("Input format error: " + formatEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerController customerController = new CustomerController();
                customerController.DeleteCustomer(customer.CustomerID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }
    }
}
