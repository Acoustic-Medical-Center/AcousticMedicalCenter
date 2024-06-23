using Domain.Entities;

namespace Application.Features.User.Queries.GetAll
{
    public class GetAllUserQueryResponse
    {
        public int TotalCount { get; set; }
        public object Users { get; set; }
    }
}