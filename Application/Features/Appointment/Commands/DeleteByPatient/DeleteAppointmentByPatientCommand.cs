﻿using Application.Repositories;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Commands.Delete
{
    public class DeleteAppointmentByPatientCommand : IRequest<DeleteAppointmentByPatientCommandResponse>
    {
        public int id { get; set; }

        public class DeleteAppointmentByPatientCommandHandler : IRequestHandler<DeleteAppointmentByPatientCommand, DeleteAppointmentByPatientCommandResponse>
        {
            private readonly IAppointmentRepository _appointmentRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public DeleteAppointmentByPatientCommandHandler(IAppointmentRepository appointmentRepository, IHttpContextAccessor httpContextAccessor)
            {
                _appointmentRepository = appointmentRepository;
                _httpContextAccessor = httpContextAccessor;
            }
            public async Task<DeleteAppointmentByPatientCommandResponse> Handle(DeleteAppointmentByPatientCommand request, CancellationToken cancellationToken)
            {
                var userId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                var appointmentToDelete = await _appointmentRepository.GetAsync(app => app.Id == request.id);
                if (appointmentToDelete != null && appointmentToDelete.PatientId == userId)
                {
                    await _appointmentRepository.DeleteAsync(appointmentToDelete);
                }
                else { throw new BusinessException("Appointment delete failed"); }
                return new();
            }
        }
    }
}
