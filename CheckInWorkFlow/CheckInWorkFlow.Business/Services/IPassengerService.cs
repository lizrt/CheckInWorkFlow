using System;
using System.Collections.Generic;
using CheckInWorkFlow.Data.Models;

namespace CheckInWorkFlow.Business.Services
{
    public interface IPassengerService
    {
        IEnumerable<Passenger> GetAllPassengers();
        int AddPassenger(Passenger passenger);

        IEnumerable<Passenger> GetAvailablePassengers();

        void UpdatePassenger(Passenger passenger);

        Passenger GetPassenger(int Id);
        void CancelPassengerAppointment(int id);
    }
}