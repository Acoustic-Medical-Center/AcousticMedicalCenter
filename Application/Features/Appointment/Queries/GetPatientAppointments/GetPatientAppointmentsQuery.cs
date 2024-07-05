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

namespace Application.Features.Appointment.Queries.GetPatientAppointments
{
    public class GetPatientAppointmentsQuery : IRequest<List<GetPatientAppointmentsQueryResponse>>, ISecuredRequest
    {
        public int id { get; set; }
        public string[] RequiredRoles => ["Doctor"];


        public class GetPatientAppointmentQueryHandler : IRequestHandler<GetPatientAppointmentsQuery, List<GetPatientAppointmentsQueryResponse>>
        {
            private readonly IAppointmentRepository _appointmentRepository;
            private readonly IMapper _mapper;

            public GetPatientAppointmentQueryHandler(IAppointmentRepository appointmentRepository, IMapper mapper)
            {
                _appointmentRepository = appointmentRepository;
                _mapper = mapper;
            }
            public async Task<List<GetPatientAppointmentsQueryResponse>> Handle(GetPatientAppointmentsQuery request, CancellationToken cancellationToken)
            {

                var appointments = await _appointmentRepository.GetListAsync
                    (predicate: app => app.PatientId == request.id,
                    include: a => a
                    .Include(appt => appt.Doctor).ThenInclude(d => d.User)
                    .Include(appt => appt.Patient).ThenInclude(d => d.User)
                    .Include(appt => appt.Report)
                    .Include(appt => appt.Prescriptions));

                var response = _mapper.Map<List<GetPatientAppointmentsQueryResponse>>(appointments);

                return response;
            }
        }
    }
}
