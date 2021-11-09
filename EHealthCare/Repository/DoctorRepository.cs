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
    public class DoctorRepository: IRepository<Doctor>
    {
        DataAccess dataAccess;

        public DoctorRepository()
        {
            this.dataAccess = new DataAccess();
        }

        public int Delete(int id)
        {
            dataAccess = new DataAccess();
            string sql = "DELETE FROM doctors WHERE ID=" + id;
            int pt = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return pt;
        }

        public Doctor Get(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM doctors WHERE ID=" + id;
           

            Doctor doctor = new Doctor();

            try
            {
                MySqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                doctor.ID = Convert.ToInt32(reader["ID"]);
                doctor.FullName = reader["FullName"].ToString();
                doctor.Address = reader["Address"].ToString();
                doctor.Designation = reader["Designation"].ToString();
                doctor.Department = reader["Department"].ToString();
                doctor.UserID= Convert.ToInt32(reader["UserID"]);
                doctor.Fee = Convert.ToInt32(reader["Fee"]);
                doctor.RegTime = Convert.ToDateTime(reader["RegTime"]);
                dataAccess.Dispose();
                return doctor;
            }
            catch (Exception e)
            {
                
               
                dataAccess.Dispose();
                return doctor;
            }
        }

        public int GetIdByName(string doctorName)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT ID FROM `doctors` WHERE FullName='"+doctorName+"'";

            try
            { 
                MySqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                int id =  Convert.ToInt32(reader["ID"]);
                dataAccess.Dispose();
                return id;
            }
            catch (Exception)
            {
               
                dataAccess.Dispose();
                return 0;
            }
        }

        public List<string> GetByDept(string deptName)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM `doctors` WHERE LOWER(`Department`)=LOWER('"+deptName+"')";
            MySqlDataReader reader = dataAccess.GetData(sql);
            List<string> doctorList = new List<string>();

            doctorList.Add("Select One");

            while (reader.Read())
            {
                doctorList.Add(reader["FullName"].ToString()); 
            }
            dataAccess.Dispose();
            return doctorList;
        }

        public List<string> GetDocDept()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT DISTINCT `Department` FROM `doctors` ";
            MySqlDataReader reader = dataAccess.GetData(sql);


            

            List<string> doctorDeptList = new List<string>();
            doctorDeptList.Add("Select One");
            while (reader.Read())
            {
                Doctor doctor = new Doctor();
                doctorDeptList.Add(reader["Department"].ToString());
            }
            dataAccess.Dispose();
            return doctorDeptList;
        }

        public List<Doctor> GetAll()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM doctors";
            MySqlDataReader reader = dataAccess.GetData(sql);
            List<Doctor> doctorList = new List<Doctor>();
            while (reader.Read())
            {
                Doctor doctor = new Doctor();


                doctor.ID = Convert.ToInt32(reader["ID"]);
                doctor.FullName = reader["FullName"].ToString();
                doctor.Address = reader["Address"].ToString();
                doctor.Designation = reader["Designation"].ToString();
                doctor.Department = reader["Department"].ToString();
                doctor.UserID = Convert.ToInt32(reader["UserID"]);
                doctor.RegTime = Convert.ToDateTime(reader["RegTime"]);
                doctorList.Add(doctor);
            }
            dataAccess.Dispose();
            return doctorList;
        }
        public int Insert(Doctor entity)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO doctors(ID,FullName,Address,Designation,Department,UserID,RegTime) VALUES(NULL,'" + entity.FullName + "','" + entity.Address + "','" + entity.Designation + "','" + entity.Department + "','" + entity.UserID + "', '"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            int apt = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return apt;
        }

        public int Update(Doctor entity)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE doctors SET ID='" + entity.ID + "',FullName='" + entity.FullName + "',Address='" + entity.Address + "',Designation='"+entity.Designation+ "',Department='" + entity.Department + "',Address='" + entity.Address + "' where ID=" + entity.ID;
            int apt = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return apt;
        }
    }
}
