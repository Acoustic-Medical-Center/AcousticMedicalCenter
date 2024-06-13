using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Prescriptions.Queries.GetByIdPatient
{
    public class GetPatientPrescriptionByIdQuery : IRequest<GetPatientPrescriptionByIdQueryResponse>
    {
        public int PrescriptionId { get; set; }

        public class GetPatientPrescriptionByIdQueryHandler : IRequestHandler<GetPatientPrescriptionByIdQuery, GetPatientPrescriptionByIdQueryResponse>
        {

            private readonly IPrescriptionRepository _prescriptionRepository;
            private readonly IMapper _mapper;

            public GetPatientPrescriptionByIdQueryHandler(IPrescriptionRepository prescriptionRepository, IMapper mapper)
            {
                _prescriptionRepository = prescriptionRepository;
                _mapper = mapper;
            }

            public async Task<GetPatientPrescriptionByIdQueryResponse> Handle(GetPatientPrescriptionByIdQuery request, CancellationToken cancellationToken)
            {
                var prescription = await _prescriptionRepository.GetAsync
                (
                  predicate: a => a.Id == request.PrescriptionId,
                        include: p => p
                    .Include(p => p.Appointment)
                    .ThenInclude(a => a.Patient)
                    .ThenInclude(p => p.User)
                    .Include(p => p.Appointment)
                    .ThenInclude(a => a.Doctor)
                    .ThenInclude(d => d.User)
                    );

                /*var prescription = await _prescriptionRepository.GetAsync(p => p.Id == request.PrescriptionId);*/

                if (prescription == null)
                    throw new Exception("Böyle bir veri bulunamadı");

                GetPatientPrescriptionByIdQueryResponse response = _mapper.Map<GetPatientPrescriptionByIdQueryResponse>(prescription);

                return response;
            }
        }
    }
}
