using Domain.Entities;

namespace Application.Features.Appointment.Queries.GetAllByUser
{
    public class GetAllAppointmentsByUserResponse
    {
        public List<Domain.Entities.Appointment> Appointment { get; set; }
    }
}