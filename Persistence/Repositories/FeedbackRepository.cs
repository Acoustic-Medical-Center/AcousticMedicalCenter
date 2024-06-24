using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class FeedbackRepository : EfRepositoryBase<Feedback, AcousticDbContext>, IFeedbackRepository
    {
        public FeedbackRepository(AcousticDbContext context) : base(context)
        {
        }
    }
}
