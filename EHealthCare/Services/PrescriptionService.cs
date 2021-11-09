using EHealthCare.Interfaces;
using EHealthCare.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHealthCare.Repository;


namespace EHealthCare.Services
{
    class PrescriptionService
    {
        IRepository<Prescription> repo;
        PrescriptionRepository prescriptRepo;

        public PrescriptionService()
        {
            this.repo = new PrescriptionRepository();
            this.prescriptRepo = new PrescriptionRepository();
        }

        public List<Prescription> GetAllPrescription()
        {
            return repo.GetAll();
        }


        
        public int CountPrescriptions(int doctorId)
        {
            return prescriptRepo.Count(doctorId);
        }







        public List<Prescription> GetPrescriptionById(int id)
        {
            var data = repo.Get(id);
            Prescription prescription = new Prescription();
            prescription.ID = data.ID;
            prescription.DoctorID = data.DoctorID;
            prescription.PatientID = data.PatientID;
            prescription.PrescribeDate = data.PrescribeDate;
            List<Prescription> list = new List<Prescription>();
            list.Add(prescription);
            return list;
        }

        public int AddPrescription(dynamic id,dynamic doctorId,dynamic patientId)
        {
            int result = repo.Insert(new Prescription() { ID=id,DoctorID=doctorId,PatientID=patientId });
            return result;
        }

        public int EditPrescription(int pId)
        {
            int result = repo.Update(new Prescription() { PatientID = pId });
            return result;
        }

        public int RemovePrescription(int id)
        {
            int result = repo.Delete(id);
            return result;
        }
    }
}
