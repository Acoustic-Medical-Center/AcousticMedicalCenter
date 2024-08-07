﻿using Core.DataAccess;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Doctor : Entity, ISoftDeletable
    {
        public int Experience { get; set; }

        public User User { get; set; }

        public DoctorSpecialization DoctorSpecialization { get; set; }
        public int DoctorSpecializationId { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }

        public virtual ICollection<DoctorInterest> DoctorInterest { get; set; }

        public string? Biography { get; set; }
        public bool IsDeleted { get; set; }
    }


}
