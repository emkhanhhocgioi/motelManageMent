using motelManageMent.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public AdminDashboard(Admin adm)
        {
            
            InitializeComponent();
           
            username = adm.Name;
            id = adm.Id;
            phone = adm.Phone;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            label3.Text = username;
            label2.Text = id;
        }
    }
}
