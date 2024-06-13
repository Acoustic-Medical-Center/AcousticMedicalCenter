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
    public class PrescriptionRepository : EfRepositoryBase<Prescription, AcousticDbContext>, IPrescriptionRepository
    {
        public PrescriptionRepository(AcousticDbContext context) : base(context)
        {
        }
    }
}
