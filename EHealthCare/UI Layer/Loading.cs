using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHealthCare.UI_Layer
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            
            
        }

        private void timerLoder_Tick(object sender, EventArgs e)
        {
            
            new UserType().Show();
            this.Hide();
            timerLoder.Stop();
        }

    }
}
