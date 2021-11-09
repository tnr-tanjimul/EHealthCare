using EHealthCare.Entities;
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
    public partial class PrescriptionPage : Form
    {
        DoctorDashboard doctorDashboard;
        MedicalHistoryService medicalHistory;
        FeverRecordService feverRecord;
        BPRecordService bPRecord;
        PatientService patientService;
        PrescriptionRecordService prescriptionRecord;
        PrescriptionService prescriptionService;
        int patientId;
        int prescripId;
        int doctorId;
        public PrescriptionPage(DoctorDashboard doctorDashboard)
        {
            this.doctorDashboard = doctorDashboard;

            this.prescripId = GenerateID();
            this.doctorId = new DoctorService().GetDoctorId(Convert.ToInt32(doctorDashboard.logData["UserID"]));
            medicalHistory = new MedicalHistoryService();
            feverRecord = new FeverRecordService();
            bPRecord = new BPRecordService();
            patientService = new PatientService();
            prescriptionRecord = new PrescriptionRecordService();
            prescriptionService = new PrescriptionService();

            if (patientId!=0)
            {
                prescriptionService.AddPrescription(this.prescripId, this.doctorId, this.patientId);
            }


            InitializeComponent();
        }


        public PrescriptionPage(int doctorId)
        {
           

            this.prescripId = GenerateID();
            this.doctorId = doctorId;
            medicalHistory = new MedicalHistoryService();
            feverRecord = new FeverRecordService();
            bPRecord = new BPRecordService();
            patientService = new PatientService();
            prescriptionRecord = new PrescriptionRecordService();
            prescriptionService = new PrescriptionService();

           

            InitializeComponent();
        }

        public PrescriptionPage(int doctorId, int patientId) : this(doctorId)
        {
            this.patientId = patientId;
            labelName.Text = patientService.GetPatientName(this.patientId);
            textBoxSearch.Text = this.patientId.ToString();

            if (patientId > 0)
            {
                prescriptionService.AddPrescription(this.prescripId, this.doctorId, this.patientId);
            }

        }

        public int GenerateID()
        {
            Random rand = new Random();
            return rand.Next(10000001, 99999999);
        }

        private void tabControlDiseases_KeyPress(object sender, KeyPressEventArgs e)
        {
            //hgh
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            UpdateData();
            UpdatePresription();


        }


        private void UpdateData()
        {
            dataGridDiseases.DataSource = medicalHistory.GetMedicalHistorys(this.patientId);
            dataGridFever.DataSource = feverRecord.GetFeverRecords(this.patientId);
            dataGridBp.DataSource = bPRecord.GetBpRecords(this.patientId);

            //dataGridDiseases.Columns.Remove("PatientID");
            //dataGridDiseases.Columns[0].Width = 35;

            //dataGridFever.Columns.Remove("PatientID");
            //dataGridFever.Columns[0].Width = 35;
            //dataGridFever.Columns[1].Width = 150;

            //dataGridBp.Columns.Remove("PatientID");
            //dataGridBp.Columns[0].Width = 35;
            //dataGridBp.Columns[1].Width = 150;
        }

        private void Reset()
        {
            textBoxDiseases.Text = textBoxSymtoms.Text = textBoxTemp.Text = textBoxBp.Text ="";
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxDiseases.TextLength==0 || textBoxSymtoms.TextLength==0)
            {
                MessageBox.Show("All field are required");
            }
            else
            {
                if (medicalHistory.AddMedicalHistory(patientId,textBoxDiseases.Text,textBoxSymtoms.Text,dateTimePickerStart.Value,dateTimePickerEnd.Value)>0)
                {
                    UpdateData();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Something Wrong..");
                }
            }
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            if (textBoxTemp.TextLength==0)
            {
                MessageBox.Show("All field are required");
            }
            else
            {
                if ( feverRecord.AddFeverRecord(this.patientId,Convert.ToSingle(textBoxTemp.Text)) > 0)
                {
                    UpdateData();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Something Wrong..");
                }
            }
        }

        private void btnBpAdd_Click(object sender, EventArgs e)
        {
            if (textBoxBp.TextLength == 0)
            {
                MessageBox.Show("All field are required");
            }
            else
            {
                if (bPRecord.AddBpRecord(this.patientId,textBoxBp.Text) > 0)
                {
                    UpdateData();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Something Wrong..");
                }
            }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxSearch.TextLength > 0)
            {
                this.patientId = Convert.ToInt32(textBoxSearch.Text);
                
                //if (patientService.GetPatientName(this.patientId)=="")
                //{
                //    labelName.Text = "Not Found";
                //}
                //else
                //{

                    labelName.Text = patientService.GetPatientName(this.patientId);


                if (patientId > 0)
                {
                    prescriptionService.AddPrescription(this.prescripId, this.doctorId, this.patientId);
                }

                //if (labelName.Text.Length > 3)
                //{

                //}
                //}
            }
            
        }

        private void PrescriptionPage_Load(object sender, EventArgs e)
        {
            dataGridDiseases.DataSource = medicalHistory.GetMedicalHistorys(this.patientId);
            dataGridFever.DataSource = feverRecord.GetFeverRecords(this.patientId);
            dataGridBp.DataSource = bPRecord.GetBpRecords(this.patientId);

            dataGridDiseases.Columns.Remove("PatientID");
            dataGridDiseases.Columns[0].Width = 35;
            dataGridFever.Columns.Remove("PatientID");
            dataGridFever.Columns[0].Width = 35;
            dataGridFever.Columns[1].Width = 150;
            dataGridBp.Columns.Remove("PatientID");
            dataGridBp.Columns[0].Width = 35;
            dataGridBp.Columns[1].Width = 150;
        }


        public void UpdatePresription()
        {
            dataGridDrug.DataSource = prescriptionRecord.GetAllPrescriptionRecords(this.prescripId);
            dataGridDrug.Columns.Remove("PrescripID");
            dataGridDrug.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void btnMedicineAdd_Click(object sender, EventArgs e)
        {
            if (textBoxMedicine.TextLength==0 || textBoxDose.TextLength==0 || textBoxDays.TextLength==0)
            {
                MessageBox.Show("Please Fillup Mandatory Fields");
            }
            else
            {
                prescriptionRecord.AddPrescriptionRecord(textBoxMedicine.Text,textBoxDose.Text,Convert.ToInt32(textBoxDays.Text),textBoxRemark.Text, this.prescripId);
                UpdatePresription();
                textBoxMedicine.Text = textBoxDose.Text = textBoxDays.Text = textBoxRemark.Text = "";
            }
        }

        private void btnAddNewPatient_Click(object sender, EventArgs e)
        {
            this.patientId = this.GenerateID();
            PatientAddUpdatePage patientAddUpdatePage = new PatientAddUpdatePage(this.patientId);
            patientAddUpdatePage.btnAdd.Visible = true;
            patientAddUpdatePage.btnUpdate.Visible = false;
            patientAddUpdatePage.ShowDialog();


            if (patientAddUpdatePage.isAdd)
            {
                labelName.Text = patientService.GetPatientName(this.patientId);
                textBoxSearch.Text = this.patientId.ToString();
                prescriptionService.AddPrescription(this.prescripId, this.doctorId, this.patientId);
            }


           

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
    
}
