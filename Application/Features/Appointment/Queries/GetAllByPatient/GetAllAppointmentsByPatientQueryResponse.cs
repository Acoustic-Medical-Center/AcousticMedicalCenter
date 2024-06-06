namespace Application.Features.Appointment.Queries.GetAllByPatient
{
    public class GetAllAppointmentsByPatientQueryResponse
    {
        public int id { get; set; }
        public string Status { get; set; }
        public string FirstName { get; set; }
        public string DoctorSpecialization { get; set; }
        public DateTime AppointmentTime { get; set; }
    }
}