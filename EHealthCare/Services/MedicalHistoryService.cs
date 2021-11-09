using EHealthCare.Interfaces;
using EHealthCare.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EHealthCare.Repository;
using EHealthCare.Repositories;

namespace EHealthCare.Services
{
    public class MedicalHistoryService
    {
        IRecord<MedicalHistory> repo;
        MedicalHistoryRepository medRepo;

        public MedicalHistoryService()
        {
            this.repo = new MedicalHistoryRepository();
            this.medRepo = new MedicalHistoryRepository();
        }

        public List<MedicalHistory> GetMedicalHistorys(int patientId)
        {
            return repo.Get(patientId);
        }

        
        

        public int AddMedicalHistory(dynamic patientId,dynamic diseasesName,dynamic symptoms,dynamic startDate,dynamic endDate)
        {
            int result = repo.Insert(new MedicalHistory() { PatientID = patientId,DiseasesName=diseasesName,Symptoms=symptoms,StartDate=startDate,EndDate=endDate });
            return result;
        }

        public int EditMedicalHistory(dynamic Id, dynamic diseasesName, dynamic symptoms, dynamic startDate, dynamic endDate)
        {
            int result = repo.Update(new MedicalHistory() { ID = Id, DiseasesName = diseasesName, Symptoms = symptoms, StartDate = startDate, EndDate = endDate });
            return result;
        }

        public int RemoveMedicalHistory(int id)
        {
            int result = repo.Delete(id);
            return result;
        }
    }
}
