using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Queries.GetAllByClaim
{
    public class GetAllAppointmentsByClaimQuery : IRequest<List<GetAllAppointmentsByClaimQueryResponse>>, ISecuredRequest
    {
        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 0;
        public string DateFilter { get; set; } = "";
        public string[] RequiredRoles => ["Admin"];

        public class GetAllAppointmentsByClaimQueryHandler : IRequestHandler<GetAllAppointmentsByClaimQuery, List<GetAllAppointmentsByClaimQueryResponse>>
        {
            private readonly IAppointmentRepository _appointmentsRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _contextAccessor;

            public GetAllAppointmentsByClaimQueryHandler(IAppointmentRepository appointmentsRepository, IMapper mapper, IHttpContextAccessor contextAccessor)
            {
                _appointmentsRepository = appointmentsRepository;
                _mapper = mapper;
                _contextAccessor = contextAccessor;
            }

            public async Task<List<GetAllAppointmentsByClaimQueryResponse>> Handle(GetAllAppointmentsByClaimQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var totalCount = _appointmentsRepository.GetList().Count();
                    if (request.PageSize == 0)
                    {
                        request.PageSize = totalCount;
                    }

                    var filteredAppointments = _appointmentsRepository.GetList(
                           predicate: a =>
                           (request.DateFilter == "Prev" ? a.AppointmentTime < DateTime.Now :
                           request.DateFilter == "Upcoming" ? a.AppointmentTime > DateTime.Now : true),
                           include: a => a
                           .Include(appt => appt.Patient)
                           .ThenInclude(p => p.User)
                           .Include(appt => appt.Doctor)
                           .ThenInclude(doc => doc.DoctorSpecialization)
                           .Include(appt => appt.Doctor)
                           .ThenInclude(d => d.User));

                    var paginatedAppointments = filteredAppointments
                        .OrderBy(appt => appt.AppointmentTime)
                        .Skip((request.Page - 1) * request.PageSize)
                        .Take(request.PageSize)
                        .ToList();

                    List<GetAllAppointmentsByClaimQueryResponse> response = _mapper.Map<List<GetAllAppointmentsByClaimQueryResponse>>(paginatedAppointments);

                    return response;
                }
                catch (Exception ex)
                {
                    throw new BusinessException($"Bir hata oluştu: {ex.Message}");
                }
            }

        }
    }
}
