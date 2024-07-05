using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reports.Queries.GetAllByPatient
{
    public class GetAllReportsByPatientQueryResponse
    {
        public int Id { get; set; }

        public string DoctorName { get; set; }

        public string DoctorSpecialization { get; set; }

        public string CreatedDate { get; set; }

        public string Diagnosis { get; set; }


    }
}
