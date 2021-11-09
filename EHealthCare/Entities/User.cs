using System;
using System.Collections.Generic;
using System.Text;

namespace EHealthCare.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public DateTime RegDate { get; set; }
        public int AccountStatus { get; set; }
    }
}
