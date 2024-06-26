using Domain.Entities;

namespace Application.Features.Doctor.Queries.GetAllSpecialization
{
    public class GetAllSpecializationQueryResponse
    {
        public List<DoctorSpecializationDto> Results { get; set; }
    }

    public class DoctorSpecializationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}