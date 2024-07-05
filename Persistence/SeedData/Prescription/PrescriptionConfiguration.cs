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
                   DosageInstructions = "Take one tablet by mouth every 8 hours.",
                   MedicationDetails = "Amoxicillin 500mg",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });

            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 2,
                   AppointmentId = 1,
                   DosageInstructions = "Take two tablets by mouth every 12 hours.",
                   MedicationDetails = "Ibuprofen 200mg",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });
            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 3,
                   AppointmentId = 1,
                   DosageInstructions = "Apply cream to the affected area twice daily.",
                   MedicationDetails = "Hydrocortisone Cream 1%",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });
            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 4,
                   AppointmentId = 1,
                   DosageInstructions = "Take one capsule by mouth every morning.",
                   MedicationDetails = "Omeprazole 20mg",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });
            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 5,
                   AppointmentId = 1,
                   DosageInstructions = "Inhale two puffs every 4-6 hours as needed.",
                   MedicationDetails = "Albuterol Inhaler",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });
            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 6,
                   AppointmentId = 1,
                   DosageInstructions = "Take one tablet by mouth every night before bed.",
                   MedicationDetails = "Metformin 500mg",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });
            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 7,
                   AppointmentId = 1,
                   DosageInstructions = "Take one tablet by mouth once daily.",
                   MedicationDetails = "Lisinopril 10mg",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });
            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 8,
                   AppointmentId = 1,
                   DosageInstructions = "Take one tablet by mouth every 6 hours as needed for pain.",
                   MedicationDetails = "Acetaminophen 500mg",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });
            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 9,
                   AppointmentId = 1,
                   DosageInstructions = "Take one tablet by mouth twice daily.",
                   MedicationDetails = "Atenolol 50mg",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });
            builder.HasData(
               new Domain.Entities.Prescription
               {
                   Id = 10,
                   AppointmentId = 1,
                   DosageInstructions = "Apply drops in the affected eye(s) twice daily.",
                   MedicationDetails = "Timolol Eye Drops",
                   IsDeleted = false,
                   CreatedDate = DateTime.Now,
               });

        }
    }
}
