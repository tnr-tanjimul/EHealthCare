using EHealthCare.Interfaces;
using EHealthCare.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHealthCare.Repository;

namespace EHealthCare.Services
{
    public class FeverRecordService
    {
        IRecord<FeverRecord> repo;
        FeverRecordRepository feverRepo;

        public FeverRecordService()
        {
            this.repo = new FeverRecordRepository();
            this.feverRepo = new FeverRecordRepository();
        }

        public List<FeverRecord> GetFeverRecords(int patientId)
        {
            return repo.Get(patientId);
        }
        //public List<FeverRecord> GetFeverRecordById(int id)
        //{
        //    var data = repo.Get(id);
        //    FeverRecord feverRecord = new FeverRecord();
        //    feverRecord.ID = data.ID;
        //    feverRecord.Temp = data.Temp;
        //    feverRecord.PatientID = data.PatientID;
        //    feverRecord.RecordTime = data.RecordTime;
        //    List<FeverRecord> list = new List<FeverRecord>();
        //    list.Add(feverRecord);
        //    return list;
        //}

        public int AddFeverRecord(dynamic patientId,dynamic temp)
        {
            int result = repo.Insert(new FeverRecord() { PatientID = patientId,Temp=temp });
            return result;
        }

        public int EditFeverRecord(dynamic id,dynamic temp)
        {
            int result = repo.Update(new FeverRecord() { ID = id,Temp=temp });
            return result;
        }

        public int RemoveFeverRecord(int id)
        {
            int result = repo.Delete(id);
            return result;
        }
    }
}
