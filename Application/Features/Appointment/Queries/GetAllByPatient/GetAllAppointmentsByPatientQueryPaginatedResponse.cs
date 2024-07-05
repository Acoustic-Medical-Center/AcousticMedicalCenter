using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Queries.GetAllByPatient
{
    public class GetAllAppointmentsByPatientQueryPaginatedResponse
    {
        public List<GetAllAppointmentsByPatientQueryResponse> Items { get; set; }
        public int TotalCount { get; set; }
    }
}
