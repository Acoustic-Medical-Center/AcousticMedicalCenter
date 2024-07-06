using Application.Features.Appointment.Queries.GelAllByDoctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Queries.GetAllByClaim
{
    public class GetAllAppointmentsByClaimQueryPaginatedResponse
    {
        public List<GetAllAppointmentsByClaimQueryResponse> Items { get; set; }
        public int TotalCount { get; set; }
    }
}
