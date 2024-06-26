﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Context;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(AcousticDbContext))]
    partial class AcousticDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);


            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Appointment", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("AppointmentTime")
                    .HasColumnType("datetime2");
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<DoctorSpecialization> DoctorSpecializations { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<DoctorInterest> DoctorInterests { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }


                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("DeletedDate")
                    .HasColumnType("datetime2");

                b.Property<int>("DoctorId")
                    .HasColumnType("int");

                b.Property<bool>("IsDeleted")
                    .HasColumnType("bit");

                b.Property<int>("PatientId")
                    .HasColumnType("int");

                b.Property<int>("Status")
                    .HasColumnType("int");

                b.Property<DateTime?>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("DoctorId");

                b.HasIndex("PatientId");

                b.ToTable("Appointments");

                b.HasData(
                    new
                    {
                        Id = 1,
                        AppointmentTime = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9902),
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9903),
                        DoctorId = 3,
                        IsDeleted = false,
                        PatientId = 1,
                        Status = 0
                    },
                    new
                    {
                        Id = 2,
                        AppointmentTime = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9912),
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9912),
                        DoctorId = 4,
                        IsDeleted = false,
                        PatientId = 1,
                        Status = 0
                    },
                    new
                    {
                        Id = 3,
                        AppointmentTime = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9916),
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9917),
                        DoctorId = 3,
                        IsDeleted = false,
                        PatientId = 2,
                        Status = 0
                    },
                    new
                    {
                        Id = 4,
                        AppointmentTime = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9920),
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9921),
                        DoctorId = 4,
                        IsDeleted = false,
                        PatientId = 2,
                        Status = 0
                    });
            });

            modelBuilder.Entity("Domain.Entities.Doctor", b =>
            {
                b.Property<int>("Id")
                    .HasColumnType("int");

                b.Property<string>("Biography")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("DeletedDate")
                    .HasColumnType("datetime2");

                b.Property<int>("DoctorSpecializationId")
                    .HasColumnType("int");

                b.Property<int>("Experience")
                    .HasColumnType("int");

                b.Property<DateTime?>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("DoctorSpecializationId");

                b.ToTable("Doctors");

                b.HasData(
                    new
                    {
                        Id = 3,
                        Biography = "Id 3 olan Doktor Özgeçmiş Example",
                        CreatedDate = new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9807),
                        DoctorSpecializationId = 1,
                        Experience = 10
                    },
                    new
                    {
                        Id = 4,
                        Biography = "Kalp Doktoru Özgeçmiş Example",
                        CreatedDate = new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9815),
                        DoctorSpecializationId = 2,
                        Experience = 5
                    });
            });

            modelBuilder.Entity("Domain.Entities.DoctorInterest", b =>
            {
                b.Property<int>("DoctorId")
                    .HasColumnType("int");

                b.Property<int>("InterestId")
                    .HasColumnType("int");

                b.HasKey("DoctorId", "InterestId");

                b.HasIndex("InterestId");

                b.ToTable("DoctorInterests");

                b.HasData(
                    new
                    {
                        DoctorId = 3,
                        InterestId = 1
                    },
                    new
                    {
                        DoctorId = 3,
                        InterestId = 2
                    },
                    new
                    {
                        DoctorId = 4,
                        InterestId = 7
                    },
                    new
                    {
                        DoctorId = 4,
                        InterestId = 8
                    });
            });

            modelBuilder.Entity("Domain.Entities.DoctorSpecialization", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("DeletedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("DoctorSpecializations");

                b.HasData(
                    new
                    {
                        Id = 1,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(8877),
                        Name = "Cerrah"
                    },
                    new
                    {
                        Id = 2,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(8909),
                        Name = "Kalp"
                    });
            });

            modelBuilder.Entity("Domain.Entities.Feedback", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("DeletedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("FeedbackMessage")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FeedbackSubject")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("Feedbacks");
            });

            modelBuilder.Entity("Domain.Entities.Interest", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("DeletedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("Interests");

                b.HasData(
                    new
                    {
                        Id = 1,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(37),
                        Name = "Kardiyoloji Araştırmaları"
                    },
                    new
                    {
                        Id = 2,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(46),
                        Name = "Çocuk Sağlığı"
                    },
                    new
                    {
                        Id = 3,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(49),
                        Name = "Onkoloji Tedavi"
                    },
                    new
                    {
                        Id = 4,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(74),
                        Name = "Nöroloji ve Beyin Cerrahisi"
                    },
                    new
                    {
                        Id = 5,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(78),
                        Name = "Endokrinoloji ve Metabolizma"
                    },
                    new
                    {
                        Id = 6,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(82),
                        Name = "Gastroenteroloji ve Sindirim Sistemi"
                    },
                    new
                    {
                        Id = 7,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(85),
                        Name = "Psikiyatri ve Mental Sağlık"
                    },
                    new
                    {
                        Id = 8,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(89),
                        Name = "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri"
                    },
                    new
                    {
                        Id = 9,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(92),
                        Name = "Parkinson Hastalığı"
                    },
                    new
                    {
                        Id = 10,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(95),
                        Name = "Bunama"
                    });
            });

            modelBuilder.Entity("Domain.Entities.OperationClaim", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("DeletedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("OperationClaims");

                b.HasData(
                    new
                    {
                        Id = 1,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9016),
                        Name = "Admin"
                    },
                    new
                    {
                        Id = 2,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9029),
                        Name = "Appointment.Delete"
                    },
                    new
                    {
                        Id = 3,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9033),
                        Name = "Doctor"
                    });
            });

            modelBuilder.Entity("Domain.Entities.Patient", b =>
            {
                b.Property<int>("Id")
                    .HasColumnType("int");

                b.Property<string>("Address")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("AppointmentId")
                    .HasColumnType("int");

                b.Property<string>("BloodType")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("DeletedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("Patients");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Address = "1234 Main St",
                        AppointmentId = 0,
                        BloodType = "A+",
                        CreatedDate = new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9704)
                    },
                    new
                    {
                        Id = 2,
                        Address = "1233 Main St",
                        AppointmentId = 0,
                        BloodType = "B+",
                        CreatedDate = new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9712)
                    });
            });

            modelBuilder.Entity("Domain.Entities.Prescription", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("AppointmentId")
                    .HasColumnType("int");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("DeletedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("DosageInstructions")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsDeleted")
                    .HasColumnType("bit");

                b.Property<string>("MedicationDetails")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("AppointmentId");

                b.ToTable("Prescriptions");
            });

            modelBuilder.Entity("Domain.Entities.Report", b =>
            {
                b.Property<int>("Id")
                    .HasColumnType("int");

                b.Property<int>("AppointmentId")
                    .HasColumnType("int");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("DeletedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Diagnosis")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ExaminationFindings")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("AppointmentId")
                    .IsUnique();

                b.ToTable("Reports");

                b.HasData(
                    new
                    {
                        Id = 1,
                        AppointmentId = 1,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(310),
                        Diagnosis = " Hipertansiyon",
                        ExaminationFindings = "Yüksek kan basıncı"
                    },
                    new
                    {
                        Id = 2,
                        AppointmentId = 2,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(320),
                        Diagnosis = " Hipertansiyon",
                        ExaminationFindings = "Yüksek kan basıncı"
                    },
                    new
                    {
                        Id = 3,
                        AppointmentId = 3,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(324),
                        Diagnosis = "Diabetes Mellitus",
                        ExaminationFindings = "Fasting blood sugar level of 140 mg/dL"
                    },
                    new
                    {
                        Id = 4,
                        AppointmentId = 4,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(328),
                        Diagnosis = "Chronic Obstructive Pulmonary Disease (COPD)",
                        ExaminationFindings = "Reduced lung function on spirometry"
                    });
            });

            modelBuilder.Entity("Domain.Entities.User", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("DeletedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Gender")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsDeleted")
                    .HasColumnType("bit");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<byte[]>("PasswordHash")
                    .IsRequired()
                    .HasColumnType("varbinary(max)");

                b.Property<byte[]>("PasswordSalt")
                    .IsRequired()
                    .HasColumnType("varbinary(max)");

                b.Property<string>("PhoneNumber")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.Property<int>("UserType")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Users");

                b.HasData(
                    new
                    {
                        Id = 1,
                        CreatedDate = new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9584),
                        Email = "hasta1@example.com",
                        FirstName = "John",
                        Gender = "Male",
                        IsDeleted = false,
                        LastName = "Doe",
                        PasswordHash = new byte[] { 15, 146, 40, 79, 228, 15, 210, 36, 215, 250, 8, 49, 148, 120, 172, 179, 11, 106, 176, 60, 104, 240, 76, 181, 216, 186, 194, 118, 34, 199, 16, 92, 40, 48, 70, 95, 50, 87, 106, 3, 15, 138, 182, 155, 26, 250, 121, 189, 201, 117, 57, 17, 182, 165, 24, 215, 193, 95, 58, 247, 16, 217, 117, 160 },
                        PasswordSalt = new byte[] { 242, 78, 106, 6, 121, 25, 130, 133, 219, 160, 6, 45, 213, 8, 103, 129, 135, 195, 181, 17, 104, 203, 154, 99, 100, 234, 48, 48, 17, 29, 93, 210, 105, 240, 149, 187, 177, 165, 219, 78, 235, 192, 165, 236, 172, 193, 59, 34, 22, 172, 226, 28, 8, 62, 230, 83, 12, 255, 154, 57, 81, 175, 244, 144, 161, 111, 4, 52, 142, 115, 23, 78, 93, 43, 4, 244, 136, 38, 48, 195, 253, 46, 32, 90, 28, 143, 13, 130, 214, 237, 199, 131, 105, 202, 109, 75, 39, 15, 44, 169, 62, 203, 14, 25, 46, 132, 230, 116, 111, 61, 142, 198, 90, 26, 75, 36, 3, 87, 166, 131, 157, 183, 250, 155, 223, 240, 102, 185 },
                        PhoneNumber = "1234567890",
                        UserType = 0
                    },
                    new
                    {
                        Id = 2,
                        CreatedDate = new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9593),
                        Email = "hasta2@example.com",
                        FirstName = "Jonathan",
                        Gender = "Male",
                        IsDeleted = false,
                        LastName = "Corwin",
                        PasswordHash = new byte[] { 15, 146, 40, 79, 228, 15, 210, 36, 215, 250, 8, 49, 148, 120, 172, 179, 11, 106, 176, 60, 104, 240, 76, 181, 216, 186, 194, 118, 34, 199, 16, 92, 40, 48, 70, 95, 50, 87, 106, 3, 15, 138, 182, 155, 26, 250, 121, 189, 201, 117, 57, 17, 182, 165, 24, 215, 193, 95, 58, 247, 16, 217, 117, 160 },
                        PasswordSalt = new byte[] { 242, 78, 106, 6, 121, 25, 130, 133, 219, 160, 6, 45, 213, 8, 103, 129, 135, 195, 181, 17, 104, 203, 154, 99, 100, 234, 48, 48, 17, 29, 93, 210, 105, 240, 149, 187, 177, 165, 219, 78, 235, 192, 165, 236, 172, 193, 59, 34, 22, 172, 226, 28, 8, 62, 230, 83, 12, 255, 154, 57, 81, 175, 244, 144, 161, 111, 4, 52, 142, 115, 23, 78, 93, 43, 4, 244, 136, 38, 48, 195, 253, 46, 32, 90, 28, 143, 13, 130, 214, 237, 199, 131, 105, 202, 109, 75, 39, 15, 44, 169, 62, 203, 14, 25, 46, 132, 230, 116, 111, 61, 142, 198, 90, 26, 75, 36, 3, 87, 166, 131, 157, 183, 250, 155, 223, 240, 102, 185 },
                        PhoneNumber = "1234512345",
                        UserType = 0
                    },
                    new
                    {
                        Id = 3,
                        CreatedDate = new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9597),
                        Email = "doktor1@example.com",
                        FirstName = "batu",
                        Gender = "Male",
                        IsDeleted = false,
                        LastName = "cerrahlar",
                        PasswordHash = new byte[] { 15, 146, 40, 79, 228, 15, 210, 36, 215, 250, 8, 49, 148, 120, 172, 179, 11, 106, 176, 60, 104, 240, 76, 181, 216, 186, 194, 118, 34, 199, 16, 92, 40, 48, 70, 95, 50, 87, 106, 3, 15, 138, 182, 155, 26, 250, 121, 189, 201, 117, 57, 17, 182, 165, 24, 215, 193, 95, 58, 247, 16, 217, 117, 160 },
                        PasswordSalt = new byte[] { 242, 78, 106, 6, 121, 25, 130, 133, 219, 160, 6, 45, 213, 8, 103, 129, 135, 195, 181, 17, 104, 203, 154, 99, 100, 234, 48, 48, 17, 29, 93, 210, 105, 240, 149, 187, 177, 165, 219, 78, 235, 192, 165, 236, 172, 193, 59, 34, 22, 172, 226, 28, 8, 62, 230, 83, 12, 255, 154, 57, 81, 175, 244, 144, 161, 111, 4, 52, 142, 115, 23, 78, 93, 43, 4, 244, 136, 38, 48, 195, 253, 46, 32, 90, 28, 143, 13, 130, 214, 237, 199, 131, 105, 202, 109, 75, 39, 15, 44, 169, 62, 203, 14, 25, 46, 132, 230, 116, 111, 61, 142, 198, 90, 26, 75, 36, 3, 87, 166, 131, 157, 183, 250, 155, 223, 240, 102, 185 },
                        PhoneNumber = "1234512312",
                        UserType = 1
                    },
                    new
                    {
                        Id = 4,
                        CreatedDate = new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9601),
                        Email = "doktor2@example.com",
                        FirstName = "kalp",
                        Gender = "Male",
                        IsDeleted = false,
                        LastName = "doktoru",
                        PasswordHash = new byte[] { 15, 146, 40, 79, 228, 15, 210, 36, 215, 250, 8, 49, 148, 120, 172, 179, 11, 106, 176, 60, 104, 240, 76, 181, 216, 186, 194, 118, 34, 199, 16, 92, 40, 48, 70, 95, 50, 87, 106, 3, 15, 138, 182, 155, 26, 250, 121, 189, 201, 117, 57, 17, 182, 165, 24, 215, 193, 95, 58, 247, 16, 217, 117, 160 },
                        PasswordSalt = new byte[] { 242, 78, 106, 6, 121, 25, 130, 133, 219, 160, 6, 45, 213, 8, 103, 129, 135, 195, 181, 17, 104, 203, 154, 99, 100, 234, 48, 48, 17, 29, 93, 210, 105, 240, 149, 187, 177, 165, 219, 78, 235, 192, 165, 236, 172, 193, 59, 34, 22, 172, 226, 28, 8, 62, 230, 83, 12, 255, 154, 57, 81, 175, 244, 144, 161, 111, 4, 52, 142, 115, 23, 78, 93, 43, 4, 244, 136, 38, 48, 195, 253, 46, 32, 90, 28, 143, 13, 130, 214, 237, 199, 131, 105, 202, 109, 75, 39, 15, 44, 169, 62, 203, 14, 25, 46, 132, 230, 116, 111, 61, 142, 198, 90, 26, 75, 36, 3, 87, 166, 131, 157, 183, 250, 155, 223, 240, 102, 185 },
                        PhoneNumber = "1234512313",
                        UserType = 1
                    },
                    new
                    {
                        Id = 5,
                        CreatedDate = new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9604),
                        Email = "admin@example.com",
                        FirstName = "Admin",
                        Gender = "Male",
                        IsDeleted = false,
                        LastName = "Yöneticioğlu",
                        PasswordHash = new byte[] { 15, 146, 40, 79, 228, 15, 210, 36, 215, 250, 8, 49, 148, 120, 172, 179, 11, 106, 176, 60, 104, 240, 76, 181, 216, 186, 194, 118, 34, 199, 16, 92, 40, 48, 70, 95, 50, 87, 106, 3, 15, 138, 182, 155, 26, 250, 121, 189, 201, 117, 57, 17, 182, 165, 24, 215, 193, 95, 58, 247, 16, 217, 117, 160 },
                        PasswordSalt = new byte[] { 242, 78, 106, 6, 121, 25, 130, 133, 219, 160, 6, 45, 213, 8, 103, 129, 135, 195, 181, 17, 104, 203, 154, 99, 100, 234, 48, 48, 17, 29, 93, 210, 105, 240, 149, 187, 177, 165, 219, 78, 235, 192, 165, 236, 172, 193, 59, 34, 22, 172, 226, 28, 8, 62, 230, 83, 12, 255, 154, 57, 81, 175, 244, 144, 161, 111, 4, 52, 142, 115, 23, 78, 93, 43, 4, 244, 136, 38, 48, 195, 253, 46, 32, 90, 28, 143, 13, 130, 214, 237, 199, 131, 105, 202, 109, 75, 39, 15, 44, 169, 62, 203, 14, 25, 46, 132, 230, 116, 111, 61, 142, 198, 90, 26, 75, 36, 3, 87, 166, 131, 157, 183, 250, 155, 223, 240, 102, 185 },
                        PhoneNumber = "1234512345",
                        UserType = 2
                    });
            });

            modelBuilder.Entity("Domain.Entities.UserOperationClaim", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("DeletedDate")
                    .HasColumnType("datetime2");

                b.Property<int>("OperationClaimId")
                    .HasColumnType("int");

                b.Property<DateTime?>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("OperationClaimId");

                b.HasIndex("UserId");

                b.ToTable("UserOperationClaims");

                b.HasData(
                    new
                    {
                        Id = 1,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9138),
                        OperationClaimId = 1,
                        UserId = 5
                    },
                    new
                    {
                        Id = 2,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9148),
                        OperationClaimId = 2,
                        UserId = 3
                    },
                    new
                    {
                        Id = 3,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9153),
                        OperationClaimId = 3,
                        UserId = 3
                    },
                    new
                    {
                        Id = 4,
                        CreatedDate = new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9157),
                        OperationClaimId = 3,
                        UserId = 4
                    });
            });

            modelBuilder.Entity("Domain.Entities.Appointment", b =>
            {
                b.HasOne("Domain.Entities.Doctor", "Doctor")
                    .WithMany("Appointment")
                    .HasForeignKey("DoctorId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.HasOne("Domain.Entities.Patient", "Patient")
                    .WithMany("Appointment")
                    .HasForeignKey("PatientId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.Navigation("Doctor");

                b.Navigation("Patient");
            });

            modelBuilder.Entity("Domain.Entities.Doctor", b =>
            {
                b.HasOne("Domain.Entities.DoctorSpecialization", "DoctorSpecialization")
                    .WithMany()
                    .HasForeignKey("DoctorSpecializationId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Domain.Entities.User", "User")
                    .WithOne("Doctor")
                    .HasForeignKey("Domain.Entities.Doctor", "Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("DoctorSpecialization");

                b.Navigation("User");
            });

            modelBuilder.Entity("Domain.Entities.DoctorInterest", b =>
            {
                b.HasOne("Domain.Entities.Doctor", "Doctor")
                    .WithMany("DoctorInterest")
                    .HasForeignKey("DoctorId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Domain.Entities.Interest", "Interest")
                    .WithMany("DoctorInterests")
                    .HasForeignKey("InterestId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Doctor");

                b.Navigation("Interest");
            });

            modelBuilder.Entity("Domain.Entities.Patient", b =>
            {
                b.HasOne("Domain.Entities.User", "User")
                    .WithOne("Patient")
                    .HasForeignKey("Domain.Entities.Patient", "Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("User");
            });

            modelBuilder.Entity("Domain.Entities.Prescription", b =>
            {
                b.HasOne("Domain.Entities.Appointment", "Appointment")
                    .WithMany("Prescriptions")
                    .HasForeignKey("AppointmentId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Appointment");
            });

            modelBuilder.Entity("Domain.Entities.Report", b =>
            {
                b.HasOne("Domain.Entities.Appointment", "Appointment")
                    .WithOne("Report")
                    .HasForeignKey("Domain.Entities.Report", "AppointmentId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Appointment");
            });

            modelBuilder.Entity("Domain.Entities.UserOperationClaim", b =>
            {
                b.HasOne("Domain.Entities.OperationClaim", "OperationClaim")
                    .WithMany("UserOperationClaims")
                    .HasForeignKey("OperationClaimId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Domain.Entities.User", "User")
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("OperationClaim");

                b.Navigation("User");
            });

            modelBuilder.Entity("Domain.Entities.Appointment", b =>
            {
                b.Navigation("Prescriptions");

                b.Navigation("Report")
                    .IsRequired();
            });

            modelBuilder.Entity("Domain.Entities.Doctor", b =>
            {
                b.Navigation("Appointment");

                b.Navigation("DoctorInterest");
            });

            modelBuilder.Entity("Domain.Entities.Interest", b =>
            {
                b.Navigation("DoctorInterests");
            });

            modelBuilder.Entity("Domain.Entities.OperationClaim", b =>
            {
                b.Navigation("UserOperationClaims");
            });

            modelBuilder.Entity("Domain.Entities.Patient", b =>
            {
                b.Navigation("Appointment");
            });

            modelBuilder.Entity("Domain.Entities.User", b =>
            {
                b.Navigation("Doctor")
                    .IsRequired();

                b.Navigation("Patient")
                    .IsRequired();
            });

        }
    }
}