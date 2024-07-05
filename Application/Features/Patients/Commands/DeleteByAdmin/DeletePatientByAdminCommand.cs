using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Doctor.Commands.DeleteByAdmin
{
    public class DeletePatientByAdminCommand : IRequest<DeletePatientByAdminCommandResponse>, ISecuredRequest
    {
        public int id { get; set; }
        public string[] RequiredRoles => ["Admin"];

        public class DeleteDoctorByAdminCommandHandler : IRequestHandler<DeletePatientByAdminCommand, DeletePatientByAdminCommandResponse>
        {
            private readonly IPatientRepository _patientRepository;
            private readonly IUserRepository _userRepository;

            public DeleteDoctorByAdminCommandHandler(IPatientRepository patientRepository, IUserRepository userRepository)
            {
                _patientRepository = patientRepository;
                _userRepository = userRepository;
            }
            public async Task<DeletePatientByAdminCommandResponse> Handle(DeletePatientByAdminCommand request, CancellationToken cancellationToken)
            {
                var patientToDelete = await _patientRepository.GetAsync(d => d.Id == request.id);
                var userToDelete = await _userRepository.GetAsync(d => d.Id == request.id);
                await _patientRepository.SoftDeleteAsync(patientToDelete);
                await _userRepository.SoftDeleteAsync(userToDelete);

                return new();
            }
        }
    }
}
