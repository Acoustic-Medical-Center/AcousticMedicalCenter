using Core.DataAccess;
using Core.Utilities.Hashing;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.SeedData.Appointment;
using Persistence.SeedData.DoctorSpecialization;
using Persistence.SeedData.Interests;
using Persistence.SeedData.OperationClaim;
using Persistence.SeedData.Patient;
using Persistence.SeedData.Reports;
using static Persistence.SeedData.Interests.InterestsConfiguration;

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
        public DbSet<Interest> Interests { get; set; }
        public DbSet<DoctorInterest> DoctorInterests { get; set; }



        public DbSet<Report> Reports { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<DoctorInterest>()
            .HasKey(di => new { di.DoctorId, di.InterestId });

            modelBuilder.Entity<Patient>()
            .Property(p => p.Id)
            .ValueGeneratedNever();

            modelBuilder.Entity<Report>()
            .Property(p => p.Id)
            .ValueGeneratedNever();

            modelBuilder.Entity<Appointment>()
            .HasOne(a => a.Report)
             .WithOne(r => r.Appointment)
             .HasForeignKey<Report>(r => r.AppointmentId);

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

            modelBuilder.ApplyConfiguration(new DoctorSpecializationConfiguration());
            modelBuilder.ApplyConfiguration(new OperationClaimConfiguration());
            modelBuilder.ApplyConfiguration(new UserOperationClaimConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new InterestsConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorInterestConfiguration());
            modelBuilder.ApplyConfiguration(new ReportConfiguration());

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Appointment>().HasQueryFilter(e => !e.IsDeleted);

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash("string", out passwordHash, out passwordSalt);

        }
        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<Entity>();

            foreach (var item in datas)
            {
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
