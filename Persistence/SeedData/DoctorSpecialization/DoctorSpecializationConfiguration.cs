using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.DoctorSpecialization
{
    public class DoctorSpecializationConfiguration : IEntityTypeConfiguration<Domain.Entities.DoctorSpecialization>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Entities.DoctorSpecialization> builder)
        {
            builder.HasData(
                new Domain.Entities.DoctorSpecialization
                {
                    Id = 1,
                    Name = "Cerrah",
                    CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
                new Domain.Entities.DoctorSpecialization
                {
                    Id = 2,
                    Name = "Kalp",
                    CreatedDate = DateTime.Now,
                }
            );
        }
    }
}
