using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Appointment : Entity
    {
        public DateTime AppointmentTime { get; set; }
        public AppointmentStatus Status { get; set; }
    }


    public enum AppointmentStatus
    {
        Scheduled,
        Completed,
        Canceled
    }
}
