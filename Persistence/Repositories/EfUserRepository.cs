﻿using Application.Repositories;
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
    public class EfUserRepository : EfRepositoryBase<User, AcousticDbContext>, IUserRepository
    {
        public EfUserRepository(AcousticDbContext context) : base(context)
        {
        }
    }
}
