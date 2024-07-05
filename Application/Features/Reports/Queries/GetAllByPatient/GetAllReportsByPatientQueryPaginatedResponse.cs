using Application.Features.Appointment.Queries.GetAllByPatient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reports.Queries.GetAllByPatient
{
    public class GetAllReportsByPatientQueryPaginatedResponse
    {
        public List<GetAllReportsByPatientQueryResponse> Items { get; set; }
        public int TotalCount { get; set; }
    }
}
