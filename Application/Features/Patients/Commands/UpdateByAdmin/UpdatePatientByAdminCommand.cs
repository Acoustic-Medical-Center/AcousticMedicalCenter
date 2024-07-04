using Application.Features.Patients.Commands.Update;
using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Patients.Commands.UpdateByAdmin
{
    public class UpdatePatientByAdminCommand : IRequest<UpdatePatientByAdminCommandResponse>, ISecuredRequest
    {
        public int id { get; set; }
        public string BloodType { get; set; }
        public string[] RequiredRoles => ["Admin"];

        public class UpdatePatientByAdminCommandHandler : IRequestHandler<UpdatePatientByAdminCommand, UpdatePatientByAdminCommandResponse>
        {
            private readonly IPatientRepository _patientRepository;

            public UpdatePatientByAdminCommandHandler(IPatientRepository patientRepository)
            {
                _patientRepository = patientRepository;
            }
            public async Task<UpdatePatientByAdminCommandResponse> Handle(UpdatePatientByAdminCommand request, CancellationToken cancellationToken)
            {
                var patientToUpdate = await _patientRepository.GetAsync(p => p.Id == request.id);
                if (request.BloodType != null)
                {
                    patientToUpdate.BloodType = request.BloodType;
                }
                await _patientRepository.UpdateAsync(patientToUpdate);
                return new UpdatePatientByAdminCommandResponse { PatientId = request.id, BloodType = patientToUpdate.BloodType };
            }
        }
    }
}
