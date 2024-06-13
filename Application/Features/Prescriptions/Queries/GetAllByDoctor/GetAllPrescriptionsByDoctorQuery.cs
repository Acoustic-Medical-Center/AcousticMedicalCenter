using Application.Features.Prescriptions.Queries.GetAllByPatient;
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

namespace Application.Features.Prescriptions.Queries.GetAllByDoctor
{
    public class GetAllPrescriptionsByDoctorQuery : IRequest<List<GetAllPrescriptionsByDoctorQueryResponse>>
    {

        public class GetAllPrescririptionsByDoctorQueryHandler : IRequestHandler<GetAllPrescriptionsByDoctorQuery, List<GetAllPrescriptionsByDoctorQueryResponse>>
        {

            private readonly IPrescriptionRepository _prescriptionRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _contextAccessor;

            public GetAllPrescririptionsByDoctorQueryHandler(IPrescriptionRepository prescriptionRepository, IMapper mapper, IHttpContextAccessor contextAccessor)
            {
                _prescriptionRepository = prescriptionRepository;
                _mapper = mapper;
                _contextAccessor = contextAccessor;
            }

            public async Task<List<GetAllPrescriptionsByDoctorQueryResponse>> Handle(GetAllPrescriptionsByDoctorQuery request, CancellationToken cancellationToken)
            {
                var doctorIdClaim = _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

                if (doctorIdClaim == null || string.IsNullOrEmpty(doctorIdClaim.Value))
                {
                    throw new BusinessException("Token gelmedi veya geçersiz.");
                }

                if (!int.TryParse(doctorIdClaim.Value, out var doctorId))
                {
                    throw new BusinessException("Geçersiz hasta kimliği.");
                }

                var prescriptions = await _prescriptionRepository.GetListAsync
                    (
                   predicate: a => a.Appointment.DoctorId == doctorId,
                        include: p => p
                    .Include(p => p.Appointment)
                    .ThenInclude(a => a.Patient)
                    .ThenInclude(p => p.User)
                    .Include(p => p.Appointment)
                    .ThenInclude(a => a.Doctor)
                    .ThenInclude(d => d.User)
                    );


                List<GetAllPrescriptionsByDoctorQueryResponse> response = _mapper.Map<List<GetAllPrescriptionsByDoctorQueryResponse>>(prescriptions);

                return response;
            }
        }
    }
}
