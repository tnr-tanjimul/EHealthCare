using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using EHealthCare.Services;

namespace EHealthCare.UI_Layer
{
    public partial class DoctorDashboard : Form
    {
        Point lastPoint;
        public NameValueCollection logData;
        public DoctorDashboard()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }


        //public DoctorDashboard(Login log)
        //{
        //    InitializeComponent();
            
        //}

        public DoctorDashboard(NameValueCollection logData)
        {
            InitializeComponent();
            this.logData = logData;
        }



        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width==245)
            {
                menuVertical.Width = 70;
            }
            else
            {
                menuVertical.Width = 245;
            }
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Cancel", "Alert!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestore.Visible = true;
            iconMaximize.Visible = false;
        }

        private void iconRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestore.Visible = false;
            iconMaximize.Visible = true;
        }


        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public void OpenFormInPanel(object FormChild)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form fh = FormChild as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }

        public Color ActiveButtonColor()
        {
            // 229, 75, 79
            return System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(75)))), ((int)(((byte)(79)))));
        }

        public void PlainBtnBackColor()
        {
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.btnAppoinments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.btnPrescriptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.btnPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new DoctorHome(new DoctorService().GetDoctorId(Convert.ToInt32(this.logData["UserID"]))));
            btnHome.BackColor = this.ActiveButtonColor();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new PatientPage());
            this.PlainBtnBackColor();
            this.btnPatients.BackColor = this.ActiveButtonColor();
        }

        private void btnPrescriptions_Click(object sender, EventArgs e)
        {
            
            OpenFormInPanel(new PrescriptionPage(this));
            this.PlainBtnBackColor();
            this.btnPrescriptions.BackColor = this.ActiveButtonColor();
        }

        private void btnAppoinments_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new AppointmentPage(this));
            this.PlainBtnBackColor();
            this.btnAppoinments.BackColor = this.ActiveButtonColor();
        }
    }
}
