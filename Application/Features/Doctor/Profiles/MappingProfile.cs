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
                .ForMember(dest => dest.DoctorInterests, opt => opt.MapFrom(src => src.Interests.Select(di => di.Interest.Name)));
        }
    }
}
