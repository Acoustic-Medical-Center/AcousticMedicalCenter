namespace Application.Features.Appointment.Queries.GelAllByDoctor
{
    public class GetAllAppointmentsByDoctorQueryResponse
    {
        public int id { get; set; }
        public string Status { get; set; }
        public string PatientName { get; set; }
        public string PatientLastName { get; set; }
        public DateTime AppointmentTime { get; set; }
    }
}