using EHealthCare.Entities;
using EHealthCare.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHealthCare.Repository
{
    class RegistrationRepository
    {
        DataAccess dataAccess;
        public RegistrationRepository()
        {
            dataAccess = new DataAccess();
        }

        public int Register(User user,Doctor doctor)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO users(Name,Phone,Username,Password,UserType,AccountStatus) VALUES('" + user.Name + "','" + user.Phone + "','" + user.Username + "','" + user.Password + "','2','1')";
            int result = dataAccess.ExecuteQuery(sql);
            if (result > 0)
            {
                dataAccess = new DataAccess();
                sql = "SELECT * FROM users WHERE Username='" + user.Username + "'";
                MySqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                int id = (int)reader["ID"];
                
           

                DoctorService doctorService = new DoctorService();
                int result2 = doctorService.AddDoctor(doctor.FullName, doctor.Address, doctor.Designation, doctor.Department, id);

                if (result2 > 0)
                {
                    return 1;
                }
                else { return 0; }
            }
            else { return 0; }
        }
    }
}
