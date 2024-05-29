using Domain.Entities;

namespace Application.Features.User.Queries.GetAll
{
    public class UserGetAllResponse
    {
        public int TotalCount { get; set; }
        public object Users { get; set; }
    }
}