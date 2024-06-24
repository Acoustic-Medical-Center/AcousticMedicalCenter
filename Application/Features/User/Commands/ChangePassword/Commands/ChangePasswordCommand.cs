using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;
using Core.Utilities.Encryption;
using Application.Repositories;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;
using Core.Utilities.JWT;
using Core.Utilities.Hashing;

namespace Application.Features.User.Commands.ChangePassword.Commands
{
    public class ChangePasswordCommand : IRequest<ChangePasswordCommandResponse>
    {
        [Required]
        public string CurrentPassword { get; set; }

        [Required]
        public string NewPassword { get; set; }

        public class ChangePasswordHandler : IRequestHandler<ChangePasswordCommand, ChangePasswordCommandResponse>
        {
            private readonly IUserRepository _userRepository;
            
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly ILogger<ChangePasswordHandler> _logger;

            public ChangePasswordHandler(IUserRepository userRepository, ILogger<ChangePasswordHandler> logger, IHttpContextAccessor httpContextAccessor)
            {
                _userRepository = userRepository;
                _httpContextAccessor = httpContextAccessor;
                _logger = logger;
            }

            public async Task<ChangePasswordCommandResponse> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
            {
                var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (userId == null)
                {
                    return new ChangePasswordCommandResponse
                    {
                        Success = false,
                        Message = "User not authenticated"
                    };
                }

                var user = await _userRepository.GetAsync(u => u.Id.ToString() == userId);
                if (user == null)
                {
                    return new ChangePasswordCommandResponse
                    {
                        Success = false,
                        Message = "User not found"
                    };
                }

                if (!HashingHelper.VerifyPasswordHash(request.CurrentPassword, user.PasswordHash, user.PasswordSalt))
                {
                    return new ChangePasswordCommandResponse
                    {
                        Success = false,
                        Message = "Current password is incorrect"
                    };
                }

                HashingHelper.CreatePasswordHash(request.NewPassword, out byte[] newHash, out byte[] newSalt);
                user.PasswordHash = newHash;
                user.PasswordSalt = newSalt;

                await _userRepository.UpdateAsync(user);

                return new ChangePasswordCommandResponse
                {
                    Success = true,
                    Message = "Password changed successfully"
                };
            }
        }
    }
}
