using EHealthCare.Services;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHealthCare.UI_Layer
{
    public partial class DoctorLogin : Form
    {
        Point lastPoint;
        LoginService loginService;
        public DoctorLogin()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        //public Login(Loading loading)
        //{
           
        //    loading.Hide();
        //    this.Show();
        //    InitializeComponent();
        //}

        private void closeIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - this.lastPoint.X;
                this.Top += e.Y - this.lastPoint.Y;
            }
        }

        private void panelRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - this.lastPoint.X;
                this.Top += e.Y - this.lastPoint.Y;
            }
        }

        private void panelLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - this.lastPoint.X;
                this.Top += e.Y - this.lastPoint.Y;
            }
        }

        private void panelRight_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (textBoxUsername.Text.Length==0 || textBoxPassword.Text.Length==0)
            {
                MessageBox.Show("Username or Password Can't be Blank");
            }
            else
            {
                NameValueCollection logData = loginService.LoginValidation(textBoxUsername.Text, textBoxPassword.Text);
                if (Int32.Parse(logData["UserID"]) > 0)
                {
                    if (logData["UserType"] == "1" || logData["UserType"] == "2")
                    {
                        new OTP(logData).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("You Haven't any Access Role");
                    }


                }
                else
                {
                    MessageBox.Show("Login Failed");
                   /// MessageBox.Show("Login Failed");

                }


                
            }


          
        }

        private void btnRegistraion_Click(object sender, EventArgs e)
        {
            new DoctorRegistration().Show();
            this.Hide();
        }



        //private void checkboxTerms_OnChange(object sender, EventArgs e)
        //{
        //    if (checkboxTerms.Checked)
        //    {
        //        buttonRegister.Enabled = true;
        //    }
        //    else
        //    {
        //        buttonRegister.Enabled = false;
        //    }
        //}






    }
}
