using Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Doctor.Queries.GetAllSpecialization
{
    public class GetAllSpecializationQuery : IRequest<List<DoctorSpecializationDto>>
    {


        public class GetAllSpecializationQueryHandler : IRequestHandler<GetAllSpecializationQuery, List<DoctorSpecializationDto>>
        {
            private readonly IDoctorSpecializationRepository _doctorSpecializationRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public GetAllSpecializationQueryHandler(IDoctorSpecializationRepository doctorSpecializationRepository, IHttpContextAccessor httpContextAccessor)
            {
                _doctorSpecializationRepository = doctorSpecializationRepository;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<List<DoctorSpecializationDto>> Handle(GetAllSpecializationQuery request, CancellationToken cancellationToken)
            {
                var languageHeader = _httpContextAccessor.HttpContext.Request.Headers["Accept-Language"].ToString();
                var preferredLanguage = languageHeader.Contains("tr") ? "TR" : "EN";


                Console.WriteLine(string.IsNullOrEmpty(languageHeader) ? "default-language" : languageHeader);

                var specializations = await _doctorSpecializationRepository.GetListAsync();

                List<DoctorSpecializationDto> result = specializations.Select(s => new DoctorSpecializationDto
                {
                    Id = s.Id,
                    Name = preferredLanguage == "EN" ? s.NameEN : s.NameTR
                }).ToList();

                return result;
            }
        }

    }
}
