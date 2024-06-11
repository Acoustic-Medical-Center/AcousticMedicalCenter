using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reports.Commands.Create
{
    public class CreateReportCommandResponse
    {

        public int Id { get; set; }
        public int AppointmentId { get; set; }

        public string ExaminationFindings { get; set; }
        public string Diagnosis { get; set; }
    }
}
