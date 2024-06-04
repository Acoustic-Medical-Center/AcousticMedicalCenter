using Application.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Doctor.Commands.Update
{
    public class UpdateDoctorCommand : IRequest<UpdateDoctorResponse>
    {


        public class UpdateDoctorCommandHandler : IRequestHandler<UpdateDoctorCommand, UpdateDoctorResponse>
        {
            private readonly IDoctorRepository _doctorRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public UpdateDoctorCommandHandler(IDoctorRepository doctorRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
            {
                _doctorRepository = doctorRepository;
                _mapper = mapper;
                _httpContextAccessor = httpContextAccessor;
            }

            public Task<UpdateDoctorResponse> Handle(UpdateDoctorCommand request, CancellationToken cancellationToken)
            {






                throw new NotImplementedException();
            }
        }
    }
}
