using EHealthCare.Interfaces;
using EHealthCare.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace EHealthCare.Repository
{
    public class PrescriptionRepository : IRepository<Prescription>
    {
        DataAccess dataAccess;

        public PrescriptionRepository()
        {
            this.dataAccess = new DataAccess();
        }


        public List<Prescription> GetAll()
        {
            dataAccess.ConnectDB();
            string sql = "SELECT * FROM prescriptions";
            MySqlDataReader reader = dataAccess.GetData(sql);

            List<Prescription> prescriptionList = new List<Prescription>();
            Prescription prescription = new Prescription();

            while (reader.Read())
            {

                prescription.ID = Convert.ToInt32(reader["ID"]);
                prescription.DoctorID = Convert.ToInt32(reader["DoctorID"]);
                prescription.PatientID = Convert.ToInt32(reader["PatientID"]);
                prescription.PrescribeDate = Convert.ToDateTime(reader["PrescribeDate"]);
                prescriptionList.Add(prescription);
            }
            dataAccess.Dispose();
            return prescriptionList;
        }

        public Prescription Get(int id)
        {
            dataAccess.ConnectDB();
            string sql = "SELECT * FROM prescrptions WHERE PatientID=" + id;

            Prescription prescription = new Prescription();

            try
            {
                MySqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();

                prescription.ID = Convert.ToInt32(reader["ID"]);
                prescription.DoctorID = Convert.ToInt32(reader["DoctorID"]);
                prescription.PatientID = Convert.ToInt32(reader["PatientID"]);
                prescription.PrescribeDate = Convert.ToDateTime(reader["PrescribeDate"]);
                dataAccess.Dispose();
                return prescription;
            }
            catch (Exception)
            {
                dataAccess.Dispose();
                return prescription;
            }
        }



        public int Count(int dId)
        {
            dataAccess.ConnectDB();
            string sql = "SELECT count(*) as total FROM `prescriptions` WHERE DoctorID=" + dId;

            

            try
            {
                MySqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                dataAccess.Dispose();

                return Convert.ToInt32(reader["total"]);
                
            }
            catch (Exception)
            {
                dataAccess.Dispose();
                return 0;
            }
        }

        public int Insert(Prescription entity)
        {
            dataAccess.ConnectDB();
            string sql = "INSERT INTO prescriptions(ID,DoctorID,PatientID,PrescribeDate) VALUES('" + entity.ID+"','" + entity.DoctorID + "','" + entity.PatientID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Update(Prescription entity)
        {
            dataAccess.ConnectDB();
            string sql = "UPDATE prescriptions SET ID='" + entity.ID + "',DoctorID=" + entity.DoctorID + ",PatientID=" + entity.PatientID + ",PrescribeDate=" + entity.PrescribeDate + "  WHERE ID=" + entity.ID;
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Delete(int id)
        {
            dataAccess.ConnectDB();
            string sql = "DELETE FROM prescriptions WHERE ID=" + id;
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        } 
    }
}
