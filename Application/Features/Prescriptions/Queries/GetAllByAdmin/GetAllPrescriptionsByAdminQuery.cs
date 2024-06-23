using Application.Features.Prescriptions.Queries.GetAllByPatient;
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

namespace Application.Features.Prescriptions.Queries.GetAllByAdmin
{
    public class GetAllPrescriptionsByAdminQuery : IRequest<List<GetAllPrescriptionsByAdminQueryResponse>>, ISecuredRequest
    {
        public string[] RequiredRoles => ["Admin"];

        public class GetAllPrescriptionsByAdminQueryHandler : IRequestHandler<GetAllPrescriptionsByAdminQuery, List<GetAllPrescriptionsByAdminQueryResponse>>
        {

            private readonly IPrescriptionRepository _prescriptionRepository;
            private readonly IMapper _mapper;
            public GetAllPrescriptionsByAdminQueryHandler(IPrescriptionRepository prescriptionRepository, IMapper mapper)
            {
                _prescriptionRepository = prescriptionRepository;
                _mapper = mapper;
            }

            public async Task<List<GetAllPrescriptionsByAdminQueryResponse>> Handle(GetAllPrescriptionsByAdminQuery request, CancellationToken cancellationToken)
            {
                var prescriptions = await _prescriptionRepository.GetListAsync
                    (
                        include: p => p
                    .Include(p => p.Appointment)
                    .ThenInclude(a => a.Patient)
                    .ThenInclude(p => p.User)
                    .Include(p => p.Appointment)
                    .ThenInclude(a => a.Doctor)
                    .ThenInclude(d => d.User)
                    );

                List<GetAllPrescriptionsByAdminQueryResponse> response = _mapper.Map<List<GetAllPrescriptionsByAdminQueryResponse>>(prescriptions);

                return response;
            }
        }
    }
}
