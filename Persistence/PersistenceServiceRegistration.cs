using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory()));
            //Console.WriteLine(Directory.GetCurrentDirectory());
            configurationManager.AddJsonFile("appsettings.json");

            services.AddDbContext<AcousticDbContext>(options => options.UseSqlServer(configurationManager.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUserRepository, EfUserRepository>();
            services.AddScoped<IUserOperationClaimRepository, EfUserOperationClaimRepository>();
            services.AddScoped<IOperationClaimRepository, EfOperationClaimRepository>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IDoctorSpecializationRepository, DoctorSpecializationRepository>();
            services.AddScoped<IReportRepository, ReportRepository>();

            return services;
        }
    }
}
