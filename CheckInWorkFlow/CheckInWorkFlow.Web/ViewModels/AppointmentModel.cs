using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CheckInWorkFlow.Web.ViewModels
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        [Required]
        public DateTime DateOfAppointment { get; set; }
        [Required]
        [Range(10, 1000, ErrorMessage="Capacity Must be below 1000")]  
        public int Capacity { get; set; }
        public bool? IsConfirmed { get; set; }

        public string Confirmationstatus {
            get{ if(IsConfirmed.HasValue && IsConfirmed.Value) return"Confirmed"; 
            else if(IsConfirmed.HasValue && !IsConfirmed.Value)return "Denied";
            else return "Not Confirmed";}}

        public IEnumerable<PassengerModel> ScheduledPassengers{get;set;}
        public IEnumerable<PassengerModel> AvailablePassengers{get;set;}
    }
}