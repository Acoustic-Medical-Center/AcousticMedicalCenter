using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
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

            services.AddDbContext<AcousticDbContext>(options => options.UseSqlServer("Data Source = localhost, 1433; Initial Catalog = AcousticDbTest; User ID = sa; Password = yourStrong(!)Password;TrustServerCertificate = True"));

            return services;
        }
    }
}
