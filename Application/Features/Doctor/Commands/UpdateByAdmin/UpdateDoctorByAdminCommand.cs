using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Doctor.Commands.UpdateByAdmin
{
    public class UpdateDoctorByAdminCommand : IRequest<UpdateDoctorByAdminCommandResponse>, ISecuredRequest
    {
        public int DoctorId { get; set; }
        public int Experience { get; set; } = 0;
        public string? Biography { get; set; }

        public string[] RequiredRoles => ["Admin"];

        public class UpdateDoctorByAdminCommandHandler : IRequestHandler<UpdateDoctorByAdminCommand, UpdateDoctorByAdminCommandResponse>
        {

            private readonly IDoctorRepository _doctorRepository;
            public UpdateDoctorByAdminCommandHandler(IDoctorRepository doctorRepository, IHttpContextAccessor httpContextAccessor)
            {
                _doctorRepository = doctorRepository;
            }
            public async Task<UpdateDoctorByAdminCommandResponse> Handle(UpdateDoctorByAdminCommand request, CancellationToken cancellationToken)
            {
                var doctorToUpdate = await _doctorRepository.GetAsync(d => d.Id == request.DoctorId);
                doctorToUpdate.Experience = request.Experience != 0 ? request.Experience : doctorToUpdate.Experience;
                doctorToUpdate.Biography = request.Biography != null ? request.Biography : doctorToUpdate.Biography;
                await _doctorRepository.UpdateAsync(doctorToUpdate);
                return new() { DoctorId = request.DoctorId, Biography = doctorToUpdate.Biography, Experience = doctorToUpdate.Experience };


                throw new NotImplementedException();
            }
        }
    }
}