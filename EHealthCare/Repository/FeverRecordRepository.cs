using EHealthCare.Interfaces;
using EHealthCare.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace EHealthCare.Repository
{
    class FeverRecordRepository : IRecord<FeverRecord>
    {
        DataAccess dataAccess;

        public FeverRecordRepository()
        {
            this.dataAccess = new DataAccess();
        }


        public List<FeverRecord> Get(int id)
        {
            dataAccess.ConnectDB();
            string sql = "SELECT * FROM feverrecords where PatientID='" + id+ "' ORDER BY `ID` DESC";
            MySqlDataReader reader = dataAccess.GetData(sql);

            List<FeverRecord> frecordList = new List<FeverRecord>();
            

            while (reader.Read())
            {
                FeverRecord feverRecord = new FeverRecord();
                feverRecord.ID = Convert.ToInt32(reader["ID"]);
                feverRecord.Temp = Convert.ToSingle(reader["Temp"]);
                feverRecord.PatientID = Convert.ToInt32(reader["PatientID"]);
                feverRecord.RecordTime = Convert.ToDateTime(reader["RecordTime"]);
                frecordList.Add(feverRecord);
            }
            dataAccess.Dispose();
            return frecordList;
        }

        //public FeverRecord Get(int id)
        //{
        //    dataAccess.ConnectDB();
        //    string sql = "SELECT * FROM feverRecords WHERE PatientID=" + id;

        //    FeverRecord feverRecord = new FeverRecord();

        //    try
        //    {
        //        MySqlDataReader reader = dataAccess.GetData(sql);
        //        reader.Read();

        //        feverRecord.ID = Convert.ToInt32(reader["ID"]);
        //        feverRecord.Temp = Convert.ToSingle(reader["Temp"]);
        //        feverRecord.PatientID = Convert.ToInt32(reader["PatientID"]);
        //        feverRecord.RecordTime = Convert.ToDateTime(reader["RecordTime"]);
        //        dataAccess.Dispose();
        //        return feverRecord;
        //    }
        //    catch (Exception)
        //    {

        //        return feverRecord;
        //    }
        //}

        public int Insert(FeverRecord entity)
        {
            dataAccess.ConnectDB();
            string sql = "INSERT INTO feverrecords(ID,Temp,PatientID,RecordTime) VALUES(NULL,'" + entity.Temp + "','" + entity.PatientID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Update(FeverRecord entity)
        {
            dataAccess.ConnectDB();
            string sql = "UPDATE feverrecords SET Temp='" + entity.Temp + "',PatientID='" + entity.PatientID + "' WHERE ID=" + entity.ID;
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Delete(int id)
        {
            dataAccess.ConnectDB();
            string sql = "DELETE FROM feverrecords WHERE ID=" + id;
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
    }
}
