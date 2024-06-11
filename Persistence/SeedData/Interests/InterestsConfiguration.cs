using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.Interests
{
    public class InterestsConfiguration : IEntityTypeConfiguration<Domain.Entities.Interest>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Interest> builder)
        {
            builder.HasData(
                new Domain.Entities.Interest
                {
                    Id = 1,
                    Name = "Kardiyoloji Araştırmaları",
                    CreatedDate = DateTime.Now,
                }

            );

            builder.HasData(
                new Domain.Entities.Interest
                {
                    Id = 2,
                    Name = "Çocuk Sağlığı",
                    CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
                new Domain.Entities.Interest
                {
                    Id = 3,
                    Name = "Onkoloji Tedavi",
                    CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
                new Domain.Entities.Interest
                {
                    Id = 4,
                    Name = "Nöroloji ve Beyin Cerrahisi",
                    CreatedDate = DateTime.Now,
                }
            );


            builder.HasData(
                new Domain.Entities.Interest
                {
                    Id = 5,
                    Name = "Endokrinoloji ve Metabolizma",
                    CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
                new Domain.Entities.Interest
                {
                    Id = 6,
                    Name = "Gastroenteroloji ve Sindirim Sistemi",
                    CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
                new Domain.Entities.Interest
                {
                    Id = 7,
                    Name = "Psikiyatri ve Mental Sağlık",
                    CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
                new Domain.Entities.Interest
                {
                    Id = 8,
                    Name = "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri",
                    CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
              new Domain.Entities.Interest
              {
                  Id = 9,
                  Name = "Parkinson Hastalığı",
                  CreatedDate = DateTime.Now,
              }
          );

            builder.HasData(
              new Domain.Entities.Interest
              {
                  Id = 10,
                  Name = "Bunama",
                  CreatedDate = DateTime.Now,
              }
          );


        }

        public class DoctorInterestConfiguration : IEntityTypeConfiguration<Domain.Entities.DoctorInterest>
        {
            public void Configure(EntityTypeBuilder<Domain.Entities.DoctorInterest> builder)
            {
                builder.HasData(
                    new Domain.Entities.DoctorInterest
                    {

                        DoctorId = 3,
                        InterestId = 1,

                    }
                );

                builder.HasData(
                    new Domain.Entities.DoctorInterest
                    {

                        DoctorId = 3,
                        InterestId = 2,

                    }
                );

                builder.HasData(
                new Domain.Entities.DoctorInterest
                {

                    DoctorId = 4,
                    InterestId = 7,

                }
            );

                builder.HasData(
                new Domain.Entities.DoctorInterest
                {

                    DoctorId = 4,
                    InterestId = 8,

                }
            );
            }
        }
    }
}
