using Domain.Entities;

namespace Application.Features.User.Queries.GetById
{
    public class UserGetByIdResponse
    {
        public Domain.Entities.User User { get; set; }
    }
}