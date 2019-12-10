using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Kalender
{
    public partial class Form1 : Form
    {
        private const string Error = "UPS!\n" + "Something's Wrong!";

        private const string Success = "Successfully \n " +
                                 "Registred";
        public Form1()
        {
            InitializeComponent();
            pnl_MainMenue.Hide();
            pnl_loggedin.Hide();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pnl_Register.Hide();
            pnl_SignUp.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pnl_SignUp.Hide();
            pnl_Register.Show();
        }

        private void Btn_Register_Register_Click(object sender, EventArgs e)
        {
            var queryclass = new Query();
            var passwordclass = new PasswordControll();
            var emailClass = new EmailContorll();
            var errorclass = new ErrorMessanges();

            bool allentered = errorclass.allEntered(bMT_Email.Text, bMT_Password_Register.Text, bMT_userName_Register.Text,
                bMT_RePassword_Register.Text);

            bool controll = passwordclass.samePassword(bMT_Password_Register.Text, bMT_RePassword_Register.Text);

            bool emailcontroll = emailClass.conrtollemail(bMT_Email.Text);

            switch (emailcontroll)
            {
                case false when controll == true && allentered==true :
                {
                    var password = passwordclass.HashPassword(bMT_Password_Register.Text);
                    queryclass.insertinto(bMT_userName_Register.Text, password, bMT_Email.Text);
                    pb_error_Register.Visible = false;
                    pb_success_Register.Visible = true;
                    lbl_Status_Register.Text = Success;
                    break;
                }
                case false:
                {
                    pb_error_Register.Visible = true;
                    lbl_Status_Register.Text = Error;
                    break;
                }
                case true:
                    pb_error_Register.Visible = true;
                    lbl_Status_Register.Text = Error ;
                    break;
            }
        }

        private void btn_SignUp_SignUp_Click(object sender, EventArgs e)
        {
            var signUpClass = new SignUp();

            if (signUpClass.controllData(bMT_userName_SignUp.Text, bMT_Password_SignUp.Text)==true)
            {
                pb_error_SignUp.Visible = false;
                pb_success_SignUp.Visible = false;
                lbl_Status_SignUp.Text ="LOGGED IN!";
                pnl_notloggedin.Hide();
                pnl_MainMenue.Show();
                pnl_loggedin.Show();
            }

            else
            {
                pb_error_SignUp.Visible = true;
                lbl_Status_SignUp.Text = Error;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

