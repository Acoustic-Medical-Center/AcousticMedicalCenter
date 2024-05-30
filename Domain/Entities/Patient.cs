using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Patient : Entity
    {
        public string? Address { get; set; }
        public string? BloodType { get; set; }

        public User User { get; set; }

        public int AppointmentId { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }

    }
}
