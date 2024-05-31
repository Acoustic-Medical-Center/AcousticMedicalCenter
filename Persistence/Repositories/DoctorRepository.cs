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
    public class DoctorRepository : EfRepositoryBase<Doctor, AcousticDbContext>, IDoctorRepository
    {
        public DoctorRepository(AcousticDbContext context) : base(context)
        {
        }
    }
}
