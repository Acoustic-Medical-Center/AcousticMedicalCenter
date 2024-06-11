using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DoctorInterest
    {
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        public int InterestId { get; set; }
        public virtual Interest Interest { get; set; }
    }
}
