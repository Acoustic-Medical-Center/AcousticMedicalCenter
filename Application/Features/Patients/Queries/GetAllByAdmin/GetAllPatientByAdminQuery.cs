using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Patients.Queries.GetAllByAdmin
{
    public class GetAllPatientByAdminQuery : IRequest<List<GetAllPatientByAdminQueryResponse>>, ISecuredRequest
    {
        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 0;
        public string[] RequiredRoles => ["Admin"];

        public class GetAllPatientByAdminQueryHandler : IRequestHandler<GetAllPatientByAdminQuery, List<GetAllPatientByAdminQueryResponse>>
        {
            private readonly IPatientRepository _patientRepository;
            private readonly IMapper _mapper;

            public GetAllPatientByAdminQueryHandler(IPatientRepository patientRepository, IMapper mapper)
            {
                _patientRepository = patientRepository;
                _mapper = mapper;
            }
            public async Task<List<GetAllPatientByAdminQueryResponse>> Handle(GetAllPatientByAdminQuery request, CancellationToken cancellationToken)
            {

                var patients = _patientRepository.GetList(
                    include: p => p.Include(pat => pat.User));

                var totalCount = _patientRepository.GetList().Count();
                if (request.PageSize == 0)
                {
                    request.PageSize = totalCount;
                }

                var paginatedPatients = patients
                        .Skip((request.Page - 1) * request.PageSize)
                        .Take(request.PageSize)
                        .ToList();

                var response = _mapper.Map<List<GetAllPatientByAdminQueryResponse>>(paginatedPatients);
                return response;
            }
        }
    }
}
