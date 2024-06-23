using Application.Repositories;
using Application.Services;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Entities;
using Core.Utilities.Hashing;
using MediatR;

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
            private readonly IMailService _mailService;

            public RegisterCommandHandler(IMapper mapper, IUserRepository userRepository, IUserOperationClaimRepository userOperationClaimRepository, IPatientRepository patientRepository, IMailService mailService)
            {
                _mapper = mapper;
                _userRepository = userRepository;
                _userOperationClaimRepository = userOperationClaimRepository;
                _patientRepository = patientRepository;
                _mailService = mailService;
            }

            public async Task Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                var isUserExist = await _userRepository.GetAsync(u => u.Email == request.Email);
                if (isUserExist != null)
                {
                    throw new BusinessException("Bu e-posta adresi kullanılıyor");
                }
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
                await _mailService.SendEmailAsync(request.Email, "Hoşgeldiniz", "Hesabınız başarıyla oluşturuldu");
                await _userRepository.AddAsync(user);
                await _patientRepository.AddAsync(new() { Id = user.Id });


            }
        }

    }
}
