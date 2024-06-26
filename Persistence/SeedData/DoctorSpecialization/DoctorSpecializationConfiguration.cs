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
                     NameTR = "Beyin ve Sinir Cerrahisi",
                     NameEN = "Neurosurgery",
                     CreatedDate = DateTime.Now
                 },
                 new Domain.Entities.DoctorSpecialization
                 {
                     Id = 2,
                     NameTR = "Dermatoloji",
                     NameEN = "Dermatology",
                     CreatedDate = DateTime.Now
                 },
                 new Domain.Entities.DoctorSpecialization
                 {
                     Id = 3,
                     NameTR = "Genel Cerrahi",
                     NameEN = "General Surgery",
                     CreatedDate = DateTime.Now
                 },
                 new Domain.Entities.DoctorSpecialization
                 {
                     Id = 4,
                     NameTR = "Göz Hastalıkları",
                     NameEN = "Ophthalmology",
                     CreatedDate = DateTime.Now
                 },
                 new Domain.Entities.DoctorSpecialization
                 {
                     Id = 5,
                     NameTR = "İç Hastalıkları",
                     NameEN = "Internal Medicine",
                     CreatedDate = DateTime.Now
                 },
                 new Domain.Entities.DoctorSpecialization
                 {
                     Id = 6,
                     NameTR = "Kadın Hastalıkları ve Doğum",
                     NameEN = "Obstetrics and Gynecology",
                     CreatedDate = DateTime.Now
                 },
                 new Domain.Entities.DoctorSpecialization
                 {
                     Id = 7,
                     NameTR = "Kulak Burun Boğaz",
                     NameEN = "Otorhinolaryngology",
                     CreatedDate = DateTime.Now
                 },
                 new Domain.Entities.DoctorSpecialization
                 {
                     Id = 8,
                     NameTR = "Ortopedi ve Travmatoloji",
                     NameEN = "Orthopedics and Traumatology",
                     CreatedDate = DateTime.Now
                 },
                 new Domain.Entities.DoctorSpecialization
                 {
                     Id = 9,
                     NameTR = "Üroloji",
                     NameEN = "Urology",
                     CreatedDate = DateTime.Now
                 },
                 new Domain.Entities.DoctorSpecialization
                 {
                     Id = 10,
                     NameTR = "Çocuk Sağlığı ve Hastalıkları",
                     NameEN = "Pediatrics",
                     CreatedDate = DateTime.Now
                 }
                 );
        }
    }
}
