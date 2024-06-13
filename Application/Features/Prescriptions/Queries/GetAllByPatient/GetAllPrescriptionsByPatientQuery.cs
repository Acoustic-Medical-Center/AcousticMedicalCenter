using Application.Features.Appointment.Queries.GetAllByClaim;
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

namespace Application.Features.Prescriptions.Queries.GetAllByPatient
{
    public class GetAllPrescriptionsByPatientQuery : IRequest<List<GetAllPrescriptionsByPatientQueryResponse>>
    {

        public class GetAllPrescriptionsByPatientQueryHandler : IRequestHandler<GetAllPrescriptionsByPatientQuery, List<GetAllPrescriptionsByPatientQueryResponse>>
        {

            private readonly IPrescriptionRepository _prescriptionRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _contextAccessor;

            public GetAllPrescriptionsByPatientQueryHandler(IPrescriptionRepository prescriptionRepository, IMapper mapper, IHttpContextAccessor contextAccessor)
            {
                _prescriptionRepository = prescriptionRepository;
                _mapper = mapper;
                _contextAccessor = contextAccessor;
            }

            public async Task<List<GetAllPrescriptionsByPatientQueryResponse>> Handle(GetAllPrescriptionsByPatientQuery request, CancellationToken cancellationToken)
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
                var prescriptions = await _prescriptionRepository.GetListAsync
                    (
                   predicate: a => a.Appointment.PatientId == patientId,
                        include: p => p
                    .Include(p => p.Appointment)
                    .ThenInclude(a => a.Patient)
                    .ThenInclude(p => p.User)
                    .Include(p => p.Appointment)
                    .ThenInclude(a => a.Doctor)
                    .ThenInclude(d => d.User)
                    );

                List<GetAllPrescriptionsByPatientQueryResponse> response = _mapper.Map<List<GetAllPrescriptionsByPatientQueryResponse>>(prescriptions);

                return response;
            }
        }
    }
}
