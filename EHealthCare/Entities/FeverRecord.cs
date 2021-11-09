using System;
using System.Collections.Generic;
using System.Text;

namespace EHealthCare.Entities
{
    public class FeverRecord
    {
        public int ID { get; set; }
        public float Temp { get; set; }
        public DateTime RecordTime { get; set; }
        public int PatientID { get; set; }
    }
}
