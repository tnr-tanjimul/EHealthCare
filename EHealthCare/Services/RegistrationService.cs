using EHealthCare.Entities;
using EHealthCare.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHealthCare.Services
{
    public class RegistrationService
    {
        RegistrationRepository regRepo;
        public RegistrationService()
        {
            regRepo = new RegistrationRepository();
        }
        public int DoctorRegistration(string name, string phone, string username, string password, string address, string designation, string department)
        {
            return regRepo.Register(new User() { Name = name, Phone = phone, Username = username, Password = password },new Doctor() {
                FullName = name,
                Address = address,
                Designation = designation,
                Department = department,
            });
        }
    }
}
