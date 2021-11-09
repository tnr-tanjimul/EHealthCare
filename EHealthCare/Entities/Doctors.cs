using System;
using System.Collections.Generic;
using System.Text;

namespace EHealthCare.Entities
{
    public class Doctor
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public int UserID { get; set; }

        public int Fee { get; set; }
        public DateTime RegTime { get; set; }
    }
}
