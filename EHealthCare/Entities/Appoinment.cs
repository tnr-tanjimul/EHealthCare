using System;
using System.Collections.Generic;
using System.Text;

namespace EHealthCare.Entities
{
    public class Appoinment
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime ApDate { get; set; }

        
        public string Name { get; set; }
        public string MobileNo { get; set; }

        public string Status { get; set; }
    }
}
