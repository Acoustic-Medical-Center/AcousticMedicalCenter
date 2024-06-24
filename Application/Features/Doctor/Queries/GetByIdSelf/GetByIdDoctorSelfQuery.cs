using Application.Features.Doctor.Queries.GetByIdSelf;
using Application.Features.User.Queries.GetByIdSelf;
using Application.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Application.Features.User.Queries.GetById
{
    public class GetByIdDoctorSelfQuery : IRequest<GetByIdDoctorSelfQueryResponse>
    {
        public class GetByIdDoctorSelfQueryHandler : IRequestHandler<GetByIdDoctorSelfQuery, GetByIdDoctorSelfQueryResponse>
        {
            private readonly IDoctorRepository _doctorRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public GetByIdDoctorSelfQueryHandler(IDoctorRepository doctorRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
            {
                _doctorRepository = doctorRepository;
                _mapper = mapper;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<GetByIdDoctorSelfQueryResponse> Handle(GetByIdDoctorSelfQuery request, CancellationToken cancellationToken)
            {
                var doctorIdClaim = int.Parse(_httpContextAccessor?.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier));
                if (doctorIdClaim == 0)
                {
                    throw new Exception("Bu kullanıcının bilgilerine ulaşamazsınız");
                }
                var user = await _doctorRepository.GetAsync(u => u.Id == doctorIdClaim,
                        include: dc => dc
                            .Include(dctri => dctri.DoctorInterest)
                                .ThenInclude(intr => intr.Interest));

                GetByIdDoctorSelfQueryResponse result = _mapper.Map<GetByIdDoctorSelfQueryResponse>(user);
                return result;
            }
        }


    }



}
