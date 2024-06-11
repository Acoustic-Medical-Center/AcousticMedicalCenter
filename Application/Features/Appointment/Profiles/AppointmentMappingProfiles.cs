using Application.Features.Appointment.Queries.GetAllByClaim;
using Application.Features.Appointment.Queries.GetAllByPatient;
using Application.Features.Appointment.Queries.GetByIdAdmin;
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

            CreateMap<Domain.Entities.Appointment, GetAllAppointmentsByClaimQueryResponse>()
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Patient.User.FirstName))
            .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.Doctor.User.FirstName))
            .ForMember(dest => dest.DoctorSpecialization, opt => opt.MapFrom(src => src.Doctor.DoctorSpecialization.Name))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status));

            CreateMap<Domain.Entities.Appointment, GetAppointmentByIdAdminResponse>()
            .ForMember(dest => dest.PatientFirstName, opt => opt.MapFrom(src => src.Patient.User.FirstName))
            .ForMember(dest => dest.PatientLastName, opt => opt.MapFrom(src => src.Patient.User.LastName))
            .ForMember(dest => dest.PatientPhoneNumber, opt => opt.MapFrom(src => src.Patient.User.PhoneNumber))
            .ForMember(dest => dest.DoctorFirstName, opt => opt.MapFrom(src => src.Doctor.User.FirstName))
            .ForMember(dest => dest.DoctorLastName, opt => opt.MapFrom(src => src.Doctor.User.LastName))
            .ForMember(dest => dest.BloodType, opt => opt.MapFrom(src => src.Patient.BloodType))
            .ForMember(dest => dest.AppointmentTime, opt => opt.MapFrom(src => src.AppointmentTime))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
            .ForMember(dest => dest.Diagnosis, opt => opt.MapFrom(src => src.Report.Diagnosis))
            .ForMember(dest => dest.ExaminationFindings, opt => opt.MapFrom(src => src.Report.ExaminationFindings));
        }
    }
}
