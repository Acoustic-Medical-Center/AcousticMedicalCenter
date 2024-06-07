using Core.DataAccess;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class AcousticDbContext : DbContext
    {
        public AcousticDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<DoctorSpecialization> DoctorSpecializations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Patient>()
            .Property(p => p.Id)
            .ValueGeneratedNever();

            modelBuilder.Entity<Doctor>()
            .Property(d => d.Id)
            .ValueGeneratedNever();

            modelBuilder.Entity<Patient>()
            .HasOne(p => p.User)
            .WithOne(u => u.Patient)
            .HasForeignKey<Patient>(p => p.Id)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Doctor>()
            .HasOne(d => d.User)
            .WithOne(u => u.Doctor)
            .HasForeignKey<Doctor>(d => d.Id)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Doctor>()
            .HasMany(d => d.Appointment)
            .WithOne(a => a.Doctor)
            .HasForeignKey(a => a.DoctorId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Patient>()
            .HasMany(p => p.Appointment)
            .WithOne(a => a.Patient)
            .HasForeignKey(a => a.PatientId)
            .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Appointment>().HasQueryFilter(e => !e.IsDeleted);
        }
        //{
        //    modelBuilder.Entity<User>()
        //        .HasOne(u => u.Doctor)
        //        .WithOne(d => d.User)
        //        .HasForeignKey<Doctor>(d => d.Id);

        //    modelBuilder.Entity<User>()
        //        .HasOne(u => u.Patient)
        //        .WithOne(p => p.User)
        //        .HasForeignKey<Patient>(p => p.Id);

        //    modelBuilder.Entity<Doctor>()
        //        .HasMany(d => d.Appointment)
        //        .WithOne(a => a.Doctor)
        //        .HasForeignKey(a => a.DoctorId);

        //    modelBuilder.Entity<Patient>()
        //        .HasMany(p => p.Appointment)
        //        .WithOne(a => a.Patient)
        //        .HasForeignKey(a => a.PatientId);
        //}
        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<Entity>();

            foreach (var item in datas)
            {
                if (item.Entity is ISoftDeletable entity && item.State == EntityState.Deleted)
                {
                    item.State = EntityState.Modified;
                    entity.IsDeleted = true;
                }
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.CreatedDate = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        item.Entity.UpdatedDate = DateTime.UtcNow;
                        break;
                    default:
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);

        }

    }
}
