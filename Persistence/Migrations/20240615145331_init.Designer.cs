﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Context;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(AcousticDbContext))]
    [Migration("20240615145331_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            AppointmentTime = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5484),
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5485),
                            DoctorId = 3,
                            IsDeleted = false,
                            PatientId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            AppointmentTime = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5492),
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5493),
                            DoctorId = 4,
                            IsDeleted = false,
                            PatientId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            AppointmentTime = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5497),
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5498),
                            DoctorId = 3,
                            IsDeleted = false,
                            PatientId = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            AppointmentTime = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5501),
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5502),
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
                        .IsRequired()
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
                            CreatedDate = new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5375),
                            DoctorSpecializationId = 1,
                            Experience = 10
                        },
                        new
                        {
                            Id = 4,
                            Biography = "Kalp Doktoru Özgeçmiş Example",
                            CreatedDate = new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5382),
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
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4374),
                            Name = "Cerrah"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4404),
                            Name = "Kalp"
                        });
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
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5604),
                            Name = "Kardiyoloji Araştırmaları"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5611),
                            Name = "Çocuk Sağlığı"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5615),
                            Name = "Onkoloji Tedavi"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5618),
                            Name = "Nöroloji ve Beyin Cerrahisi"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5621),
                            Name = "Endokrinoloji ve Metabolizma"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5627),
                            Name = "Gastroenteroloji ve Sindirim Sistemi"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5630),
                            Name = "Psikiyatri ve Mental Sağlık"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5633),
                            Name = "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5637),
                            Name = "Parkinson Hastalığı"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5640),
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
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4530),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4540),
                            Name = "Appointment.Delete"
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
                            CreatedDate = new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5226)
                        },
                        new
                        {
                            Id = 2,
                            Address = "1233 Main St",
                            AppointmentId = 0,
                            BloodType = "B+",
                            CreatedDate = new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5234)
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

                    b.Property<string>("MedicationDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrescriptionStatus")
                        .HasColumnType("int");

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
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5836),
                            Diagnosis = " Hipertansiyon",
                            ExaminationFindings = "Yüksek kan basıncı"
                        },
                        new
                        {
                            Id = 2,
                            AppointmentId = 2,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5848),
                            Diagnosis = " Hipertansiyon",
                            ExaminationFindings = "Yüksek kan basıncı"
                        },
                        new
                        {
                            Id = 3,
                            AppointmentId = 3,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5852),
                            Diagnosis = "Diabetes Mellitus",
                            ExaminationFindings = "Fasting blood sugar level of 140 mg/dL"
                        },
                        new
                        {
                            Id = 4,
                            AppointmentId = 4,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5855),
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
                            CreatedDate = new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5096),
                            Email = "hasta1@example.com",
                            FirstName = "John",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Doe",
                            PasswordHash = new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 },
                            PasswordSalt = new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 },
                            PhoneNumber = "1234567890",
                            UserType = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5106),
                            Email = "hasta2@example.com",
                            FirstName = "Jonathan",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Corwin",
                            PasswordHash = new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 },
                            PasswordSalt = new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 },
                            PhoneNumber = "1234512345",
                            UserType = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5111),
                            Email = "doktor1@example.com",
                            FirstName = "batu",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "cerrahlar",
                            PasswordHash = new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 },
                            PasswordSalt = new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 },
                            PhoneNumber = "1234512312",
                            UserType = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5115),
                            Email = "doktor2@example.com",
                            FirstName = "kalp",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "doktoru",
                            PasswordHash = new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 },
                            PasswordSalt = new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 },
                            PhoneNumber = "1234512313",
                            UserType = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5119),
                            Email = "admin@example.com",
                            FirstName = "Admin",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Yöneticioğlu",
                            PasswordHash = new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 },
                            PasswordSalt = new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 },
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
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4650),
                            OperationClaimId = 1,
                            UserId = 5
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4660),
                            OperationClaimId = 2,
                            UserId = 3
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
#pragma warning restore 612, 618
        }
    }
}