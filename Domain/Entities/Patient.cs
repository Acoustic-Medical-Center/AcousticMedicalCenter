using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Patient : Entity
    {
        public DateTime DateTime { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
    }
}
