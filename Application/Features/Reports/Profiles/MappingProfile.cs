using Application.Features.Reports.Commands.Create;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reports.Profiles
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {

            CreateMap<Report, CreateReportCommand>().ReverseMap().
            ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AppointmentId));


            CreateMap<Report, CreateReportCommandResponse>().ReverseMap().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AppointmentId)); ;








        }

    }
}
