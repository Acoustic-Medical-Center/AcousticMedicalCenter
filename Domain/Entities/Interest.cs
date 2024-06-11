using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Interest : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<DoctorInterest> DoctorInterests { get; set; }
    }
}
