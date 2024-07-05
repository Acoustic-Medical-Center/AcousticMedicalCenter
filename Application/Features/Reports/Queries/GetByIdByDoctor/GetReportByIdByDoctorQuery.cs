using Application.Features.Reports.Queries.GetByIdByPatient;
using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
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

namespace Application.Features.Reports.Queries.GetByIdByDoctor
{
    public class GetReportByIdByDoctorQuery : IRequest<GetReportByIdByDoctorQueryResponse>, ISecuredRequest
    {
        public int id { get; set; }
        public string[] RequiredRoles => ["Doctor"];

        public class GetReportByIdByDoctorQueryHandler : IRequestHandler<GetReportByIdByDoctorQuery, GetReportByIdByDoctorQueryResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IReportRepository _reportRepository;
            private readonly IMapper _mapper;

            public GetReportByIdByDoctorQueryHandler(IHttpContextAccessor httpContextAccessor, IReportRepository reportRepository, IMapper mapper)
            {
                _httpContextAccessor = httpContextAccessor;
                _reportRepository = reportRepository;
                _mapper = mapper;
            }
            public async Task<GetReportByIdByDoctorQueryResponse> Handle(GetReportByIdByDoctorQuery request, CancellationToken cancellationToken)
            {
                var doctorId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                var report = await _reportRepository.GetAsync
                (
                  predicate: a => a.Id == request.id && a.Appointment.DoctorId == int.Parse(doctorId),
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
                if (report == null)
                    throw new Exception("Böyle bir veri bulunamadı");

                var response = _mapper.Map<GetReportByIdByDoctorQueryResponse>(report);

                return response;
            }
        }
    }
}
