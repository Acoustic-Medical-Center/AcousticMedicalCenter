using Application.Repositories;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Commands.Cancel
{
    public class CancelAppointmentCommand : IRequest<CancelAppointmentCommandResponse>
    {
        public int AppointmentId { get; set; }

        public class CancelAppointmentCommandHandler : IRequestHandler<CancelAppointmentCommand, CancelAppointmentCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IAppointmentRepository _appointmentRepository;

            public CancelAppointmentCommandHandler(IHttpContextAccessor httpContextAccessor, IAppointmentRepository appointmentRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _appointmentRepository = appointmentRepository;
            }

            public async Task<CancelAppointmentCommandResponse> Handle(CancelAppointmentCommand request, CancellationToken cancellationToken)
            {
                var userClaim = _httpContextAccessor.HttpContext.User.FindFirstValue("UserType");

                if (userClaim == "Admin" || userClaim == "Doctor")
                {
                    var appToUpdate = await _appointmentRepository.GetAsync(predicate: a => a.Id == request.AppointmentId);
                    appToUpdate.Status = Domain.Entities.AppointmentStatus.Canceled;
                    await _appointmentRepository.UpdateAsync(appToUpdate);
                    return new();
                }

                var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (userId == null) throw new BusinessException("Giriş yapmadınız");

                var appointmentToUpdate = await _appointmentRepository.GetAsync(predicate: app => app.PatientId == int.Parse(userId) && app.Id == request.AppointmentId);
                if (appointmentToUpdate == null) throw new BusinessException("Bu randevuda değişiklik yapamazsınız");
                appointmentToUpdate.Status = Domain.Entities.AppointmentStatus.Canceled;
                await _appointmentRepository.UpdateAsync(appointmentToUpdate);
                return new();

            }
        }
    }
}
