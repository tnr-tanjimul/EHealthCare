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
    public partial class PatientAddUpdatePage : Form
    {
        PatientService patientService;
        public int id;
        private int pId;
        public bool isAdd;

        public PatientAddUpdatePage()
        {
            InitializeComponent();
            this.patientService = new PatientService();
        }

        public PatientAddUpdatePage(int v)
        {
            this.pId = v;
            InitializeComponent();
            this.patientService = new PatientService();
        }

        //public PatientAddUpdatePage(PatientPage pp)
        //{
        //    InitializeComponent();
        //    this.patientService = new PatientService();
        //    this.patientPage = pp;
        //}

        private bool DataValidate()
        {
            if (textBoxName.TextLength==0 || textBoxMobileNo.TextLength==0 || textBoxAddress.TextLength==0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DataValidate())
            {
                int result = patientService.AddPatient(this.pId,textBoxName.Text, textBoxAddress.Text, textBoxMobileNo.Text, comboBoxSmoker.SelectedItem, comboBoxGlassUse.SelectedItem, comboBoxGender.SelectedItem, datePickDOB.Value, comboBoxMaritalStatus.SelectedItem, comboBoxBloodGroup.SelectedItem);
                if (result > 0)
                {
                    MessageBox.Show("Success");
                    this.Close();
                    //patientPage.ReloadGridView();

                    isAdd = true;


                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
            else
            {
                MessageBox.Show("All Field are required");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //int id = 1235499;
            if (DataValidate())
            {
                int result = patientService.EditPatient(id,textBoxName.Text, textBoxAddress.Text, textBoxMobileNo.Text, comboBoxSmoker.SelectedItem, comboBoxGlassUse.SelectedItem, comboBoxGender.SelectedItem, datePickDOB.Value, comboBoxMaritalStatus.SelectedItem, comboBoxBloodGroup.SelectedItem);
                if (result > 0)
                {
                    MessageBox.Show("Update Successfully");
                    this.Close();
                    //patientPage.ReloadGridView();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
            else
            {
                MessageBox.Show("All Field are required");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxName.Text = textBoxMobileNo.Text = textBoxAddress.Text = "";
        }

      

        

        

        private void PatientAddUpdatePage_Load(object sender, EventArgs e)
        {
            comboBoxBloodGroup.SelectedIndex = 0;
            comboBoxGender.SelectedIndex = 0;
            comboBoxGlassUse.SelectedIndex = 0;
            comboBoxMaritalStatus.SelectedIndex = 0;
            comboBoxSmoker.SelectedIndex = 0;

        }

       

        private void textBoxMobileNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
