using motelManageMent.Controller;
using motelManageMent.Model;
using System.Text.RegularExpressions;

namespace motelManageMent
{
    public partial class Form1 : Form
    {
        private int targetX = -30; // Vị trí đích trên trục X
        private int startX;
        private int step = 10; // Khoảng cách di chuyển mỗi lần
        private bool isMovingLeft = false;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            alertgmail.Visible = false;
            alertk.Visible = false;
            alertmk.Visible = false;
            alertsdt.Visible = false;
            alertlogingmail.Visible = false;
            alertloginpassword.Visible = false; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            startX = panel2.Left;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gmail = GmailLogintxt.Text;

          


            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            if (!Regex.IsMatch(gmail, pattern))
            {

                alertlogingmail.Text = "Vui lòng nhập đúng gmail";
                alertlogingmail.Visible = true;
            }
            else
            {
                alertlogingmail.Visible = false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            AdminController adc = new AdminController();

            try
            {
                bool isValid = validateLogin();
                if (isValid == true)
                {
                    string gmail = GmailLogintxt.Text;

                    string password = Passwordlogintxt.Text;
                    Admin adm = adc.login(gmail, password);
                    if (adm != null)
                    {
                        this.Visible = false;
                        AdminDashboard form = new AdminDashboard(adm);
                        form.Visible = true;
                    }
                }
                


            }
            catch (Exception ex)
            {

            }
        }
        public bool validateLogin()
        {

            if (alertloginpassword.Visible == true || alertlogingmail.Visible == true)
            {
                return false;
            }
            return true;

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            loginbtn.SendToBack();
            signupbtn.SendToBack();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Kiểm tra xem panel2 còn ở phía phải của targetX hay không
            if (panel2.Left > targetX)
            {
                panel2.Left -= step;  // Di chuyển panel2 sang trái (giảm giá trị Left)
            }
            else
            {
                panel2.Left = targetX;
                timer1.Enabled = false;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel2.Left < startX)
            {
                panel2.Left += step;
            }
            else
            {
                panel2.Left = startX;
                timer2.Enabled = false;
                isMovingLeft = false;
            }
        }

        private void loginrtn_Click(object sender, EventArgs e)
        {
            if (!isMovingLeft)
            {
                timer2.Enabled = true;
                loginbtn.SendToBack();
                signupbtn.SendToBack();
                isMovingLeft = true;
            }
            else
            {
                timer2.Enabled = true;
            }
        }


        private void alertk_Click(object sender, EventArgs e)
        {

        }

        private void loginrtn_Click_1(object sender, EventArgs e)
        {
            if (!isMovingLeft)
            {
                timer2.Enabled = true;
                loginbtn.SendToBack();
                signupbtn.SendToBack();
                isMovingLeft = true;
            }
            else
            {
                timer2.Enabled = true;
            }
        }
        private bool validateSignUpdata()
        {
            string msg;
            if (alertmk.Visible == true)
            {
                msg = "Mật khẩu của bạn chưa đúng!";
            }
            if (alertgmail.Visible == true)
            {
                msg = "Gmail của bạn chưa đúng!";
            }
            if (alertsdt.Visible == true)
            {
                msg = "Số điện thoại của bạn chưa đúng!";
            }
            if (alertmk.Visible == false && alertgmail.Visible == false && alertsdt.Visible == false)
            {
                return true;
            }
            return false;
        }
        private void signupUnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupPasstxt_TextChanged(object sender, EventArgs e)
        {
            string pass = signupPasstxt.Text;
            if (pass.Length <= 6)
            {
                alertmk.Text = "mật khẩu phải có hơn 6 kí tự ";
                alertmk.Visible = true;

            }
            else
            {

                alertmk.Visible = false;
            }
        }

        private void signUpGmailtxt_TextChanged(object sender, EventArgs e)
        {
            string gmail = signUpGmailtxt.Text;
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            if (!Regex.IsMatch(gmail, pattern))
            {
                alertgmail.Text = "vui lòng nhập đúng định dạng @gmail";
                alertgmail.Visible = true;

            }
            else
            {
                alertgmail.Visible = false;

            }
        }

        private void signupPhonetxt_TextChanged(object sender, EventArgs e)
        {
            string phone = signupPhonetxt.Text;
            string pattern = @"^(0[3|5|7|8|9])+([0-9]{8})$";
            if (!Regex.IsMatch(phone, pattern))
            {
                alertsdt.Text = "số điện thoại của bạn bị sai định dạng!";
                alertsdt.Visible = true;
                button2.Enabled = true;
            }
            else
            {
                alertsdt.Visible = false;

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AdminController adc = new AdminController();
            try
            {
                string uname = signupUnametxt.Text;
                string pass = signupPasstxt.Text;
                string gmail = signUpGmailtxt.Text;
                string phone = signupPhonetxt.Text;

                if (uname.Length < 1 || pass.Length < 1 || gmail.Length < 1 || phone.Length < 1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu đăng ký");
                }
                else
                {
                    bool isValid = validateSignUpdata();
                    if (isValid == true)
                    {
                        adc.SignUp(uname, pass, gmail, phone);
                        signupUnametxt.Text = "";
                        signupPasstxt.Text = "";
                        signupPhonetxt.Text = "";
                        signUpGmailtxt.Text = "";
                        alertgmail.Visible = false;
                        alertmk.Visible = false;
                        alertsdt.Visible = false;
                        if (!isMovingLeft)
                        {
                            timer2.Enabled = true;
                            loginbtn.SendToBack();
                            signupbtn.SendToBack();
                            isMovingLeft = true;
                        }
                        else
                        {
                            timer2.Enabled = true;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Passwordlogintxt_TextChanged(object sender, EventArgs e)
        {
            string password = Passwordlogintxt.Text;
            if (password.Length < 7)
            {
                alertloginpassword.Text = "Vui lòng nhập đúng mật khẩu";
                alertloginpassword.Visible = true;
            }
            else
            {
                alertloginpassword.Visible = false;
            }
        }
    }
}
