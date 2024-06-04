using Domain.Entities;

namespace Application.Features.Doctor.Queries.GetAllSpecialization
{
    public class GetAllSpecializationResponse
    {
        public List<DoctorSpecialization> DoctorSpecialization { get; set; }
    }
}