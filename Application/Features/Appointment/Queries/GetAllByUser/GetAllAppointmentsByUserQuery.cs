using Application.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Queries.GetAllByUser
{
    public class GetAllAppointmentsByUserQuery : IRequest<GetAllAppointmentsByUserResponse>
    {
        public string asd { get; set; } = "";

        public class GetAllAppointmentsByUserQueryHandler : IRequestHandler<GetAllAppointmentsByUserQuery, GetAllAppointmentsByUserResponse>
        {
            private readonly IMapper _mapper;
            private readonly IPatientRepository _patientRepository;
            private readonly IAppointmentRepository _appointmentRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public GetAllAppointmentsByUserQueryHandler(IMapper mapper, IPatientRepository patientRepository, IAppointmentRepository appointmentRepository, IHttpContextAccessor httpContextAccessor)
            {
                _mapper = mapper;
                _patientRepository = patientRepository;
                _appointmentRepository = appointmentRepository;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<GetAllAppointmentsByUserResponse> Handle(GetAllAppointmentsByUserQuery request, CancellationToken cancellationToken)
            {
                var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                var appointments = await _appointmentRepository.GetListAsync(a => a.PatientId == currentUserId);

                return new() { Appointment = appointments };

            }
        }
    }
}
