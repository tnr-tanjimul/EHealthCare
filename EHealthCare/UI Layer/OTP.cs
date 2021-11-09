using EHealthCare.Services;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHealthCare.UI_Layer
{
    public partial class OTP : Form
    {
        Point lastPoint;
        
        NameValueCollection logData;
        OtpServices otpServices;
        int otp;
        bool isDoctor = false;
        bool isPatient = false;
        private PatientLogin patientLogin;

        public OTP(NameValueCollection logData)
        {
            InitializeComponent();
            this.logData = logData;
            otpServices = new OtpServices();
            otp = otpServices.GenerateOTP();
            otpServices.SendOTP(otp,logData);
            this.isDoctor = true;
        }

        public OTP(PatientLogin patientLogin)
        {
            InitializeComponent();
            this.patientLogin = patientLogin;
            this.logData = patientLogin.logData;
            otpServices = new OtpServices();
            otp = otpServices.GenerateOTP();
            otpServices.SendOTP(otp, logData);
            this.isPatient = true;
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
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



        private void buttonVerify_Click(object sender, EventArgs e)
        {


            


            if (textBoxOtp.Text==otp.ToString())
            {

                if (isDoctor)
                {
                    //MessageBox.Show("Verification Success");
                    new DoctorDashboard(this.logData).Show();
                    this.Hide();
                }

                if (isPatient)
                {
                    new PatientDashboard(this.logData).Show();
                    this.Hide();
                }

               
            }
            else
            {
                MessageBox.Show("Verification Failed");
                
            }
            

        }

        private void btnReSend_Click(object sender, EventArgs e)
        {
            otpServices = new OtpServices();
            otp = otpServices.GenerateOTP();
            otpServices.SendOTP(otp, logData);
        }
    }
}
