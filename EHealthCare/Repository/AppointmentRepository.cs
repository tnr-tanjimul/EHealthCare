using EHealthCare.Entities;
using EHealthCare.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EHealthCare.Repository
{
    public class AppoinmentRepository : IRepository<Appoinment>
    {
        DataAccess dataAccess;

        public AppoinmentRepository()
        {
            this.dataAccess = new DataAccess();
        }

        public int Delete(int id)
        {
            dataAccess = new DataAccess();
            string sql = "DELETE FROM appointments WHERE ID=" + id;
            int apt = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return apt;
        }

        public Appoinment Get(int id)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM appointment WHERE PatientID=" + id;
            MySqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();

            Appoinment appoinment = new Appoinment();

            try
            {
                appoinment.ID = Convert.ToInt32(reader["ID"]);
                appoinment.ApDate = Convert.ToDateTime(reader["ApDate"]);
                appoinment.PatientID = Convert.ToInt32(reader["PatientID"]);
                appoinment.DoctorID = Convert.ToInt32(reader["DoctorID"]);
                //appoinment.Status = Convert.ToInt32(reader["Status"]);
                dataAccess.Dispose();
                return appoinment;
            }
            catch (Exception)
            {
                dataAccess.Dispose();
                return appoinment;
            }
        }

        public int CountCompleteByDoc(int doctorId)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT count(*) as total FROM `appointments` WHERE `Status`='Complete' and `DoctorID`=" + doctorId;
            
            try
            {
                MySqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                int total = Convert.ToInt32(reader["total"]);
               
                dataAccess.Dispose();
                return total;
            }
            catch (Exception)
            {
                dataAccess.Dispose();
                return 0;
            }
        }

        public int CountPendingByDoc(int doctorId)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT count(*) as total FROM `appointments` WHERE `Status`='Pending' and `DoctorID`=" + doctorId;

            try
            {
                MySqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                int total = Convert.ToInt32(reader["total"]);

                dataAccess.Dispose();
                return total;
            }
            catch (Exception)
            {
                dataAccess.Dispose();
                return 0;
            }
        }

        public List<Appoinment> GetPatientAppointments(int patientId)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT a.*,CONCAT('Dr. ',b.FullName) as Name,c.Phone as MobileNo FROM `appointments` a,doctors b,users c WHERE a.`DoctorID`=b.ID and b.UserID=c.ID and a.PatientID='"+patientId+"' ORDER BY `a`.`ApDate` DESC";

            List<Appoinment> appointmentList = new List<Appoinment>();


            try
            {
                MySqlDataReader reader = dataAccess.GetData(sql);
                while (reader.Read())
                {
                    Appoinment appoinment = new Appoinment();

                    //To map the data from database to our enrity clasess
                    appoinment.ID = Convert.ToInt32(reader["ID"]);
                    appoinment.ApDate = Convert.ToDateTime(reader["ApDate"]);
                    appoinment.PatientID = Convert.ToInt32(reader["PatientID"]);
                    appoinment.DoctorID = Convert.ToInt32(reader["DoctorID"]);
                    appoinment.Status = reader["Status"].ToString();
                    appoinment.Name = reader["Name"].ToString();
                    appoinment.MobileNo = reader["MobileNo"].ToString();
                    appointmentList.Add(appoinment);
                }
                dataAccess.Dispose();
                return appointmentList;
            }
            catch (Exception)
            {

                dataAccess.Dispose();
                return appointmentList;
            }
        }

        public List<Appoinment> GetAll()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM Appointment";
            MySqlDataReader reader = dataAccess.GetData(sql);
            List<Appoinment> appointmentList = new List<Appoinment>();
            while (reader.Read()) // if any record is avaibale within this reference it wil read
            {
                Appoinment appoinment = new Appoinment();

                //To map the data from database to our enrity clasess
                appoinment.ID = Convert.ToInt32(reader["ID"]);
                appoinment.ApDate = Convert.ToDateTime(reader["ApDate"]);
                appoinment.PatientID = Convert.ToInt32(reader["PatientID"]);
                appoinment.DoctorID = Convert.ToInt32(reader["DoctorID"]);
                //appoinment.Status = Convert.ToInt32(reader["Status"]);
                appointmentList.Add(appoinment);
            }
            dataAccess.Dispose();
            return appointmentList;
        }

        public List<Appoinment> GetDoctorAppointments(int doctorId)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT a.*,b.Name,b.MobileNo FROM `appointments` a,patients b WHERE a.`PatientID`=b.`ID` and a.`Status`='Pending' and DoctorID='"+doctorId+"' ORDER BY `a`.`ApDate`  ASC";
            

            List<Appoinment> appointmentList = new List<Appoinment>();


            try
            {
                MySqlDataReader reader = dataAccess.GetData(sql);
                while (reader.Read())
                {
                    Appoinment appoinment = new Appoinment();

                    //To map the data from database to our enrity clasess
                    appoinment.ID = Convert.ToInt32(reader["ID"]);
                    appoinment.ApDate = Convert.ToDateTime(reader["ApDate"]);
                    appoinment.PatientID = Convert.ToInt32(reader["PatientID"]);
                    appoinment.DoctorID = Convert.ToInt32(reader["DoctorID"]);
                    appoinment.Status = reader["Status"].ToString();
                    appoinment.Name= reader["Name"].ToString();
                    appoinment.MobileNo = reader["MobileNo"].ToString();
                    appointmentList.Add(appoinment);
                }
                dataAccess.Dispose();
                return appointmentList;
            }
            catch (Exception)
            {

                dataAccess.Dispose();
                return appointmentList;
            }


            
        }


       

        public int Insert(Appoinment entity)
        {
            dataAccess = new DataAccess();
            string sql = "INSERT INTO appointments(ID,ApDate,PatientID,DoctorID,Status) VALUES(NULL,'" + entity.ApDate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + entity.PatientID + "','" + entity.DoctorID + "','" + entity.Status + "')";
            int apt = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return apt;
        }

        public int Update(Appoinment entity)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE appointments SET Status='" + entity.Status + "' WHERE ID=" + entity.ID;
            int apt = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return apt;
        }
    }
}

    
