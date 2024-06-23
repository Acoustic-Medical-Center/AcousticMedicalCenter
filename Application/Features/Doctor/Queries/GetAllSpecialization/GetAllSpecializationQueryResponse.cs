using Domain.Entities;

namespace Application.Features.Doctor.Queries.GetAllSpecialization
{
    public class GetAllSpecializationQueryResponse
    {
        public List<DoctorSpecialization> DoctorSpecialization { get; set; }
    }
}