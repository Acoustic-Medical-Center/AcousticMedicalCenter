using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Prescriptions.Queries.GetAllByPatient
{
    public class GetAllPrescriptionsByPatientQueryResponse
    {
        public int Id { get; set; }

        //public string PatientName { get; set; }

        public string DoctorName { get; set; }

        public string MedicationDetails { get; set; }
        public string DosageInstructions { get; set; }

        public string CreatedDate { get; set; }

    }
}
