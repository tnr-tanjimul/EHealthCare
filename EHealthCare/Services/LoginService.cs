using EHealthCare.Entities;
using EHealthCare.Repository;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHealthCare.Services
{
    public class LoginService
    {
        LoginRepository loginRepository;
        public LoginService()
        {
            loginRepository = new LoginRepository();
        }

        public NameValueCollection LoginValidation(string username, string password)
        {
            return loginRepository.Validation(new User() { Username = username, Password = password });
        }

        public NameValueCollection PatientLoginValidation(string mobileNo)
        {
            return loginRepository.PatientValidation(new Patient() { MobileNo=mobileNo });
        }

    }
}
