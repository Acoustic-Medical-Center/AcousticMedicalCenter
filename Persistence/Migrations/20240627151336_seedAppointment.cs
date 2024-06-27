using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seedAppointment : Migration
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
                    { 1, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(242), null, "Neurosurgery", "Beyin ve Sinir Cerrahisi", null },
                    { 2, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(252), null, "Dermatology", "Dermatoloji", null },
                    { 3, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(254), null, "General Surgery", "Genel Cerrahi", null },
                    { 4, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(255), null, "Ophthalmology", "Göz Hastalıkları", null },
                    { 5, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(256), null, "Internal Medicine", "İç Hastalıkları", null },
                    { 6, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(257), null, "Obstetrics and Gynecology", "Kadın Hastalıkları ve Doğum", null },
                    { 7, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(259), null, "Otorhinolaryngology", "Kulak Burun Boğaz", null },
                    { 8, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(260), null, "Orthopedics and Traumatology", "Ortopedi ve Travmatoloji", null },
                    { 9, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(261), null, "Urology", "Üroloji", null },
                    { 10, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(262), null, "Pediatrics", "Çocuk Sağlığı ve Hastalıkları", null }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2041), null, "Kardiyoloji Araştırmaları", null },
                    { 2, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2048), null, "Çocuk Sağlığı", null },
                    { 3, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2052), null, "Onkoloji Tedavi", null },
                    { 4, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2056), null, "Nöroloji ve Beyin Cerrahisi", null },
                    { 5, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2059), null, "Endokrinoloji ve Metabolizma", null },
                    { 6, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2064), null, "Gastroenteroloji ve Sindirim Sistemi", null },
                    { 7, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2067), null, "Psikiyatri ve Mental Sağlık", null },
                    { 8, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2070), null, "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri", null },
                    { 9, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2074), null, "Parkinson Hastalığı", null },
                    { 10, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2112), null, "Bunama", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(526), null, "Admin", null },
                    { 2, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(534), null, "Appointment.Delete", null },
                    { 3, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(538), null, "Doctor", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1049), null, "hasta1@example.com", "John", "Male", false, "Doe", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234567890", null, 0 },
                    { 2, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1059), null, "hasta2@example.com", "Jonathan", "Male", false, "Corwin", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234512345", null, 0 },
                    { 3, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1063), null, "doktor1@example.com", "batu", "Male", false, "cerrahlar", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234512312", null, 1 },
                    { 4, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1068), null, "doktor4@example.com", "Fatma", "Female", false, "Koç", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500004", null, 1 },
                    { 5, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1070), null, "doktor5@example.com", "Mehmet", "Male", false, "Öz", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500005", null, 1 },
                    { 6, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1072), null, "doktor6@example.com", "Canan", "Female", false, "Çelik", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500006", null, 1 },
                    { 7, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1073), null, "doktor7@example.com", "Emre", "Male", false, "Arı", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500007", null, 1 },
                    { 8, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1075), null, "doktor8@example.com", "Burak", "Male", false, "Temiz", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500008", null, 1 },
                    { 9, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1077), null, "doktor9@example.com", "Seda", "Female", false, "Ak", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500009", null, 1 },
                    { 10, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1079), null, "doktor10@example.com", "Murat", "Male", false, "Tez", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500010", null, 1 },
                    { 11, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1081), null, "doktor11@example.com", "Zeynep", "Female", false, "Bal", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500011", null, 1 },
                    { 12, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1083), null, "doktor12@example.com", "Kemal", "Male", false, "Sağ", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500012", null, 1 },
                    { 13, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1084), null, "doktor13@example.com", "Cansu", "Female", false, "Dur", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500013", null, 1 },
                    { 14, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1086), null, "doktor14@example.com", "Oğuz", "Male", false, "Kurt", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500014", null, 1 },
                    { 15, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1088), null, "doktor15@example.com", "Esra", "Female", false, "Deniz", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500015", null, 1 },
                    { 16, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1090), null, "doktor16@example.com", "Baran", "Male", false, "Gül", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500016", null, 1 },
                    { 17, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1092), null, "doktor17@example.com", "Duygu", "Female", false, "Aydın", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500017", null, 1 },
                    { 18, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1094), null, "doktor18@example.com", "Tarkan", "Male", false, "Kara", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500018", null, 1 },
                    { 19, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1095), null, "doktor19@example.com", "Nil", "Female", false, "Koç", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500019", null, 1 },
                    { 20, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1097), null, "doktor20@example.com", "Sami", "Male", false, "Öztürk", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500020", null, 1 },
                    { 21, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1099), null, "doktor21@example.com", "Ece", "Female", false, "Uzun", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500021", null, 1 },
                    { 22, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1101), null, "doktor22@example.com", "Levent", "Male", false, "Yıldız", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500022", null, 1 },
                    { 23, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1103), null, "doktor23@example.com", "Selin", "Female", false, "Demirci", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500023", null, 1 },
                    { 24, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1105), null, "doktor24@example.com", "Onur", "Male", false, "Akar", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500024", null, 1 },
                    { 25, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1107), null, "doktor25@example.com", "İrem", "Female", false, "Dere", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500025", null, 1 },
                    { 26, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1108), null, "doktor26@example.com", "Cenk", "Male", false, "Taş", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500026", null, 1 },
                    { 27, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1110), null, "doktor27@example.com", "Hande", "Female", false, "Yener", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234500027", null, 1 },
                    { 99, new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1131), null, "admin@example.com", "Admin", "Male", false, "Yöneticioğlu", new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 }, "1234512345", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Biography", "CreatedDate", "DeletedDate", "DoctorSpecializationId", "Experience", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, "Id 3 olan Doktor Özgeçmiş Example asd", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1495), null, 1, 10, null },
                    { 4, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1503), null, 2, 5, null },
                    { 5, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1504), null, 7, 3, null },
                    { 6, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1505), null, 1, 10, null },
                    { 7, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1507), null, 4, 8, null },
                    { 8, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1508), null, 6, 6, null },
                    { 9, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1509), null, 9, 7, null },
                    { 10, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1510), null, 5, 2, null },
                    { 11, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1512), null, 10, 4, null },
                    { 12, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1513), null, 8, 9, null },
                    { 13, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1514), null, 3, 6, null },
                    { 14, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1515), null, 2, 5, null },
                    { 15, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1517), null, 7, 3, null },
                    { 16, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1518), null, 1, 10, null },
                    { 17, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1519), null, 4, 8, null },
                    { 18, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1520), null, 6, 6, null },
                    { 19, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1521), null, 9, 7, null },
                    { 20, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1523), null, 5, 2, null },
                    { 21, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1524), null, 10, 4, null },
                    { 22, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1525), null, 8, 9, null },
                    { 23, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1526), null, 3, 6, null },
                    { 24, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1528), null, 2, 5, null },
                    { 25, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1529), null, 1, 4, null },
                    { 26, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1530), null, 5, 7, null },
                    { 27, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1531), null, 8, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1234 Main St", 0, "A+", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1265), null, null },
                    { 2, "1233 Main St", 0, "B+", new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1273), null, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(640), null, 1, null, 5 },
                    { 2, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(648), null, 2, null, 3 },
                    { 3, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(652), null, 3, null, 3 },
                    { 4, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(657), null, 3, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "CreatedDate", "DeletedDate", "DoctorId", "IsDeleted", "PatientId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1640), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1642), null, 3, false, 1, 0, null },
                    { 2, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1652), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1652), null, 4, false, 1, 0, null },
                    { 3, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1656), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1657), null, 3, false, 2, 0, null },
                    { 4, new DateTime(2024, 6, 28, 8, 0, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 27, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 5, new DateTime(2024, 6, 27, 8, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 6, new DateTime(2024, 6, 27, 9, 0, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 8, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 7, new DateTime(2024, 6, 27, 9, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 8, new DateTime(2024, 6, 27, 10, 0, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 12, new DateTime(2024, 6, 28, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 13, new DateTime(2024, 6, 28, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 14, new DateTime(2024, 6, 28, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 15, new DateTime(2024, 6, 28, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 16, new DateTime(2024, 6, 28, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 17, new DateTime(2024, 6, 28, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 18, new DateTime(2024, 6, 28, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 19, new DateTime(2024, 6, 28, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 20, new DateTime(2024, 6, 28, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 21, new DateTime(2024, 6, 28, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 22, new DateTime(2024, 6, 28, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 23, new DateTime(2024, 6, 28, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 24, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 25, new DateTime(2024, 6, 28, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 12, false, 2, 0, null },
                    { 50, new DateTime(2024, 6, 28, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 51, new DateTime(2024, 6, 28, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 52, new DateTime(2024, 6, 28, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 53, new DateTime(2024, 6, 28, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 54, new DateTime(2024, 6, 28, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 55, new DateTime(2024, 6, 28, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 56, new DateTime(2024, 6, 28, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 57, new DateTime(2024, 6, 28, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 58, new DateTime(2024, 6, 28, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 59, new DateTime(2024, 6, 28, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 60, new DateTime(2024, 6, 28, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 61, new DateTime(2024, 6, 28, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 62, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 63, new DateTime(2024, 6, 28, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 4, false, 2, 0, null },
                    { 100, new DateTime(2024, 6, 28, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null },
                    { 101, new DateTime(2024, 6, 28, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null },
                    { 102, new DateTime(2024, 6, 28, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null },
                    { 103, new DateTime(2024, 6, 28, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null },
                    { 104, new DateTime(2024, 6, 28, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null },
                    { 105, new DateTime(2024, 6, 28, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null },
                    { 106, new DateTime(2024, 6, 28, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null },
                    { 107, new DateTime(2024, 6, 28, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null },
                    { 108, new DateTime(2024, 6, 28, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null },
                    { 109, new DateTime(2024, 6, 28, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null },
                    { 110, new DateTime(2024, 6, 28, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null },
                    { 111, new DateTime(2024, 6, 28, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null },
                    { 112, new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null },
                    { 113, new DateTime(2024, 6, 28, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811), null, 5, false, 2, 0, null }
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
                    { 1, 1, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2316), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 2, 2, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2323), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 3, 3, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2327), null, "Diabetes Mellitus", "Fasting blood sugar level of 140 mg/dL", null },
                    { 4, 4, new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2331), null, "Chronic Obstructive Pulmonary Disease (COPD)", "Reduced lung function on spirometry", null }
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
