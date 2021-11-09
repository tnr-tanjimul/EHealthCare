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
    public partial class FeverReordPage : Form
    {
        FeverRecordService feverRecord;
        private int patientId;
        private int id;
        private PatientDashboard patientDashboard;

        public FeverReordPage()
        {
            InitializeComponent();
            this.feverRecord = new FeverRecordService();
        }

        public FeverReordPage(PatientDashboard patientDashboard)
        {
            InitializeComponent();
            this.feverRecord = new FeverRecordService();
            this.patientDashboard = patientDashboard;
            this.patientId = Convert.ToInt32(patientDashboard.logData["UserID"]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxTemp.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTemp.TextLength == 0)
            {
                MessageBox.Show("All field are required");
            }
            else
            {
                if (feverRecord.AddFeverRecord(this.patientId,Convert.ToSingle(textBoxTemp.Text)) > 0)
                {
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
            dataGridFeverRecords.DataSource = feverRecord.GetFeverRecords(this.patientId);
            dataGridFeverRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.feverRecord.RemoveFeverRecord(this.id) > 0)
            {
                MessageBox.Show("Deleted Successfully");
                UpdateData();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void FeverReordPage_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void dataGridFeverRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.id = Convert.ToInt32(dataGridFeverRecords.Rows[e.RowIndex].Cells[0].Value);
                btnDelete.Visible = true;
            }
            catch (Exception)
            {
                this.id = 0;


            }

            
        }

        private void FeverReordPage_MouseClick(object sender, MouseEventArgs e)
        {
            btnDelete.Visible = false;
        }
    }
}
