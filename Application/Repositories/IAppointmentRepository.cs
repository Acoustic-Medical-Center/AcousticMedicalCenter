using Core.DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IAppointmentRepository : IRepository<Appointment>, IAsyncRepository<Appointment>
    {
        Task<(bool isAvailable, DateTime roundedAppointmentTime)> CheckAndRoundAppointmentTimeAsync(int doctorId, DateTime appointmentTime);
    }
}
