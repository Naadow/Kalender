﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Kalender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            pnl_Register.SendToBack();
            pnl_SignUp.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pnl_SignUp.SendToBack();
            pnl_Register.BringToFront();
        }

        private void Btn_Register_Register_Click(object sender, EventArgs e)
        {
            Query queryclass = new Query();
            PasswordControll passwordclass = new PasswordControll();
            EmailContorll emailClass = new EmailContorll();

            bool controll = passwordclass.samePassword(bMT_Password_Register.Text, bMT_RePassword_Register.Text);

            bool emailcontroll = emailClass.conrtollemail(bMT_Email.Text);

            switch (emailcontroll)
            {
                case false when controll==true:
                {
                    string password = passwordclass.HashPassword(bMT_Password_Register.Text);
                
                    queryclass.insertinto(bMT_userName_Register.Text, password, bMT_Email.Text);
                    pb_error.Visible = false;
                    pb_success.Visible = true;
                    lbl_Status.Text = "Successfully \n " +
                                      "Registred";
                    break;
                }
                case false:
                {
                    if (controll==false)
                    {
                        pb_error.Visible = true;
                        lbl_Status.Text = "UPS!\n" +
                                          "Somethings Wrong!";
                    }

                    break;
                }
                case true:
                    pb_error.Visible = true;
                    lbl_Status.Text = "UPS!\n" +
                                      "Somethings Wrong!";
                    break;
            }
                

           /* if (controll==true)
            {
                string password = passwordclass.HashPassword(bMT_Password_Register.Text);
                
                queryclass.insertinto(bMT_userName_Register.Text, password, bMT_Email.Text);
                lbl_Status.Text = "Successfully \n " +
                                  "Registred";
            }

            else if (controll==false)
            {
                pb_error.Visible = true;
                lbl_Status.Text = "UPS!\n" +
                    "Somethings Wrong!";
            }*/
        }
    }
    
}
