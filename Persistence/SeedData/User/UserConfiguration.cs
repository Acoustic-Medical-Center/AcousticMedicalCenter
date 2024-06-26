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
            new User { Id = 4, FirstName = "Fatma", LastName = "Koç", Email = "doktor4@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500004", Gender = "Female", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 5, FirstName = "Mehmet", LastName = "Öz", Email = "doktor5@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500005", Gender = "Male", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 6, FirstName = "Canan", LastName = "Çelik", Email = "doktor6@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500006", Gender = "Female", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 7, FirstName = "Emre", LastName = "Arı", Email = "doktor7@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500007", Gender = "Male", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 8, FirstName = "Burak", LastName = "Temiz", Email = "doktor8@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500008", Gender = "Male", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 9, FirstName = "Seda", LastName = "Ak", Email = "doktor9@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500009", Gender = "Female", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 10, FirstName = "Murat", LastName = "Tez", Email = "doktor10@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500010", Gender = "Male", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 11, FirstName = "Zeynep", LastName = "Bal", Email = "doktor11@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500011", Gender = "Female", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 12, FirstName = "Kemal", LastName = "Sağ", Email = "doktor12@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500012", Gender = "Male", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 13, FirstName = "Cansu", LastName = "Dur", Email = "doktor13@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500013", Gender = "Female", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
             new User { Id = 14, FirstName = "Oğuz", LastName = "Kurt", Email = "doktor14@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500014", Gender = "Male", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 15, FirstName = "Esra", LastName = "Deniz", Email = "doktor15@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500015", Gender = "Female", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 16, FirstName = "Baran", LastName = "Gül", Email = "doktor16@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500016", Gender = "Male", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 17, FirstName = "Duygu", LastName = "Aydın", Email = "doktor17@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500017", Gender = "Female", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 18, FirstName = "Tarkan", LastName = "Kara", Email = "doktor18@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500018", Gender = "Male", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 19, FirstName = "Nil", LastName = "Koç", Email = "doktor19@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500019", Gender = "Female", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 20, FirstName = "Sami", LastName = "Öztürk", Email = "doktor20@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500020", Gender = "Male", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 21, FirstName = "Ece", LastName = "Uzun", Email = "doktor21@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500021", Gender = "Female", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 22, FirstName = "Levent", LastName = "Yıldız", Email = "doktor22@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500022", Gender = "Male", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 23, FirstName = "Selin", LastName = "Demirci", Email = "doktor23@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500023", Gender = "Female", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 24, FirstName = "Onur", LastName = "Akar", Email = "doktor24@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500024", Gender = "Male", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 25, FirstName = "İrem", LastName = "Dere", Email = "doktor25@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500025", Gender = "Female", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 26, FirstName = "Cenk", LastName = "Taş", Email = "doktor26@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500026", Gender = "Male", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow },
            new User { Id = 27, FirstName = "Hande", LastName = "Yener", Email = "doktor27@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, PhoneNumber = "1234500027", Gender = "Female", UserType = UserType.Doctor, CreatedDate = DateTime.UtcNow }
            );

            builder.HasData(
               new User
               {
                   Id = 99,
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
                    Biography = "Id 3 olan Doktor Özgeçmiş Example asd",
                    Experience = 10,
                    CreatedDate = DateTime.UtcNow
                }
            );

            builder.HasData(
                new Domain.Entities.Doctor
                {
                    Id = 4,
                    DoctorSpecializationId = 2,
                    Biography = "Kalp Doktoru Özgeçmiş Example",
                    Experience = 5,
                    CreatedDate = DateTime.UtcNow
                },
                new Doctor { Id = 5, DoctorSpecializationId = 7, Biography = "Göz Doktoru Özgeçmiş Example", Experience = 3, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 6, DoctorSpecializationId = 1, Biography = "Ortopedi Doktoru Özgeçmiş Example", Experience = 10, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 7, DoctorSpecializationId = 4, Biography = "Dahiliye Doktoru Özgeçmiş Example", Experience = 8, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 8, DoctorSpecializationId = 6, Biography = "Nöroloji Doktoru Özgeçmiş Example", Experience = 6, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 9, DoctorSpecializationId = 9, Biography = "Psikiyatri Doktoru Özgeçmiş Example", Experience = 7, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 10, DoctorSpecializationId = 5, Biography = "Pediatri Doktoru Özgeçmiş Example", Experience = 2, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 11, DoctorSpecializationId = 10, Biography = "Dermatoloji Doktoru Özgeçmiş Example", Experience = 4, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 12, DoctorSpecializationId = 8, Biography = "Kulak Burun Boğaz Doktoru Özgeçmiş Example", Experience = 9, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 13, DoctorSpecializationId = 3, Biography = "Genel Cerrahi Doktoru Özgeçmiş Example", Experience = 6, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 14, DoctorSpecializationId = 2, Biography = "Kalp Doktoru Özgeçmiş Example", Experience = 5, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 15, DoctorSpecializationId = 7, Biography = "Göz Doktoru Özgeçmiş Example", Experience = 3, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 16, DoctorSpecializationId = 1, Biography = "Ortopedi Doktoru Özgeçmiş Example", Experience = 10, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 17, DoctorSpecializationId = 4, Biography = "Dahiliye Doktoru Özgeçmiş Example", Experience = 8, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 18, DoctorSpecializationId = 6, Biography = "Nöroloji Doktoru Özgeçmiş Example", Experience = 6, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 19, DoctorSpecializationId = 9, Biography = "Psikiyatri Doktoru Özgeçmiş Example", Experience = 7, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 20, DoctorSpecializationId = 5, Biography = "Pediatri Doktoru Özgeçmiş Example", Experience = 2, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 21, DoctorSpecializationId = 10, Biography = "Dermatoloji Doktoru Özgeçmiş Example", Experience = 4, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 22, DoctorSpecializationId = 8, Biography = "Kulak Burun Boğaz Doktoru Özgeçmiş Example", Experience = 9, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 23, DoctorSpecializationId = 3, Biography = "Genel Cerrahi Doktoru Özgeçmiş Example", Experience = 6, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 24, DoctorSpecializationId = 2, Biography = "Kalp Doktoru Özgeçmiş Example", Experience = 5, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 25, DoctorSpecializationId = 1, Biography = "Ortopedi Doktoru Özgeçmiş Example", Experience = 4, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 26, DoctorSpecializationId = 5, Biography = "Pediatri Doktoru Özgeçmiş Example", Experience = 7, CreatedDate = DateTime.UtcNow },
                new Doctor { Id = 27, DoctorSpecializationId = 8, Biography = "Kulak Burun Boğaz Doktoru Özgeçmiş Example", Experience = 3, CreatedDate = DateTime.UtcNow }
            );
        }


    }
}
