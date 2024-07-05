using Application.Features.Prescriptions.Queries.GetAllByPatient;
using Application.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reports.Queries.GetAllByPatient
{
    public class GetAllReportsByPatientQuery : IRequest<GetAllReportsByPatientQueryPaginatedResponse>
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public class GetAllReportsByPatientQueryHandler : IRequestHandler<GetAllReportsByPatientQuery, GetAllReportsByPatientQueryPaginatedResponse>
        {
            private readonly IReportRepository _reportRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _contextAccessor;

            public GetAllReportsByPatientQueryHandler(IReportRepository reportRepository, IMapper mapper, IHttpContextAccessor contextAccessor)
            {
                _reportRepository = reportRepository;
                _mapper = mapper;
                _contextAccessor = contextAccessor;
            }

            public async Task<GetAllReportsByPatientQueryPaginatedResponse> Handle(GetAllReportsByPatientQuery request, CancellationToken cancellationToken)
            {
                var patientIdClaim = _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

                if (patientIdClaim == null || string.IsNullOrEmpty(patientIdClaim.Value))
                {
                    throw new BusinessException("Token gelmedi veya geçersiz.");
                }

                if (!int.TryParse(patientIdClaim.Value, out var patientId))
                {
                    throw new BusinessException("Geçersiz hasta kimliği.");
                }
                var filteredReports = await _reportRepository.GetListAsync
                    (
                        predicate: a => a.Appointment.PatientId == patientId,
                        include: r => r
                            .Include(r => r.Appointment)
                                .ThenInclude(a => a.Patient)
                                .ThenInclude(p => p.User)
                            .Include(r => r.Appointment)
                                .ThenInclude(a => a.Doctor)
                                .ThenInclude(d => d.User)
                            .Include(r => r.Appointment)
                                .ThenInclude(a => a.Doctor)
                                .ThenInclude(d => d.DoctorSpecialization)

                    );

                var totalCount = filteredReports.Count;

                if (request.PageSize == 0)
                {
                    request.PageSize = totalCount;
                }

                var paginatedReports = filteredReports
                                            .Skip((request.Page - 1) * request.PageSize)
                                            .Take(request.PageSize)
                                            .ToList();

                List<GetAllReportsByPatientQueryResponse> response = _mapper.Map<List<GetAllReportsByPatientQueryResponse>>(paginatedReports);

                return new GetAllReportsByPatientQueryPaginatedResponse()
                {
                    TotalCount = totalCount,
                    Items = response
                };
            }
        }
    }
}
