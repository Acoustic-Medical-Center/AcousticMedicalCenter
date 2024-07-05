using System;
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
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
                    { 1, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1137), null, "Neurosurgery", "Beyin ve Sinir Cerrahisi", null },
                    { 2, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1147), null, "Dermatology", "Dermatoloji", null },
                    { 3, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1149), null, "General Surgery", "Genel Cerrahi", null },
                    { 4, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1150), null, "Ophthalmology", "Göz Hastalıkları", null },
                    { 5, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1151), null, "Internal Medicine", "İç Hastalıkları", null },
                    { 6, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1152), null, "Obstetrics and Gynecology", "Kadın Hastalıkları ve Doğum", null },
                    { 7, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1154), null, "Otorhinolaryngology", "Kulak Burun Boğaz", null },
                    { 8, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1155), null, "Orthopedics and Traumatology", "Ortopedi ve Travmatoloji", null },
                    { 9, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1156), null, "Urology", "Üroloji", null },
                    { 10, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1157), null, "Pediatrics", "Çocuk Sağlığı ve Hastalıkları", null }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6188), null, "Kardiyoloji Araştırmaları", null },
                    { 2, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6197), null, "Çocuk Sağlığı", null },
                    { 3, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6201), null, "Onkoloji Tedavi", null },
                    { 4, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6205), null, "Nöroloji ve Beyin Cerrahisi", null },
                    { 5, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6208), null, "Endokrinoloji ve Metabolizma", null },
                    { 6, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6213), null, "Gastroenteroloji ve Sindirim Sistemi", null },
                    { 7, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6216), null, "Psikiyatri ve Mental Sağlık", null },
                    { 8, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6219), null, "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri", null },
                    { 9, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6222), null, "Parkinson Hastalığı", null },
                    { 10, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6226), null, "Bunama", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1366), null, "Admin", null },
                    { 2, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1374), null, "Appointment.Delete", null },
                    { 3, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1379), null, "Doctor", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(2277), null, "hasta1@example.com", "46fw7Rk8/m7cXdvb9VCuiw==", "Male", false, "IY+uLFq91e9Pl1fZz9KL+g==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234567890", null, 0 },
                    { 2, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(2397), null, "hasta2@example.com", "lx191yNB5UTgUeNqX1QIZQ==", "Male", false, "ESeBAof1D3qOrdvr0NsjqQ==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234512345", null, 0 },
                    { 3, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(2507), null, "doktor1@example.com", "JJIVK0Z5Q3xurg/5rwsjpw==", "Male", false, "SbwDEUPBok2ObkCL8mzFcQ==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234512312", null, 1 },
                    { 4, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(2616), null, "doktor4@example.com", "FfeaE5zn6NjabjeVhYSrEQ==", "Female", false, "dwMtHvVvQqj6d7sMPCqIjg==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500004", null, 1 },
                    { 5, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(2719), null, "doktor5@example.com", "+au//BigQ3yTZoy4bkmhhQ==", "Male", false, "dzHbICsDLYy/vGyYJIPZfQ==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500005", null, 1 },
                    { 6, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(2819), null, "doktor6@example.com", "Mh0v4J32+JlNpaD/O7+qSA==", "Female", false, "+hNFC6xqdqf8w9sO855a0Q==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500006", null, 1 },
                    { 7, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(2910), null, "doktor7@example.com", "Ibn6o8AedzQLx6T8v7QyWQ==", "Male", false, "qApbKXsPUcTvGAWZiov2eg==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500007", null, 1 },
                    { 8, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(3037), null, "doktor8@example.com", "QRc31Nk0c/N3r0eGOY3tJg==", "Male", false, "crndYAoJPeqqluXZHHwnzQ==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500008", null, 1 },
                    { 9, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(3196), null, "doktor9@example.com", "2vpZVUEDo5Auij4xmX6p/w==", "Female", false, "pnrXKW7b8Nkl2aPQe6wmIA==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500009", null, 1 },
                    { 10, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(3308), null, "doktor10@example.com", "qZKdo9nxms9FWbRIQ6mDQg==", "Male", false, "72UZHOJjBL5fuqnE5KqkAA==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500010", null, 1 },
                    { 11, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(3404), null, "doktor11@example.com", "jj9UNKyFcbh2ikUCQQDWyw==", "Female", false, "Etzl4OT8hsUVt6ZxK/O0LA==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500011", null, 1 },
                    { 12, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(3502), null, "doktor12@example.com", "Q4daCkyHEECDbBgMNxgSIA==", "Male", false, "/Q9/SHuMD9cCphQ2hpSmJg==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500012", null, 1 },
                    { 13, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(3604), null, "doktor13@example.com", "w+eXoITM5M9bWhvdxONk6g==", "Female", false, "jzee7V57E88iuKsNYWgVYw==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500013", null, 1 },
                    { 14, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(3703), null, "doktor14@example.com", "onmhUNgVYSb9KJWjNTgeig==", "Male", false, "QjBL/R6X9KC7lG1rhgidbw==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500014", null, 1 },
                    { 15, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(3801), null, "doktor15@example.com", "Fvj3ZYvX8aHqo+f8cu9Hgw==", "Female", false, "IqHJenJjFanZMJg+oHogDw==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500015", null, 1 },
                    { 16, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(3893), null, "doktor16@example.com", "2OrR7nTyK7M9EzSHBXuaOw==", "Male", false, "PQ79eSlatrg1jKu+RShUWw==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500016", null, 1 },
                    { 17, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(4008), null, "doktor17@example.com", "CxBc6OuQft7mnBW4YZ2RmQ==", "Female", false, "M/0Rh8M/57cW6K5KSeg/wQ==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500017", null, 1 },
                    { 18, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(4071), null, "doktor18@example.com", "v8S/QBqz7DdlbUyIGJVanw==", "Male", false, "HEnM1rpNCBeMA1OQBWYQQA==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500018", null, 1 },
                    { 19, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(4181), null, "doktor19@example.com", "qQeUOmjbsPj9QrelGnJ0xw==", "Female", false, "dwMtHvVvQqj6d7sMPCqIjg==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500019", null, 1 },
                    { 20, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(4277), null, "doktor20@example.com", "XGLB1Jqkf8ye3RiI7REdtg==", "Male", false, "asHqAzJLyIiq8nFybKhJ9Q==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500020", null, 1 },
                    { 21, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(4451), null, "doktor21@example.com", "E6GrrCDe0S5fe/J0cQT0QQ==", "Female", false, "F5wwQbK4qmtX1bWH9FPM4w==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500021", null, 1 },
                    { 22, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(4548), null, "doktor22@example.com", "NTN4MQGjhs5QmulzI20AUQ==", "Male", false, "3uGzHpqFlftm4h46r6sCvg==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500022", null, 1 },
                    { 23, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(4645), null, "doktor23@example.com", "F9vfnlFH27RRbGIAlLcUrg==", "Female", false, "zxIs9+mg1FC/hF/oGsX7yg==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500023", null, 1 },
                    { 24, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(4741), null, "doktor24@example.com", "76Jr0erPduMYIgqOy5Gm2A==", "Male", false, "ZVYa/Ha75fykIUoBnPYU2w==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500024", null, 1 },
                    { 25, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(4826), null, "doktor25@example.com", "Gnvo6mwNUF/bN9v9ID485w==", "Female", false, "qJCxvSS+EnCd4srQEbeJvw==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500025", null, 1 },
                    { 26, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(4887), null, "doktor26@example.com", "Erzb68h8hV8wJ2vAGBiz5Q==", "Male", false, "tZEaxP2Ab3PHXSqcANuRYw==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500026", null, 1 },
                    { 27, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5023), null, "doktor27@example.com", "RHmGtLmFF2rZIizvT6WWJg==", "Female", false, "cUcUFQAnZR4CocSgPu3OUg==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234500027", null, 1 },
                    { 99, new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5148), null, "admin@example.com", "aNbdnOzUNuGnMPCOxe7GbA==", "Male", false, "7ZoRxRkAs9bCJPAAcPqRUQ==", new byte[] { 137, 240, 177, 182, 127, 103, 204, 218, 210, 214, 100, 29, 38, 254, 155, 18, 133, 26, 171, 150, 42, 202, 108, 71, 251, 235, 14, 198, 182, 194, 34, 119, 69, 115, 129, 77, 193, 9, 77, 14, 40, 46, 227, 95, 176, 183, 68, 189, 9, 93, 217, 39, 120, 30, 160, 250, 94, 93, 21, 32, 99, 64, 226, 14 }, new byte[] { 6, 109, 125, 91, 248, 30, 7, 252, 118, 23, 29, 161, 248, 175, 44, 161, 68, 195, 11, 22, 119, 238, 113, 174, 95, 178, 174, 27, 22, 73, 105, 97, 15, 180, 146, 33, 140, 214, 0, 67, 202, 113, 219, 200, 130, 175, 78, 6, 241, 199, 9, 251, 117, 169, 96, 193, 190, 171, 13, 125, 9, 3, 95, 102, 66, 122, 10, 110, 39, 95, 174, 221, 8, 85, 41, 255, 211, 148, 9, 135, 199, 157, 10, 94, 29, 25, 157, 148, 183, 125, 143, 60, 50, 85, 160, 60, 33, 237, 151, 105, 160, 253, 64, 86, 68, 148, 77, 2, 229, 192, 35, 222, 73, 161, 179, 228, 134, 85, 133, 1, 214, 155, 238, 73, 67, 127, 249, 67 }, "1234512345", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Biography", "CreatedDate", "DeletedDate", "DoctorSpecializationId", "Experience", "IsDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, "Id 3 olan Doktor Özgeçmiş Example asd", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5459), null, 1, 10, false, null },
                    { 4, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5466), null, 2, 5, false, null },
                    { 5, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5467), null, 7, 3, false, null },
                    { 6, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5468), null, 1, 10, false, null },
                    { 7, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5470), null, 4, 8, false, null },
                    { 8, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5514), null, 6, 6, false, null },
                    { 9, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5516), null, 9, 7, false, null },
                    { 10, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5517), null, 5, 2, false, null },
                    { 11, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5518), null, 10, 4, false, null },
                    { 12, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5519), null, 8, 9, false, null },
                    { 13, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5520), null, 3, 6, false, null },
                    { 14, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5522), null, 2, 5, false, null },
                    { 15, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5523), null, 7, 3, false, null },
                    { 16, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5524), null, 1, 10, false, null },
                    { 17, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5525), null, 4, 8, false, null },
                    { 18, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5527), null, 6, 6, false, null },
                    { 19, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5528), null, 9, 7, false, null },
                    { 20, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5529), null, 5, 2, false, null },
                    { 21, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5530), null, 10, 4, false, null },
                    { 22, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5531), null, 8, 9, false, null },
                    { 23, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5533), null, 3, 6, false, null },
                    { 24, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5534), null, 2, 5, false, null },
                    { 25, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5535), null, 1, 4, false, null },
                    { 26, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5536), null, 5, 7, false, null },
                    { 27, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5537), null, 8, 3, false, null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1234 Main St", 0, "A+", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5332), null, null },
                    { 2, "1233 Main St", 0, "B+", new DateTime(2024, 7, 4, 22, 31, 37, 379, DateTimeKind.Utc).AddTicks(5341), null, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1478), null, 1, null, 99 },
                    { 2, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1487), null, 2, null, 3 },
                    { 3, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1491), null, 3, null, 3 },
                    { 4, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(1495), null, 3, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "CreatedDate", "DeletedDate", "DoctorId", "IsDeleted", "PatientId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5771), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5773), null, 3, false, 1, 0, null },
                    { 2, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5781), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5782), null, 4, false, 1, 0, null },
                    { 3, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5786), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5786), null, 3, false, 2, 0, null },
                    { 4, new DateTime(2024, 6, 28, 8, 0, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 27, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 5, new DateTime(2024, 6, 27, 8, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 6, new DateTime(2024, 6, 27, 9, 0, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 8, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 7, new DateTime(2024, 6, 27, 9, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 8, new DateTime(2024, 6, 27, 10, 0, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 12, new DateTime(2024, 7, 6, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 13, new DateTime(2024, 7, 6, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 14, new DateTime(2024, 7, 6, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 15, new DateTime(2024, 7, 6, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 16, new DateTime(2024, 7, 6, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 17, new DateTime(2024, 7, 6, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 18, new DateTime(2024, 7, 6, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 19, new DateTime(2024, 7, 6, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 20, new DateTime(2024, 7, 6, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 21, new DateTime(2024, 7, 6, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 22, new DateTime(2024, 7, 6, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 23, new DateTime(2024, 7, 6, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 24, new DateTime(2024, 7, 6, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 25, new DateTime(2024, 7, 6, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 12, false, 2, 0, null },
                    { 50, new DateTime(2024, 7, 6, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 51, new DateTime(2024, 7, 6, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 52, new DateTime(2024, 7, 6, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 53, new DateTime(2024, 7, 6, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 54, new DateTime(2024, 7, 6, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 55, new DateTime(2024, 7, 6, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 56, new DateTime(2024, 7, 6, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 57, new DateTime(2024, 7, 6, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 58, new DateTime(2024, 7, 6, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 59, new DateTime(2024, 7, 6, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 60, new DateTime(2024, 7, 6, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 61, new DateTime(2024, 7, 6, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 62, new DateTime(2024, 7, 6, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 63, new DateTime(2024, 7, 6, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 4, false, 2, 0, null },
                    { 100, new DateTime(2024, 7, 6, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null },
                    { 101, new DateTime(2024, 7, 6, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null },
                    { 102, new DateTime(2024, 7, 6, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null },
                    { 103, new DateTime(2024, 7, 6, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null },
                    { 104, new DateTime(2024, 7, 6, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null },
                    { 105, new DateTime(2024, 7, 6, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null },
                    { 106, new DateTime(2024, 7, 6, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null },
                    { 107, new DateTime(2024, 7, 6, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null },
                    { 108, new DateTime(2024, 7, 6, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null },
                    { 109, new DateTime(2024, 7, 6, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null },
                    { 110, new DateTime(2024, 7, 6, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null },
                    { 111, new DateTime(2024, 7, 6, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null },
                    { 112, new DateTime(2024, 7, 6, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null },
                    { 113, new DateTime(2024, 7, 6, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(5953), null, 5, false, 2, 0, null }
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
                    { 1, 1, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6426), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 2, 2, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6434), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 3, 3, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6481), null, "Diabetes Mellitus", "Fasting blood sugar level of 140 mg/dL", null },
                    { 4, 4, new DateTime(2024, 7, 5, 1, 31, 37, 379, DateTimeKind.Local).AddTicks(6485), null, "Chronic Obstructive Pulmonary Disease (COPD)", "Reduced lung function on spirometry", null }
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
