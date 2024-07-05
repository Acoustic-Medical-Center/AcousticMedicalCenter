using Application.Features.Appointment.Queries.GetAllByPatient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Prescriptions.Queries.GetAllByPatient
{
    public class GetAllPrescriptionsByPatientQueryPaginatedResponse
    {
        public List<GetAllPrescriptionsByPatientQueryResponse> Items { get; set; }
        public int TotalCount { get; set; }
    }
}
