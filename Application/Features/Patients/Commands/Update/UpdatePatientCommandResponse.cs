﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Patients.Commands.Update
{
    public class UpdatePatientCommandResponse
    {
        public int PatientId { get; set; }
        public string BloodType { get; set; }
        
    }
}
