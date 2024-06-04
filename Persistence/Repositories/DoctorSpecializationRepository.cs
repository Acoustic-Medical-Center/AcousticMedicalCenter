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
    public class DoctorSpecializationRepository : EfRepositoryBase<DoctorSpecialization, AcousticDbContext>, IDoctorSpecializationRepository
    {
        public DoctorSpecializationRepository(AcousticDbContext context) : base(context)
        {
        }
    }
}
