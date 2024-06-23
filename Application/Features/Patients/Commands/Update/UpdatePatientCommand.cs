using Application.Features.Doctor.Commands.Update;
using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Patients.Commands.Update
{
    public class UpdatePatientCommand : IRequest<UpdatePatientCommandResponse>
    {
        public string BloodType { get; set; }
       

        public class UpdatePatientCommandHandler : IRequestHandler<UpdatePatientCommand, UpdatePatientCommandResponse>
        {
            private readonly IPatientRepository _patientRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public UpdatePatientCommandHandler(IPatientRepository patientRepository, IHttpContextAccessor httpContextAccessor)
            {
                _patientRepository = patientRepository;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<UpdatePatientCommandResponse> Handle(UpdatePatientCommand request, CancellationToken cancellationToken)
            {
                var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

                var patientToUpdate = await _patientRepository.GetAsync(p=> p.Id == currentUserId);
                if (request.BloodType != null)
                {
                    patientToUpdate.BloodType = request.BloodType;
                }

                await _patientRepository.UpdateAsync(patientToUpdate);
                return new UpdatePatientCommandResponse { PatientId = currentUserId, BloodType = patientToUpdate.BloodType };
            }
        }
    }
}
