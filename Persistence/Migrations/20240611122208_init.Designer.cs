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
    [Migration("20240611122208_init")]
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
                            AppointmentTime = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1216),
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1217),
                            DoctorId = 3,
                            IsDeleted = false,
                            PatientId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            AppointmentTime = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1224),
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1225),
                            DoctorId = 4,
                            IsDeleted = false,
                            PatientId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            AppointmentTime = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1229),
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1230),
                            DoctorId = 3,
                            IsDeleted = false,
                            PatientId = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            AppointmentTime = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1233),
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1234),
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
                            CreatedDate = new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(1110),
                            DoctorSpecializationId = 1,
                            Experience = 10
                        },
                        new
                        {
                            Id = 4,
                            Biography = "Kalp Doktoru Özgeçmiş Example",
                            CreatedDate = new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(1117),
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
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(187),
                            Name = "Cerrah"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(223),
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
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1323),
                            Name = "Kardiyoloji Araştırmaları"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1331),
                            Name = "Çocuk Sağlığı"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1334),
                            Name = "Onkoloji Tedavi"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1338),
                            Name = "Nöroloji ve Beyin Cerrahisi"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1341),
                            Name = "Endokrinoloji ve Metabolizma"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1345),
                            Name = "Gastroenteroloji ve Sindirim Sistemi"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1388),
                            Name = "Psikiyatri ve Mental Sağlık"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1391),
                            Name = "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1394),
                            Name = "Parkinson Hastalığı"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1399),
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
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(333),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(342),
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
                            CreatedDate = new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(1012)
                        },
                        new
                        {
                            Id = 2,
                            Address = "1233 Main St",
                            AppointmentId = 0,
                            BloodType = "B+",
                            CreatedDate = new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(1021)
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1693),
                            Diagnosis = " Hipertansiyon",
                            ExaminationFindings = "Yüksek kan basıncı"
                        },
                        new
                        {
                            Id = 2,
                            AppointmentId = 2,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1701),
                            Diagnosis = " Hipertansiyon",
                            ExaminationFindings = "Yüksek kan basıncı"
                        },
                        new
                        {
                            Id = 3,
                            AppointmentId = 3,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1705),
                            Diagnosis = "Diabetes Mellitus",
                            ExaminationFindings = "Fasting blood sugar level of 140 mg/dL"
                        },
                        new
                        {
                            Id = 4,
                            AppointmentId = 4,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1709),
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
                            CreatedDate = new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(884),
                            Email = "hasta1@example.com",
                            FirstName = "John",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Doe",
                            PasswordHash = new byte[] { 243, 150, 71, 42, 143, 223, 78, 205, 33, 8, 230, 209, 139, 157, 103, 171, 38, 136, 189, 188, 98, 21, 226, 24, 203, 66, 60, 254, 1, 204, 137, 142, 27, 91, 148, 133, 16, 237, 104, 152, 151, 74, 154, 124, 11, 143, 133, 153, 61, 236, 53, 73, 85, 14, 109, 252, 157, 105, 169, 107, 96, 98, 26, 158 },
                            PasswordSalt = new byte[] { 37, 49, 100, 185, 106, 53, 47, 217, 90, 122, 94, 190, 135, 227, 201, 233, 168, 196, 241, 193, 109, 217, 118, 91, 69, 150, 192, 38, 210, 33, 40, 71, 3, 178, 14, 173, 78, 213, 191, 157, 146, 188, 0, 82, 12, 234, 77, 176, 151, 49, 95, 45, 153, 66, 58, 137, 92, 154, 71, 28, 68, 17, 58, 65, 2, 180, 131, 148, 233, 137, 44, 104, 45, 120, 171, 105, 134, 210, 98, 107, 129, 232, 161, 8, 156, 109, 99, 139, 192, 234, 146, 195, 9, 219, 19, 197, 223, 146, 149, 170, 41, 226, 162, 139, 112, 222, 224, 198, 100, 70, 245, 97, 150, 169, 28, 90, 217, 240, 111, 203, 82, 71, 55, 232, 102, 47, 91, 228 },
                            PhoneNumber = "1234567890",
                            UserType = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(894),
                            Email = "hasta2@example.com",
                            FirstName = "Jonathan",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Corwin",
                            PasswordHash = new byte[] { 243, 150, 71, 42, 143, 223, 78, 205, 33, 8, 230, 209, 139, 157, 103, 171, 38, 136, 189, 188, 98, 21, 226, 24, 203, 66, 60, 254, 1, 204, 137, 142, 27, 91, 148, 133, 16, 237, 104, 152, 151, 74, 154, 124, 11, 143, 133, 153, 61, 236, 53, 73, 85, 14, 109, 252, 157, 105, 169, 107, 96, 98, 26, 158 },
                            PasswordSalt = new byte[] { 37, 49, 100, 185, 106, 53, 47, 217, 90, 122, 94, 190, 135, 227, 201, 233, 168, 196, 241, 193, 109, 217, 118, 91, 69, 150, 192, 38, 210, 33, 40, 71, 3, 178, 14, 173, 78, 213, 191, 157, 146, 188, 0, 82, 12, 234, 77, 176, 151, 49, 95, 45, 153, 66, 58, 137, 92, 154, 71, 28, 68, 17, 58, 65, 2, 180, 131, 148, 233, 137, 44, 104, 45, 120, 171, 105, 134, 210, 98, 107, 129, 232, 161, 8, 156, 109, 99, 139, 192, 234, 146, 195, 9, 219, 19, 197, 223, 146, 149, 170, 41, 226, 162, 139, 112, 222, 224, 198, 100, 70, 245, 97, 150, 169, 28, 90, 217, 240, 111, 203, 82, 71, 55, 232, 102, 47, 91, 228 },
                            PhoneNumber = "1234512345",
                            UserType = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(899),
                            Email = "doktor1@example.com",
                            FirstName = "batu",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "cerrahlar",
                            PasswordHash = new byte[] { 243, 150, 71, 42, 143, 223, 78, 205, 33, 8, 230, 209, 139, 157, 103, 171, 38, 136, 189, 188, 98, 21, 226, 24, 203, 66, 60, 254, 1, 204, 137, 142, 27, 91, 148, 133, 16, 237, 104, 152, 151, 74, 154, 124, 11, 143, 133, 153, 61, 236, 53, 73, 85, 14, 109, 252, 157, 105, 169, 107, 96, 98, 26, 158 },
                            PasswordSalt = new byte[] { 37, 49, 100, 185, 106, 53, 47, 217, 90, 122, 94, 190, 135, 227, 201, 233, 168, 196, 241, 193, 109, 217, 118, 91, 69, 150, 192, 38, 210, 33, 40, 71, 3, 178, 14, 173, 78, 213, 191, 157, 146, 188, 0, 82, 12, 234, 77, 176, 151, 49, 95, 45, 153, 66, 58, 137, 92, 154, 71, 28, 68, 17, 58, 65, 2, 180, 131, 148, 233, 137, 44, 104, 45, 120, 171, 105, 134, 210, 98, 107, 129, 232, 161, 8, 156, 109, 99, 139, 192, 234, 146, 195, 9, 219, 19, 197, 223, 146, 149, 170, 41, 226, 162, 139, 112, 222, 224, 198, 100, 70, 245, 97, 150, 169, 28, 90, 217, 240, 111, 203, 82, 71, 55, 232, 102, 47, 91, 228 },
                            PhoneNumber = "1234512312",
                            UserType = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(904),
                            Email = "doktor2@example.com",
                            FirstName = "kalp",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "doktoru",
                            PasswordHash = new byte[] { 243, 150, 71, 42, 143, 223, 78, 205, 33, 8, 230, 209, 139, 157, 103, 171, 38, 136, 189, 188, 98, 21, 226, 24, 203, 66, 60, 254, 1, 204, 137, 142, 27, 91, 148, 133, 16, 237, 104, 152, 151, 74, 154, 124, 11, 143, 133, 153, 61, 236, 53, 73, 85, 14, 109, 252, 157, 105, 169, 107, 96, 98, 26, 158 },
                            PasswordSalt = new byte[] { 37, 49, 100, 185, 106, 53, 47, 217, 90, 122, 94, 190, 135, 227, 201, 233, 168, 196, 241, 193, 109, 217, 118, 91, 69, 150, 192, 38, 210, 33, 40, 71, 3, 178, 14, 173, 78, 213, 191, 157, 146, 188, 0, 82, 12, 234, 77, 176, 151, 49, 95, 45, 153, 66, 58, 137, 92, 154, 71, 28, 68, 17, 58, 65, 2, 180, 131, 148, 233, 137, 44, 104, 45, 120, 171, 105, 134, 210, 98, 107, 129, 232, 161, 8, 156, 109, 99, 139, 192, 234, 146, 195, 9, 219, 19, 197, 223, 146, 149, 170, 41, 226, 162, 139, 112, 222, 224, 198, 100, 70, 245, 97, 150, 169, 28, 90, 217, 240, 111, 203, 82, 71, 55, 232, 102, 47, 91, 228 },
                            PhoneNumber = "1234512313",
                            UserType = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(907),
                            Email = "admin@example.com",
                            FirstName = "Admin",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Yöneticioğlu",
                            PasswordHash = new byte[] { 243, 150, 71, 42, 143, 223, 78, 205, 33, 8, 230, 209, 139, 157, 103, 171, 38, 136, 189, 188, 98, 21, 226, 24, 203, 66, 60, 254, 1, 204, 137, 142, 27, 91, 148, 133, 16, 237, 104, 152, 151, 74, 154, 124, 11, 143, 133, 153, 61, 236, 53, 73, 85, 14, 109, 252, 157, 105, 169, 107, 96, 98, 26, 158 },
                            PasswordSalt = new byte[] { 37, 49, 100, 185, 106, 53, 47, 217, 90, 122, 94, 190, 135, 227, 201, 233, 168, 196, 241, 193, 109, 217, 118, 91, 69, 150, 192, 38, 210, 33, 40, 71, 3, 178, 14, 173, 78, 213, 191, 157, 146, 188, 0, 82, 12, 234, 77, 176, 151, 49, 95, 45, 153, 66, 58, 137, 92, 154, 71, 28, 68, 17, 58, 65, 2, 180, 131, 148, 233, 137, 44, 104, 45, 120, 171, 105, 134, 210, 98, 107, 129, 232, 161, 8, 156, 109, 99, 139, 192, 234, 146, 195, 9, 219, 19, 197, 223, 146, 149, 170, 41, 226, 162, 139, 112, 222, 224, 198, 100, 70, 245, 97, 150, 169, 28, 90, 217, 240, 111, 203, 82, 71, 55, 232, 102, 47, 91, 228 },
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
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(449),
                            OperationClaimId = 1,
                            UserId = 5
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(458),
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