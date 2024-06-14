using Application.Features.Patients.Queries.GetById;
using Application.Features.Reports.Commands.Create;
using Application.Features.Reports.Queries.GetAllByPatient;
using Application.Features.Reports.Queries.GetByIdByPatient;
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


            CreateMap<Report, CreateReportCommandResponse>().ReverseMap().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AppointmentId));


            CreateMap<Report, GetAllReportsByPatientQuery>().ReverseMap();
            CreateMap<Report, GetAllReportsByPatientQueryResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => $"{src.Appointment.Doctor.User.FirstName} {src.Appointment.Doctor.User.LastName}"))
            .ForMember(dest => dest.DoctorSpecialization, opt => opt.MapFrom(src => src.Appointment.Doctor.DoctorSpecialization.Name))
            .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate.ToString("yyyy-MM-dd")))
            .ForMember(dest => dest.Diagnosis, opt => opt.MapFrom(src => src.Diagnosis))
            .ReverseMap();


            CreateMap<Report, GetPatientReportByIdQuery>().ReverseMap();
            CreateMap<Report, GetPatientReportByIdQueryResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => $"{src.Appointment.Doctor.User.FirstName} {src.Appointment.Doctor.User.LastName}"))
            .ForMember(dest => dest.DoctorSpecialization, opt => opt.MapFrom(src => src.Appointment.Doctor.DoctorSpecialization.Name))
            .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate.ToString("yyyy-MM-dd")))
            .ForMember(dest => dest.Diagnosis, opt => opt.MapFrom(src => src.Diagnosis))
            .ReverseMap();

        }

    }
}
