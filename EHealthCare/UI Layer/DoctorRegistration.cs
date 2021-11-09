using EHealthCare.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHealthCare.UI_Layer
{
    public partial class DoctorRegistration : Form
    {
        Point lastPoint;
        RegistrationService registrationService;
        public DoctorRegistration()
        {
            InitializeComponent();
            this.registrationService = new RegistrationService();
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            new DoctorLogin().Show();
            this.Hide();
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

        private void checkboxTerms_OnChange(object sender, EventArgs e)
        {
            if (checkboxTerms.Checked)
            {
                buttonRegister.Enabled = true;
            }
            else
            {
                buttonRegister.Enabled = false;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text.Length==0)
            {
                MessageBox.Show("Full Name is Required");
            }
            else if (textBoxMobileNo.Text.Length==0)
            {
                MessageBox.Show("Mobile No is Required");
            }
            else if (textBoxMobileNo.Text.Length < 11)
            {
                MessageBox.Show("Mobile No Must be 11 Digit");
            }
            else if (textBoxAddress.Text.Length == 0)
            {
                MessageBox.Show("Address is Required");
            }
            else if (textBoxDesingnation.Text.Length == 0)
            {
                MessageBox.Show("Desingnation is Required");
            }
            else if (textBoxDepartment.Text.Length == 0)
            {
                MessageBox.Show("Department is Required");
            }
            else if (textBoxUsername.Text.Length == 0)
            {
                MessageBox.Show("Username Cann't be Blank");
            }
            else if (textBoxUsername.Text.Length < 5)
            {
                MessageBox.Show("Username at Least 5 Character");
            }
            else if (textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Password Cann't be Blank");
            }
            else if (textBoxPassword.Text.Length < 5)
            {
                MessageBox.Show("Password at Least 5 Character");
            }
            else
            {
                int result = registrationService.DoctorRegistration(textBoxFullName.Text, textBoxMobileNo.Text, textBoxUsername.Text, textBoxPassword.Text, textBoxAddress.Text, textBoxDesingnation.Text, textBoxDepartment.Text);
                if (result > 0)
                {
                    MessageBox.Show("Registration Success");
                    ClearText();
                    this.Hide();
                    new DoctorLogin().Show();
                }
                else
                {
                    MessageBox.Show("Registration Failed");
                }
                
            }
        }

        private void ClearText()
        {
            textBoxAddress.Text = textBoxDepartment.Text = textBoxDesingnation.Text = textBoxFullName.Text = "";
            textBoxMobileNo.Text = textBoxPassword.Text = textBoxUsername.Text = "";
        }
    }
}
