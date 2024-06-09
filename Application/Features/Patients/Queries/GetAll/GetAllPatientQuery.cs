using Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Patients.Queries.GetAll
{
    public class GetAllPatientQuery : IRequest<GetAllPatientResponse>
    {

        public class GetAllPatientQueryHandler : IRequestHandler<GetAllPatientQuery, GetAllPatientResponse>
        {
            private readonly IPatientRepository _patientRepository;
            private readonly IDoctorRepository _doctorRepository;
            private readonly IAppointmentRepository _appointmentRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public GetAllPatientQueryHandler(IPatientRepository patientRepository, IDoctorRepository doctorRepository, IAppointmentRepository appointmentRepository, IHttpContextAccessor httpContextAccessor)
            {
                _patientRepository = patientRepository;
                _doctorRepository = doctorRepository;
                _appointmentRepository = appointmentRepository;
                _httpContextAccessor = httpContextAccessor;
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
                var response = new GetAllPatientResponse() { Patient = patients };
                return response;    
            }
        }
    }
}
