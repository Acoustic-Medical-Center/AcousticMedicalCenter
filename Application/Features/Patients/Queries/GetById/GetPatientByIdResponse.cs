using Domain.Entities;

namespace Application.Features.Patients.Queries.GetById
{
    public class GetPatientByIdResponse
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BloodType { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
    }
}