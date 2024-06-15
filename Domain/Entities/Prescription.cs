using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Prescription : Entity
    {

        public string MedicationDetails { get; set; }
        public string DosageInstructions { get; set; }
        public PrescriptionStatus PrescriptionStatus { get; set; }
        public int AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
    }

    public enum PrescriptionStatus
    {
        Active,
        Passive
    }
}
