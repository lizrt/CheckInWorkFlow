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
    public class AppointmentController : Controller
    {
        private readonly ILogger<AppointmentController> _logger;
        private readonly IAppointmentService _appointmentService;
        private readonly IPassengerService _passengerService;

        private readonly IMapper _mapper;

        public AppointmentController(ILogger<AppointmentController> logger,IPassengerService passengerService,IAppointmentService appointmentService,IMapper mapper)
        {
            _logger = logger;
            _appointmentService=appointmentService;
            _passengerService=passengerService;
            _mapper=mapper;
        }

        public IActionResult Index()
        {
          
          //  List<AppointmentModel> appointmentVM=new List<AppointmentModel>();
          

             IEnumerable<Appointment> appointmentdata =   _appointmentService.GetAllAppointments();
           //  IEnumerable<AppointmentModel> appointmentVM = AutoMapperExtensions.MapList<Appointment,AppointmentModel>(appointmentdata);
             var appointmentVM=_mapper.Map<IEnumerable<Appointment>, IEnumerable<AppointmentModel>>(appointmentdata);
                        
            return View(appointmentVM);
        }

        [HttpGet]
        public IActionResult ViewAppointment(int Id)
        {
            Appointment appointment=_appointmentService.GetAppointmentById(Id);
            AppointmentModel model=new AppointmentModel{
                Id=appointment.Id,
                ScheduledPassengers=_mapper.Map<IEnumerable<Passenger>, IEnumerable<PassengerModel>>(appointment.Passengers),
                AvailablePassengers=_mapper.Map<IEnumerable<Passenger>, IEnumerable<PassengerModel>>(_passengerService.GetAvailablePassengers())

                
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            AppointmentModel model=new AppointmentModel();
            return View(model);
        }
         [HttpGet]
        public IActionResult ConfirmAppointment(int AppointmentId)
        {
            _appointmentService.ConfirmAppointment(AppointmentId);
            return RedirectToAction("Index");
        }
         [HttpGet]
        public IActionResult DenyAppointment(int AppointmentId)
        {
             _appointmentService.DenyAppointment(AppointmentId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(AppointmentModel model)
        {
            if(ModelState.IsValid)
            {
            Appointment appointment = _mapper.Map<Appointment>(model);
            int Id=_appointmentService.AddAppointment(appointment);
            if(Id>0)
                return RedirectToAction("Index");
             else
                return View(model); 
            }
            else
            {
                ModelState.AddModelError("","Invalid data"); 
                return View(model); 
            }
        }

        
    }
}
