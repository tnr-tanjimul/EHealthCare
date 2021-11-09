using EHealthCare.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHealthCare.Repository
{
    public class LoginRepository
    {
        DataAccess dataAccess;
        NameValueCollection logData;
        public LoginRepository()
        {
            dataAccess = new DataAccess();
            logData = new NameValueCollection(){
                                                    { "UserID", "0" },
                                                    { "UserType", "0" },
                                                    { "UserName", "" },
                                                    { "UserMobile", "" },

                                               }; 
        }

        public NameValueCollection Validation(User user)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM users WHERE Username='" + user.Username + "' AND Password='" + user.Password + "'";
            MySqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();

           ///// MessageBox.Show(sql);

            if (reader.HasRows)
            {
                logData["UserID"] = reader["ID"].ToString();
                logData["UserType"] = reader["UserType"].ToString();
                logData["UserName"] = reader["Name"].ToString();
                logData["UserMobile"] = reader["Phone"].ToString();

                dataAccess.Dispose();
                return logData;
            }
            else
            {

                return logData;
            }
        }


        public NameValueCollection PatientValidation(Patient patient)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM patients WHERE MobileNo='" + patient.MobileNo + "'";
            MySqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();

            ///// MessageBox.Show(sql);

            if (reader.HasRows)
            {
                logData["UserID"] = reader["ID"].ToString();
               // logData["UserType"] = reader["UserType"].ToString();
                logData["UserName"] = reader["Name"].ToString();
                logData["UserMobile"] = reader["MobileNo"].ToString();

                dataAccess.Dispose();
                return logData;
            }
            else
            {

                return logData;
            }
        }
    }
}
