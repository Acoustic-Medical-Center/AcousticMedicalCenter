using Application.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Queries.GetAllByPatient
{
    public class GetAllAppointmensByPatientQuery : IRequest<GetAllAppointmentsByPatientQueryPaginatedResponse>
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string DateFilter { get; set; } = "";

        public class GetAllAppointmensByPatientQueryHandler : IRequestHandler<GetAllAppointmensByPatientQuery, GetAllAppointmentsByPatientQueryPaginatedResponse>
        {
            private readonly IAppointmentRepository _appointmentsRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _contextAccessor;

            public GetAllAppointmensByPatientQueryHandler(IAppointmentRepository appointmentsRepository, IMapper mapper, IHttpContextAccessor contextAccessor)
            {
                _appointmentsRepository = appointmentsRepository;
                _mapper = mapper;
                _contextAccessor = contextAccessor;
            }

            public async Task<GetAllAppointmentsByPatientQueryPaginatedResponse> Handle(GetAllAppointmensByPatientQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var patientIdClaim = _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

                    if (patientIdClaim == null || string.IsNullOrEmpty(patientIdClaim.Value))
                    {
                        throw new BusinessException("Token gelmedi veya geçersiz.");
                    }

                    if (!int.TryParse(patientIdClaim.Value, out var patientId))
                    {
                        throw new BusinessException("Geçersiz hasta kimliği.");
                    }

                    Expression<Func<Domain.Entities.Appointment, bool>> predicate = a => a.PatientId == patientId &&
                        (request.DateFilter == "Prev" ? a.AppointmentTime < DateTime.Now :
                        request.DateFilter == "Upcoming" ? a.AppointmentTime > DateTime.Now : true);

                    Func<IQueryable<Domain.Entities.Appointment>, IIncludableQueryable<Domain.Entities.Appointment, object>> include = a =>
                        a.Include(appt => appt.Doctor)
                         .ThenInclude(doc => doc.DoctorSpecialization)
                         .Include(appt => appt.Doctor)
                         .ThenInclude(d => d.User);

                    var filteredAppointments = await _appointmentsRepository.GetListAsync(predicate, include);
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

                    List<GetAllAppointmentsByPatientQueryResponse> responseItems = _mapper.Map<List<GetAllAppointmentsByPatientQueryResponse>>(paginatedAppointments);

                    return new GetAllAppointmentsByPatientQueryPaginatedResponse
                    {
                        Items = responseItems,
                        TotalCount = totalCount
                    };
                }
                catch (Exception ex)
                {
                    // Hatanın türüne göre farklı işlemler yapabilirsiniz. Örneğin, loglama.
                    // Loglama kodu burada olabilir.
                    throw new BusinessException($"Bir hata oluştu: {ex.Message}");
                }
            }
        }
    }
}
