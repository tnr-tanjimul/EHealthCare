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
    public class AppointmentService
    {
        IRepository<Appoinment> repo;
        AppoinmentRepository appRepo;
        public AppointmentService()
        {
            this.repo = new AppoinmentRepository();
            this.appRepo = new AppoinmentRepository();
        }

        public List<Appoinment> GetAllAppointments()
        {
            return repo.GetAll();
        }
       
        public List<Appoinment> GetAppointmentById(int id)
        {
            var data = repo.Get(id);
            Appoinment appointment= new Appoinment();
            appointment.ID = data.ID;
            appointment.ApDate = data.ApDate;
            appointment.PatientID = data.PatientID;
            appointment.DoctorID = data.DoctorID;
            appointment.Status = data.Status;
            List<Appoinment> list = new List<Appoinment>();
            list.Add(appointment);
            return list;
        }

        public int CountAppointmentComplete(int doctorId)
        {
           return appRepo.CountCompleteByDoc(doctorId);
        }

        public int CountAppointmentPending(int doctorId)
        {
            return appRepo.CountPendingByDoc(doctorId);
        }

        public List<Appoinment> GetAllAppointmentsByDoc(int docId)
        {
            return appRepo.GetDoctorAppointments(docId);
        }

        public List<Appoinment> GetAllAppointmentsByPatient(int patientId)
        {
            return appRepo.GetPatientAppointments(patientId);
        }


        public int AddAppointment(dynamic doctorId,dynamic patientid,dynamic date,dynamic status)
        {
            int result = repo.Insert(new Appoinment() { DoctorID=doctorId,PatientID=patientid,ApDate=date,Status=status});
            return result;
        }

        public int EditAppointment(int id,string status)
        {      
            int result = repo.Update(new Appoinment() { ID = id,Status=status });
            return result;
        }

        public int RemoveAppointment(int id)
        {
            int result = repo.Delete(id);
            return result;
        }


    }
}
