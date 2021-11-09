using System;
using System.Collections.Generic;
using System.Text;

namespace EHealthCare.Entities
{
    public class MedicalHistory
    {
        public int ID { get; set; }
        public string DiseasesName { get; set; }
        
        public string Symptoms { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PatientID { get; set; }
        public int DiseasesType { get; set; }
    }
}
