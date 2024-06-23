using Application.Features.Patients.Queries.GetById;
using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Patients.Queries.GetPatientById
{
    public class GetPatientIdQuery : IRequest<GetPatientIdResponse>
    {
        public int PatientId { get; set; }
       

        public class GetPatientByIdQueryHandler : IRequestHandler<GetPatientIdQuery, GetPatientIdResponse>
        {
            private readonly IAppointmentRepository _appointmentRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IPatientRepository _patientRepository;
            private readonly IMapper _mapper;

            public GetPatientByIdQueryHandler(IAppointmentRepository appointmentRepository, IHttpContextAccessor contextAccessor, IPatientRepository patientRepository, IMapper mapper)
            {
                _appointmentRepository = appointmentRepository;
                _httpContextAccessor = contextAccessor;
                _patientRepository = patientRepository;
                _mapper = mapper;
            }

            public async Task<GetPatientIdResponse> Handle(GetPatientIdQuery request, CancellationToken cancellationToken)
            {
                 var userIdClaim = _httpContextAccessor?.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier);

              

                var patient = await _patientRepository.GetAsync(p=>p.Id == request.PatientId, include: p=> p.Include(p=>p.User)); // Include if necessary
                if (patient == null)
                {
                    throw new BusinessException("Hasta bulunamadı");
                }

                var response = _mapper.Map<GetPatientIdResponse>(patient);
                response.BloodType = patient.BloodType;
                return response;

                // Kan grubunu ekleyin
                
            }
        }
    }
}
