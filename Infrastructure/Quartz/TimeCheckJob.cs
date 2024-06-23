using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Quartz
{
    public class CheckAppointmentTimeJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            DateTime now = DateTime.Now;
            if (now.Minute % 5 == 0)
            {
                Console.WriteLine($"Current Time: {now}");
            }
            return Task.CompletedTask;
        }
    }
}
