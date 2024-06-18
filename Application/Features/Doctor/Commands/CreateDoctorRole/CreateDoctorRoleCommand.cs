using Application.Repositories;
using AutoMapper;
using Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Doctor.Commands.CreateDoctorRole
{
    public class CreateDoctorRoleCommand : IRequest<CreateDoctorRoleResponse>
    {
        public int UserId { get; set; }
        public int SpecializationId { get; set; }
        public int Experience { get; set; }


        public class CreateDoctorRoleCommandHandler : IRequestHandler<CreateDoctorRoleCommand, CreateDoctorRoleResponse>
        {

            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;
            private readonly IPatientRepository _patientRepository;
            private readonly IDoctorRepository _doctorRepository;
            private readonly IUserOperationClaimRepository _userOperationClaimRepository;

            public CreateDoctorRoleCommandHandler(IUserRepository userRepository, IMapper mapper, IPatientRepository patientRepository, IDoctorRepository doctorRepository, IUserOperationClaimRepository userOperationClaimRepository)
            {
                _userRepository = userRepository;
                _mapper = mapper;
                _patientRepository = patientRepository;
                _doctorRepository = doctorRepository;
                _userOperationClaimRepository = userOperationClaimRepository;
            }

            public async Task<CreateDoctorRoleResponse> Handle(CreateDoctorRoleCommand request, CancellationToken cancellationToken)
            {
                var patientToDelete = await _patientRepository.GetAsync(p => p.Id == request.UserId);
                await _patientRepository.DeleteAsync(patientToDelete);
                var userToChangeRole = await _userRepository.GetAsync(u => u.Id == request.UserId);
                userToChangeRole.UserType = UserType.Doctor;
                await _doctorRepository.AddAsync(new() { Id = request.UserId, DoctorSpecializationId = request.SpecializationId, Experience = request.Experience });
                await _userOperationClaimRepository.AddAsync(new() { UserId = request.UserId, OperationClaimId = 3 });
                return new() { };

            }
        }
    }
}
