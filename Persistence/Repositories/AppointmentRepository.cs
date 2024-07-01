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

        public async Task<(bool isAvailable, DateTime roundedAppointmentTime)> CheckAndRoundAppointmentTimeAsync(int doctorId, DateTime appointmentTime)
        {

            var roundedAppointmentTime = new DateTime(
                appointmentTime.Year,
                appointmentTime.Month,
                appointmentTime.Day,
                appointmentTime.Hour,
                appointmentTime.Minute < 30 ? 0 : 30,
                0
            );

            var startOfSlot = roundedAppointmentTime;
            var endOfSlot = roundedAppointmentTime.AddMinutes(30);

            bool isAvailable = !await _context.Appointments.AnyAsync(a =>
                a.DoctorId == doctorId &&
                a.AppointmentTime >= startOfSlot &&
                a.AppointmentTime < endOfSlot &&
                a.Status != AppointmentStatus.Canceled);

            return (isAvailable, roundedAppointmentTime);
        }
    }
}
