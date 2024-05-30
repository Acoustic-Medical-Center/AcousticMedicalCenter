using Application.Repositories;
using AutoMapper;
using Core.Utilities.Hashing;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Commands.Register
{
    public class RegisterCommand : IRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }


        public class RegisterCommandHandler : IRequestHandler<RegisterCommand>
        {

            private readonly IMapper _mapper;
            private readonly IUserRepository _userRepository;
            private readonly IUserOperationClaimRepository _userOperationClaimRepository;
            private readonly IPatientRepository _patientRepository;

            public RegisterCommandHandler(IMapper mapper, IUserRepository userRepository, IUserOperationClaimRepository userOperationClaimRepository, IPatientRepository patientRepository)
            {
                _mapper = mapper;
                _userRepository = userRepository;
                _userOperationClaimRepository = userOperationClaimRepository;
                _patientRepository = patientRepository;
            }

            public async Task Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                Domain.Entities.User user = _mapper.Map<Domain.Entities.User>(request);
                user.UserType = UserType.Patient;

                byte[] passwordHash, passwordSalt;

                HashingHelper.CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);

                user.PasswordSalt = passwordSalt;
                user.PasswordHash = passwordHash;
                //user.UserOperationClaims = new List<UserOperationClaim>() {
                //    new UserOperationClaim() { OperationClaimId = 6, UserId = user.Id }
                //};

                //user.Id = 10;
                await _userRepository.AddAsync(user);
                await _patientRepository.AddAsync(new() { Id = user.Id });


            }
        }

    }
}
