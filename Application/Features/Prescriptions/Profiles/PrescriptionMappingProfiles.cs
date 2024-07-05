using Application.Features.Prescriptions.Commands.Create;
using Application.Features.Prescriptions.Queries.GetAllByAdmin;
using Application.Features.Prescriptions.Queries.GetAllByDoctor;
using Application.Features.Prescriptions.Queries.GetAllByPatient;
using Application.Features.Prescriptions.Queries.GetByIdPatient;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Prescriptions.Profiles
{
    public class PrescriptionMappingProfiles : Profile
    {
        public PrescriptionMappingProfiles()
        {
            CreateMap<Prescription, CreatePrescriptionCommand>().ReverseMap();
            CreateMap<Prescription, CreatePrescriptionCommandResponse>().ReverseMap();


            CreateMap<Prescription, GetAllPrescriptionsByPatientQuery>().ReverseMap();
            CreateMap<Prescription, GetAllPrescriptionsByPatientQueryResponse>()
            //.ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.Appointment.Patient.User.FirstName))
            .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.Appointment.Doctor.User.FirstName))
            .ReverseMap();

            CreateMap<Prescription, GetAllPrescriptionsByDoctorQuery>().ReverseMap();
            CreateMap<Prescription, GetAllPrescriptionsByDoctorQueryResponse>()
            .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.Appointment.Patient.User.FirstName))
            .ReverseMap();


            CreateMap<Prescription, GetAllPrescriptionsByAdminQuery>().ReverseMap();
            CreateMap<Prescription, GetAllPrescriptionsByAdminQueryResponse>()
            .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.Appointment.Patient.User.FirstName))
            .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.Appointment.Doctor.User.FirstName))
            .ReverseMap();



            CreateMap<Prescription, GetPatientPrescriptionByIdQuery>().ReverseMap();
            CreateMap<Prescription, GetPatientPrescriptionByIdQueryResponse>()
            //.ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.Appointment.Patient.User.FirstName))
            .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.Appointment.Doctor.User.FirstName))
            .ReverseMap();

            CreateMap<Prescription, GetAllPrescriptionsByPatientQueryResponse>()
                .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.Appointment.Doctor.User.FirstName));



        }
    }
}
