using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.OperationClaim
{
    public class OperationClaimConfiguration : IEntityTypeConfiguration<Domain.Entities.OperationClaim>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.OperationClaim> builder)
        {
            builder.HasData(
                new Domain.Entities.OperationClaim
                {
                    Id = 1,
                    Name = "Admin",
                    CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
                new Domain.Entities.OperationClaim
                {
                    Id = 2,
                    Name = "Appointment.Delete",
                    CreatedDate = DateTime.Now,
                }
            );
        }
    }

    public class UserOperationClaimConfiguration : IEntityTypeConfiguration<Domain.Entities.UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.UserOperationClaim> builder)
        {
            builder.HasData(
                new Domain.Entities.UserOperationClaim
                {
                    Id = 1,
                    UserId = 5,
                    OperationClaimId = 1,
                    CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
                new Domain.Entities.UserOperationClaim
                {
                    Id = 2,
                    UserId = 3,
                    OperationClaimId = 2,
                    CreatedDate = DateTime.Now,
                }
            );
        }
    }
}
