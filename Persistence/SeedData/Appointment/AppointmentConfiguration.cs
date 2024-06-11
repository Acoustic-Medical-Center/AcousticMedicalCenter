using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.Appointment
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Domain.Entities.Appointment>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Appointment> builder)
        {
            builder.HasData(
               new Domain.Entities.Appointment
               {
                   Id = 1,
                   PatientId = 1,
                   DoctorId = 3,

                   Status = Domain.Entities.AppointmentStatus.Scheduled,
                   AppointmentTime = DateTime.Now,
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               }
           );

            builder.HasData(
               new Domain.Entities.Appointment
               {
                   Id = 2,
                   PatientId = 1,
                   DoctorId = 4,

                   Status = Domain.Entities.AppointmentStatus.Scheduled,
                   AppointmentTime = DateTime.Now,
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               }
           );

            builder.HasData(
               new Domain.Entities.Appointment
               {
                   Id = 3,
                   PatientId = 2,
                   DoctorId = 3,

                   Status = Domain.Entities.AppointmentStatus.Scheduled,
                   AppointmentTime = DateTime.Now,
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               }
           );

            builder.HasData(
               new Domain.Entities.Appointment
               {
                   Id = 4,
                   PatientId = 2,
                   DoctorId = 4,

                   Status = Domain.Entities.AppointmentStatus.Scheduled,
                   AppointmentTime = DateTime.Now,
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               }
           );
        }
    }
}
