using System;
using System.Linq;
using System.Collections.Generic;
using CheckInWorkFlow.Data.Models;
using CheckInWorkFlow.Data.Repositories;

namespace CheckInWorkFlow.Business.Services
{
    public class PassengerService : IPassengerService
    {
        private IRepository<Passenger> _passengerRepo;
        public PassengerService(IRepository<Passenger> passengerRepo)
        {
            _passengerRepo=passengerRepo;
        }

        public IEnumerable<Passenger> GetAllPassengers()
        {
            return _passengerRepo.GetAll();
        }

        public int AddPassenger(Passenger passenger)
        {
            return _passengerRepo.Insert(passenger).Id;
        }
        public IEnumerable<Passenger> GetAvailablePassengers()
        {
            return _passengerRepo.GetAll().Where(x=>x.AppointmentId==null).ToList();
        }

        public void UpdatePassenger(Passenger passenger)
        {
             _passengerRepo.Update(passenger);
        }
        public Passenger GetPassenger(int Id)
        {
            return _passengerRepo.Get(Id);
        }

        public void CancelPassengerAppointment(int id)
        {
            Passenger passenger=GetPassenger(id);
            passenger.AppointmentId=null;
            passenger.Appointment=null;
            passenger.Status=Status.ScheduleAppointment;
            UpdatePassenger(passenger);
        }
    }
}