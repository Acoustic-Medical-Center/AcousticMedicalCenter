﻿using Application.Features.Appointment.Queries.GelAllByDoctor;
using Application.Features.Appointment.Queries.GetAllAvailableAppointments;
using Application.Features.Appointment.Queries.GetAllByClaim;
using Application.Features.Appointment.Queries.GetAllByPatient;
using Application.Features.Appointment.Queries.GetByIdAdmin;
using Application.Features.Appointment.Queries.GetPatientAppointments;
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
           .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Doctor.User.LastName))
           .ForMember(dest => dest.DoctorSpecialization, opt => opt.MapFrom(src => src.Doctor.DoctorSpecialization.NameTR));

            CreateMap<Domain.Entities.Appointment, GetAllAppointmentsByDoctorQueryResponse>()
           .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.Patient.User.FirstName))
           .ForMember(dest => dest.PatientLastName, opt => opt.MapFrom(src => src.Patient.User.LastName))
           .ForMember(dest => dest.AppointmentTime, opt => opt.MapFrom(src => src.AppointmentTime));

            CreateMap<Domain.Entities.Appointment, GetAllAppointmentsByClaimQueryResponse>()
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Patient.User.FirstName))
            .ForMember(dest => dest.UserLastName, opt => opt.MapFrom(src => src.Patient.User.LastName))
            .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.Doctor.User.FirstName))
            .ForMember(dest => dest.DoctorLastName, opt => opt.MapFrom(src => src.Doctor.User.LastName))
            .ForMember(dest => dest.DoctorSpecialization, opt => opt.MapFrom(src => src.Doctor.DoctorSpecialization.NameTR))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
            .ForMember(dest => dest.PatientPhoneNumber, opt => opt.MapFrom(src => src.Patient.User.PhoneNumber))
            .ForMember(dest => dest.PatientGender, opt => opt.MapFrom(src => src.Patient.User.Gender))
            .ForMember(dest => dest.PatientEmail, opt => opt.MapFrom(src => src.Patient.User.Email));

            CreateMap<Domain.Entities.Appointment, GetAppointmentByIdAdminQueryResponse>()
            .ForMember(dest => dest.PatientFirstName, opt => opt.MapFrom(src => src.Patient.User.FirstName))
            .ForMember(dest => dest.PatientLastName, opt => opt.MapFrom(src => src.Patient.User.LastName))
            .ForMember(dest => dest.PatientPhoneNumber, opt => opt.MapFrom(src => src.Patient.User.PhoneNumber))
            .ForMember(dest => dest.DoctorFirstName, opt => opt.MapFrom(src => src.Doctor.User.FirstName))
            .ForMember(dest => dest.DoctorLastName, opt => opt.MapFrom(src => src.Doctor.User.LastName))
            .ForMember(dest => dest.BloodType, opt => opt.MapFrom(src => src.Patient.BloodType))
            .ForMember(dest => dest.AppointmentTime, opt => opt.MapFrom(src => src.AppointmentTime))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
            .ForMember(dest => dest.Diagnosis, opt => opt.MapFrom(src => src.Report.Diagnosis))
            .ForMember(dest => dest.PatientGender, opt => opt.MapFrom(src => src.Patient.User.Gender));

            CreateMap<Domain.Entities.Appointment, GetPatientAppointmentsQueryResponse>()
            .ForMember(dest => dest.AppointmentId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.PatientFirstName, opt => opt.MapFrom(src => src.Patient.User.FirstName))
            .ForMember(dest => dest.PatientLastName, opt => opt.MapFrom(src => src.Patient.User.LastName))
            .ForMember(dest => dest.PatientPhoneNumber, opt => opt.MapFrom(src => src.Patient.User.PhoneNumber))
            .ForMember(dest => dest.DoctorFirstName, opt => opt.MapFrom(src => src.Doctor.User.FirstName))
            .ForMember(dest => dest.DoctorLastName, opt => opt.MapFrom(src => src.Doctor.User.LastName))
            .ForMember(dest => dest.BloodType, opt => opt.MapFrom(src => src.Patient.BloodType))
            .ForMember(dest => dest.AppointmentTime, opt => opt.MapFrom(src => src.AppointmentTime))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
            .ForMember(dest => dest.Diagnosis, opt => opt.MapFrom(src => src.Report.Diagnosis))
            .ForMember(dest => dest.ExaminationFindings, opt => opt.MapFrom(src => src.Report.ExaminationFindings))
            .ForMember(dest => dest.PatientGender, opt => opt.MapFrom(src => src.Patient.User.Gender));

            CreateMap<Domain.Entities.Appointment, GetAllAvailableAppointmentsQueryResponse>();
        }
    }
}
