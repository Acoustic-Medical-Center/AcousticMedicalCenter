using Application.Features.Appointment.Queries.GetAllByPatient;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Profiles
{
    public class AppointmentMappingProfiles : Profile
    {
        public AppointmentMappingProfiles()
        {
            CreateMap<Domain.Entities.Appointment, GetAllAppointmentsByPatientQueryResponse>()
           .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Doctor.User.FirstName))
           .ForMember(dest => dest.DoctorSpecialization, opt => opt.MapFrom(src => src.Doctor.DoctorSpecialization.Name));
        }
    }
}
