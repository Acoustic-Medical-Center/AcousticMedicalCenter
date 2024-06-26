﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorSpecializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSpecializations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeedbackMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    DoctorSpecializationId = table.Column<int>(type: "int", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_DoctorSpecializations_DoctorSpecializationId",
                        column: x => x.DoctorSpecializationId,
                        principalTable: "DoctorSpecializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctors_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorInterests",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    InterestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorInterests", x => new { x.DoctorId, x.InterestId });
                    table.ForeignKey(
                        name: "FK_DoctorInterests_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorInterests_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicationDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DosageInstructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ExaminationFindings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DoctorSpecializations",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "NameEN", "NameTR", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3222), null, "Neurosurgery", "Beyin ve Sinir Cerrahisi", null },
                    { 2, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3244), null, "Dermatology", "Dermatoloji", null },
                    { 3, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3245), null, "General Surgery", "Genel Cerrahi", null },
                    { 4, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3246), null, "Ophthalmology", "Göz Hastalıkları", null },
                    { 5, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3247), null, "Internal Medicine", "İç Hastalıkları", null },
                    { 6, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3249), null, "Obstetrics and Gynecology", "Kadın Hastalıkları ve Doğum", null },
                    { 7, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3249), null, "Otorhinolaryngology", "Kulak Burun Boğaz", null },
                    { 8, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3250), null, "Orthopedics and Traumatology", "Ortopedi ve Travmatoloji", null },
                    { 9, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3251), null, "Urology", "Üroloji", null },
                    { 10, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3252), null, "Pediatrics", "Çocuk Sağlığı ve Hastalıkları", null }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5006), null, "Kardiyoloji Araştırmaları", null },
                    { 2, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5017), null, "Çocuk Sağlığı", null },
                    { 3, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5021), null, "Onkoloji Tedavi", null },
                    { 4, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5025), null, "Nöroloji ve Beyin Cerrahisi", null },
                    { 5, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5028), null, "Endokrinoloji ve Metabolizma", null },
                    { 6, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5032), null, "Gastroenteroloji ve Sindirim Sistemi", null },
                    { 7, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5035), null, "Psikiyatri ve Mental Sağlık", null },
                    { 8, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5038), null, "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri", null },
                    { 9, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5041), null, "Parkinson Hastalığı", null },
                    { 10, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5045), null, "Bunama", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3516), null, "Admin", null },
                    { 2, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3526), null, "Appointment.Delete", null },
                    { 3, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3531), null, "Doctor", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4314), null, "hasta1@example.com", "John", "Male", false, "Doe", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234567890", null, 0 },
                    { 2, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4328), null, "hasta2@example.com", "Jonathan", "Male", false, "Corwin", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234512345", null, 0 },
                    { 3, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4333), null, "doktor1@example.com", "batu", "Male", false, "cerrahlar", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234512312", null, 1 },
                    { 4, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4338), null, "doktor4@example.com", "Fatma", "Female", false, "Koç", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500004", null, 1 },
                    { 5, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4339), null, "doktor5@example.com", "Mehmet", "Male", false, "Öz", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500005", null, 1 },
                    { 6, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4340), null, "doktor6@example.com", "Canan", "Female", false, "Çelik", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500006", null, 1 },
                    { 7, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4342), null, "doktor7@example.com", "Emre", "Male", false, "Arı", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500007", null, 1 },
                    { 8, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4343), null, "doktor8@example.com", "Burak", "Male", false, "Temiz", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500008", null, 1 },
                    { 9, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4345), null, "doktor9@example.com", "Seda", "Female", false, "Ak", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500009", null, 1 },
                    { 10, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4346), null, "doktor10@example.com", "Murat", "Male", false, "Tez", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500010", null, 1 },
                    { 11, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4348), null, "doktor11@example.com", "Zeynep", "Female", false, "Bal", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500011", null, 1 },
                    { 12, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4349), null, "doktor12@example.com", "Kemal", "Male", false, "Sağ", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500012", null, 1 },
                    { 13, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4350), null, "doktor13@example.com", "Cansu", "Female", false, "Dur", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500013", null, 1 },
                    { 14, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4352), null, "doktor14@example.com", "Oğuz", "Male", false, "Kurt", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500014", null, 1 },
                    { 15, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4353), null, "doktor15@example.com", "Esra", "Female", false, "Deniz", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500015", null, 1 },
                    { 16, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4355), null, "doktor16@example.com", "Baran", "Male", false, "Gül", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500016", null, 1 },
                    { 17, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4356), null, "doktor17@example.com", "Duygu", "Female", false, "Aydın", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500017", null, 1 },
                    { 18, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4358), null, "doktor18@example.com", "Tarkan", "Male", false, "Kara", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500018", null, 1 },
                    { 19, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4359), null, "doktor19@example.com", "Nil", "Female", false, "Koç", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500019", null, 1 },
                    { 20, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4361), null, "doktor20@example.com", "Sami", "Male", false, "Öztürk", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500020", null, 1 },
                    { 21, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4362), null, "doktor21@example.com", "Ece", "Female", false, "Uzun", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500021", null, 1 },
                    { 22, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4363), null, "doktor22@example.com", "Levent", "Male", false, "Yıldız", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500022", null, 1 },
                    { 23, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4365), null, "doktor23@example.com", "Selin", "Female", false, "Demirci", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500023", null, 1 },
                    { 24, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4366), null, "doktor24@example.com", "Onur", "Male", false, "Akar", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500024", null, 1 },
                    { 25, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4368), null, "doktor25@example.com", "İrem", "Female", false, "Dere", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500025", null, 1 },
                    { 26, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4369), null, "doktor26@example.com", "Cenk", "Male", false, "Taş", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500026", null, 1 },
                    { 27, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4371), null, "doktor27@example.com", "Hande", "Female", false, "Yener", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234500027", null, 1 },
                    { 99, new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4388), null, "admin@example.com", "Admin", "Male", false, "Yöneticioğlu", new byte[] { 110, 96, 48, 96, 147, 189, 194, 44, 71, 37, 117, 108, 185, 12, 243, 126, 71, 76, 2, 137, 241, 3, 39, 1, 63, 6, 197, 224, 213, 223, 185, 141, 7, 220, 95, 18, 171, 95, 248, 33, 10, 171, 110, 142, 246, 175, 200, 143, 0, 255, 87, 231, 210, 67, 69, 181, 215, 64, 222, 112, 162, 189, 208, 76 }, new byte[] { 143, 102, 34, 179, 255, 9, 16, 197, 122, 221, 95, 109, 228, 152, 157, 195, 137, 191, 214, 6, 55, 12, 226, 63, 167, 143, 144, 178, 138, 204, 106, 219, 217, 175, 232, 207, 22, 122, 161, 189, 60, 250, 213, 205, 7, 196, 63, 29, 86, 224, 212, 184, 58, 37, 124, 84, 220, 60, 17, 49, 91, 35, 224, 73, 29, 188, 15, 203, 133, 85, 30, 133, 33, 41, 252, 65, 187, 81, 255, 64, 209, 160, 64, 15, 63, 81, 238, 155, 208, 78, 79, 240, 18, 126, 190, 250, 126, 31, 239, 165, 82, 97, 112, 154, 128, 22, 52, 83, 5, 0, 16, 119, 59, 62, 54, 63, 153, 61, 98, 172, 112, 35, 171, 182, 14, 71, 149, 229 }, "1234512345", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Biography", "CreatedDate", "DeletedDate", "DoctorSpecializationId", "Experience", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, "Id 3 olan Doktor Özgeçmiş Example asd", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4670), null, 1, 10, null },
                    { 4, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4679), null, 2, 5, null },
                    { 5, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4680), null, 7, 3, null },
                    { 6, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4681), null, 1, 10, null },
                    { 7, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4682), null, 4, 8, null },
                    { 8, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4683), null, 6, 6, null },
                    { 9, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4684), null, 9, 7, null },
                    { 10, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4685), null, 5, 2, null },
                    { 11, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4686), null, 10, 4, null },
                    { 12, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4686), null, 8, 9, null },
                    { 13, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4687), null, 3, 6, null },
                    { 14, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4688), null, 2, 5, null },
                    { 15, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4689), null, 7, 3, null },
                    { 16, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4690), null, 1, 10, null },
                    { 17, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4708), null, 4, 8, null },
                    { 18, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4710), null, 6, 6, null },
                    { 19, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4711), null, 9, 7, null },
                    { 20, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4712), null, 5, 2, null },
                    { 21, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4712), null, 10, 4, null },
                    { 22, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4713), null, 8, 9, null },
                    { 23, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4714), null, 3, 6, null },
                    { 24, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4715), null, 2, 5, null },
                    { 25, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4716), null, 1, 4, null },
                    { 26, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4717), null, 5, 7, null },
                    { 27, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4718), null, 8, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1234 Main St", 0, "A+", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4536), null, null },
                    { 2, "1233 Main St", 0, "B+", new DateTime(2024, 6, 26, 13, 53, 59, 326, DateTimeKind.Utc).AddTicks(4548), null, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3644), null, 1, null, 5 },
                    { 2, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3654), null, 2, null, 3 },
                    { 3, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3659), null, 3, null, 3 },
                    { 4, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(3663), null, 3, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "CreatedDate", "DeletedDate", "DoctorId", "IsDeleted", "PatientId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(4838), new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(4840), null, 3, false, 1, 0, null },
                    { 2, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(4851), new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(4851), null, 4, false, 1, 0, null },
                    { 3, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(4856), null, 3, false, 2, 0, null },
                    { 4, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(4860), new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(4860), null, 4, false, 2, 0, null }
                });

            migrationBuilder.InsertData(
                table: "DoctorInterests",
                columns: new[] { "DoctorId", "InterestId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 3, 2 },
                    { 4, 7 },
                    { 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "AppointmentId", "CreatedDate", "DeletedDate", "Diagnosis", "ExaminationFindings", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5285), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 2, 2, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5295), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 3, 3, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5299), null, "Diabetes Mellitus", "Fasting blood sugar level of 140 mg/dL", null },
                    { 4, 4, new DateTime(2024, 6, 26, 16, 53, 59, 326, DateTimeKind.Local).AddTicks(5303), null, "Chronic Obstructive Pulmonary Disease (COPD)", "Reduced lung function on spirometry", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorInterests_InterestId",
                table: "DoctorInterests",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DoctorSpecializationId",
                table: "Doctors",
                column: "DoctorSpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_AppointmentId",
                table: "Prescriptions",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_AppointmentId",
                table: "Reports",
                column: "AppointmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_UserId",
                table: "UserOperationClaims",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorInterests");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "DoctorSpecializations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
