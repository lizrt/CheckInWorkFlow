using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CheckInWorkFlow.Web.Models;
using CheckInWorkFlow.Business.Services;
using AutoMapper;
using CheckInWorkFlow.Data.Models;
using CheckInWorkFlow.Web.ViewModels;

namespace CheckInWorkFlow.Web.Controllers
{
    [ViewComponent(Name = "PassengerSummary")]
    public class PassengerSummaryComponent : ViewComponent
    {
         private readonly ILogger<PassengerSummaryComponent> _logger;
        private readonly IAppointmentService _appointmentService;
        private readonly IPassengerService _passengerService;

        private readonly IMapper _mapper;

        public PassengerSummaryComponent(ILogger<PassengerSummaryComponent> logger,IPassengerService passengerService,IAppointmentService appointmentService,IMapper mapper)
        {
            _logger = logger;
            _appointmentService=appointmentService;
            _passengerService=passengerService;
            _mapper=mapper;
        }
public async Task<IViewComponentResult> InvokeAsync(int AppointmentId)
        // public IViewComponentResult invoke(
        // int AppointmentId)
        {
           var task = Task.Run(() => _appointmentService.GetAppointmentById(AppointmentId));
  // do other stuff
  var myOutput = await task;
            return View(new PassengerSummaryModel{
                PassengerCount= myOutput.Passengers.Count,
                TotalWeight=myOutput.Passengers.Sum(x=>x.Weight)
            });
        }
    }
    // private Task<List<Passenger>> GetPassengersForAppointment(int AppointmentId)
    // {
    //     return _appointmentService.GetAppointmentById(AppointmentId).ToListAsync();
    // }
}