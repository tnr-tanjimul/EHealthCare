using EHealthCare.Interfaces;
using EHealthCare.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using EHealthCare.Repository;

namespace EHealthCare.Repositories
{
    class PrescriptionRecordRepository:IRepository<PrescriptionRecord>
    {
        DataAccess dataAccess;

        public PrescriptionRecordRepository()
        {
            this.dataAccess = new DataAccess();
        }


        public List<PrescriptionRecord> GetAll()
        {
            dataAccess.ConnectDB();
            string sql = "SELECT * FROM prescrptionrecords";
            MySqlDataReader reader = dataAccess.GetData(sql);

            List<PrescriptionRecord> prescriptionRecordList = new List<PrescriptionRecord>();
            PrescriptionRecord prescriptionRecord = new PrescriptionRecord();

            while (reader.Read())
            {

                prescriptionRecord.ID = Convert.ToInt32(reader["ID"]);
                prescriptionRecord.Medicine = reader["Medicine"].ToString();
                prescriptionRecord.Dose = reader["Dose"].ToString();
                prescriptionRecord.Days = Convert.ToInt32(reader["Days"]);
                prescriptionRecord.Remarks = reader["Remarks"].ToString();
                prescriptionRecord.PrescripID = Convert.ToInt32(reader["PrescripID"]);
                prescriptionRecordList.Add(prescriptionRecord);
            }
            dataAccess.Dispose();
            return prescriptionRecordList;
        }

        public List<PrescriptionRecord> GetRecord(int id)
        {
            dataAccess.ConnectDB();
            string sql = "SELECT * FROM presciptionrecords where PrescipID=" + id;
            

            List<PrescriptionRecord> prescriptionRecordList = new List<PrescriptionRecord>();
            
            

            try
            {
                MySqlDataReader reader = dataAccess.GetData(sql);
               
                while (reader.Read())
                {

                    PrescriptionRecord prescriptionRecord = new PrescriptionRecord();
                    prescriptionRecord.ID = Convert.ToInt32(reader["ID"]);
                    prescriptionRecord.Medicine = reader["Medicine"].ToString();
                    prescriptionRecord.Dose = reader["Dose"].ToString();
                    prescriptionRecord.Days = Convert.ToInt32(reader["Days"]);
                    prescriptionRecord.Remarks = reader["Remark"].ToString();
                    prescriptionRecord.PrescripID = Convert.ToInt32(reader["PrescipID"]);
                    prescriptionRecordList.Add(prescriptionRecord);
                }
                dataAccess.Dispose();
                return prescriptionRecordList;

            }
            catch (Exception)
            {

                dataAccess.Dispose();
                return prescriptionRecordList;
            }


            
        }

        public PrescriptionRecord Get(int id)
        {
            dataAccess.ConnectDB();
            string sql = "SELECT * FROM presciptionrecords WHERE ID=" + id;

            PrescriptionRecord prescriptionRecord = new PrescriptionRecord();

            try
            {
                MySqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();

                prescriptionRecord.ID = Convert.ToInt32(reader["ID"]);
                prescriptionRecord.Medicine = reader["Medicine"].ToString();
                prescriptionRecord.Dose = reader["Dose"].ToString();
                prescriptionRecord.Days = Convert.ToInt32(reader["Days"]);
                prescriptionRecord.Remarks = reader["Remark"].ToString();
                prescriptionRecord.PrescripID = Convert.ToInt32(reader["PrescipID"]);
                dataAccess.Dispose();
                return prescriptionRecord;
            }
            catch (Exception)
            {

                return prescriptionRecord;
            }
        }

        public int Insert(PrescriptionRecord entity)
        {
            dataAccess.ConnectDB();
            string sql = "INSERT INTO presciptionrecords(Medicine,Dose,Days,Remark,PrescipID) VALUES('" + entity.Medicine + "','" + entity.Dose + "','" + entity.Days + "','" + entity.Remarks + "','" + entity.PrescripID + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Update(PrescriptionRecord entity)
        {
            dataAccess.ConnectDB();
            string sql = "UPDATE prescriptionRecords SET ID='" + entity.ID + "',Medicine=" + entity.Medicine + ",Dose=" + entity.Dose + ",Days=" + entity.Days + ",Remarks=" + entity.Remarks + ",PrescripID=" + entity.PrescripID + "  WHERE ID=" + entity.ID;
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Delete(int id)
        {
            dataAccess.ConnectDB();
            string sql = "DELETE FROM prescriptionRecords WHERE ID=" + id;
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
    }
}
