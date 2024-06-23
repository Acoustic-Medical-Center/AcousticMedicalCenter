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
    public class GetPatientByIdSelfQuery : IRequest<GetPatientByIdSelfQueryResponse>, ISecuredRequest
    {
        public string[] RequiredRoles => [];

        public class GetPatientByIdQueryHandler : IRequestHandler<GetPatientByIdSelfQuery, GetPatientByIdSelfQueryResponse>
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

            public async Task<GetPatientByIdSelfQueryResponse> Handle(GetPatientByIdSelfQuery request, CancellationToken cancellationToken)
            {
                var userIdClaim = int.Parse(_httpContextAccessor?.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier));
                if (userIdClaim == 0)
                {
                    throw new Exception("Bu kullanıcının bilgilerine ulaşamazsınız");
                }
                var patient = await _patientRepository.GetAsync(p => p.Id == userIdClaim);

                var response = _mapper.Map<GetPatientByIdSelfQueryResponse>(patient);
                return response;

            }
        }
    }
}
