using Application.Services;
using Infrastructure.Quartz;
using Infrastructure.Services.EmailService;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {

            services.AddScoped<IMailService, MailService>();


            // Birden fazla quartz job yazılacaksa bu kısım farklı bir classa alınabilir
            services.AddQuartz(configure =>
            {
                // Job anahtarı
                var jobKey = new JobKey(nameof(CheckAppointmentTimeJob));

                // Job ve trigger
                configure
                    .AddJob<CheckAppointmentTimeJob>(jobKey)
                    .AddTrigger(trigger => trigger
                        .ForJob(jobKey)
                        .WithSimpleSchedule(schedule => schedule
                            .WithIntervalInSeconds(30)
                            .RepeatForever()));

                // Microsoft Dependency Injection
                configure.UseMicrosoftDependencyInjectionJobFactory();
            });

            // Quartz server ekle
            services.AddQuartzHostedService(options => options.WaitForJobsToComplete = true);

            return services;
        }
    }
}
