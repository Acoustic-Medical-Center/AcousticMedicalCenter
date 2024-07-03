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
    public class DeleteDoctorByAdminCommand : IRequest<DeleteDoctorByAdminCommandResponse>, ISecuredRequest
    {
        public int id { get; set; }
        public string[] RequiredRoles => ["Admin"];

        public class DeleteDoctorByAdminCommandHandler : IRequestHandler<DeleteDoctorByAdminCommand, DeleteDoctorByAdminCommandResponse>
        {
            private readonly IDoctorRepository _doctorRepository;
            private readonly IUserRepository _userRepository;

            public DeleteDoctorByAdminCommandHandler(IDoctorRepository doctorRepository, IUserRepository userRepository)
            {
                _doctorRepository = doctorRepository;
                _userRepository = userRepository;
            }
            public async Task<DeleteDoctorByAdminCommandResponse> Handle(DeleteDoctorByAdminCommand request, CancellationToken cancellationToken)
            {
                var doctorToDelete = await _doctorRepository.GetAsync(d => d.Id == request.id);
                var userToDelete = await _userRepository.GetAsync(d => d.Id == request.id);
                await _doctorRepository.SoftDeleteAsync(doctorToDelete);
                await _userRepository.SoftDeleteAsync(userToDelete);

                return new();
            }
        }
    }
}
