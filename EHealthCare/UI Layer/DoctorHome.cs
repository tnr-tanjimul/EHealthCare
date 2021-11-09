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
    public partial class DoctorHome : Form
    {
        PatientService patientService = new PatientService();
        PrescriptionService prescriptionService = new PrescriptionService();
        AppointmentService appointmentService = new AppointmentService();
        int doctorId;
        public DoctorHome(int doctorId)
        {
            InitializeComponent();
            this.doctorId = doctorId;
        }

        private void DoctorHome_Load(object sender, EventArgs e)
        {
            labelPatient.Text= patientService.CountPatients().ToString();
            labelPrescription.Text = prescriptionService.CountPrescriptions(this.doctorId).ToString();
            labelCompleted.Text = appointmentService.CountAppointmentComplete(this.doctorId).ToString();
            labelPending.Text = appointmentService.CountAppointmentPending(this.doctorId).ToString();
        }
    }
}
