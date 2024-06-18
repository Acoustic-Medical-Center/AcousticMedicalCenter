using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Application.Features.Patients.Queries.GetAll
{
    public class GetAllPatientQuery : IRequest<GetAllPatientResponse>, ISecuredRequest
    {
        public string[] RequiredRoles => ["Doctor"];

        public class GetAllPatientQueryHandler : IRequestHandler<GetAllPatientQuery, GetAllPatientResponse>
        {
            private readonly IPatientRepository _patientRepository;
            private readonly IAppointmentRepository _appointmentRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IMapper _mapper;

            public GetAllPatientQueryHandler(IPatientRepository patientRepository, IAppointmentRepository appointmentRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper)
            {
                _patientRepository = patientRepository;
                _appointmentRepository = appointmentRepository;
                _httpContextAccessor = httpContextAccessor;
                _mapper = mapper;
            }

            public async Task<GetAllPatientResponse> Handle(GetAllPatientQuery request, CancellationToken cancellationToken)
            {
                var doctorId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                var appointments = await _appointmentRepository.GetListAsync(d => d.DoctorId == doctorId);
                List<int> patientIds = new List<int>();
                foreach (var appointment in appointments)
                {
                    patientIds.Add(appointment.PatientId);
                }
                var patients = await _patientRepository.GetListAsync(predicate: p => patientIds.Contains(p.Id), include: p => p.Include(d => d.User));

                var response = _mapper.Map<List<GetAllPatientDto>>(patients);
                return new() { Patients = response };
            }
        }
    }
}
