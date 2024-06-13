using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Prescriptions.Queries.GetAllByDoctor
{
    public class GetAllPrescriptionsByDoctorQueryResponse
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string MedicationDetails { get; set; }
        public string DosageInstructions { get; set; }
        public string CreatedDate { get; set; }
    }
}
