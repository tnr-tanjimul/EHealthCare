using System;
using System.Collections.Generic;
using System.Text;

namespace EHealthCare.Entities
{
    public class BpRecord
    {
        public int ID { get; set; }
        public string BP { get; set; }
        public int PatientID { get; set; }
        public DateTime RecordTime { get; set; }
    }
}
