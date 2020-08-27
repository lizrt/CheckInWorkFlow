using System;
using System.ComponentModel.DataAnnotations;
using CheckInWorkFlow.Data.Models;

namespace CheckInWorkFlow.Web.ViewModels
{
    public class PassengerModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
       [Required]
        [Range(10, 150, ErrorMessage="Weight Must be between 10 and 150")]  

        public decimal Weight { get; set; }

        public string FullName {get{return FirstName+" "+LastName;}}
        public Status Status { get; set; }
        public int? AppointmentId{get;set;}
    }


}