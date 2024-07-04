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
                    { 1, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3373), null, "Neurosurgery", "Beyin ve Sinir Cerrahisi", null },
                    { 2, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3389), null, "Dermatology", "Dermatoloji", null },
                    { 3, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3390), null, "General Surgery", "Genel Cerrahi", null },
                    { 4, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3391), null, "Ophthalmology", "Göz Hastalıkları", null },
                    { 5, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3392), null, "Internal Medicine", "İç Hastalıkları", null },
                    { 6, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3393), null, "Obstetrics and Gynecology", "Kadın Hastalıkları ve Doğum", null },
                    { 7, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3394), null, "Otorhinolaryngology", "Kulak Burun Boğaz", null },
                    { 8, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3395), null, "Orthopedics and Traumatology", "Ortopedi ve Travmatoloji", null },
                    { 9, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3396), null, "Urology", "Üroloji", null },
                    { 10, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3397), null, "Pediatrics", "Çocuk Sağlığı ve Hastalıkları", null }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9123), null, "Kardiyoloji Araştırmaları", null },
                    { 2, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9132), null, "Çocuk Sağlığı", null },
                    { 3, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9135), null, "Onkoloji Tedavi", null },
                    { 4, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9138), null, "Nöroloji ve Beyin Cerrahisi", null },
                    { 5, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9141), null, "Endokrinoloji ve Metabolizma", null },
                    { 6, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9145), null, "Gastroenteroloji ve Sindirim Sistemi", null },
                    { 7, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9148), null, "Psikiyatri ve Mental Sağlık", null },
                    { 8, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9151), null, "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri", null },
                    { 9, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9153), null, "Parkinson Hastalığı", null },
                    { 10, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9156), null, "Bunama", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3626), null, "Admin", null },
                    { 2, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3670), null, "Appointment.Delete", null },
                    { 3, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3674), null, "Doctor", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(4701), null, "hasta1@example.com", "jJKj6zJuYyuGblzT55fLwqFtWBN+UdqzeUsOahipBNA=", "Male", false, "7U6O95176YRPY7DcZd5nqI6aWVKkqxXXpxTWWoCtbzw=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234567890", null, 0 },
                    { 2, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(4827), null, "hasta2@example.com", "UyuPupdDvgPZIZylNV5HgnOehl+ZngSyxpnsatpUnYc=", "Male", false, "4tI8Lg6OXyGG/ogKljryPycdPOZYKD0RaEhYcOvORzY=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234512345", null, 0 },
                    { 3, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(4958), null, "doktor1@example.com", "C9J+kESc4wBKZG+Z4w+jPILUZ5TCLhBM2x9SweqOU1g=", "Male", false, "PaWWVeUWfsTn9D6aAolLHaugssxMmeMvD+GikUCac5Y=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234512312", null, 1 },
                    { 4, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(5100), null, "doktor4@example.com", "ArDT+FQXdNpmgvZ8Wx1goAAcdcy1bws/SKwDMjk2RcM=", "Female", false, "0cIKa9y8FwHUTLuimVdBa3Uy13jC5UNgrv5OpicFDNQ=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500004", null, 1 },
                    { 5, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(5256), null, "doktor5@example.com", "MkSu4fxdP6zQ5CK1b5Xpelv9I2Ig9HOm+vG/AmyaGik=", "Male", false, "rFPv+zXvia6ws9voF95ALaL3kOcD5syLgHDCzF0N5NU=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500005", null, 1 },
                    { 6, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(5420), null, "doktor6@example.com", "R57FcgyMavOEwcxMJA5NinxHsKMp3Nlc+3MrFIMEL1E=", "Female", false, "Tuyfrl3fkT+p3docpNbdEhNr3ykPZhwdFSxNVRzyZds=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500006", null, 1 },
                    { 7, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(5544), null, "doktor7@example.com", "3vYo5ciCvMRA7X1EFenBcyMPFu/F0ScupdLWmcjx6tw=", "Male", false, "G1IyA/W+GYJ4IkbnIf9daw27iZkNFvlsgUEJ75fQFLo=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500007", null, 1 },
                    { 8, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(5667), null, "doktor8@example.com", "LFSFXaCeHHiiUGc3gQuf1es/n+byI1PW6yB5v6A0uhQ=", "Male", false, "kUWwF4fsN+aYgux3Umx8Riw36Tc8gqxWDJ09WJ4VD84=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500008", null, 1 },
                    { 9, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(5788), null, "doktor9@example.com", "nIQHwP62Ix3YPXvFZix45k2dN90IB5bQPNqzCqybr0k=", "Female", false, "zkCr0xA67sVlh0dgdQSLlRUlllzoQ887niw/XkNQgus=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500009", null, 1 },
                    { 10, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(5896), null, "doktor10@example.com", "tRKnr08cLn7OLVIzMoTLoc/IqD2G3DXgrksAOBFElgI=", "Male", false, "xhDYiZQINDQuAIPKIgLWqtEa8MxJwsiqBibVR06Nwo0=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500010", null, 1 },
                    { 11, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(6020), null, "doktor11@example.com", "LdeeqiUXzGaHL+kCNV4ichhm2mqKLlB3zuKjU9qSzAM=", "Female", false, "GCZyAJmMGwAUhdWnFjdF8m2E9BH73XZMuyAOQTCSAR8=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500011", null, 1 },
                    { 12, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(6179), null, "doktor12@example.com", "Im0BdjBoYfx2b3/WQrTRs/YWaMUZ4yv1O/xeTLKqOzk=", "Male", false, "YFmwcY43NL6iSzyjE6CQ6kut8/U5+M0DE1dixnz5RGQ=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500012", null, 1 },
                    { 13, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(6313), null, "doktor13@example.com", "GjN465wf91SgJZwuWi97UFxEPhRTOze2MkeFL21mDhU=", "Female", false, "PpUMgPdwM+kO6HVEoNiiOx/yeIo1qI5rjKEABUHjhs4=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500013", null, 1 },
                    { 14, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(6419), null, "doktor14@example.com", "xLkO1o0uhjWoaNIaz6RRcXCvzk5ADE6RQ8pKHcn3+Bo=", "Male", false, "4USv9gi1hNnXOran80etgYqk8fQMMp4ycYJD4IO1icQ=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500014", null, 1 },
                    { 15, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(6546), null, "doktor15@example.com", "h35hl3QL+d6k/Fcs9I0RI6ukYuekE81OD0VE6IoI9lM=", "Female", false, "NCnjV3z6jtJHbFcUSZOoAlK7dhx/dPJhIBxdxyaRpOg=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500015", null, 1 },
                    { 16, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(6668), null, "doktor16@example.com", "RxBCZGd2hNlgVV2xzxns/hfgs3KdxX9JLi9GPISE+XU=", "Male", false, "DQiL+zVPA6OaKuXmQoO13CZnZ1pQ3UyeqlC4+xBwSvA=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500016", null, 1 },
                    { 17, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(6792), null, "doktor17@example.com", "eU/WaNvB2g6AgZ81SVH9CdX4UQz9If8vFzv/Kt1bDeU=", "Female", false, "J5UN0eVWH5lWZN7p68SFiz6kUE439G7aZKWeHV3zI5o=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500017", null, 1 },
                    { 18, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(6965), null, "doktor18@example.com", "Zgr2s2wWvfS9A1sa1ZkAiEH7+tDXVqmr/tnDRQZwDcY=", "Male", false, "9TuKMODsRvUMp767V7Wp8OURgTvXbKsXzoixeo/D9m8=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500018", null, 1 },
                    { 19, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(7074), null, "doktor19@example.com", "Dtgj5FUreO7osLgeeg626VGTU1XkZjp10kYyeg/sU3I=", "Female", false, "0cIKa9y8FwHUTLuimVdBa3Uy13jC5UNgrv5OpicFDNQ=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500019", null, 1 },
                    { 20, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(7195), null, "doktor20@example.com", "ZpIdKBXIiVfHhKUxeqA1iwKfxxG2YhrSYSmsMbjcaMA=", "Male", false, "VxAqqjvO20HL8WYFIQ5k7232b5sPlfPXyyLphf1v8HA=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500020", null, 1 },
                    { 21, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(7315), null, "doktor21@example.com", "V6cXQy56rXg43Y56mFPJBuPhzc3v1Jnzn+46SLd2Uoc=", "Female", false, "Bp3vBNouhArb8KYIj2N1qU5v2zXjXFqUQ3q5gCoHhjI=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500021", null, 1 },
                    { 22, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(7428), null, "doktor22@example.com", "MrvGVZzVvzLEh7t3If8kIPhakH6huxZ/7L1CfUmwYoU=", "Male", false, "KsnQHnKUAFLmr2nd4w5wJ/CJwMe97Io9po5N+IoTB5U=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500022", null, 1 },
                    { 23, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(7538), null, "doktor23@example.com", "8/0yw7U9grwZiM2o1Cbj3a7N/VQC5MUN5OO8y6w4d+g=", "Female", false, "Zt6k4MDLOnNTpDL54GMIhlGoYmjHXsIwHuvKJw1lBtg=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500023", null, 1 },
                    { 24, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(7709), null, "doktor24@example.com", "7j26j+5nIckB/lTUDFGu9Lrt6+YRDQzvE8BNpGjg6to=", "Male", false, "jSlrCaMkMPTyWL/UgDdogXwFsqxJM2hGRO3D3ki3SB0=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500024", null, 1 },
                    { 25, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(7830), null, "doktor25@example.com", "sgFEBVDD/HbodbXFK2j3X/+H3xFjCb2Nglxx/sdVBX8=", "Female", false, "GFFDTZ9YZ9BbDp2msw2T9d/7L0eoUPw6dHTXlMLTOQI=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500025", null, 1 },
                    { 26, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(7952), null, "doktor26@example.com", "tjFGE5PBJZOk8/WEU9k75PhCuY0WXuBYfbrllBeA1l0=", "Male", false, "RHczLSubdaAPMiNvcxeqzC/EtX3oI66YVNHmRHmOwfw=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500026", null, 1 },
                    { 27, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8045), null, "doktor27@example.com", "4/rSlgbDYDq8Fz50vbExKo+Fbqwkg4brmzDdpmspTko=", "Female", false, "7DTh5FiFgY608BAk3LROCK0rCs8SnOzoOIvntCqFScQ=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234500027", null, 1 },
                    { 99, new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8202), null, "admin@example.com", "5wqaBWk/+na3Mey9j9NRkin0jk3GhJuUrARSVOjE97w=", "Male", false, "hpwlh6df81jer01fiS3nezYRoQ+zRTswYGg5ZBfLj2A=", new byte[] { 155, 191, 65, 62, 63, 215, 229, 37, 205, 182, 64, 202, 231, 131, 83, 12, 35, 131, 147, 147, 109, 194, 237, 223, 7, 107, 213, 131, 146, 10, 77, 11, 6, 214, 248, 186, 155, 28, 253, 7, 164, 74, 105, 28, 214, 179, 25, 179, 226, 157, 216, 67, 31, 151, 100, 81, 160, 239, 8, 70, 136, 0, 102, 108 }, new byte[] { 131, 172, 16, 150, 37, 95, 77, 148, 240, 142, 19, 123, 6, 105, 10, 158, 91, 27, 55, 136, 169, 91, 33, 124, 4, 90, 21, 183, 233, 164, 80, 13, 177, 151, 150, 239, 230, 238, 37, 63, 30, 34, 24, 157, 11, 162, 249, 22, 200, 100, 105, 15, 36, 234, 209, 244, 247, 173, 232, 142, 20, 227, 122, 157, 34, 70, 14, 179, 211, 90, 155, 128, 18, 59, 98, 161, 43, 193, 133, 54, 11, 50, 248, 204, 42, 103, 236, 215, 79, 80, 1, 110, 9, 132, 162, 164, 178, 164, 221, 217, 18, 95, 77, 31, 28, 199, 214, 112, 244, 125, 93, 40, 125, 237, 202, 45, 52, 3, 70, 207, 119, 16, 14, 73, 197, 48, 157, 129 }, "1234512345", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Biography", "CreatedDate", "DeletedDate", "DoctorSpecializationId", "Experience", "IsDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, "Id 3 olan Doktor Özgeçmiş Example asd", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8603), null, 1, 10, false, null },
                    { 4, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8613), null, 2, 5, false, null },
                    { 5, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8615), null, 7, 3, false, null },
                    { 6, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8616), null, 1, 10, false, null },
                    { 7, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8617), null, 4, 8, false, null },
                    { 8, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8617), null, 6, 6, false, null },
                    { 9, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8618), null, 9, 7, false, null },
                    { 10, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8619), null, 5, 2, false, null },
                    { 11, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8620), null, 10, 4, false, null },
                    { 12, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8621), null, 8, 9, false, null },
                    { 13, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8622), null, 3, 6, false, null },
                    { 14, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8623), null, 2, 5, false, null },
                    { 15, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8624), null, 7, 3, false, null },
                    { 16, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8649), null, 1, 10, false, null },
                    { 17, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8650), null, 4, 8, false, null },
                    { 18, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8651), null, 6, 6, false, null },
                    { 19, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8652), null, 9, 7, false, null },
                    { 20, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8653), null, 5, 2, false, null },
                    { 21, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8654), null, 10, 4, false, null },
                    { 22, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8655), null, 8, 9, false, null },
                    { 23, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8656), null, 3, 6, false, null },
                    { 24, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8657), null, 2, 5, false, null },
                    { 25, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8658), null, 1, 4, false, null },
                    { 26, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8658), null, 5, 7, false, null },
                    { 27, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8659), null, 8, 3, false, null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1234 Main St", 0, "A+", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8478), null, null },
                    { 2, "1233 Main St", 0, "B+", new DateTime(2024, 7, 4, 17, 12, 29, 969, DateTimeKind.Utc).AddTicks(8489), null, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3784), null, 1, null, 99 },
                    { 2, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3792), null, 2, null, 3 },
                    { 3, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3797), null, 3, null, 3 },
                    { 4, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(3799), null, 3, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "CreatedDate", "DeletedDate", "DoctorId", "IsDeleted", "PatientId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8769), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8772), null, 3, false, 1, 0, null },
                    { 2, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8781), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8782), null, 4, false, 1, 0, null },
                    { 3, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8786), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8787), null, 3, false, 2, 0, null },
                    { 4, new DateTime(2024, 6, 28, 8, 0, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 27, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 5, new DateTime(2024, 6, 27, 8, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 6, new DateTime(2024, 6, 27, 9, 0, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 8, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 7, new DateTime(2024, 6, 27, 9, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 8, new DateTime(2024, 6, 27, 10, 0, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 12, new DateTime(2024, 7, 5, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 13, new DateTime(2024, 7, 5, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 14, new DateTime(2024, 7, 5, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 15, new DateTime(2024, 7, 5, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 16, new DateTime(2024, 7, 5, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 17, new DateTime(2024, 7, 5, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 18, new DateTime(2024, 7, 5, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 19, new DateTime(2024, 7, 5, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 20, new DateTime(2024, 7, 5, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 21, new DateTime(2024, 7, 5, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 22, new DateTime(2024, 7, 5, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 23, new DateTime(2024, 7, 5, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 24, new DateTime(2024, 7, 5, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 25, new DateTime(2024, 7, 5, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 12, false, 2, 0, null },
                    { 50, new DateTime(2024, 7, 5, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 51, new DateTime(2024, 7, 5, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 52, new DateTime(2024, 7, 5, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 53, new DateTime(2024, 7, 5, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 54, new DateTime(2024, 7, 5, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 55, new DateTime(2024, 7, 5, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 56, new DateTime(2024, 7, 5, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 57, new DateTime(2024, 7, 5, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 58, new DateTime(2024, 7, 5, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 59, new DateTime(2024, 7, 5, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 60, new DateTime(2024, 7, 5, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 61, new DateTime(2024, 7, 5, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 62, new DateTime(2024, 7, 5, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 63, new DateTime(2024, 7, 5, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 4, false, 2, 0, null },
                    { 100, new DateTime(2024, 7, 5, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null },
                    { 101, new DateTime(2024, 7, 5, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null },
                    { 102, new DateTime(2024, 7, 5, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null },
                    { 103, new DateTime(2024, 7, 5, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null },
                    { 104, new DateTime(2024, 7, 5, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null },
                    { 105, new DateTime(2024, 7, 5, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null },
                    { 106, new DateTime(2024, 7, 5, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null },
                    { 107, new DateTime(2024, 7, 5, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null },
                    { 108, new DateTime(2024, 7, 5, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null },
                    { 109, new DateTime(2024, 7, 5, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null },
                    { 110, new DateTime(2024, 7, 5, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null },
                    { 111, new DateTime(2024, 7, 5, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null },
                    { 112, new DateTime(2024, 7, 5, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null },
                    { 113, new DateTime(2024, 7, 5, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(8958), null, 5, false, 2, 0, null }
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
                    { 1, 1, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9352), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 2, 2, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9361), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 3, 3, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9365), null, "Diabetes Mellitus", "Fasting blood sugar level of 140 mg/dL", null },
                    { 4, 4, new DateTime(2024, 7, 4, 20, 12, 29, 969, DateTimeKind.Local).AddTicks(9368), null, "Chronic Obstructive Pulmonary Disease (COPD)", "Reduced lung function on spirometry", null }
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
