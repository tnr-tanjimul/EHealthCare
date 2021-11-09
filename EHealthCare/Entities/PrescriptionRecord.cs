using System;
using System.Collections.Generic;
using System.Text;

namespace EHealthCare.Entities
{
    public class PrescriptionRecord
    {
        public int ID { get; set; }
        public string Medicine { get; set; }
        public string Dose { get; set; }
        public int Days { get; set; }
        public string Remarks { get; set; }
        public int PrescripID { get; set; }
    }
}
