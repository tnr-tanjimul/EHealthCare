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
    public partial class AppointmentPage : Form
    {
        AppointmentService appointmentService;
        DoctorDashboard doctorDashboard;
        int patientId;
        int doctorId;
        int appointmentId;
        bool isDoctor = false;
        bool isPatient = false;
        private PatientDashboard patientDashboard;

        public AppointmentPage(DoctorDashboard doctorDashboard)
        {
            InitializeComponent();
            appointmentService = new AppointmentService();
            this.doctorDashboard = doctorDashboard;
            this.doctorId = new DoctorService().GetDoctorId(Convert.ToInt32(doctorDashboard.logData["UserID"]));
            this.isDoctor = true;
        }

        public AppointmentPage(PatientDashboard patientDashboard)
        {
            InitializeComponent();
            appointmentService = new AppointmentService();
            this.patientId = Convert.ToInt32(patientDashboard.logData["UserID"]);
            this.patientDashboard = patientDashboard;
            this.isPatient = true;
            btnAddNew.Text = "Create";
        }

        private void AppointmentPage_Load(object sender, EventArgs e)
        {
            //dataGridAppointment.Columns.Remove("Fax");
            //dataGridAppointment.DataSource = appointmentService.GetAllAppointmentsByDoc(this.doctorId);
            
            UpdateData();
        }

        private void dataGridAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                this.appointmentId = Convert.ToInt32(dataGridAppointment.Rows[e.RowIndex].Cells[0].Value);
                this.patientId = Convert.ToInt32(dataGridAppointment.Rows[e.RowIndex].Cells[1].Value);
            }
            catch (Exception)
            {

                patientId = 0;
            }

            btnDelete.Visible = true;


            if (isDoctor)
            {
                btnCreate.Visible = true;
            }

            

            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (this.isPatient)
            {
                AppointmentAdd appointment = new AppointmentAdd(this.patientId);
                appointment.ShowDialog();
                UpdateData();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            doctorDashboard.OpenFormInPanel(new PrescriptionPage(this.doctorId, this.patientId));
            doctorDashboard.PlainBtnBackColor();
            doctorDashboard.btnPrescriptions.BackColor = doctorDashboard.ActiveButtonColor();
            appointmentService.EditAppointment(this.appointmentId, "Complete");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (appointmentService.RemoveAppointment(this.appointmentId) > 0)
            {
                MessageBox.Show("Sucessfully Deleted");
                UpdateData();
            }
            else
            {
                MessageBox.Show("Something Wrong..");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            

            if (this.isDoctor)
            {
                dataGridAppointment.DataSource = appointmentService.GetAllAppointmentsByDoc(this.doctorId);
               

            }

            if (this.isPatient)
            {
                dataGridAppointment.DataSource = appointmentService.GetAllAppointmentsByPatient(this.patientId);
               
                //dataGridAppointment.Columns[0].Width = 60;
                //dataGridAppointment.Columns[1].Width = 0;
                //dataGridAppointment.Columns[2].Width = 0;
                //dataGridAppointment.Columns[3].Width = 120;
                //dataGridAppointment.Columns[4].Width = 120;
                //dataGridAppointment.Columns[5].Width = 120;
                //dataGridAppointment.Columns[5].Width = 100;
            }

            dataGridAppointment.Columns.Remove("PatientID");
            dataGridAppointment.Columns.Remove("DoctorID");




            dataGridAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridAppointment.Columns.Remove("PatientID");
           // dataGridAppointment.Columns.Remove("DoctorID");
            
        }
    }
}
