
using System;
using CheckInWorkFlow.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace CheckInWorkFlow.Data.DataAccess
{
    public class CheckInContext : DbContext
    {
        public CheckInContext (DbContextOptions<CheckInContext> options)
            : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<ScheduledPassengers> ScheduledPassengers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passenger>()
            .Property(p => p.Status)
            .HasDefaultValue(Status.ScheduleAppointment);
        }
    }
}
