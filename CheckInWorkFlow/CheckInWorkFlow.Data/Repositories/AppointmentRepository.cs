using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CheckInWorkFlow.Data.DataAccess;
using CheckInWorkFlow.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace CheckInWorkFlow.Data.Repositories
{
    public class AppointmentRepository : EFRepository<Appointment>
    {
        private readonly CheckInContext context;  
        private DbSet <Appointment> appointments;  

        public AppointmentRepository(CheckInContext context) : base(context)
        {
            this.context = context;  
            appointments = context.Set<Appointment> ();  
        }

        public Appointment GetAppointmentById(int Id)
        {
            
                var appointment = this.context.Appointments
                    .Include(app => app.Passengers)
                    .Where(x=>x.Id==Id);

                    return appointment.FirstOrDefault();
            
        }
        public void ConfirmAppointment(int Id)
        {
            Appointment appointment=GetAppointmentById(Id);
            appointment.IsConfirmed=true;
            foreach(var passenger in appointment.Passengers)
            {
                passenger.Status= Status.SuccessfulFlight;
            }
            context.SaveChanges();
        }
        public void DenyAppointment(int Id)
        {
            Appointment appointment=GetAppointmentById(Id);
            appointment.IsConfirmed=false;
            foreach(var passenger in appointment.Passengers)
            {
                passenger.Status= Status.ActiveAppointment;
            }
            context.SaveChanges();
            
        }

        
    }
}