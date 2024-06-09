using Domain.Entities;

namespace Application.Features.Patients.Queries.GetAll
{
    public class GetAllPatientResponse
    {
        public List<GetAllPatientDto> Patients { get; set; }
    }

    public class GetAllPatientDto
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}