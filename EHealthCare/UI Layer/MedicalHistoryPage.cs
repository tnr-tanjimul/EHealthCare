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
    public partial class MedicalHistoryPage : Form
    {
        private PatientDashboard patientDashboard;
        MedicalHistoryService medicalHistory;
        private int patientId;
        private int id;

        public MedicalHistoryPage()
        {
            InitializeComponent();
        }

        public MedicalHistoryPage(PatientDashboard patientDashboard)
        {
            this.patientDashboard = patientDashboard;
            this.medicalHistory = new MedicalHistoryService();
            this.patientId = Convert.ToInt32(patientDashboard.logData["UserID"]);
            InitializeComponent();
        }

        private void MedicalHistoryPage_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxDiseases.TextLength == 0 || textBoxSymtoms.TextLength == 0)
            {
                MessageBox.Show("All field are required");
            }
            else
            {
                if (medicalHistory.AddMedicalHistory(patientId, textBoxDiseases.Text, textBoxSymtoms.Text, dateTimePickerStart.Value, dateTimePickerEnd.Value) > 0)
                {
                    textBoxDiseases.Text = textBoxSymtoms.Text = "";
                    dateTimePickerStart.Value = DateTime.Now;
                    dateTimePickerEnd.Value = DateTime.Now;
                    UpdateData();
                   
                }
                else
                {
                    MessageBox.Show("Something Wrong..");
                }
            }
        }

        private void UpdateData()
        {
            dataGridMedicalHistory.DataSource = medicalHistory.GetMedicalHistorys(this.patientId);
            dataGridMedicalHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxDiseases.Text = textBoxSymtoms.Text  = "";
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
        }

        private void dataGridMedicalHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.id = Convert.ToInt32(dataGridMedicalHistory.Rows[e.RowIndex].Cells[0].Value);
                btnDelete.Visible = true;
            }
            catch (Exception)
            {
                this.id = 0;


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (medicalHistory.RemoveMedicalHistory(this.id)>0)
            {
                MessageBox.Show("Deleted Successfully");
                UpdateData();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            btnDelete.Visible = false;
        }
    }
}
