using Domain.Entities;

namespace Application.Features.Patients.Queries.GetAll
{
    public class GetAllPatientResponse
    {
        public List<Patient> Patient { get; set; }
    }
}