using EHealthCare.Interfaces;
using EHealthCare.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using EHealthCare.Repository;

namespace EHealthCare.Repositories
{
    class MedicalHistoryRepository:IRecord<MedicalHistory>
    {
        DataAccess dataAccess;

        public MedicalHistoryRepository()
        {
            this.dataAccess = new DataAccess();
        }


        public List<MedicalHistory> Get(int id)
        {
            dataAccess.ConnectDB();
            string sql = "SELECT * FROM medicalhistorys where PatientID='"+id+ "' ORDER BY `ID` DESC";
            MySqlDataReader reader = dataAccess.GetData(sql);

            List<MedicalHistory> medicalHistoryList = new List<MedicalHistory>();
           

            while (reader.Read())
            {
                MedicalHistory medicalHistory = new MedicalHistory();
                medicalHistory.ID = Convert.ToInt32(reader["ID"]);
                medicalHistory.DiseasesName = reader["DiseasesName"].ToString();
                medicalHistory.DiseasesType = Convert.ToInt32(reader["DiseasesType"]);
                medicalHistory.Symptoms = reader["Symptoms"].ToString();
                medicalHistory.StartDate = Convert.ToDateTime(reader["StartDate"]);
                medicalHistory.EndDate = Convert.ToDateTime(reader["EndDate"]);
                medicalHistory.PatientID = Convert.ToInt32(reader["PatientID"]);
                medicalHistoryList.Add(medicalHistory);
            }
            dataAccess.Dispose();
            return medicalHistoryList;
        }

        

        public int Insert(MedicalHistory entity)
        {
            dataAccess.ConnectDB();
            string sql = "INSERT INTO medicalhistorys(ID,DiseasesName,DiseasesType,Symptoms,StartDate,EndDate,PatientID) VALUES(NULL,'" + entity.DiseasesName + "','" + entity.DiseasesType + "','" + entity.Symptoms + "','" + entity.StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + entity.EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + entity.PatientID + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Update(MedicalHistory entity)
        {
            dataAccess.ConnectDB();
            string sql = "UPDATE medicalhistorys SET DiseasesName='" + entity.DiseasesName + "',Symptoms='" + entity.Symptoms + "',StartDate='" + entity.StartDate + "',EndDate='" + entity.EndDate + "'  WHERE ID='" + entity.ID+"'";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Delete(int id)
        {
            dataAccess.ConnectDB();
            string sql = "DELETE FROM medicalhistorys WHERE ID=" + id;
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
    }
}
