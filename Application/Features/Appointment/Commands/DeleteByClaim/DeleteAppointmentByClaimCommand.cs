using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Commands.DeleteByClaim
{
    public class DeleteAppointmentByClaimCommand : IRequest<DeleteAppointmentByClaimCommandResponse>, ISecuredRequest
    {
        public int AppointmentId { get; set; }

        public string[] RequiredRoles => ["Admin", "DeleteAppointment"];

        public class DeleteAppointmentByClaimCommandHandler : IRequestHandler<DeleteAppointmentByClaimCommand, DeleteAppointmentByClaimCommandResponse>
        {
            private readonly IAppointmentRepository _appointmentRepository;

            public DeleteAppointmentByClaimCommandHandler(IAppointmentRepository appointmentRepository)
            {
                _appointmentRepository = appointmentRepository;
            }

            public async Task<DeleteAppointmentByClaimCommandResponse> Handle(DeleteAppointmentByClaimCommand request, CancellationToken cancellationToken)
            {
                var appointmentToDelete = await _appointmentRepository.GetAsync(app => app.Id == request.AppointmentId);
                await _appointmentRepository.DeleteAsync(appointmentToDelete);
                return new();
            }
        }
    }
}
