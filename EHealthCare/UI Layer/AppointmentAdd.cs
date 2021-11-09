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
    public partial class AppointmentAdd : Form
    {
        DoctorService doctorService;
        AppointmentService appointmentService;
        private int patientId;
        private int doctorId;

        public AppointmentAdd()
        {
            InitializeComponent();
            this.doctorService = new DoctorService();
            this.appointmentService = new AppointmentService();
        }

        public AppointmentAdd(int patientId)
        {
            InitializeComponent();
            this.doctorService = new DoctorService();
            this.appointmentService = new AppointmentService();
            this.patientId = patientId;
        }

        private void AppointmentAdd_Load(object sender, EventArgs e)
        {
            comboBoxDepartment.DataSource = this.doctorService.GetDoctorDepartment();        }

       

        private void comboBoxDepartment_TextChanged(object sender, EventArgs e)
        {
            string deptName = comboBoxDepartment.SelectedItem.ToString();
            comboBoxDoctor.DataSource = this.doctorService.GetDoctorListByDepartment(deptName);
        }

        private void comboBoxDoctor_TextChanged(object sender, EventArgs e)
        {
            string doctorName = comboBoxDoctor.SelectedItem.ToString();
            

            this.doctorId = this.doctorService.GetDoctorIdByName(doctorName);

            labelFee.Text = this.doctorService.GetDoctorFee(doctorId).ToString();

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            if (this.appointmentService.AddAppointment(this.doctorId, this.patientId, dateTimePickerAppDate.Value, "Pending") > 0)
            {
                MessageBox.Show("Sucess");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed");
            }

             
           
        }
    }
}
