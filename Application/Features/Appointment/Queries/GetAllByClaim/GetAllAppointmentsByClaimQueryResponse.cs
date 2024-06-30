namespace Application.Features.Appointment.Queries.GetAllByClaim
{
    public class GetAllAppointmentsByClaimQueryResponse
    {
        public int id { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }

        public string DoctorName { get; set; }
        public string DoctorLastName { get; set; }
        public string DoctorSpecialization { get; set; }
        public DateTime AppointmentTime { get; set; }
    }
}