using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class AppointmentRepository : EfRepositoryBase<Appointment, AcousticDbContext>, IAppointmentRepository
    {
        private readonly AcousticDbContext _context;

        public AppointmentRepository(AcousticDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> IsAppointmentSlotAvailable(int doctorId, DateTime appointmentTime)
        {
            var startOfHour = new DateTime(appointmentTime.Year, appointmentTime.Month, appointmentTime.Day, appointmentTime.Hour, 0, 0);
            var endOfHour = startOfHour.AddHours(1);

            return !await _context.Appointments.AnyAsync(a => a.DoctorId == doctorId && a.AppointmentTime >= startOfHour && a.AppointmentTime < endOfHour && a.Status != AppointmentStatus.Canceled );
        }
    }
}
