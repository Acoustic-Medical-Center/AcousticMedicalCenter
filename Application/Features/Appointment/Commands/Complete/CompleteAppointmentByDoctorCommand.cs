using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Commands.Complete
{
    public class CompleteAppointmentByDoctorCommand : IRequest<CompleteAppointmentByDoctorCommandResponse>, ISecuredRequest
    {
        public int id { get; set; }
        public string[] RequiredRoles => ["Doctor"];

        public class CompleteAppointmentCommandHandler : IRequestHandler<CompleteAppointmentByDoctorCommand, CompleteAppointmentByDoctorCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IAppointmentRepository _appointmentRepository;

            public CompleteAppointmentCommandHandler(IHttpContextAccessor httpContextAccessor, IAppointmentRepository appointmentRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _appointmentRepository = appointmentRepository;
            }
            public async Task<CompleteAppointmentByDoctorCommandResponse> Handle(CompleteAppointmentByDoctorCommand request, CancellationToken cancellationToken)
            {
                var doctorId = _httpContextAccessor?.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var appointmentToUpdate = await _appointmentRepository.GetAsync(app => app.Id == request.id && app.DoctorId == int.Parse(doctorId) && app.AppointmentTime < DateTime.Now && app.Status == Domain.Entities.AppointmentStatus.Scheduled);
                if (appointmentToUpdate == null)
                {
                    throw new BusinessException("Bu randevunun tamamlanma durumunu değiştiremezsiniz");
                }
                appointmentToUpdate.Status = Domain.Entities.AppointmentStatus.Completed;
                await _appointmentRepository.UpdateAsync(appointmentToUpdate);
                return new();
            }
        }
    }
}