﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.Reports
{
    public class ReportConfiguration : IEntityTypeConfiguration<Domain.Entities.Report>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Report> builder)
        {
            builder.HasData(
               new Domain.Entities.Report
               {
                   Id = 1,
                   AppointmentId = 1,

                   CreatedDate = DateTime.Now,

                   Diagnosis = " Hipertansiyon",

                   ExaminationFindings = "Yüksek kan basıncı",
               }
           );

            builder.HasData(
               new Domain.Entities.Report
               {
                   Id = 2,
                   AppointmentId = 2,

                   CreatedDate = DateTime.Now,

                   Diagnosis = " Hipertansiyon",

                   ExaminationFindings = "Yüksek kan basıncı",
               }
           );

            builder.HasData(
               new Domain.Entities.Report
               {
                   Id = 3,
                   AppointmentId = 3,

                   CreatedDate = DateTime.Now,

                   Diagnosis = "Diabetes Mellitus",

                   ExaminationFindings = "Fasting blood sugar level of 140 mg/dL",
               }
           );

            builder.HasData(
               new Domain.Entities.Report
               {
                   Id = 4,
                   AppointmentId = 4,

                   CreatedDate = DateTime.Now,

                   Diagnosis = "Chronic Obstructive Pulmonary Disease (COPD)",

                   ExaminationFindings = "Reduced lung function on spirometry",
               }
           );
        }
    }
}