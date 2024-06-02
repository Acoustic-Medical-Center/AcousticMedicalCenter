using Application.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Doctor.Queries.GetAll
{
    public class GetAllDoctorQuery : IRequest<GetAllDoctorQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 0;

        public class GetAllDoctorQueryHandler : IRequestHandler<GetAllDoctorQuery, GetAllDoctorQueryResponse>
        {
            private readonly IDoctorRepository _doctorRepository;
            private readonly IMapper _mapper;
            public GetAllDoctorQueryHandler(IDoctorRepository doctorRepository, IMapper mapper)
            {
                _doctorRepository = doctorRepository;
                _mapper = mapper;
            }

            public async Task<GetAllDoctorQueryResponse> Handle(GetAllDoctorQuery request, CancellationToken cancellationToken)
            {
                var totalCount = _doctorRepository.GetList().Count();
                if (request.PageSize == 0)
                {
                    request.PageSize = totalCount;
                }

                var doctors = _doctorRepository.GetList(include: q => q.Include(d => d.User))
                     .Skip((request.Page - 1) * request.PageSize)
                     .Take(request.PageSize)
                     .Select(d => new
                     {
                         d.Id,
                         d.Specialization,
                         d.Experience,
                         d.User.FirstName,
                         d.User.LastName,
                     }).ToList();

                return new()
                {
                    Doctors = doctors,
                    TotalCount = totalCount
                };

            }
        }
    }
}