using System;
using System.Collections.Generic;
using CheckInWorkFlow.Data.Models;
using CheckInWorkFlow.Data.Repositories;

namespace CheckInWorkFlow.Business.Services
{
    public class AppointmentService : IAppointmentService
    {
        private AppointmentRepository _appoointmentRepo;
        public AppointmentService(AppointmentRepository appoointmentRepo)
        {
            _appoointmentRepo=appoointmentRepo;
        }

        public IEnumerable<Appointment> GetAllAppointments()
        {
            return _appoointmentRepo.GetAll();
        }

        public int AddAppointment(Appointment appointment)
        {
            return _appoointmentRepo.Insert(appointment).Id;
        }

        public Appointment GetAppointmentById(int Id)
        {
            return _appoointmentRepo.GetAppointmentById(Id);
        }
        public bool ValidateForCapacity(int Id)
        {
            Appointment appointment= _appoointmentRepo.GetAppointmentById(Id);
            if(appointment.Passengers.Count>=appointment.Capacity)
            return false;
            else return true;
        }

        public void ConfirmAppointment(int Id)
        {
            _appoointmentRepo.ConfirmAppointment(Id);
        }
        public void DenyAppointment(int Id)
        {
            _appoointmentRepo.DenyAppointment(Id);
        }
    }
}