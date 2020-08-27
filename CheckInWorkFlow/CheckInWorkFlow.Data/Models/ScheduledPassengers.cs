using System;
using System.ComponentModel.DataAnnotations;
namespace CheckInWorkFlow.Data.Models
{
    
    public class ScheduledPassengers : IEntity
    {
        
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public bool AppointmentConfirmed {get;set;}
    }
}