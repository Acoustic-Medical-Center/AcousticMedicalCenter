using Application.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.User.Commands.Update
{
    public class UserUpdateCommand : IRequest<UserUpdateCommandResponse>
    {
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }


        public class UserUpdateCommandHandler : IRequestHandler<UserUpdateCommand, UserUpdateCommandResponse>
        {

            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public UserUpdateCommandHandler(IUserRepository userRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
            {
                _userRepository = userRepository;
                _mapper = mapper;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<UserUpdateCommandResponse> Handle(UserUpdateCommand request, CancellationToken cancellationToken)
            {
                var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                var userToUpdate = await _userRepository.GetAsync(u => u.Id == currentUserId);

                userToUpdate.Email = request.Email != null ? request.Email : userToUpdate.Email;
                userToUpdate.FirstName = request.FirstName != null ? request.FirstName : userToUpdate.FirstName;
                userToUpdate.LastName = request.LastName != null ? request.LastName : userToUpdate.LastName;
                userToUpdate.PhoneNumber = request.PhoneNumber != null ? request.PhoneNumber : userToUpdate.PhoneNumber;

                await _userRepository.UpdateAsync(userToUpdate);
                return new();
            }
        }
    }
}