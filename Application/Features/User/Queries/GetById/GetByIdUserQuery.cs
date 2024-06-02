using Application.Features.User.Queries.GetAll;
using Application.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.User.Queries.GetById
{
    public class UserGetByIdQuery : IRequest<GetByIdUserResponse>
    {
        public int UserId { get; set; }

        public class UserGetByIdQueryHandler : IRequestHandler<UserGetByIdQuery, GetByIdUserResponse>
        {
            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;

            public UserGetByIdQueryHandler(IUserRepository userRepository, IMapper mapper)
            {
                _userRepository = userRepository;
                _mapper = mapper;
            }

            public async Task<GetByIdUserResponse> Handle(UserGetByIdQuery request, CancellationToken cancellationToken)
            {

                var resultUser = await _userRepository.GetAsync(u => u.Id == request.UserId);
                return new() { User = resultUser };

            }
        }
    }
}
