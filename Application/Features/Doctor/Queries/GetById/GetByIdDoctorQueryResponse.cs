using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Doctor.Queries.GetById
{
    public class GetByIdDoctorQueryResponse
    {
        public int Id { get; set; }

        public string Experience { get; set; }

        public string Biography  { get; set; }
        public virtual ICollection<string> DoctorInterests { get; set; }



    }
}
