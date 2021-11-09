using EHealthCare.UI_Layer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHealthCare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loading());
            //Application.Run(new Login());
            //Application.Run(new DoctorDashboard());
            //Application.Run(new PatientPage());
            //Application.Run(new PatientAddUpdatePage());
            //Application.Run(new PatientRegistration());

            NameValueCollection logData = new NameValueCollection(){
                                                    { "UserID", "1235508" },
                                                    { "UserType", "2" },
                                                    { "UserName", "" },
                                                    { "UserMobile", "" },

                                               };
           //Application.Run(new PatientDashboard(logData));

            int patientId = 1235513;
            //Application.Run(new AppointmentAdd(patientId));
            




        }
    }
}
