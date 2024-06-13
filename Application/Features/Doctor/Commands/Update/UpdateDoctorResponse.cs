namespace Application.Features.Doctor.Commands.Update
{
    public class UpdateDoctorResponse
    {
        public int DoctorId { get; set; }
        public int Experience { get; set; }
        public string Biography { get; set; }
        public List<string> DoctorInterests { get; set; }
    }
}