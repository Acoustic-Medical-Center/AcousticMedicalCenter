using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.User.Queries.GetAll
{
    public class GetAllUserQuery : IRequest<GetAllUserResponse>
    {

        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 0;

        public class UserGetAllQueryHandler : IRequestHandler<GetAllUserQuery, GetAllUserResponse>
        {

            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;

            public UserGetAllQueryHandler(IUserRepository userRepository, IMapper mapper)
            {
                _userRepository = userRepository;
                _mapper = mapper;
            }

            public async Task<GetAllUserResponse> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
            {

                var totalCount = _userRepository.GetList().Count();
                if (request.PageSize == 0)
                {
                    request.PageSize = totalCount;
                }
                var users = _userRepository.GetList()
                     .Skip(request.Page - 1 * request.PageSize)
                     .Take(request.PageSize)
                     .Select(u => new
                     {
                         u.Id,
                         u.FirstName,
                         u.LastName,
                         u.Email,
                         u.PhoneNumber,
                     }).ToList();

                return new()
                {
                    Users = users,
                    TotalCount = totalCount
                };

                //List<Domain.Entities.User> paginatedUsers = _mapper.Map<List<Domain.Entities.User>>(users);


            }
        }

    }
}
