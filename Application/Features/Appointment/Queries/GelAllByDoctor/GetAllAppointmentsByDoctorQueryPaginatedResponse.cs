using Application.Features.Appointment.Queries.GetAllByPatient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Appointment.Queries.GelAllByDoctor
{
    public class GetAllAppointmentsByDoctorQueryPaginatedResponse
    {
        public List<GetAllAppointmentsByDoctorQueryResponse> Items { get; set; }
        public int TotalCount { get; set; }
    }
}
