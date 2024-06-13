using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Prescriptions.Commands.Create
{
    public class CreatePrescriptionCommandResponse
    {

        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public string MedicationDetails { get; set; }
        public string DosageInstructions { get; set; }

    }
}
