﻿using Core.DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IReportRepository : IRepository<Report>, IAsyncRepository<Report>
    {
    }
}
