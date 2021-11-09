using EHealthCare.Interfaces;
using EHealthCare.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace EHealthCare.Repository
{
    public class BPRecordRepository:IRecord<BpRecord>
    {
        DataAccess dataAccess;

        public BPRecordRepository()
        {
            this.dataAccess = new DataAccess();
        }


        public List<BpRecord> Get(int id)
        {
            dataAccess.ConnectDB();
            string sql = "SELECT * FROM bprecords where PatientID='" + id + "' ORDER BY `ID` DESC";
            MySqlDataReader reader = dataAccess.GetData(sql);

            List<BpRecord> bprecordList = new List<BpRecord>();
            

            while (reader.Read())
            {
                BpRecord bprecord = new BpRecord();
                bprecord.ID = Convert.ToInt32(reader["ID"]);
                bprecord.BP = reader["BP"].ToString();
                bprecord.PatientID = Convert.ToInt32(reader["PatientID"]);
                bprecord.RecordTime = Convert.ToDateTime(reader["RecordTime"]);
                bprecordList.Add(bprecord);
            }
            dataAccess.Dispose();
            return bprecordList;
        }

        //public BpRecord Get(int id)
        //{
        //    dataAccess.ConnectDB();
        //    string sql = "SELECT * FROM bpRecords WHERE PatientID=" + id;

        //    BpRecord bprecord = new BpRecord();

        //    try
        //    {
        //        MySqlDataReader reader = dataAccess.GetData(sql);
        //        reader.Read();

        //        bprecord.ID = Convert.ToInt32(reader["ID"]);
        //        bprecord.BP = reader["BP"].ToString();
        //        bprecord.PatientID = Convert.ToInt32(reader["PatientID"]);
        //        bprecord.RecordTime = Convert.ToDateTime(reader["RecordTime"]);
        //        dataAccess.Dispose();
        //        return bprecord;
        //    }
        //    catch (Exception)
        //    {

        //        return bprecord;
        //    }
        //}

        public int Insert(BpRecord entity)
        {
            dataAccess.ConnectDB();
            string sql = "INSERT INTO bpRecords(ID,BP,PatientID,RecordTime) VALUES(NULL,'" + entity.BP + "','" + entity.PatientID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Update(BpRecord entity)
        {
            dataAccess.ConnectDB();
            string sql = "UPDATE bpRecords SET ID='" + entity.ID + "',BP='" + entity.BP + "' WHERE ID=" + entity.ID;
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }

        public int Delete(int id)
        {
            dataAccess.ConnectDB();
            string sql = "DELETE FROM bpRecords WHERE ID=" + id;
            int result = dataAccess.ExecuteQuery(sql);
            dataAccess.Dispose();
            return result;
        }
    }
}
