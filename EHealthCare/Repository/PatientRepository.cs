using EHealthCare.Entities;
using EHealthCare.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHealthCare.Repository
{
    public class PatientRepository : IRepository<Patient>
    {
        DataAccess dataAccess;

        public PatientRepository()
        {
            this.dataAccess = new DataAccess();
        }

        public int Delete(int id)
        {
            dataAccess = new DataAccess();
            string sql = "DELETE FROM patients WHERE ID=" + id;
            int pt = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return pt;
        }

        public int Count()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT count(*) as total FROM patients";
            MySqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();

            int total;

            try
            {
                total = Convert.ToInt32(reader["total"]);
                
                return total;
            }
            catch (Exception)
            {

                return 0;
            }
        }


        public List<Patient> GetAll()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `patients`";
            List<Patient> patientList = new List<Patient>();
            try
            {
                MySqlDataReader reader = dataAccess.GetData(sql);

                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.ID = Convert.ToInt32(reader["ID"]);
                    patient.Name = reader["Name"].ToString();
                    patient.Address = reader["Address"].ToString();
                    patient.MobileNo = reader["MobileNo"].ToString();
                    patient.Smoker = reader["Smoker"].ToString();
                    patient.GlassUse = reader["GlassUse"].ToString();
                    patient.Gender = reader["Gender"].ToString();
                    patient.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    patient.BloodGroup = reader["BloodGroup"].ToString();
                    patient.MaritalStatus = reader["MaritalStatus"].ToString();
                    patient.RegTime = Convert.ToDateTime(reader["RegTime"]);
                    patientList.Add(patient);
                }
                dataAccess.Dispose();
                return patientList;
            }
            catch (Exception)
            {

                dataAccess.Dispose();
                return patientList;
            }


        }

        public List<Patient> GetByText(string text)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `patients` where ID LIKE '%"+ text + "%' or LOWER(Name) LIKE LOWER('%" + text + "%') or MobileNo LIKE '%" + text + "%'";
            List<Patient> patientList = new List<Patient>();
            try
            {
                MySqlDataReader reader = dataAccess.GetData(sql);

                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.ID = Convert.ToInt32(reader["ID"]);
                    patient.Name = reader["Name"].ToString();
                    patient.Address = reader["Address"].ToString();
                    patient.MobileNo = reader["MobileNo"].ToString();
                    patient.Smoker = reader["Smoker"].ToString();
                    patient.GlassUse = reader["GlassUse"].ToString();
                    patient.Gender = reader["Gender"].ToString();
                    patient.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    patient.BloodGroup = reader["BloodGroup"].ToString();
                    ///patient.MaritalStatus = reader["MartialStatus"].ToString();
                    patient.RegTime = Convert.ToDateTime(reader["RegTime"]);
                    patientList.Add(patient);
                }
                dataAccess.Dispose();
                return patientList;
            }
            catch (Exception)
            {

                dataAccess.Dispose();
                return patientList; 
            }

            
        }


        public Patient Get(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM patients WHERE ID=" + id;
            

            Patient patient = new Patient();

            try
            {
                MySqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                patient.ID = Convert.ToInt32(reader["ID"]);
                patient.Name = reader["Name"].ToString();
                patient.Address = reader["Address"].ToString();
                patient.MobileNo = reader["MobileNo"].ToString();
                patient.Smoker = reader["Smoker"].ToString();
                patient.GlassUse = reader["GlassUse"].ToString();
                patient.Gender = reader["Gender"].ToString();
                patient.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                patient.BloodGroup = reader["BloodGroup"].ToString();
                patient.MaritalStatus = reader["MartialStatus"].ToString();
                patient.RegTime = Convert.ToDateTime(reader["RegTime"]);
                dataAccess.Dispose();
                return patient;
            }
            catch (Exception)
            {
                dataAccess.Dispose();
                return patient;
            }
        }

        public int Insert(Patient entity)
        {
            string sql;
            if (entity.ID >0)
            {
                sql = "INSERT INTO patients(ID,Name,Address,MobileNo,Smoker,GlassUse,Gender,DateOfBirth,BloodGroup,MaritalStatus,RegTime) VALUES('"+entity.ID+"','" + entity.Name + "','" + entity.Address + "','" + entity.MobileNo + "','" + entity.Smoker + "','" + entity.GlassUse + "','" + entity.Gender + "','" + entity.DateOfBirth.ToString("yyyy-MM-dd HH:mm:ss") + "','" + entity.BloodGroup + "','" + entity.MaritalStatus + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

            }
            else
            {
                sql = "INSERT INTO patients(ID,Name,Address,MobileNo,Smoker,GlassUse,Gender,DateOfBirth,BloodGroup,MaritalStatus,RegTime) VALUES(NULL,'" + entity.Name + "','" + entity.Address + "','" + entity.MobileNo + "','" + entity.Smoker + "','" + entity.GlassUse + "','" + entity.Gender + "','" + entity.DateOfBirth.ToString("yyyy-MM-dd HH:mm:ss") + "','" + entity.BloodGroup + "','" + entity.MaritalStatus + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

            }
            dataAccess = new DataAccess();

           
            int pt = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return pt;
        }

        public int Update(Patient entity)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE patients SET Name='" + entity.Name + "', Address='" + entity.Address + "', MobileNo='" + entity.MobileNo + "',Smoker='" + entity.Smoker + "',GlassUse='" + entity.GlassUse + "',Gender='" + entity.Gender + "',DateOfBirth='" + entity.DateOfBirth.ToString("yyyy-MM-dd HH:mm:ss") + "',BloodGroup='" + entity.BloodGroup + "',MaritalStatus='" + entity.MaritalStatus + "' WHERE ID='" + entity.ID+"'";
            int pt = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return pt;
        }
    }
}
