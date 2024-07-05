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
    public class GetAllAppointmentsByDoctorQuery : IRequest<GetAllAppointmentsByDoctorQueryPaginatedResponse>, ISecuredRequest
    {
        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 0;
        public string DateFilter { get; set; } = "";
        public string[] RequiredRoles => ["Doctor"];

        public class GetAllAppointmentsByDoctorQueryHandler : IRequestHandler<GetAllAppointmentsByDoctorQuery, GetAllAppointmentsByDoctorQueryPaginatedResponse>
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

            public async Task<GetAllAppointmentsByDoctorQueryPaginatedResponse> Handle(GetAllAppointmentsByDoctorQuery request, CancellationToken cancellationToken)
            {

                var doctorId = int.Parse(_contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

                var filteredAppointments = await _appointmentsRepository.GetListAsync(
                predicate: app => app.DoctorId == doctorId &&
                      (request.DateFilter == "Prev" ? app.AppointmentTime < DateTime.Now :
                      request.DateFilter == "Upcoming" ? app.AppointmentTime > DateTime.Now : true),
                include: a => a
                      .Include(appt => appt.Patient)
                      .ThenInclude(pat => pat.User));

                var totalCount = filteredAppointments.Count;
                if (request.PageSize == 0)
                {
                    request.PageSize = totalCount;
                }

                var paginatedAppointments = filteredAppointments
                        .OrderBy(appt => appt.AppointmentTime)
                        .Skip((request.Page - 1) * request.PageSize)
                        .Take(request.PageSize)
                        .ToList();

                List<GetAllAppointmentsByDoctorQueryResponse> response = _mapper.Map<List<GetAllAppointmentsByDoctorQueryResponse>>(paginatedAppointments);

                return new()
                {
                    Items = response,
                    TotalCount = totalCount,
                };
            }
        }
    }
}
