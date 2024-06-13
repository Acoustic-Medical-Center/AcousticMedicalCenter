using Application.Features.Doctor.Commands.Update;
using Application.Features.Doctor.Queries.GetById;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Doctor.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Entities.Doctor, GetByIdDoctorQueryResponse>()
                .ForMember(dest => dest.DoctorInterests, opt => opt.MapFrom(src => src.DoctorInterest.Select(di => di.Interest.Name).ToList()));

            CreateMap<Domain.Entities.Doctor, UpdateDoctorResponse>()
                .ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Experience, opt => opt.MapFrom(src => src.Experience))
                .ForMember(dest => dest.Biography, opt => opt.MapFrom(src => src.Biography))
                .ForMember(dest => dest.DoctorInterests, opt => opt.MapFrom(src => src.DoctorInterest.Select(di => di.Interest.Name).ToList()));
        }
    }
}

       
