using Core.DataAccess;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Appointment : Entity, ISoftDeletable
    {
        public DateTime AppointmentTime { get; set; }
        public AppointmentStatus Status { get; set; }
        public bool IsDeleted { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }



        public virtual Report Report { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }



    public enum AppointmentStatus
    {
        Scheduled,
        Completed,
        Canceled
    }
}
