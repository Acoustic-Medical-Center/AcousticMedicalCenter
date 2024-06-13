using Application.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Doctor.Commands.Update
{
    public class UpdateDoctorCommand : IRequest<UpdateDoctorResponse>
    {
        public int DoctorId { get; set; }   
        public int Experience { get; set; }
        public string Biography { get; set; }


        public class UpdateDoctorCommandHandler : IRequestHandler<UpdateDoctorCommand, UpdateDoctorResponse>
        {
            private readonly IDoctorRepository _doctorRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public UpdateDoctorCommandHandler(IDoctorRepository doctorRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
            {
                _doctorRepository = doctorRepository;
                _mapper = mapper;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<UpdateDoctorResponse> Handle(UpdateDoctorCommand request, CancellationToken cancellationToken)
            {

                var currentUserId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (string.IsNullOrEmpty(currentUserId)){
                    throw new UnauthorizedAccessException("Kullanıcı kimliği bulunamadı !!");
                }

                //Güncellenecek doktoru bul

                var doctor = await _doctorRepository.GetAsync(
                    d => d.Id == request.DoctorId,
                    include: source=> source
                        .Include(d=>d.DoctorInterest)
                        .ThenInclude(di=>di.Interest)
                    
                );
                if (doctor == null)
                {
                    throw new KeyNotFoundException("Doktor bulunamadı !");
                }

                //Doktorun bilgilerini güncelle 
                doctor.Experience = request.Experience;
                doctor.Biography = request.Biography;

                //Db kaydet
                await  _doctorRepository.UpdateAsync(doctor);

                //Yanıt
                var response = _mapper.Map<UpdateDoctorResponse>(doctor);
                return response;


            }
        }
    }
}
