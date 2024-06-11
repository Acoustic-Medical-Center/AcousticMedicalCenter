using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Report : Entity
    {



        //public string PatientName { get; set; }
        //public DateTime PatientBirthDate { get; set; }
        //public string PatientGender { get; set; }

        public string ExaminationFindings { get; set; }

        public string Diagnosis { get; set; }


        //public string DoctorName { get; set; }
        //public string DoctorSpecialization { get; set; }



        public int AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}
