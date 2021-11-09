using EHealthCare.Interfaces;
using EHealthCare.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHealthCare.Repository;

namespace EHealthCare.Services
{
    public class BPRecordService
    {
        IRecord<BpRecord> repo;
        BPRecordRepository bpRepo;

        public BPRecordService()
        {
            this.repo = new BPRecordRepository();
            this.bpRepo = new BPRecordRepository();
        }

        public List<BpRecord> GetBpRecords(int patientId)
        {
            return repo.Get(patientId);
        }
        //public List<BpRecord> GetBpRecordById(int id)
        //{
        //    var data = repo.Get(id);
        //    BpRecord bpRecord = new BpRecord();
        //    bpRecord.ID = data.ID;
        //    bpRecord.BP = data.BP;
        //    bpRecord.PatientID = data.PatientID;
        //    bpRecord.RecordTime = data.RecordTime;
        //    List<BpRecord> list = new List<BpRecord>();
        //    list.Add(bpRecord);
        //    return list;
        //}

        public int AddBpRecord(dynamic patientId, dynamic bp)
        {
            int result = repo.Insert(new BpRecord() { PatientID = patientId, BP = bp});
            return result;
        }

        public int EditBpRecord(dynamic Id,dynamic bp,dynamic recordTime)
        {
            int result = repo.Update(new BpRecord() { PatientID = Id,BP=bp,RecordTime=recordTime });
            return result;
        }

        public int RemoveBpRecord(int id)
        {
            int result = repo.Delete(id);
            return result;
        }
    }
}
