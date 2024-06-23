using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Queries.GetByIdAdmin
{
    public class GetAppointmentByIdAdminQuery : IRequest<GetAppointmentByIdAdminQueryResponse>, ISecuredRequest
    {
        public int AppointmentId { get; set; }
        public string[] RequiredRoles => ["Admin"];

        public class GetAppointmentByIdAdminQueryHandler : IRequestHandler<GetAppointmentByIdAdminQuery, GetAppointmentByIdAdminQueryResponse>
        {
            private readonly IAppointmentRepository _appointmentRepository;
            private readonly IMapper _mapper;

            public GetAppointmentByIdAdminQueryHandler(IAppointmentRepository appointmentRepository, IMapper mapper)
            {
                _appointmentRepository = appointmentRepository;
                _mapper = mapper;
            }

            public async Task<GetAppointmentByIdAdminQueryResponse> Handle(GetAppointmentByIdAdminQuery request, CancellationToken cancellationToken)
            {
                var appointment = await _appointmentRepository.GetAsync
                    (predicate: app => app.Id == request.AppointmentId,
                    include: a => a
                    .Include(appt => appt.Doctor)
                    .ThenInclude(d => d.User)
                    .Include(appt => appt.Patient)
                    .ThenInclude(d => d.User)
                    .Include(appt => appt.Report)
                    .Include(appt => appt.Prescriptions));

                var result = _mapper.Map<GetAppointmentByIdAdminQueryResponse>(appointment);

                return result;

            }
        }
    }
}
