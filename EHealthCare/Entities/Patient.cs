using EHealthCare.UI_Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHealthCare.Entities
{
    public class Patient
    {
       

        public int ID { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        
        public string Smoker { get; set; }
        public string GlassUse { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime RegTime { get; set; }

    }
}
