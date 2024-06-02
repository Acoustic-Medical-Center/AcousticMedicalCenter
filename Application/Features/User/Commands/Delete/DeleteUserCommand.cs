using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.User.Commands.Delete
{
    public class DeleteUserCommand : IRequest<DeleteUserCommandResponse>
    {
        public int UserId { get; set; }

        public class UserDeleteCommandHandler : IRequestHandler<DeleteUserCommand, DeleteUserCommandResponse>
        {

            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;

            public UserDeleteCommandHandler(IUserRepository userRepository, IMapper mapper)
            {
                _userRepository = userRepository;
                _mapper = mapper;
            }
            public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
            {
                var userToDelete = await _userRepository.GetAsync(u => u.Id == request.UserId);
                await _userRepository.DeleteAsync(userToDelete);
                return new() { };
            }
        }
    }
}
