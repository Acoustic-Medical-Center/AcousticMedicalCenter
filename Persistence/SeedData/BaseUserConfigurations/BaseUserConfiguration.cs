using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class BaseUserConfiguration : IEntityTypeConfiguration<BaseUser>
{
    public void Configure(EntityTypeBuilder<BaseUser> builder)
    {
        builder.Property(u => u.FirstName)
               .HasColumnName("FirstName")
               .IsRequired()
               .HasMaxLength(256);

        builder.Property(u => u.LastName)
               .HasColumnName("LastName")
               .IsRequired()
               .HasMaxLength(256);
    }
}