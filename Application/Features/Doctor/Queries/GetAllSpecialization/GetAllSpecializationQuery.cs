using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Doctor.Queries.GetAllSpecialization
{
    public class GetAllSpecializationQuery : IRequest<GetAllSpecializationResponse>
    {


        public class GetAllSpecializationQueryHandler : IRequestHandler<GetAllSpecializationQuery, GetAllSpecializationResponse>
        {
            private readonly IDoctorSpecializationRepository _doctorSpecializationRepository;

            public GetAllSpecializationQueryHandler(IDoctorSpecializationRepository doctorSpecializationRepository)
            {
                _doctorSpecializationRepository = doctorSpecializationRepository;
            }

            public async Task<GetAllSpecializationResponse> Handle(GetAllSpecializationQuery request, CancellationToken cancellationToken)
            {
                var response = await _doctorSpecializationRepository.GetListAsync();
                return new() { DoctorSpecialization = response };
            }
        }
    }
}
