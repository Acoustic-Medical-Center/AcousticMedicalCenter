using Application.Features.User.Queries.GetByIdSelf;
using Application.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Application.Features.User.Queries.GetById
{
    public class GetByIdUserSelfQuery : IRequest<GetByIdUserSelfQueryResponse>
    {
        public class GetByIdUserSelfQueryHandler : IRequestHandler<GetByIdUserSelfQuery, GetByIdUserSelfQueryResponse>
        {
            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public GetByIdUserSelfQueryHandler(IUserRepository userRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
            {
                _userRepository = userRepository;
                _mapper = mapper;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<GetByIdUserSelfQueryResponse> Handle(GetByIdUserSelfQuery request, CancellationToken cancellationToken)
            {
                var userIdClaim = int.Parse(_httpContextAccessor?.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier));
                if (userIdClaim == 0)
                {
                    throw new Exception("Bu kullanıcının bilgilerine ulaşamazsınız");
                }
                var user = await _userRepository.GetAsync(u => u.Id == userIdClaim);

                GetByIdUserSelfQueryResponse result = _mapper.Map<GetByIdUserSelfQueryResponse>(user);
                return result;
            }
        }


    }



}
