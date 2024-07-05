﻿using Application.Features.Prescriptions.Queries.GetByIdPatient;
using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reports.Queries.GetByIdByPatient
{
    public class GetPatientReportByIdQuery : IRequest<GetPatientReportByIdQueryResponse>, ISecuredRequest
    {

        // TODO: Başka  hastalar diğer hastaların raporlarına ulaşabiliyor. Rapor Çekerken Reçete bilgilerini de liste olarak dönebiliriz.
        public int ReportId { get; set; }

        public string[] RequiredRoles => [];

        public class GetPatientReportByIdQueryHandler : IRequestHandler<GetPatientReportByIdQuery, GetPatientReportByIdQueryResponse>
        {

            private readonly IReportRepository _reportRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public GetPatientReportByIdQueryHandler(IReportRepository reportRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
            {
                _reportRepository = reportRepository;
                _mapper = mapper;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<GetPatientReportByIdQueryResponse> Handle(GetPatientReportByIdQuery request, CancellationToken cancellationToken)
            {

                var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                var report = await _reportRepository.GetAsync
                (
                  predicate: a => a.Id == request.ReportId && a.Appointment.PatientId == int.Parse(userId),
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

                GetPatientReportByIdQueryResponse response = _mapper.Map<GetPatientReportByIdQueryResponse>(report);

                return response;
            }
        }

    }
}
