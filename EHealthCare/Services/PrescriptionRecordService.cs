using EHealthCare.Interfaces;
using EHealthCare.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHealthCare.Repository;
using EHealthCare.Repositories;

namespace EHealthCare.Services
{
    public class PrescriptionRecordService
    {
        IRepository<PrescriptionRecord> repo;
        PrescriptionRecordRepository presRepo;

        public PrescriptionRecordService()
        {
            this.repo = new PrescriptionRecordRepository();
            this.presRepo = new PrescriptionRecordRepository();
        }

        public List<PrescriptionRecord> GetAllPrescriptionRecords()
        {
            return repo.GetAll();
        }



        public List<PrescriptionRecord> GetAllPrescriptionRecords(int prId)
        {
            return presRepo.GetRecord(prId);
        }

        public List<PrescriptionRecord> GetPrescriptionRecordById(int id)
        {
            var data = repo.Get(id);
            PrescriptionRecord prescriptionRecord = new PrescriptionRecord();
            prescriptionRecord.ID = data.ID;
            prescriptionRecord.Medicine = data.Medicine;
            prescriptionRecord.Dose = data.Dose;
            prescriptionRecord.Days = data.Days;
            prescriptionRecord.Remarks = data.Remarks;
           // prescriptionRecord.PrescripID = data.PrescripID;
            List<PrescriptionRecord> list = new List<PrescriptionRecord>();
            list.Add(prescriptionRecord);
            return list;
        }

        public int AddPrescriptionRecord(dynamic medicine,dynamic dose, dynamic days,dynamic remark,dynamic prescipID)
        {
            int result = repo.Insert(new PrescriptionRecord() {Medicine=medicine,Dose=dose,Days=days,Remarks=remark,PrescripID=prescipID });
            return result;
        }

        public int EditPrescriptionRecord(int id)
        {
            int result = repo.Update(new PrescriptionRecord() { ID = id });
            return result;
        }

        public int RemovePrescriptionRecord(int id)
        {
            int result = repo.Delete(id);
            return result;
        }
    }
}
