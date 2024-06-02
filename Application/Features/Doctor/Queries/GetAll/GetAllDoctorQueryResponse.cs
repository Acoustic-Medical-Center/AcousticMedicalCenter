namespace Application.Features.Doctor.Queries.GetAll
{
    public class GetAllDoctorQueryResponse
    {
        public int TotalCount { get; set; }
        public object Doctors { get; set; }
    }
}