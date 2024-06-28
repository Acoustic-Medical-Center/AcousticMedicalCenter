using Application.Features.Appointment.Queries.GetAllByPatient;
using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Application.Features.Appointment.Queries.GelAllByDoctor
{
    public class GetAllAppointmentsByDoctorQuery : IRequest<List<GetAllAppointmentsByDoctorQueryResponse>>, ISecuredRequest
    {
        public string DateFilter { get; set; } = "";
        public string[] RequiredRoles => ["Doctor"];

        public class GetAllAppointmentsByDoctorQueryHandler : IRequestHandler<GetAllAppointmentsByDoctorQuery, List<GetAllAppointmentsByDoctorQueryResponse>>
        {
            private readonly IAppointmentRepository _appointmentsRepository;
            private readonly IHttpContextAccessor _contextAccessor;
            private readonly IMapper _mapper;

            public GetAllAppointmentsByDoctorQueryHandler(IAppointmentRepository appointmentsRepository, IHttpContextAccessor contextAccessor, IMapper mapper)
            {
                _appointmentsRepository = appointmentsRepository;
                _contextAccessor = contextAccessor;
                _mapper = mapper;
            }

            public async Task<List<GetAllAppointmentsByDoctorQueryResponse>> Handle(GetAllAppointmentsByDoctorQuery request, CancellationToken cancellationToken)
            {

                var doctorId = int.Parse(_contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

                var appointments = await _appointmentsRepository.GetListAsync(predicate: app => app.DoctorId == doctorId,
                    include: a => a
                            .Include(appt => appt.Patient)
                            .ThenInclude(pat => pat.User));

                var response = new List<GetAllAppointmentsByDoctorQueryResponse>();

                if (request.DateFilter == "Prev") response = _mapper.Map<List<GetAllAppointmentsByDoctorQueryResponse>>(appointments.Where(app => app.AppointmentTime < DateTime.Now));
                else if (request.DateFilter == "Upcoming") response = _mapper.Map<List<GetAllAppointmentsByDoctorQueryResponse>>(appointments.Where(app => app.AppointmentTime > DateTime.Now));
                else response = _mapper.Map<List<GetAllAppointmentsByDoctorQueryResponse>>(appointments);

                return response;
            }
        }
    }
}
