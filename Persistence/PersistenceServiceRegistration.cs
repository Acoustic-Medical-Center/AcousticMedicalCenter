using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class PersistenceServiceRegistration
    {

        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {

            services.AddDbContext<AcousticDbContext>(options => options.UseSqlServer("Server=localhost; Database=AMC.Test; Trusted_Connection=True; TrustServerCertificate=True;"));
            services.AddScoped<IUserRepository, EfUserRepository>();
            services.AddScoped<IUserOperationClaimRepository, EfUserOperationClaimRepository>();
            services.AddScoped<IOperationClaimRepository, EfOperationClaimRepository>();

            return services;
        }
    }
}
