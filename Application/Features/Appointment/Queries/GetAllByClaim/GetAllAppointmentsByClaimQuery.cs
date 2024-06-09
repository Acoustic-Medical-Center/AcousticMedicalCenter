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
                    var appointments = await _appointmentsRepository.GetListAsync(
                        include: a => a
                            .Include(appt => appt.Patient)
                            .ThenInclude(p => p.User)
                            .Include(appt => appt.Doctor)
                            .ThenInclude(doc => doc.DoctorSpecialization)
                            .Include(appt => appt.Doctor)
                            .ThenInclude(d => d.User)
                    );

                    List<GetAllAppointmentsByClaimQueryResponse> response = _mapper.Map<List<GetAllAppointmentsByClaimQueryResponse>>(appointments);

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
