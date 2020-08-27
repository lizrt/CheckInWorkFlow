using AutoMapper;
using CheckInWorkFlow.Data.Models;
using CheckInWorkFlow.Web.ViewModels;

namespace CheckInWorkFlow.Web
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AppointmentModel, Appointment>().ReverseMap();
            CreateMap<PassengerModel, Passenger>().ReverseMap();
        }
    }
}