using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DoctorSpecialization : Entity
    {
        public string NameTR { get; set; }
        public string NameEN { get; set; }
    }
}
