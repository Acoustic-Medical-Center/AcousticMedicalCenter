using Application.Repositories;
using AutoMapper;
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

namespace Application.Features.Appointment.Queries.GetAllByPatient
{
    public class GetAllAppointmensByPatientQuery : IRequest<List<GetAllAppointmentsByPatientQueryResponse>>
    {
        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 0;
        public string DateFilter { get; set; } = "";

        public class GetAllAppointmensByPatientQueryHandler : IRequestHandler<GetAllAppointmensByPatientQuery, List<GetAllAppointmentsByPatientQueryResponse>>
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

            public async Task<List<GetAllAppointmentsByPatientQueryResponse>> Handle(GetAllAppointmensByPatientQuery request, CancellationToken cancellationToken)
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
                    var totalCount = _appointmentsRepository.GetList().Count();
                    if (request.PageSize == 0)
                    {
                        request.PageSize = totalCount;
                    }

                    var filteredAppointments = _appointmentsRepository.GetList(
                                            predicate: a => a.PatientId == patientId &&
                                            (request.DateFilter == "Prev" ? a.AppointmentTime < DateTime.Now :
                                            request.DateFilter == "Upcoming" ? a.AppointmentTime > DateTime.Now : true),
                                            include: a => a
                                            .Include(appt => appt.Doctor)
                                            .ThenInclude(doc => doc.DoctorSpecialization)
                                            .Include(appt => appt.Doctor)
                                            .ThenInclude(d => d.User));

                    var paginatedAppointments = filteredAppointments
                                            .OrderBy(appt => appt.AppointmentTime)
                                            .Skip((request.Page - 1) * request.PageSize)
                                            .Take(request.PageSize)
                                            .ToList();

                    List<GetAllAppointmentsByPatientQueryResponse> response = _mapper.Map<List<GetAllAppointmentsByPatientQueryResponse>>(paginatedAppointments);
                    return response;
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
