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
    public class PassengerController : Controller
    {
        private readonly ILogger<PassengerController> _logger;
        private readonly IAppointmentService _appointmentService;
        private readonly IPassengerService _passengerService;
        private readonly IMapper _mapper;

        public PassengerController(ILogger<PassengerController> logger,IAppointmentService appointmentService,IPassengerService passengerService,IMapper mapper)
        {
            _logger = logger;
            _passengerService=passengerService;
            _appointmentService=appointmentService;
            _mapper=mapper;
        }

       public IActionResult Index()
        {
             IEnumerable<Passenger> passengerdata =   _passengerService.GetAllPassengers();
            var passengerVM=_mapper.Map<IEnumerable<Passenger>, IEnumerable<PassengerModel>>(passengerdata);
                        
            return View(passengerVM);
        }

       [HttpGet]
        public IActionResult Create()
        {
            PassengerModel model=new PassengerModel();
            return View(model);
        }

         [HttpPost]
        public IActionResult Create(PassengerModel model)
        {
            if(ModelState.IsValid)
            {
            Passenger passenger = _mapper.Map<Passenger>(model);
            int Id=_passengerService.AddPassenger(passenger);
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
          [HttpGet]
        public IActionResult BookPassenger(int AppointmentId)
        {
            TempData["AppointmentId"]=AppointmentId;
             IEnumerable<Passenger> passengers=_passengerService.GetAvailablePassengers();
           IEnumerable<PassengerModel> AvailablePassengers=_mapper.Map<IEnumerable<Passenger>, IEnumerable<PassengerModel>>(passengers);

                
           
            return View("Index",AvailablePassengers);
        }

           [HttpGet]
        public IActionResult CancelAppointment(int PassengerId)
        {
            Passenger data=_passengerService.GetPassenger(PassengerId);
                int appointmentId=data.AppointmentId.Value;
           _passengerService.CancelPassengerAppointment(PassengerId);
            return RedirectToAction("ViewAppointment","Appointment",new{Id=appointmentId});

        }
        [HttpGet]
        public IActionResult BookPassengerData(string PassengerId,string AppointmentId)
        {
            Passenger passengerdata=_passengerService.GetPassenger(Convert.ToInt32(PassengerId));
            passengerdata.AppointmentId=Convert.ToInt32(AppointmentId);
            passengerdata.Status=Status.ActiveAppointment;
            if(!_appointmentService.ValidateForCapacity(Convert.ToInt32(AppointmentId)))
            {
                ModelState.AddModelError("","Passenger Capacity exceeds"); 
                return RedirectToAction("BookPassenger",passengerdata.AppointmentId); 
            }
            if(ModelState.IsValid)
            {
            
            _passengerService.UpdatePassenger(passengerdata);
                return RedirectToAction("ViewAppointment","Appointment",new{Id=passengerdata.AppointmentId});
            }
            else
            {
                ModelState.AddModelError("","Invalid data"); 
                 return RedirectToAction("BookPassenger",passengerdata.AppointmentId); 
            }
        }
    }
}
