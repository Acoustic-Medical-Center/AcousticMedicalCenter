using Core.DataAccess;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Prescription : Entity, ISoftDeletable
    {

        public string MedicationDetails { get; set; }
        public string DosageInstructions { get; set; }
        public int AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
        public bool IsDeleted { get; set; }
    }
}
