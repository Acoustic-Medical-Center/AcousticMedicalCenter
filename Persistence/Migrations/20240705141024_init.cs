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
                    { 1, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9131), null, "Neurosurgery", "Beyin ve Sinir Cerrahisi", null },
                    { 2, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9146), null, "Dermatology", "Dermatoloji", null },
                    { 3, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9148), null, "General Surgery", "Genel Cerrahi", null },
                    { 4, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9149), null, "Ophthalmology", "Göz Hastalıkları", null },
                    { 5, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9150), null, "Internal Medicine", "İç Hastalıkları", null },
                    { 6, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9151), null, "Obstetrics and Gynecology", "Kadın Hastalıkları ve Doğum", null },
                    { 7, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9152), null, "Otorhinolaryngology", "Kulak Burun Boğaz", null },
                    { 8, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9152), null, "Orthopedics and Traumatology", "Ortopedi ve Travmatoloji", null },
                    { 9, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9153), null, "Urology", "Üroloji", null },
                    { 10, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9154), null, "Pediatrics", "Çocuk Sağlığı ve Hastalıkları", null }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3611), null, "Kardiyoloji Araştırmaları", null },
                    { 2, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3623), null, "Çocuk Sağlığı", null },
                    { 3, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3627), null, "Onkoloji Tedavi", null },
                    { 4, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3630), null, "Nöroloji ve Beyin Cerrahisi", null },
                    { 5, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3634), null, "Endokrinoloji ve Metabolizma", null },
                    { 6, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3637), null, "Gastroenteroloji ve Sindirim Sistemi", null },
                    { 7, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3641), null, "Psikiyatri ve Mental Sağlık", null },
                    { 8, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3644), null, "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri", null },
                    { 9, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3647), null, "Parkinson Hastalığı", null },
                    { 10, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3651), null, "Bunama", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9427), null, "Admin", null },
                    { 2, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9438), null, "Appointment.Delete", null },
                    { 3, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9444), null, "Doctor", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(515), null, "hasta1@example.com", "46fw7Rk8/m7cXdvb9VCuiw==", "Male", false, "IY+uLFq91e9Pl1fZz9KL+g==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234567890", null, 0 },
                    { 2, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(619), null, "hasta2@example.com", "lx191yNB5UTgUeNqX1QIZQ==", "Male", false, "ESeBAof1D3qOrdvr0NsjqQ==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234512345", null, 0 },
                    { 3, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(694), null, "doktor1@example.com", "JJIVK0Z5Q3xurg/5rwsjpw==", "Male", false, "SbwDEUPBok2ObkCL8mzFcQ==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234512312", null, 1 },
                    { 4, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(807), null, "doktor4@example.com", "FfeaE5zn6NjabjeVhYSrEQ==", "Female", false, "dwMtHvVvQqj6d7sMPCqIjg==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500004", null, 1 },
                    { 5, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(896), null, "doktor5@example.com", "+au//BigQ3yTZoy4bkmhhQ==", "Male", false, "dzHbICsDLYy/vGyYJIPZfQ==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500005", null, 1 },
                    { 6, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(973), null, "doktor6@example.com", "Mh0v4J32+JlNpaD/O7+qSA==", "Female", false, "+hNFC6xqdqf8w9sO855a0Q==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500006", null, 1 },
                    { 7, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(1046), null, "doktor7@example.com", "Ibn6o8AedzQLx6T8v7QyWQ==", "Male", false, "qApbKXsPUcTvGAWZiov2eg==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500007", null, 1 },
                    { 8, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(1121), null, "doktor8@example.com", "QRc31Nk0c/N3r0eGOY3tJg==", "Male", false, "crndYAoJPeqqluXZHHwnzQ==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500008", null, 1 },
                    { 9, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(1188), null, "doktor9@example.com", "2vpZVUEDo5Auij4xmX6p/w==", "Female", false, "pnrXKW7b8Nkl2aPQe6wmIA==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500009", null, 1 },
                    { 10, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(1314), null, "doktor10@example.com", "qZKdo9nxms9FWbRIQ6mDQg==", "Male", false, "72UZHOJjBL5fuqnE5KqkAA==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500010", null, 1 },
                    { 11, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(1379), null, "doktor11@example.com", "jj9UNKyFcbh2ikUCQQDWyw==", "Female", false, "Etzl4OT8hsUVt6ZxK/O0LA==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500011", null, 1 },
                    { 12, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(1443), null, "doktor12@example.com", "Q4daCkyHEECDbBgMNxgSIA==", "Male", false, "/Q9/SHuMD9cCphQ2hpSmJg==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500012", null, 1 },
                    { 13, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(1532), null, "doktor13@example.com", "w+eXoITM5M9bWhvdxONk6g==", "Female", false, "jzee7V57E88iuKsNYWgVYw==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500013", null, 1 },
                    { 14, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(1616), null, "doktor14@example.com", "onmhUNgVYSb9KJWjNTgeig==", "Male", false, "QjBL/R6X9KC7lG1rhgidbw==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500014", null, 1 },
                    { 15, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(1689), null, "doktor15@example.com", "Fvj3ZYvX8aHqo+f8cu9Hgw==", "Female", false, "IqHJenJjFanZMJg+oHogDw==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500015", null, 1 },
                    { 16, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(1760), null, "doktor16@example.com", "2OrR7nTyK7M9EzSHBXuaOw==", "Male", false, "PQ79eSlatrg1jKu+RShUWw==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500016", null, 1 },
                    { 17, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(1826), null, "doktor17@example.com", "CxBc6OuQft7mnBW4YZ2RmQ==", "Female", false, "M/0Rh8M/57cW6K5KSeg/wQ==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500017", null, 1 },
                    { 18, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(1864), null, "doktor18@example.com", "v8S/QBqz7DdlbUyIGJVanw==", "Male", false, "HEnM1rpNCBeMA1OQBWYQQA==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500018", null, 1 },
                    { 19, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(1952), null, "doktor19@example.com", "qQeUOmjbsPj9QrelGnJ0xw==", "Female", false, "dwMtHvVvQqj6d7sMPCqIjg==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500019", null, 1 },
                    { 20, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(2064), null, "doktor20@example.com", "XGLB1Jqkf8ye3RiI7REdtg==", "Male", false, "asHqAzJLyIiq8nFybKhJ9Q==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500020", null, 1 },
                    { 21, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(2120), null, "doktor21@example.com", "E6GrrCDe0S5fe/J0cQT0QQ==", "Female", false, "F5wwQbK4qmtX1bWH9FPM4w==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500021", null, 1 },
                    { 22, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(2270), null, "doktor22@example.com", "NTN4MQGjhs5QmulzI20AUQ==", "Male", false, "3uGzHpqFlftm4h46r6sCvg==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500022", null, 1 },
                    { 23, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(2347), null, "doktor23@example.com", "F9vfnlFH27RRbGIAlLcUrg==", "Female", false, "zxIs9+mg1FC/hF/oGsX7yg==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500023", null, 1 },
                    { 24, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(2420), null, "doktor24@example.com", "76Jr0erPduMYIgqOy5Gm2A==", "Male", false, "ZVYa/Ha75fykIUoBnPYU2w==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500024", null, 1 },
                    { 25, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(2490), null, "doktor25@example.com", "Gnvo6mwNUF/bN9v9ID485w==", "Female", false, "qJCxvSS+EnCd4srQEbeJvw==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500025", null, 1 },
                    { 26, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(2563), null, "doktor26@example.com", "Erzb68h8hV8wJ2vAGBiz5Q==", "Male", false, "tZEaxP2Ab3PHXSqcANuRYw==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500026", null, 1 },
                    { 27, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(2601), null, "doktor27@example.com", "RHmGtLmFF2rZIizvT6WWJg==", "Female", false, "cUcUFQAnZR4CocSgPu3OUg==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234500027", null, 1 },
                    { 99, new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(2691), null, "admin@example.com", "aNbdnOzUNuGnMPCOxe7GbA==", "Male", false, "7ZoRxRkAs9bCJPAAcPqRUQ==", new byte[] { 80, 162, 202, 177, 143, 176, 17, 202, 231, 168, 0, 149, 61, 182, 225, 238, 78, 176, 89, 36, 74, 43, 161, 148, 237, 9, 161, 220, 10, 65, 95, 193, 7, 39, 208, 218, 127, 131, 205, 28, 11, 151, 146, 117, 173, 234, 33, 213, 159, 82, 225, 187, 192, 2, 240, 30, 171, 127, 18, 64, 18, 95, 242, 9 }, new byte[] { 238, 27, 192, 180, 110, 57, 63, 56, 89, 21, 36, 241, 211, 67, 222, 85, 102, 190, 172, 213, 116, 194, 152, 231, 246, 150, 229, 113, 125, 115, 180, 153, 4, 87, 193, 191, 67, 147, 226, 83, 248, 106, 171, 220, 189, 216, 11, 82, 192, 162, 248, 171, 34, 82, 139, 147, 28, 60, 183, 159, 253, 61, 11, 169, 37, 66, 133, 193, 101, 112, 56, 232, 49, 105, 114, 115, 58, 233, 43, 240, 170, 87, 3, 188, 100, 245, 8, 25, 10, 110, 148, 77, 96, 253, 23, 195, 53, 61, 38, 87, 141, 181, 98, 54, 116, 212, 156, 136, 199, 172, 59, 50, 102, 170, 137, 127, 48, 79, 249, 172, 153, 205, 134, 201, 39, 207, 74, 246 }, "1234512345", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Biography", "CreatedDate", "DeletedDate", "DoctorSpecializationId", "Experience", "IsDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, "Id 3 olan Doktor Özgeçmiş Example asd", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(2966), null, 1, 10, false, null },
                    { 4, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3003), null, 2, 5, false, null },
                    { 5, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3004), null, 7, 3, false, null },
                    { 6, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3005), null, 1, 10, false, null },
                    { 7, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3006), null, 4, 8, false, null },
                    { 8, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3007), null, 6, 6, false, null },
                    { 9, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3008), null, 9, 7, false, null },
                    { 10, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3009), null, 5, 2, false, null },
                    { 11, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3010), null, 10, 4, false, null },
                    { 12, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3011), null, 8, 9, false, null },
                    { 13, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3012), null, 3, 6, false, null },
                    { 14, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3013), null, 2, 5, false, null },
                    { 15, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3014), null, 7, 3, false, null },
                    { 16, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3015), null, 1, 10, false, null },
                    { 17, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3016), null, 4, 8, false, null },
                    { 18, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3017), null, 6, 6, false, null },
                    { 19, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3018), null, 9, 7, false, null },
                    { 20, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3019), null, 5, 2, false, null },
                    { 21, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3020), null, 10, 4, false, null },
                    { 22, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3020), null, 8, 9, false, null },
                    { 23, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3021), null, 3, 6, false, null },
                    { 24, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3022), null, 2, 5, false, null },
                    { 25, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3023), null, 1, 4, false, null },
                    { 26, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3024), null, 5, 7, false, null },
                    { 27, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(3025), null, 8, 3, false, null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1234 Main St", 0, "A+", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(2858), null, null },
                    { 2, "1233 Main St", 0, "B+", new DateTime(2024, 7, 5, 14, 10, 24, 389, DateTimeKind.Utc).AddTicks(2867), null, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9537), null, 1, null, 99 },
                    { 2, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9546), null, 2, null, 3 },
                    { 3, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9551), null, 3, null, 3 },
                    { 4, new DateTime(2024, 7, 5, 17, 10, 24, 388, DateTimeKind.Local).AddTicks(9554), null, 3, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "CreatedDate", "DeletedDate", "DoctorId", "IsDeleted", "PatientId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3237), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3242), null, 3, false, 1, 0, null },
                    { 2, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3252), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3252), null, 4, false, 1, 0, null },
                    { 3, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3256), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3257), null, 3, false, 2, 0, null },
                    { 4, new DateTime(2024, 6, 28, 8, 0, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 27, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 5, new DateTime(2024, 6, 27, 8, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 6, new DateTime(2024, 6, 27, 9, 0, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 8, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 7, new DateTime(2024, 6, 27, 9, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 8, new DateTime(2024, 6, 27, 10, 0, 3, 785, DateTimeKind.Unspecified).AddTicks(6820), new DateTime(2024, 6, 28, 13, 30, 3, 785, DateTimeKind.Unspecified).AddTicks(6830), null, 12, false, 2, 0, null },
                    { 12, new DateTime(2024, 7, 6, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 13, new DateTime(2024, 7, 6, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 14, new DateTime(2024, 7, 6, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 15, new DateTime(2024, 7, 6, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 16, new DateTime(2024, 7, 6, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 17, new DateTime(2024, 7, 6, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 18, new DateTime(2024, 7, 6, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 19, new DateTime(2024, 7, 6, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 20, new DateTime(2024, 7, 6, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 21, new DateTime(2024, 7, 6, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 22, new DateTime(2024, 7, 6, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 23, new DateTime(2024, 7, 6, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 24, new DateTime(2024, 7, 6, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 25, new DateTime(2024, 7, 6, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 12, false, 2, 0, null },
                    { 50, new DateTime(2024, 7, 6, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 51, new DateTime(2024, 7, 6, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 52, new DateTime(2024, 7, 6, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 53, new DateTime(2024, 7, 6, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 54, new DateTime(2024, 7, 6, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 55, new DateTime(2024, 7, 6, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 56, new DateTime(2024, 7, 6, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 57, new DateTime(2024, 7, 6, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 58, new DateTime(2024, 7, 6, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 59, new DateTime(2024, 7, 6, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 60, new DateTime(2024, 7, 6, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 61, new DateTime(2024, 7, 6, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 62, new DateTime(2024, 7, 6, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 63, new DateTime(2024, 7, 6, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 4, false, 2, 0, null },
                    { 100, new DateTime(2024, 7, 6, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null },
                    { 101, new DateTime(2024, 7, 6, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null },
                    { 102, new DateTime(2024, 7, 6, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null },
                    { 103, new DateTime(2024, 7, 6, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null },
                    { 104, new DateTime(2024, 7, 6, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null },
                    { 105, new DateTime(2024, 7, 6, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null },
                    { 106, new DateTime(2024, 7, 6, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null },
                    { 107, new DateTime(2024, 7, 6, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null },
                    { 108, new DateTime(2024, 7, 6, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null },
                    { 109, new DateTime(2024, 7, 6, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null },
                    { 110, new DateTime(2024, 7, 6, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null },
                    { 111, new DateTime(2024, 7, 6, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null },
                    { 112, new DateTime(2024, 7, 6, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null },
                    { 113, new DateTime(2024, 7, 6, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3433), null, 5, false, 2, 0, null }
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
                    { 1, 1, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3901), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 2, 2, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3909), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 3, 3, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3913), null, "Diabetes Mellitus", "Fasting blood sugar level of 140 mg/dL", null },
                    { 4, 4, new DateTime(2024, 7, 5, 17, 10, 24, 389, DateTimeKind.Local).AddTicks(3916), null, "Chronic Obstructive Pulmonary Disease (COPD)", "Reduced lung function on spirometry", null }
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
