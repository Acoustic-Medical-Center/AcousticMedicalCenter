using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.Prescription
{
    public class PrescriptionConfiguration : IEntityTypeConfiguration<Domain.Entities.Prescription>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Prescription> builder)
        {
            builder.HasData(
   new Domain.Entities.Prescription
   {
       Id = 1,
       AppointmentId = 1,
       DosageInstructions = "Her 8 saatte bir ağızdan bir tablet alın.",
       MedicationDetails = "Amoksisilin 500mg",
       IsDeleted = false,
       CreatedDate = DateTime.Now,
   });

            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 2,
                   AppointmentId = 1,
                   DosageInstructions = "Her 12 saatte bir ağızdan iki tablet alın.",
                   MedicationDetails = "İbuprofen 200mg",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });

            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 3,
                   AppointmentId = 1,
                   DosageInstructions = "Etkilenen bölgeye günde iki kez krem uygulayın.",
                   MedicationDetails = "Hidrokortizon Kremi %1",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });

            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 4,
                   AppointmentId = 1,
                   DosageInstructions = "Her sabah ağızdan bir kapsül alın.",
                   MedicationDetails = "Omeprazol 20mg",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });

            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 5,
                   AppointmentId = 1,
                   DosageInstructions = "İhtiyaç duyulduğunda her 4-6 saatte bir iki püskürtme yapın.",
                   MedicationDetails = "Albuterol İnhalatörü",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });

            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 6,
                   AppointmentId = 1,
                   DosageInstructions = "Her gece yatmadan önce ağızdan bir tablet alın.",
                   MedicationDetails = "Metformin 500mg",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });

            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 7,
                   AppointmentId = 1,
                   DosageInstructions = "Günde bir kez ağızdan bir tablet alın.",
                   MedicationDetails = "Lisinopril 10mg",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });

            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 8,
                   AppointmentId = 1,
                   DosageInstructions = "Ağrı için gerektiğinde her 6 saatte bir ağızdan bir tablet alın.",
                   MedicationDetails = "Asetaminofen 500mg",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });

            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 9,
                   AppointmentId = 1,
                   DosageInstructions = "Günde iki kez ağızdan bir tablet alın.",
                   MedicationDetails = "Atenolol 50mg",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });

            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 10,
                   AppointmentId = 1,
                   DosageInstructions = "Etkilenen göze/gözlere günde iki kez damla uygulayın.",
                   MedicationDetails = "Timolol Göz Damlası",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });

        }
    }
}
