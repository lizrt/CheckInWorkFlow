
using System;
using System.Linq;
using CheckInWorkFlow.Data.Models;
namespace CheckInWorkFlow.Data.DataAccess
{
    public class DbInitializer
    {
        /// <summary>
        /// This method Seed data to database
        /// </summary>
        /// <param name="context"></param>
        public static void Initialize(CheckInContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Appointments.Any())
            {
                return;   // DB has been seeded
            }

            var appointments = new Appointment[]
            {
            new Appointment{DateOfAppointment=DateTime.Now,Capacity=50},
            new Appointment{DateOfAppointment=DateTime.Now,Capacity=30}
            };
            foreach (Appointment s in appointments)
            {
                context.Appointments.Add(s);
            }
            context.SaveChanges();
        
           

        }
    }
}

  