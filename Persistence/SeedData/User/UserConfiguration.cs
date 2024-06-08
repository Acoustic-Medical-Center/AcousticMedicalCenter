using Core.Entities;
using Core.Utilities.Hashing;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.Patient
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Kullanıcı için parola hash ve salt oluşturma
            HashingHelper.CreatePasswordHash("123456", out byte[] passwordHash, out byte[] passwordSalt);

            // User seed
            builder.HasData(
                new User
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "hasta1@example.com",
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    PhoneNumber = "1234567890",
                    Gender = "Male",
                    UserType = UserType.Patient,
                    CreatedDate = DateTime.UtcNow
                }
            );

            builder.HasData(
                new User
                {
                    Id = 2,
                    FirstName = "Jonathan",
                    LastName = "Corwin",
                    Email = "hasta2@example.com",
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    PhoneNumber = "1234512345",
                    Gender = "Male",
                    UserType = UserType.Patient,
                    CreatedDate = DateTime.UtcNow
                }
            );

            builder.HasData(
                new User
                {
                    Id = 3,
                    FirstName = "batu",
                    LastName = "cerrahlar",
                    Email = "doktor1@example.com",
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    PhoneNumber = "1234512312",
                    Gender = "Male",
                    UserType = UserType.Doctor,
                    CreatedDate = DateTime.UtcNow
                }
            );

            builder.HasData(
                new User
                {
                    Id = 4,
                    FirstName = "kalp",
                    LastName = "doktoru",
                    Email = "doktor2@example.com",
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    PhoneNumber = "1234512313",
                    Gender = "Male",
                    UserType = UserType.Doctor,
                    CreatedDate = DateTime.UtcNow
                }
            );

            builder.HasData(
               new User
               {
                   Id = 5,
                   FirstName = "Admin",
                   LastName = "Yöneticioğlu",
                   Email = "admin@example.com",
                   PasswordHash = passwordHash,
                   PasswordSalt = passwordSalt,
                   PhoneNumber = "1234512345",
                   Gender = "Male",
                   UserType = UserType.Admin,
                   CreatedDate = DateTime.UtcNow
               }
           );
        }
    }
    public class PatientConfiguration : IEntityTypeConfiguration<Domain.Entities.Patient>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Patient> builder)
        {
            // Patient seed
            builder.HasData(
                new Domain.Entities.Patient
                {
                    Id = 1,
                    Address = "1234 Main St",
                    BloodType = "A+",
                    CreatedDate = DateTime.UtcNow
                }
            );

            builder.HasData(
                new Domain.Entities.Patient
                {
                    Id = 2,
                    Address = "1233 Main St",
                    BloodType = "B+",
                    CreatedDate = DateTime.UtcNow
                }
            );
        }
    }
    public class DoctorConfiguration : IEntityTypeConfiguration<Domain.Entities.Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(
                new Domain.Entities.Doctor
                {
                    Id = 3,
                    DoctorSpecializationId = 1,
                    Experience = 10,
                    CreatedDate = DateTime.UtcNow
                }
            );

            builder.HasData(
                new Domain.Entities.Doctor
                {
                    Id = 4,
                    DoctorSpecializationId = 2,
                    Experience = 5,
                    CreatedDate = DateTime.UtcNow
                }
            );
        }


    }
}
