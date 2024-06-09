using Application.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Doctor.Queries.GetById
{
    public class GetByIdDoctorQuery : IRequest<GetByIdDoctorQueryResponse>
    {
        public int Id { get; set; }

        public class GetByIdDoctorQueryHandler : IRequestHandler<GetByIdDoctorQuery, GetByIdDoctorQueryResponse>
        {

            private IMapper _mapper;
            private IDoctorRepository _doctorRepository;

            public GetByIdDoctorQueryHandler(IMapper mapper, IDoctorRepository doctorRepository)
            {
                _mapper = mapper;
                _doctorRepository = doctorRepository;
            }

            public async Task<GetByIdDoctorQueryResponse> Handle(GetByIdDoctorQuery request, CancellationToken cancellationToken)
            {
                Domain.Entities.Doctor? doctor = await _doctorRepository.GetAsync(d => d.Id == request.Id);

                if (doctor is null)
                    throw new BusinessException("Böyle bir veri bulunamadı.");

                GetByIdDoctorQueryResponse response = _mapper.Map<GetByIdDoctorQueryResponse>(doctor);

                return response;
            }
        }
    }
}
