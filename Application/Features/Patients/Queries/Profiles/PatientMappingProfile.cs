using Application.Features.Appointment.Queries.GetAllByPatient;
using Application.Features.Patients.Queries.GetAll;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Patients.Queries.Profiles
{
    public class PatientMappingProfile : Profile
    {
        public PatientMappingProfile()
        {
            CreateMap<GetAllPatientDto, Domain.Entities.Patient>().ReverseMap()
           .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User.FirstName))
           .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User.LastName))
           .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
           .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.User.PhoneNumber));
        }
    }
}
