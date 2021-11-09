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
    public partial class BPRecordPage : Form
    {
        BPRecordService bPRecord;
        private int patientId;
        private PatientDashboard patientDashboard;
        private int id;

        public BPRecordPage()
        {
            InitializeComponent();
            this.bPRecord = new BPRecordService();
        }

        public BPRecordPage(PatientDashboard patientDashboard)
        {
            InitializeComponent();
            this.bPRecord = new BPRecordService();
            this.patientDashboard = patientDashboard;
            this.patientId = Convert.ToInt32(patientDashboard.logData["UserID"]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxBp.TextLength == 0)
            {
                MessageBox.Show("All field are required");
            }
            else
            {
                if (bPRecord.AddBpRecord(this.patientId, textBoxBp.Text) > 0)
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

        private void UpdateData()
        {
            dataGridBPRecords.DataSource = bPRecord.GetBpRecords(this.patientId);
            dataGridBPRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Reset()
        {
            textBoxBp.Text="";
        }

        private void FeverRecordPage_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void dataGridFeverRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.id = Convert.ToInt32(dataGridBPRecords.Rows[e.RowIndex].Cells[0].Value);
                btnDelete.Visible = true;
            }
            catch (Exception)
            {
                this.id = 0;


            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bPRecord.RemoveBpRecord(this.id) > 0)
            {
                MessageBox.Show("Deleted Successfully");
                UpdateData();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxBp.Text = "";
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            btnDelete.Visible = false;
        }
    }
}
