using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CheckInWorkFlow.Data.Models
{
    public class Appointment : IEntity
    {
        public int Id { get; set; }
        [Required]
        public DateTime DateOfAppointment { get; set; }
        [Required]
        [Range(10, 1000, ErrorMessage="Capacity Must be below 1000")]  
        public int Capacity { get; set; }
        public bool? IsConfirmed { get; set; }

        public List<Passenger> Passengers{get;set;}
    }
}