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
    public class DoctorService
    {
        IRepository<Doctor> repo;
        DoctorRepository doctorRepo;
        public DoctorService()
        {
            this.repo = new DoctorRepository();
            this.doctorRepo = new DoctorRepository();
        }

        public List<Doctor> GetAllDoctors()
        {
            return repo.GetAll();
        }

        public int GetDoctorId(int userId)
        {
            var data = repo.Get(userId);
            
            return data.ID;
            
        }

        public List<string> GetDoctorDepartment()
        {
            return doctorRepo.GetDocDept();
        }

        public List<Doctor> GetDoctorById(int id)
        {
            var data = repo.Get(id);
            Doctor doctor = new Doctor();
            doctor.ID = data.ID;
            doctor.FullName = data.FullName;
            doctor.Address = data.Address;
            doctor.Designation = data.Designation;
            doctor.Department = data.Department;
            doctor.UserID = data.UserID;
            doctor.RegTime = data.RegTime;
            




            List<Doctor> list = new List<Doctor>();
            list.Add(doctor);
            return list;
        }

        public int GetDoctorIdByName(string doctorName)
        {
            return doctorRepo.GetIdByName(doctorName);
        }

        public int GetDoctorFee(int doctorId)
        {
            var data = repo.Get(doctorId);
           
            return data.Fee;
        }

        public List<string> GetDoctorListByDepartment(string deptName)
        {
            return doctorRepo.GetByDept(deptName);
        }

        public int AddDoctor(dynamic fullName,dynamic address,dynamic designation,dynamic department,dynamic userID)
        {
            int result = repo.Insert(new Doctor() 
                { 
                    FullName = fullName,
                    Address = address,
                    Designation = designation,
                    Department = department,
                    UserID = userID
                }
            );
            return result;
        }

        public int EditDoctor(int id)
        {
            int result = repo.Update(new Doctor() { ID = id });
            return result;
        }

        public int RemoveDoctor(int id)
        {
            int result = repo.Delete(id);
            return result;
        }

    }
}
