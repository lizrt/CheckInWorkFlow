using System;
using System.Collections.Generic;
using CheckInWorkFlow.Data.Models;

namespace CheckInWorkFlow.Business.Services
{
    public interface IAppointmentService
    {
        IEnumerable<Appointment> GetAllAppointments();
        int AddAppointment(Appointment appointment);

        Appointment GetAppointmentById(int Id);
        bool ValidateForCapacity(int Id);
        void ConfirmAppointment(int Id);
        void DenyAppointment(int Id);
    }
}