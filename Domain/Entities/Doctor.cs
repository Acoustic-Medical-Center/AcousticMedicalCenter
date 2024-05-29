using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Doctor : Entity
    {
        public string Specialization { get; set; }
        public int Experience { get; set; }

    }
}
