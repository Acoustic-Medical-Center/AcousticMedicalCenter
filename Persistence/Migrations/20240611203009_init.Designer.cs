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
    [Migration("20240611203009_init")]
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
                            AppointmentTime = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(849),
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(850),
                            DoctorId = 3,
                            IsDeleted = false,
                            PatientId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            AppointmentTime = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(859),
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(860),
                            DoctorId = 4,
                            IsDeleted = false,
                            PatientId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            AppointmentTime = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(864),
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(864),
                            DoctorId = 3,
                            IsDeleted = false,
                            PatientId = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            AppointmentTime = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(867),
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(868),
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
                            CreatedDate = new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(702),
                            DoctorSpecializationId = 1,
                            Experience = 10
                        },
                        new
                        {
                            Id = 4,
                            Biography = "Kalp Doktoru Özgeçmiş Example",
                            CreatedDate = new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(710),
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
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 585, DateTimeKind.Local).AddTicks(9734),
                            Name = "Cerrah"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 585, DateTimeKind.Local).AddTicks(9769),
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
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(957),
                            Name = "Kardiyoloji Araştırmaları"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(964),
                            Name = "Çocuk Sağlığı"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(968),
                            Name = "Onkoloji Tedavi"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(971),
                            Name = "Nöroloji ve Beyin Cerrahisi"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(974),
                            Name = "Endokrinoloji ve Metabolizma"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(978),
                            Name = "Gastroenteroloji ve Sindirim Sistemi"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(981),
                            Name = "Psikiyatri ve Mental Sağlık"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(984),
                            Name = "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(987),
                            Name = "Parkinson Hastalığı"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(990),
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
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 585, DateTimeKind.Local).AddTicks(9893),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 585, DateTimeKind.Local).AddTicks(9903),
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
                            CreatedDate = new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(519)
                        },
                        new
                        {
                            Id = 2,
                            Address = "1233 Main St",
                            AppointmentId = 0,
                            BloodType = "B+",
                            CreatedDate = new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(528)
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

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Prescription");
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
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(1172),
                            Diagnosis = " Hipertansiyon",
                            ExaminationFindings = "Yüksek kan basıncı"
                        },
                        new
                        {
                            Id = 2,
                            AppointmentId = 2,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(1180),
                            Diagnosis = " Hipertansiyon",
                            ExaminationFindings = "Yüksek kan basıncı"
                        },
                        new
                        {
                            Id = 3,
                            AppointmentId = 3,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(1184),
                            Diagnosis = "Diabetes Mellitus",
                            ExaminationFindings = "Fasting blood sugar level of 140 mg/dL"
                        },
                        new
                        {
                            Id = 4,
                            AppointmentId = 4,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(1188),
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
                            CreatedDate = new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(401),
                            Email = "hasta1@example.com",
                            FirstName = "John",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Doe",
                            PasswordHash = new byte[] { 52, 160, 214, 5, 204, 125, 141, 102, 54, 97, 3, 19, 120, 168, 219, 66, 235, 106, 75, 33, 86, 60, 213, 28, 150, 253, 139, 63, 232, 135, 144, 210, 62, 195, 64, 212, 10, 188, 177, 63, 244, 228, 226, 153, 243, 95, 161, 80, 166, 213, 230, 68, 27, 118, 55, 200, 69, 102, 44, 139, 88, 15, 16, 197 },
                            PasswordSalt = new byte[] { 229, 0, 21, 252, 2, 35, 17, 139, 110, 182, 104, 6, 69, 98, 76, 219, 4, 26, 212, 45, 40, 68, 215, 96, 111, 194, 111, 58, 85, 253, 207, 233, 71, 217, 140, 42, 44, 237, 170, 150, 135, 229, 99, 10, 57, 129, 255, 209, 106, 32, 141, 91, 168, 63, 118, 199, 114, 163, 52, 114, 176, 209, 20, 127, 210, 152, 101, 121, 207, 224, 230, 30, 184, 196, 218, 169, 193, 170, 125, 53, 233, 120, 200, 27, 91, 116, 125, 101, 212, 48, 189, 152, 15, 235, 72, 45, 152, 175, 126, 108, 5, 186, 44, 114, 43, 26, 99, 65, 81, 204, 46, 97, 241, 148, 191, 230, 11, 220, 226, 21, 199, 144, 193, 237, 47, 207, 48, 70 },
                            PhoneNumber = "1234567890",
                            UserType = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(410),
                            Email = "hasta2@example.com",
                            FirstName = "Jonathan",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Corwin",
                            PasswordHash = new byte[] { 52, 160, 214, 5, 204, 125, 141, 102, 54, 97, 3, 19, 120, 168, 219, 66, 235, 106, 75, 33, 86, 60, 213, 28, 150, 253, 139, 63, 232, 135, 144, 210, 62, 195, 64, 212, 10, 188, 177, 63, 244, 228, 226, 153, 243, 95, 161, 80, 166, 213, 230, 68, 27, 118, 55, 200, 69, 102, 44, 139, 88, 15, 16, 197 },
                            PasswordSalt = new byte[] { 229, 0, 21, 252, 2, 35, 17, 139, 110, 182, 104, 6, 69, 98, 76, 219, 4, 26, 212, 45, 40, 68, 215, 96, 111, 194, 111, 58, 85, 253, 207, 233, 71, 217, 140, 42, 44, 237, 170, 150, 135, 229, 99, 10, 57, 129, 255, 209, 106, 32, 141, 91, 168, 63, 118, 199, 114, 163, 52, 114, 176, 209, 20, 127, 210, 152, 101, 121, 207, 224, 230, 30, 184, 196, 218, 169, 193, 170, 125, 53, 233, 120, 200, 27, 91, 116, 125, 101, 212, 48, 189, 152, 15, 235, 72, 45, 152, 175, 126, 108, 5, 186, 44, 114, 43, 26, 99, 65, 81, 204, 46, 97, 241, 148, 191, 230, 11, 220, 226, 21, 199, 144, 193, 237, 47, 207, 48, 70 },
                            PhoneNumber = "1234512345",
                            UserType = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(415),
                            Email = "doktor1@example.com",
                            FirstName = "batu",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "cerrahlar",
                            PasswordHash = new byte[] { 52, 160, 214, 5, 204, 125, 141, 102, 54, 97, 3, 19, 120, 168, 219, 66, 235, 106, 75, 33, 86, 60, 213, 28, 150, 253, 139, 63, 232, 135, 144, 210, 62, 195, 64, 212, 10, 188, 177, 63, 244, 228, 226, 153, 243, 95, 161, 80, 166, 213, 230, 68, 27, 118, 55, 200, 69, 102, 44, 139, 88, 15, 16, 197 },
                            PasswordSalt = new byte[] { 229, 0, 21, 252, 2, 35, 17, 139, 110, 182, 104, 6, 69, 98, 76, 219, 4, 26, 212, 45, 40, 68, 215, 96, 111, 194, 111, 58, 85, 253, 207, 233, 71, 217, 140, 42, 44, 237, 170, 150, 135, 229, 99, 10, 57, 129, 255, 209, 106, 32, 141, 91, 168, 63, 118, 199, 114, 163, 52, 114, 176, 209, 20, 127, 210, 152, 101, 121, 207, 224, 230, 30, 184, 196, 218, 169, 193, 170, 125, 53, 233, 120, 200, 27, 91, 116, 125, 101, 212, 48, 189, 152, 15, 235, 72, 45, 152, 175, 126, 108, 5, 186, 44, 114, 43, 26, 99, 65, 81, 204, 46, 97, 241, 148, 191, 230, 11, 220, 226, 21, 199, 144, 193, 237, 47, 207, 48, 70 },
                            PhoneNumber = "1234512312",
                            UserType = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(418),
                            Email = "doktor2@example.com",
                            FirstName = "kalp",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "doktoru",
                            PasswordHash = new byte[] { 52, 160, 214, 5, 204, 125, 141, 102, 54, 97, 3, 19, 120, 168, 219, 66, 235, 106, 75, 33, 86, 60, 213, 28, 150, 253, 139, 63, 232, 135, 144, 210, 62, 195, 64, 212, 10, 188, 177, 63, 244, 228, 226, 153, 243, 95, 161, 80, 166, 213, 230, 68, 27, 118, 55, 200, 69, 102, 44, 139, 88, 15, 16, 197 },
                            PasswordSalt = new byte[] { 229, 0, 21, 252, 2, 35, 17, 139, 110, 182, 104, 6, 69, 98, 76, 219, 4, 26, 212, 45, 40, 68, 215, 96, 111, 194, 111, 58, 85, 253, 207, 233, 71, 217, 140, 42, 44, 237, 170, 150, 135, 229, 99, 10, 57, 129, 255, 209, 106, 32, 141, 91, 168, 63, 118, 199, 114, 163, 52, 114, 176, 209, 20, 127, 210, 152, 101, 121, 207, 224, 230, 30, 184, 196, 218, 169, 193, 170, 125, 53, 233, 120, 200, 27, 91, 116, 125, 101, 212, 48, 189, 152, 15, 235, 72, 45, 152, 175, 126, 108, 5, 186, 44, 114, 43, 26, 99, 65, 81, 204, 46, 97, 241, 148, 191, 230, 11, 220, 226, 21, 199, 144, 193, 237, 47, 207, 48, 70 },
                            PhoneNumber = "1234512313",
                            UserType = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(422),
                            Email = "admin@example.com",
                            FirstName = "Admin",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Yöneticioğlu",
                            PasswordHash = new byte[] { 52, 160, 214, 5, 204, 125, 141, 102, 54, 97, 3, 19, 120, 168, 219, 66, 235, 106, 75, 33, 86, 60, 213, 28, 150, 253, 139, 63, 232, 135, 144, 210, 62, 195, 64, 212, 10, 188, 177, 63, 244, 228, 226, 153, 243, 95, 161, 80, 166, 213, 230, 68, 27, 118, 55, 200, 69, 102, 44, 139, 88, 15, 16, 197 },
                            PasswordSalt = new byte[] { 229, 0, 21, 252, 2, 35, 17, 139, 110, 182, 104, 6, 69, 98, 76, 219, 4, 26, 212, 45, 40, 68, 215, 96, 111, 194, 111, 58, 85, 253, 207, 233, 71, 217, 140, 42, 44, 237, 170, 150, 135, 229, 99, 10, 57, 129, 255, 209, 106, 32, 141, 91, 168, 63, 118, 199, 114, 163, 52, 114, 176, 209, 20, 127, 210, 152, 101, 121, 207, 224, 230, 30, 184, 196, 218, 169, 193, 170, 125, 53, 233, 120, 200, 27, 91, 116, 125, 101, 212, 48, 189, 152, 15, 235, 72, 45, 152, 175, 126, 108, 5, 186, 44, 114, 43, 26, 99, 65, 81, 204, 46, 97, 241, 148, 191, 230, 11, 220, 226, 21, 199, 144, 193, 237, 47, 207, 48, 70 },
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
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(7),
                            OperationClaimId = 1,
                            UserId = 5
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(15),
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
                        .WithMany("Interests")
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

                    b.Navigation("Interests");
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