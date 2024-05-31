using Application.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.User.Commands.CreateDoctorRole
{
    public class CreateDoctorRoleCommand : IRequest<CreateDoctorRoleResponse>
    {
        public int UserId { get; set; }
        public string Specialization { get; set; }
        public int Experience { get; set; }


        public class CreateDoctorRoleCommandHandler : IRequestHandler<CreateDoctorRoleCommand, CreateDoctorRoleResponse>
        {

            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;
            private readonly IPatientRepository _patientRepository;
            private readonly IDoctorRepository _doctorRepository;

            public CreateDoctorRoleCommandHandler(IUserRepository userRepository, IMapper mapper, IPatientRepository patientRepository, IDoctorRepository doctorRepository)
            {
                _userRepository = userRepository;
                _mapper = mapper;
                _patientRepository = patientRepository;
                _doctorRepository = doctorRepository;
            }

            public async Task<CreateDoctorRoleResponse> Handle(CreateDoctorRoleCommand request, CancellationToken cancellationToken)
            {
                var patientToDelete = await _patientRepository.GetAsync(p => p.Id == request.UserId);
                await _patientRepository.DeleteAsync(patientToDelete);

                await _doctorRepository.AddAsync(new() { Id = request.UserId, Specialization = request.Specialization, Experience = request.Experience });
                return new() { };

            }
        }
    }
}
