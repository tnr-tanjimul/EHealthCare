using EHealthCare.Entities;
using EHealthCare.Interfaces;
using EHealthCare.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHealthCare.Services
{
    public class PatientService
    {
        IRepository<Patient> repo;
        PatientRepository patientRepo;
        public PatientService()
        {
            this.repo = new PatientRepository();
            this.patientRepo = new PatientRepository();
        }

        public List<Patient> GetAllPatients()
        {
            return repo.GetAll();
        }

        public int CountPatients()
        {
            return patientRepo.Count();
        }


        public string GetPatientName(int pId)
        {
            var data = repo.Get(pId);
            
            return  data.Name;
            
        }


        public int AddPatient(dynamic id,dynamic name,dynamic address,dynamic mobileNo,dynamic smoker,dynamic glassUse,dynamic gender,dynamic dob,dynamic ms,dynamic bg)
        {
            int result = repo.Insert(new Patient()
            {
                ID = id,
                Name = name,
                MobileNo = mobileNo,
                Address = address,
                Smoker = smoker,
                GlassUse = glassUse,
                Gender = gender,
                DateOfBirth = dob,
                BloodGroup = bg,
                MaritalStatus = ms
            }); ;
            return result;
        }

        public int EditPatient(int id, dynamic name, dynamic address, dynamic mobileNo, dynamic smoker, dynamic glassUse, dynamic gender, dynamic dob, dynamic ms, dynamic bg)
        {
            int result = repo.Update(new Patient() 
            { 
                ID = id,
                Name = name,
                MobileNo = mobileNo,
                Address = address,
                Smoker = smoker,
                GlassUse = glassUse,
                Gender = gender,
                DateOfBirth = dob,
                BloodGroup = bg,
                MaritalStatus = ms
            });
            return result;
        }

        public int RemovePatient(int id)
        {
            int result = repo.Delete(id);
            return result;
        }

        public List<Patient> SearchPatients(string text)
        {
            return patientRepo.GetByText(text);
        }

    }
}
