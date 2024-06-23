using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
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
    public class UpdateDoctorCommand : IRequest<UpdateDoctorCommandResponse>, ISecuredRequest
    {
        public int Experience { get; set; } = 0;
        public string? Biography { get; set; }

        public string[] RequiredRoles => ["Doctor"];

        public class UpdateDoctorCommanddHandler : IRequestHandler<UpdateDoctorCommand, UpdateDoctorCommandResponse>
        {

            private readonly IDoctorRepository _doctorRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;
            public UpdateDoctorCommanddHandler(IDoctorRepository doctorRepository, IHttpContextAccessor httpContextAccessor)
            {
                _doctorRepository = doctorRepository;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<UpdateDoctorCommandResponse> Handle(UpdateDoctorCommand request, CancellationToken cancellationToken)
            {
                var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

                var doctorToUpdate = await _doctorRepository.GetAsync(d => d.Id == currentUserId);
                doctorToUpdate.Experience = request.Experience != 0 ? request.Experience : doctorToUpdate.Experience;
                doctorToUpdate.Biography = request.Biography != null ? request.Biography : doctorToUpdate.Biography;
                await _doctorRepository.UpdateAsync(doctorToUpdate);
                return new() { DoctorId = currentUserId, Biography = doctorToUpdate.Biography, Experience = doctorToUpdate.Experience };
            }
        }
    }
}