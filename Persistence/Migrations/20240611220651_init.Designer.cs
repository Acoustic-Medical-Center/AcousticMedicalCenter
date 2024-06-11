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
    [Migration("20240611220651_init")]
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
                            AppointmentTime = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1081),
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1083),
                            DoctorId = 3,
                            IsDeleted = false,
                            PatientId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            AppointmentTime = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1095),
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1095),
                            DoctorId = 4,
                            IsDeleted = false,
                            PatientId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            AppointmentTime = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1100),
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1101),
                            DoctorId = 3,
                            IsDeleted = false,
                            PatientId = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            AppointmentTime = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1105),
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1106),
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
                            CreatedDate = new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(932),
                            DoctorSpecializationId = 1,
                            Experience = 10
                        },
                        new
                        {
                            Id = 4,
                            Biography = "Kalp Doktoru Özgeçmiş Example",
                            CreatedDate = new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(942),
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
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 588, DateTimeKind.Local).AddTicks(9920),
                            Name = "Cerrah"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 588, DateTimeKind.Local).AddTicks(9950),
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
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1241),
                            Name = "Kardiyoloji Araştırmaları"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1252),
                            Name = "Çocuk Sağlığı"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1256),
                            Name = "Onkoloji Tedavi"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1260),
                            Name = "Nöroloji ve Beyin Cerrahisi"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1263),
                            Name = "Endokrinoloji ve Metabolizma"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1269),
                            Name = "Gastroenteroloji ve Sindirim Sistemi"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1272),
                            Name = "Psikiyatri ve Mental Sağlık"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1276),
                            Name = "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1280),
                            Name = "Parkinson Hastalığı"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1284),
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
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(73),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(80),
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
                            CreatedDate = new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(831)
                        },
                        new
                        {
                            Id = 2,
                            Address = "1233 Main St",
                            AppointmentId = 0,
                            BloodType = "B+",
                            CreatedDate = new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(839)
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
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1629),
                            Diagnosis = " Hipertansiyon",
                            ExaminationFindings = "Yüksek kan basıncı"
                        },
                        new
                        {
                            Id = 2,
                            AppointmentId = 2,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1645),
                            Diagnosis = " Hipertansiyon",
                            ExaminationFindings = "Yüksek kan basıncı"
                        },
                        new
                        {
                            Id = 3,
                            AppointmentId = 3,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1650),
                            Diagnosis = "Diabetes Mellitus",
                            ExaminationFindings = "Fasting blood sugar level of 140 mg/dL"
                        },
                        new
                        {
                            Id = 4,
                            AppointmentId = 4,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1654),
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
                            CreatedDate = new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(701),
                            Email = "hasta1@example.com",
                            FirstName = "John",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Doe",
                            PasswordHash = new byte[] { 233, 97, 61, 2, 125, 16, 232, 220, 225, 30, 23, 71, 255, 122, 95, 71, 219, 61, 243, 252, 168, 1, 232, 183, 72, 172, 196, 138, 39, 12, 42, 105, 240, 132, 41, 230, 59, 17, 83, 21, 141, 92, 68, 189, 252, 148, 39, 164, 133, 239, 115, 142, 177, 193, 215, 46, 214, 180, 222, 222, 200, 145, 203, 219 },
                            PasswordSalt = new byte[] { 186, 65, 135, 84, 235, 18, 151, 37, 46, 128, 228, 177, 50, 71, 208, 2, 227, 213, 225, 234, 200, 44, 199, 249, 61, 227, 178, 210, 58, 134, 186, 63, 60, 194, 229, 214, 222, 53, 35, 168, 102, 183, 56, 85, 85, 90, 172, 213, 248, 67, 203, 247, 190, 130, 143, 147, 227, 61, 181, 241, 205, 170, 251, 21, 184, 172, 72, 32, 153, 248, 216, 100, 6, 149, 51, 213, 151, 215, 102, 11, 221, 212, 161, 18, 234, 195, 29, 117, 248, 234, 149, 180, 69, 23, 193, 88, 53, 86, 154, 30, 109, 32, 249, 96, 95, 205, 40, 191, 42, 225, 248, 133, 31, 112, 247, 59, 111, 47, 107, 224, 57, 196, 64, 187, 93, 67, 45, 166 },
                            PhoneNumber = "1234567890",
                            UserType = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(713),
                            Email = "hasta2@example.com",
                            FirstName = "Jonathan",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Corwin",
                            PasswordHash = new byte[] { 233, 97, 61, 2, 125, 16, 232, 220, 225, 30, 23, 71, 255, 122, 95, 71, 219, 61, 243, 252, 168, 1, 232, 183, 72, 172, 196, 138, 39, 12, 42, 105, 240, 132, 41, 230, 59, 17, 83, 21, 141, 92, 68, 189, 252, 148, 39, 164, 133, 239, 115, 142, 177, 193, 215, 46, 214, 180, 222, 222, 200, 145, 203, 219 },
                            PasswordSalt = new byte[] { 186, 65, 135, 84, 235, 18, 151, 37, 46, 128, 228, 177, 50, 71, 208, 2, 227, 213, 225, 234, 200, 44, 199, 249, 61, 227, 178, 210, 58, 134, 186, 63, 60, 194, 229, 214, 222, 53, 35, 168, 102, 183, 56, 85, 85, 90, 172, 213, 248, 67, 203, 247, 190, 130, 143, 147, 227, 61, 181, 241, 205, 170, 251, 21, 184, 172, 72, 32, 153, 248, 216, 100, 6, 149, 51, 213, 151, 215, 102, 11, 221, 212, 161, 18, 234, 195, 29, 117, 248, 234, 149, 180, 69, 23, 193, 88, 53, 86, 154, 30, 109, 32, 249, 96, 95, 205, 40, 191, 42, 225, 248, 133, 31, 112, 247, 59, 111, 47, 107, 224, 57, 196, 64, 187, 93, 67, 45, 166 },
                            PhoneNumber = "1234512345",
                            UserType = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(717),
                            Email = "doktor1@example.com",
                            FirstName = "batu",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "cerrahlar",
                            PasswordHash = new byte[] { 233, 97, 61, 2, 125, 16, 232, 220, 225, 30, 23, 71, 255, 122, 95, 71, 219, 61, 243, 252, 168, 1, 232, 183, 72, 172, 196, 138, 39, 12, 42, 105, 240, 132, 41, 230, 59, 17, 83, 21, 141, 92, 68, 189, 252, 148, 39, 164, 133, 239, 115, 142, 177, 193, 215, 46, 214, 180, 222, 222, 200, 145, 203, 219 },
                            PasswordSalt = new byte[] { 186, 65, 135, 84, 235, 18, 151, 37, 46, 128, 228, 177, 50, 71, 208, 2, 227, 213, 225, 234, 200, 44, 199, 249, 61, 227, 178, 210, 58, 134, 186, 63, 60, 194, 229, 214, 222, 53, 35, 168, 102, 183, 56, 85, 85, 90, 172, 213, 248, 67, 203, 247, 190, 130, 143, 147, 227, 61, 181, 241, 205, 170, 251, 21, 184, 172, 72, 32, 153, 248, 216, 100, 6, 149, 51, 213, 151, 215, 102, 11, 221, 212, 161, 18, 234, 195, 29, 117, 248, 234, 149, 180, 69, 23, 193, 88, 53, 86, 154, 30, 109, 32, 249, 96, 95, 205, 40, 191, 42, 225, 248, 133, 31, 112, 247, 59, 111, 47, 107, 224, 57, 196, 64, 187, 93, 67, 45, 166 },
                            PhoneNumber = "1234512312",
                            UserType = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(721),
                            Email = "doktor2@example.com",
                            FirstName = "kalp",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "doktoru",
                            PasswordHash = new byte[] { 233, 97, 61, 2, 125, 16, 232, 220, 225, 30, 23, 71, 255, 122, 95, 71, 219, 61, 243, 252, 168, 1, 232, 183, 72, 172, 196, 138, 39, 12, 42, 105, 240, 132, 41, 230, 59, 17, 83, 21, 141, 92, 68, 189, 252, 148, 39, 164, 133, 239, 115, 142, 177, 193, 215, 46, 214, 180, 222, 222, 200, 145, 203, 219 },
                            PasswordSalt = new byte[] { 186, 65, 135, 84, 235, 18, 151, 37, 46, 128, 228, 177, 50, 71, 208, 2, 227, 213, 225, 234, 200, 44, 199, 249, 61, 227, 178, 210, 58, 134, 186, 63, 60, 194, 229, 214, 222, 53, 35, 168, 102, 183, 56, 85, 85, 90, 172, 213, 248, 67, 203, 247, 190, 130, 143, 147, 227, 61, 181, 241, 205, 170, 251, 21, 184, 172, 72, 32, 153, 248, 216, 100, 6, 149, 51, 213, 151, 215, 102, 11, 221, 212, 161, 18, 234, 195, 29, 117, 248, 234, 149, 180, 69, 23, 193, 88, 53, 86, 154, 30, 109, 32, 249, 96, 95, 205, 40, 191, 42, 225, 248, 133, 31, 112, 247, 59, 111, 47, 107, 224, 57, 196, 64, 187, 93, 67, 45, 166 },
                            PhoneNumber = "1234512313",
                            UserType = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(725),
                            Email = "admin@example.com",
                            FirstName = "Admin",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Yöneticioğlu",
                            PasswordHash = new byte[] { 233, 97, 61, 2, 125, 16, 232, 220, 225, 30, 23, 71, 255, 122, 95, 71, 219, 61, 243, 252, 168, 1, 232, 183, 72, 172, 196, 138, 39, 12, 42, 105, 240, 132, 41, 230, 59, 17, 83, 21, 141, 92, 68, 189, 252, 148, 39, 164, 133, 239, 115, 142, 177, 193, 215, 46, 214, 180, 222, 222, 200, 145, 203, 219 },
                            PasswordSalt = new byte[] { 186, 65, 135, 84, 235, 18, 151, 37, 46, 128, 228, 177, 50, 71, 208, 2, 227, 213, 225, 234, 200, 44, 199, 249, 61, 227, 178, 210, 58, 134, 186, 63, 60, 194, 229, 214, 222, 53, 35, 168, 102, 183, 56, 85, 85, 90, 172, 213, 248, 67, 203, 247, 190, 130, 143, 147, 227, 61, 181, 241, 205, 170, 251, 21, 184, 172, 72, 32, 153, 248, 216, 100, 6, 149, 51, 213, 151, 215, 102, 11, 221, 212, 161, 18, 234, 195, 29, 117, 248, 234, 149, 180, 69, 23, 193, 88, 53, 86, 154, 30, 109, 32, 249, 96, 95, 205, 40, 191, 42, 225, 248, 133, 31, 112, 247, 59, 111, 47, 107, 224, 57, 196, 64, 187, 93, 67, 45, 166 },
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
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(189),
                            OperationClaimId = 1,
                            UserId = 5
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(199),
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