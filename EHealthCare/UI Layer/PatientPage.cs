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
   
    public partial class PatientPage : Form
    {
        PatientService patientService;
        PatientAddUpdatePage patientAddUpdatePage;
        int id;
        //private PrescriptionPage prescriptionPage;

        public PatientPage()
        {
            InitializeComponent();
            this.patientService = new PatientService();
            this.patientAddUpdatePage = new PatientAddUpdatePage();
        }

        //public PatientPage(PrescriptionPage prescriptionPage)
        //{
        //    this.prescriptionPage = prescriptionPage;
        //    this.patientService = new PatientService();
        //    this.patientAddUpdatePage = new PatientAddUpdatePage();
        //}

        public void ReloadGridView()
        {

            

            dataGridPatients.DataSource = patientService.GetAllPatients();
            dataGridPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPatients.Columns[0].Width = 55;
            dataGridPatients.Columns[1].Width = 125;
            dataGridPatients.Columns[2].Width = 95;
            dataGridPatients.Columns[3].Width = 230;
            dataGridPatients.Columns[4].Width = 55;
            dataGridPatients.Columns[5].Width = 70;
            dataGridPatients.Columns[6].Width = 55;
            dataGridPatients.Columns[7].Width = 90;
            dataGridPatients.Columns[8].Width = 70;
            dataGridPatients.Columns[9].Width = 100;
        }

        private void PatientPage_Load(object sender, EventArgs e)
        {
            ReloadGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            DialogResult dresult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dresult == DialogResult.Yes)
            {
                if (patientService.RemovePatient(id) > 0)
                {
                    MessageBox.Show("Patient Deleted successfully.");
                    ReloadGridView();
                    
                }
                else
                {
                    MessageBox.Show("Error occured..");
                   
                }
            }
            else { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            patientAddUpdatePage.btnAdd.Visible = false;
            patientAddUpdatePage.btnUpdate.Visible = true;
            patientAddUpdatePage.ShowDialog();
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            PatientAddUpdatePage patientAddUpdatePage = new PatientAddUpdatePage();
            patientAddUpdatePage.btnAdd.Visible = true;
            patientAddUpdatePage.btnUpdate.Visible = false;
            patientAddUpdatePage.ShowDialog();
           
        }

        private void dataGridPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelEdit.Visible = true;

            try
            {
                id = Convert.ToInt32(dataGridPatients.Rows[e.RowIndex].Cells[0].Value);
                patientAddUpdatePage.id = this.id;
                patientAddUpdatePage.textBoxName.Text = dataGridPatients.Rows[e.RowIndex].Cells[1].Value.ToString();
                patientAddUpdatePage.textBoxMobileNo.Text = dataGridPatients.Rows[e.RowIndex].Cells[2].Value.ToString();
                patientAddUpdatePage.textBoxAddress.Text = dataGridPatients.Rows[e.RowIndex].Cells[3].Value.ToString();
                patientAddUpdatePage.comboBoxSmoker.SelectedItem = dataGridPatients.Rows[e.RowIndex].Cells[4].Value.ToString();
                patientAddUpdatePage.comboBoxGlassUse.SelectedItem = dataGridPatients.Rows[e.RowIndex].Cells[5].Value.ToString();
                patientAddUpdatePage.comboBoxGender.SelectedItem = dataGridPatients.Rows[e.RowIndex].Cells[6].Value.ToString();
                //patientAddUpdatePage.datePickDOB.Value = dataGridPatients.Rows[e.RowIndex].Cells[7].Value.ToString("yyyy-MM-dd HH:mm:ss");
                patientAddUpdatePage.comboBoxBloodGroup.SelectedItem = dataGridPatients.Rows[e.RowIndex].Cells[8].Value.ToString();
                ///patientAddUpdatePage.comboBoxMaritalStatus.Text= dataGridPatients.Rows[e.RowIndex].Cells[9].Value.ToString();
                //textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                //textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                

                
            }
            catch (Exception)
            {

                MessageBox.Show("Something Wrong");
            }

           
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            panelEdit.Visible = false;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridPatients.DataSource = patientService.SearchPatients(textBoxSearch.Text);
            dataGridPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReloadGridView();
        }
    }
}
