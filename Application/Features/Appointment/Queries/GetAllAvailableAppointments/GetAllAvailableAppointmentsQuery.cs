using Application.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Queries.GetAllAvailableAppointments
{
    public class GetAllAvailableAppointmentsQuery : IRequest<List<GetAllAvailableAppointmentsQueryResponse>>
    {
        public int DoctorId { get; set; }
        public DateTime? Date { get; set; }

        public class GetAllAppointmentsQueryHandler : IRequestHandler<GetAllAvailableAppointmentsQuery, List<GetAllAvailableAppointmentsQueryResponse>>
        {
            private readonly IAppointmentRepository _appointmentRepository;
            private readonly IMapper _mapper;

            public GetAllAppointmentsQueryHandler(IAppointmentRepository appointmentRepository, IMapper mapper)
            {
                _appointmentRepository = appointmentRepository;
                _mapper = mapper;

            }

            public async Task<List<GetAllAvailableAppointmentsQueryResponse>> Handle(GetAllAvailableAppointmentsQuery request, CancellationToken cancellationToken)
            {
                IEnumerable<Domain.Entities.Appointment> availableAppointments;
                if (request.Date.HasValue)
                {
                    var dayStart = request.Date.Value.Date; // Günün başlangıcı (00:00)
                    var dayEnd = dayStart.AddDays(1); // Günün sonu (00:00 sonraki gün)

                    availableAppointments = await _appointmentRepository.GetListAsync(
                        predicate: d => d.DoctorId == request.DoctorId &&
                                        d.AppointmentTime >= dayStart &&
                                        d.AppointmentTime < dayEnd);
                }
                else
                {
                    availableAppointments = await _appointmentRepository.GetListAsync(
                        predicate: d => d.DoctorId == request.DoctorId);
                }

                var response = _mapper.Map<List<GetAllAvailableAppointmentsQueryResponse>>(availableAppointments);
                return response;

            }
        }
    }
}
