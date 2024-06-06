﻿using Application.Repositories;
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

                    var appointments = await _appointmentsRepository.GetListAsync(
                        predicate: a => a.PatientId == patientId,
                        include: a => a
                            .Include(appt => appt.Doctor)
                            .ThenInclude(doc => doc.DoctorSpecialization)
                            .Include(appt => appt.Doctor)
                            .ThenInclude(d => d.User)
                    );

                    List<GetAllAppointmentsByPatientQueryResponse> response = _mapper.Map<List<GetAllAppointmentsByPatientQueryResponse>>(appointments);

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