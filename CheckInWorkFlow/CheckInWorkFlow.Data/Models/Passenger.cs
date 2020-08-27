using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CheckInWorkFlow.Data.Models
{
    public class Passenger : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Range(10, 150, ErrorMessage="Weight Must be between 10 and 150")]  
        public decimal Weight { get; set; }

        public Status Status { get; set; }
        public int? AppointmentId{get;set;}

        public Appointment Appointment{get;set;}
    }

    [DefaultValue(ScheduleAppointment)]
    public enum Status
    {
        [Description("Can Schedule Appointment")]
        ScheduleAppointment =1,
        [Description("Already have Active Appointment")]

        ActiveAppointment=2,
        [Description("Already had successful flight")]
        SuccessfulFlight=3
    }
}