using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Doctor.Queries.GetAllSpecialization
{
    public class GetAllSpecializationQuery : IRequest<GetAllSpecializationQueryResponse>
    {


        public class GetAllSpecializationQueryHandler : IRequestHandler<GetAllSpecializationQuery, GetAllSpecializationQueryResponse>
        {
            private readonly IDoctorSpecializationRepository _doctorSpecializationRepository;

            public GetAllSpecializationQueryHandler(IDoctorSpecializationRepository doctorSpecializationRepository)
            {
                _doctorSpecializationRepository = doctorSpecializationRepository;
            }

            public async Task<GetAllSpecializationQueryResponse> Handle(GetAllSpecializationQuery request, CancellationToken cancellationToken)
            {
                var response = await _doctorSpecializationRepository.GetListAsync();
                return new() { DoctorSpecialization = response };
            }
        }
    }
}
