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
    public class GetAllReportsByPatientQuery : IRequest<List<GetAllReportsByPatientQueryResponse>>
    {

        public class GetAllReportsByPatientQueryHandler : IRequestHandler<GetAllReportsByPatientQuery, List<GetAllReportsByPatientQueryResponse>>
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

            public async Task<List<GetAllReportsByPatientQueryResponse>> Handle(GetAllReportsByPatientQuery request, CancellationToken cancellationToken)
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
                var reports = await _reportRepository.GetListAsync
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

                List<GetAllReportsByPatientQueryResponse> response = _mapper.Map<List<GetAllReportsByPatientQueryResponse>>(reports);

                return response;
            }
        }
    }
}
