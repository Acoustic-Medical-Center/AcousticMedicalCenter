using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Commands.Create
{
    public class CreateAppointmentCommand : IRequest<CreateAppointmentCommandResponse>
    {
        public int DoctorId { get; set; }



        public class CreateAppointmentCommandHandler : IRequestHandler<CreateAppointmentCommand, CreateAppointmentCommandResponse>
        {

            private readonly IMapper _mapper;
            private readonly IPatientRepository _patientRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IAppointmentRepository _appointmentRepository;

            public CreateAppointmentCommandHandler(IMapper mapper, IPatientRepository patientRepository, IHttpContextAccessor httpContextAccessor, IAppointmentRepository appointmentRepository)
            {
                _mapper = mapper;
                _patientRepository = patientRepository;
                _httpContextAccessor = httpContextAccessor;
                _appointmentRepository = appointmentRepository;
            }
            public async Task<CreateAppointmentCommandResponse> Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
            {
                var userId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                await _appointmentRepository.AddAsync(new() { DoctorId = request.DoctorId, PatientId = userId, Status = AppointmentStatus.Scheduled });

                return new() { };
            }
        }
    }
}
