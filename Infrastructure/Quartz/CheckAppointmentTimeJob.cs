using Application.Repositories;
using Application.Services;
using Microsoft.EntityFrameworkCore;
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
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMailService _mailService;

        public CheckAppointmentTimeJob(IAppointmentRepository appointmentRepository, IMailService mailService)
        {
            _appointmentRepository = appointmentRepository;
            _mailService = mailService;
        }
        public async Task Execute(IJobExecutionContext context)
        {
            var appsToSendMail = await _appointmentRepository.GetListAsync(appointment => appointment.AppointmentTime >= DateTime.Now &&
                appointment.AppointmentTime <= DateTime.Now.AddHours(48),
                include: app => app.Include(app => app.Patient).ThenInclude(app => app.User));

            if (appsToSendMail != null)
            {
                foreach (var item in appsToSendMail)
                {
                    await _mailService.SendEmailAsync(item.Patient.User.Email,
                        "Randevunuz var",
                        $"{item.AppointmentTime} tarihli randevunuz yaklaşmaktadır. Lütfen bir değişiklik durumunda bizimle iletişime geçiniz");
                }
            }
        }
    }
}
