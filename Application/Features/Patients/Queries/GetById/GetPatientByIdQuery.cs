using Application.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Patients.Queries.GetById
{
    public class GetPatientByIdQuery : IRequest<GetPatientByIdResponse>
    {
        public int PatientId { get; set; }


        public class GetPatientByIdQueryHandler : IRequestHandler<GetPatientByIdQuery, GetPatientByIdResponse>
        {
            private readonly IAppointmentRepository _appointmentRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IPatientRepository _patientRepository;
            private readonly IMapper _mapper;

            public GetPatientByIdQueryHandler(IAppointmentRepository appointmentRepository, IHttpContextAccessor httpContextAccessor, IPatientRepository patientRepository, IMapper mapper)
            {
                _appointmentRepository = appointmentRepository;
                _httpContextAccessor = httpContextAccessor;
                _patientRepository = patientRepository;
                _mapper = mapper;
            }

            public async Task<GetPatientByIdResponse> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
            {
                var userIdClaim = _httpContextAccessor?.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                if (string.IsNullOrEmpty(userIdClaim))
                {
                    throw new BusinessException("Yetkisiz erişim.");
                }

                var doctorId = int.Parse(userIdClaim);

                var appointment = await _appointmentRepository.GetAsync(predicate: app => app.DoctorId == doctorId && app.PatientId == request.PatientId);
                if (appointment != null)
                {
                    var patient = await _patientRepository.GetAsync(p => p.Id == request.PatientId, include: p => p.Include(p => p.User));
                    var response = _mapper.Map<GetPatientByIdResponse>(patient);
                    return response;
                }
                throw new BusinessException("Bu hastanın bilgilerine erişemezsiniz");
            }
        }
    }
}
