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
    [Migration("20240608152938_mig11")]
    partial class mig11
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
                            AppointmentTime = new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(3262),
                            CreatedDate = new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(3263),
                            DoctorId = 3,
                            IsDeleted = false,
                            PatientId = 1,
                            Status = 0
                        });
                });

            modelBuilder.Entity("Domain.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

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
                            AppointmentId = 0,
                            CreatedDate = new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(3169),
                            DoctorSpecializationId = 1,
                            Experience = 10
                        },
                        new
                        {
                            Id = 4,
                            AppointmentId = 0,
                            CreatedDate = new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(3175),
                            DoctorSpecializationId = 2,
                            Experience = 5
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
                            CreatedDate = new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(2121),
                            Name = "Cerrah"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(2155),
                            Name = "Kalp"
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
                            CreatedDate = new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(2354),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(2367),
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
                            CreatedDate = new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(3075)
                        },
                        new
                        {
                            Id = 2,
                            Address = "1233 Main St",
                            AppointmentId = 0,
                            BloodType = "B+",
                            CreatedDate = new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(3082)
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
                            CreatedDate = new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(2960),
                            Email = "hasta1@example.com",
                            FirstName = "John",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Doe",
                            PasswordHash = new byte[] { 19, 112, 48, 82, 122, 170, 69, 75, 83, 24, 2, 243, 80, 202, 166, 120, 117, 33, 1, 229, 207, 205, 34, 199, 234, 190, 62, 83, 109, 7, 24, 92, 248, 30, 16, 233, 46, 71, 53, 218, 53, 115, 207, 130, 93, 209, 75, 49, 225, 70, 159, 231, 31, 64, 215, 129, 156, 46, 87, 114, 82, 72, 153, 74 },
                            PasswordSalt = new byte[] { 97, 30, 120, 255, 115, 234, 151, 99, 61, 38, 135, 78, 58, 248, 163, 225, 175, 190, 53, 127, 71, 238, 136, 143, 187, 110, 5, 84, 52, 151, 87, 183, 120, 8, 122, 240, 78, 10, 167, 14, 15, 106, 196, 121, 213, 90, 107, 102, 119, 204, 98, 205, 92, 100, 85, 230, 248, 118, 222, 139, 217, 211, 139, 134, 127, 202, 231, 104, 233, 160, 100, 38, 41, 11, 27, 208, 155, 214, 232, 18, 111, 107, 147, 173, 119, 110, 119, 70, 59, 145, 180, 124, 248, 79, 72, 57, 11, 106, 104, 141, 221, 239, 186, 86, 151, 117, 6, 19, 19, 166, 22, 167, 237, 77, 183, 104, 14, 157, 69, 101, 108, 240, 168, 25, 95, 186, 78, 67 },
                            PhoneNumber = "1234567890",
                            UserType = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(2969),
                            Email = "hasta2@example.com",
                            FirstName = "Jonathan",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Corwin",
                            PasswordHash = new byte[] { 19, 112, 48, 82, 122, 170, 69, 75, 83, 24, 2, 243, 80, 202, 166, 120, 117, 33, 1, 229, 207, 205, 34, 199, 234, 190, 62, 83, 109, 7, 24, 92, 248, 30, 16, 233, 46, 71, 53, 218, 53, 115, 207, 130, 93, 209, 75, 49, 225, 70, 159, 231, 31, 64, 215, 129, 156, 46, 87, 114, 82, 72, 153, 74 },
                            PasswordSalt = new byte[] { 97, 30, 120, 255, 115, 234, 151, 99, 61, 38, 135, 78, 58, 248, 163, 225, 175, 190, 53, 127, 71, 238, 136, 143, 187, 110, 5, 84, 52, 151, 87, 183, 120, 8, 122, 240, 78, 10, 167, 14, 15, 106, 196, 121, 213, 90, 107, 102, 119, 204, 98, 205, 92, 100, 85, 230, 248, 118, 222, 139, 217, 211, 139, 134, 127, 202, 231, 104, 233, 160, 100, 38, 41, 11, 27, 208, 155, 214, 232, 18, 111, 107, 147, 173, 119, 110, 119, 70, 59, 145, 180, 124, 248, 79, 72, 57, 11, 106, 104, 141, 221, 239, 186, 86, 151, 117, 6, 19, 19, 166, 22, 167, 237, 77, 183, 104, 14, 157, 69, 101, 108, 240, 168, 25, 95, 186, 78, 67 },
                            PhoneNumber = "1234512345",
                            UserType = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(2974),
                            Email = "doktor1@example.com",
                            FirstName = "batu",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "cerrahlar",
                            PasswordHash = new byte[] { 19, 112, 48, 82, 122, 170, 69, 75, 83, 24, 2, 243, 80, 202, 166, 120, 117, 33, 1, 229, 207, 205, 34, 199, 234, 190, 62, 83, 109, 7, 24, 92, 248, 30, 16, 233, 46, 71, 53, 218, 53, 115, 207, 130, 93, 209, 75, 49, 225, 70, 159, 231, 31, 64, 215, 129, 156, 46, 87, 114, 82, 72, 153, 74 },
                            PasswordSalt = new byte[] { 97, 30, 120, 255, 115, 234, 151, 99, 61, 38, 135, 78, 58, 248, 163, 225, 175, 190, 53, 127, 71, 238, 136, 143, 187, 110, 5, 84, 52, 151, 87, 183, 120, 8, 122, 240, 78, 10, 167, 14, 15, 106, 196, 121, 213, 90, 107, 102, 119, 204, 98, 205, 92, 100, 85, 230, 248, 118, 222, 139, 217, 211, 139, 134, 127, 202, 231, 104, 233, 160, 100, 38, 41, 11, 27, 208, 155, 214, 232, 18, 111, 107, 147, 173, 119, 110, 119, 70, 59, 145, 180, 124, 248, 79, 72, 57, 11, 106, 104, 141, 221, 239, 186, 86, 151, 117, 6, 19, 19, 166, 22, 167, 237, 77, 183, 104, 14, 157, 69, 101, 108, 240, 168, 25, 95, 186, 78, 67 },
                            PhoneNumber = "1234512312",
                            UserType = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(2978),
                            Email = "doktor2@example.com",
                            FirstName = "kalp",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "doktoru",
                            PasswordHash = new byte[] { 19, 112, 48, 82, 122, 170, 69, 75, 83, 24, 2, 243, 80, 202, 166, 120, 117, 33, 1, 229, 207, 205, 34, 199, 234, 190, 62, 83, 109, 7, 24, 92, 248, 30, 16, 233, 46, 71, 53, 218, 53, 115, 207, 130, 93, 209, 75, 49, 225, 70, 159, 231, 31, 64, 215, 129, 156, 46, 87, 114, 82, 72, 153, 74 },
                            PasswordSalt = new byte[] { 97, 30, 120, 255, 115, 234, 151, 99, 61, 38, 135, 78, 58, 248, 163, 225, 175, 190, 53, 127, 71, 238, 136, 143, 187, 110, 5, 84, 52, 151, 87, 183, 120, 8, 122, 240, 78, 10, 167, 14, 15, 106, 196, 121, 213, 90, 107, 102, 119, 204, 98, 205, 92, 100, 85, 230, 248, 118, 222, 139, 217, 211, 139, 134, 127, 202, 231, 104, 233, 160, 100, 38, 41, 11, 27, 208, 155, 214, 232, 18, 111, 107, 147, 173, 119, 110, 119, 70, 59, 145, 180, 124, 248, 79, 72, 57, 11, 106, 104, 141, 221, 239, 186, 86, 151, 117, 6, 19, 19, 166, 22, 167, 237, 77, 183, 104, 14, 157, 69, 101, 108, 240, 168, 25, 95, 186, 78, 67 },
                            PhoneNumber = "1234512313",
                            UserType = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(2981),
                            Email = "admin@example.com",
                            FirstName = "Admin",
                            Gender = "Male",
                            IsDeleted = false,
                            LastName = "Yöneticioğlu",
                            PasswordHash = new byte[] { 19, 112, 48, 82, 122, 170, 69, 75, 83, 24, 2, 243, 80, 202, 166, 120, 117, 33, 1, 229, 207, 205, 34, 199, 234, 190, 62, 83, 109, 7, 24, 92, 248, 30, 16, 233, 46, 71, 53, 218, 53, 115, 207, 130, 93, 209, 75, 49, 225, 70, 159, 231, 31, 64, 215, 129, 156, 46, 87, 114, 82, 72, 153, 74 },
                            PasswordSalt = new byte[] { 97, 30, 120, 255, 115, 234, 151, 99, 61, 38, 135, 78, 58, 248, 163, 225, 175, 190, 53, 127, 71, 238, 136, 143, 187, 110, 5, 84, 52, 151, 87, 183, 120, 8, 122, 240, 78, 10, 167, 14, 15, 106, 196, 121, 213, 90, 107, 102, 119, 204, 98, 205, 92, 100, 85, 230, 248, 118, 222, 139, 217, 211, 139, 134, 127, 202, 231, 104, 233, 160, 100, 38, 41, 11, 27, 208, 155, 214, 232, 18, 111, 107, 147, 173, 119, 110, 119, 70, 59, 145, 180, 124, 248, 79, 72, 57, 11, 106, 104, 141, 221, 239, 186, 86, 151, 117, 6, 19, 19, 166, 22, 167, 237, 77, 183, 104, 14, 157, 69, 101, 108, 240, 168, 25, 95, 186, 78, 67 },
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
                            CreatedDate = new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(2467),
                            OperationClaimId = 1,
                            UserId = 5
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(2476),
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

            modelBuilder.Entity("Domain.Entities.Patient", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithOne("Patient")
                        .HasForeignKey("Domain.Entities.Patient", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
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

            modelBuilder.Entity("Domain.Entities.Doctor", b =>
                {
                    b.Navigation("Appointment");
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
