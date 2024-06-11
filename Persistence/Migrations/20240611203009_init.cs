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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSpecializations", x => x.Id);
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
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Prescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicationDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DosageInstructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescription_Appointments_AppointmentId",
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
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 23, 30, 9, 585, DateTimeKind.Local).AddTicks(9734), null, "Cerrah", null },
                    { 2, new DateTime(2024, 6, 11, 23, 30, 9, 585, DateTimeKind.Local).AddTicks(9769), null, "Kalp", null }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(957), null, "Kardiyoloji Araştırmaları", null },
                    { 2, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(964), null, "Çocuk Sağlığı", null },
                    { 3, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(968), null, "Onkoloji Tedavi", null },
                    { 4, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(971), null, "Nöroloji ve Beyin Cerrahisi", null },
                    { 5, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(974), null, "Endokrinoloji ve Metabolizma", null },
                    { 6, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(978), null, "Gastroenteroloji ve Sindirim Sistemi", null },
                    { 7, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(981), null, "Psikiyatri ve Mental Sağlık", null },
                    { 8, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(984), null, "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri", null },
                    { 9, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(987), null, "Parkinson Hastalığı", null },
                    { 10, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(990), null, "Bunama", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 23, 30, 9, 585, DateTimeKind.Local).AddTicks(9893), null, "Admin", null },
                    { 2, new DateTime(2024, 6, 11, 23, 30, 9, 585, DateTimeKind.Local).AddTicks(9903), null, "Appointment.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(401), null, "hasta1@example.com", "John", "Male", false, "Doe", new byte[] { 52, 160, 214, 5, 204, 125, 141, 102, 54, 97, 3, 19, 120, 168, 219, 66, 235, 106, 75, 33, 86, 60, 213, 28, 150, 253, 139, 63, 232, 135, 144, 210, 62, 195, 64, 212, 10, 188, 177, 63, 244, 228, 226, 153, 243, 95, 161, 80, 166, 213, 230, 68, 27, 118, 55, 200, 69, 102, 44, 139, 88, 15, 16, 197 }, new byte[] { 229, 0, 21, 252, 2, 35, 17, 139, 110, 182, 104, 6, 69, 98, 76, 219, 4, 26, 212, 45, 40, 68, 215, 96, 111, 194, 111, 58, 85, 253, 207, 233, 71, 217, 140, 42, 44, 237, 170, 150, 135, 229, 99, 10, 57, 129, 255, 209, 106, 32, 141, 91, 168, 63, 118, 199, 114, 163, 52, 114, 176, 209, 20, 127, 210, 152, 101, 121, 207, 224, 230, 30, 184, 196, 218, 169, 193, 170, 125, 53, 233, 120, 200, 27, 91, 116, 125, 101, 212, 48, 189, 152, 15, 235, 72, 45, 152, 175, 126, 108, 5, 186, 44, 114, 43, 26, 99, 65, 81, 204, 46, 97, 241, 148, 191, 230, 11, 220, 226, 21, 199, 144, 193, 237, 47, 207, 48, 70 }, "1234567890", null, 0 },
                    { 2, new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(410), null, "hasta2@example.com", "Jonathan", "Male", false, "Corwin", new byte[] { 52, 160, 214, 5, 204, 125, 141, 102, 54, 97, 3, 19, 120, 168, 219, 66, 235, 106, 75, 33, 86, 60, 213, 28, 150, 253, 139, 63, 232, 135, 144, 210, 62, 195, 64, 212, 10, 188, 177, 63, 244, 228, 226, 153, 243, 95, 161, 80, 166, 213, 230, 68, 27, 118, 55, 200, 69, 102, 44, 139, 88, 15, 16, 197 }, new byte[] { 229, 0, 21, 252, 2, 35, 17, 139, 110, 182, 104, 6, 69, 98, 76, 219, 4, 26, 212, 45, 40, 68, 215, 96, 111, 194, 111, 58, 85, 253, 207, 233, 71, 217, 140, 42, 44, 237, 170, 150, 135, 229, 99, 10, 57, 129, 255, 209, 106, 32, 141, 91, 168, 63, 118, 199, 114, 163, 52, 114, 176, 209, 20, 127, 210, 152, 101, 121, 207, 224, 230, 30, 184, 196, 218, 169, 193, 170, 125, 53, 233, 120, 200, 27, 91, 116, 125, 101, 212, 48, 189, 152, 15, 235, 72, 45, 152, 175, 126, 108, 5, 186, 44, 114, 43, 26, 99, 65, 81, 204, 46, 97, 241, 148, 191, 230, 11, 220, 226, 21, 199, 144, 193, 237, 47, 207, 48, 70 }, "1234512345", null, 0 },
                    { 3, new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(415), null, "doktor1@example.com", "batu", "Male", false, "cerrahlar", new byte[] { 52, 160, 214, 5, 204, 125, 141, 102, 54, 97, 3, 19, 120, 168, 219, 66, 235, 106, 75, 33, 86, 60, 213, 28, 150, 253, 139, 63, 232, 135, 144, 210, 62, 195, 64, 212, 10, 188, 177, 63, 244, 228, 226, 153, 243, 95, 161, 80, 166, 213, 230, 68, 27, 118, 55, 200, 69, 102, 44, 139, 88, 15, 16, 197 }, new byte[] { 229, 0, 21, 252, 2, 35, 17, 139, 110, 182, 104, 6, 69, 98, 76, 219, 4, 26, 212, 45, 40, 68, 215, 96, 111, 194, 111, 58, 85, 253, 207, 233, 71, 217, 140, 42, 44, 237, 170, 150, 135, 229, 99, 10, 57, 129, 255, 209, 106, 32, 141, 91, 168, 63, 118, 199, 114, 163, 52, 114, 176, 209, 20, 127, 210, 152, 101, 121, 207, 224, 230, 30, 184, 196, 218, 169, 193, 170, 125, 53, 233, 120, 200, 27, 91, 116, 125, 101, 212, 48, 189, 152, 15, 235, 72, 45, 152, 175, 126, 108, 5, 186, 44, 114, 43, 26, 99, 65, 81, 204, 46, 97, 241, 148, 191, 230, 11, 220, 226, 21, 199, 144, 193, 237, 47, 207, 48, 70 }, "1234512312", null, 1 },
                    { 4, new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(418), null, "doktor2@example.com", "kalp", "Male", false, "doktoru", new byte[] { 52, 160, 214, 5, 204, 125, 141, 102, 54, 97, 3, 19, 120, 168, 219, 66, 235, 106, 75, 33, 86, 60, 213, 28, 150, 253, 139, 63, 232, 135, 144, 210, 62, 195, 64, 212, 10, 188, 177, 63, 244, 228, 226, 153, 243, 95, 161, 80, 166, 213, 230, 68, 27, 118, 55, 200, 69, 102, 44, 139, 88, 15, 16, 197 }, new byte[] { 229, 0, 21, 252, 2, 35, 17, 139, 110, 182, 104, 6, 69, 98, 76, 219, 4, 26, 212, 45, 40, 68, 215, 96, 111, 194, 111, 58, 85, 253, 207, 233, 71, 217, 140, 42, 44, 237, 170, 150, 135, 229, 99, 10, 57, 129, 255, 209, 106, 32, 141, 91, 168, 63, 118, 199, 114, 163, 52, 114, 176, 209, 20, 127, 210, 152, 101, 121, 207, 224, 230, 30, 184, 196, 218, 169, 193, 170, 125, 53, 233, 120, 200, 27, 91, 116, 125, 101, 212, 48, 189, 152, 15, 235, 72, 45, 152, 175, 126, 108, 5, 186, 44, 114, 43, 26, 99, 65, 81, 204, 46, 97, 241, 148, 191, 230, 11, 220, 226, 21, 199, 144, 193, 237, 47, 207, 48, 70 }, "1234512313", null, 1 },
                    { 5, new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(422), null, "admin@example.com", "Admin", "Male", false, "Yöneticioğlu", new byte[] { 52, 160, 214, 5, 204, 125, 141, 102, 54, 97, 3, 19, 120, 168, 219, 66, 235, 106, 75, 33, 86, 60, 213, 28, 150, 253, 139, 63, 232, 135, 144, 210, 62, 195, 64, 212, 10, 188, 177, 63, 244, 228, 226, 153, 243, 95, 161, 80, 166, 213, 230, 68, 27, 118, 55, 200, 69, 102, 44, 139, 88, 15, 16, 197 }, new byte[] { 229, 0, 21, 252, 2, 35, 17, 139, 110, 182, 104, 6, 69, 98, 76, 219, 4, 26, 212, 45, 40, 68, 215, 96, 111, 194, 111, 58, 85, 253, 207, 233, 71, 217, 140, 42, 44, 237, 170, 150, 135, 229, 99, 10, 57, 129, 255, 209, 106, 32, 141, 91, 168, 63, 118, 199, 114, 163, 52, 114, 176, 209, 20, 127, 210, 152, 101, 121, 207, 224, 230, 30, 184, 196, 218, 169, 193, 170, 125, 53, 233, 120, 200, 27, 91, 116, 125, 101, 212, 48, 189, 152, 15, 235, 72, 45, 152, 175, 126, 108, 5, 186, 44, 114, 43, 26, 99, 65, 81, 204, 46, 97, 241, 148, 191, 230, 11, 220, 226, 21, 199, 144, 193, 237, 47, 207, 48, 70 }, "1234512345", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Biography", "CreatedDate", "DeletedDate", "DoctorSpecializationId", "Experience", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, "Id 3 olan Doktor Özgeçmiş Example", new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(702), null, 1, 10, null },
                    { 4, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(710), null, 2, 5, null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1234 Main St", 0, "A+", new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(519), null, null },
                    { 2, "1233 Main St", 0, "B+", new DateTime(2024, 6, 11, 20, 30, 9, 586, DateTimeKind.Utc).AddTicks(528), null, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(7), null, 1, null, 5 },
                    { 2, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(15), null, 2, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "CreatedDate", "DeletedDate", "DoctorId", "IsDeleted", "PatientId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(849), new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(850), null, 3, false, 1, 0, null },
                    { 2, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(859), new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(860), null, 4, false, 1, 0, null },
                    { 3, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(864), null, 3, false, 2, 0, null },
                    { 4, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(867), new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(868), null, 4, false, 2, 0, null }
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
                    { 1, 1, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(1172), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 2, 2, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(1180), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 3, 3, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(1184), null, "Diabetes Mellitus", "Fasting blood sugar level of 140 mg/dL", null },
                    { 4, 4, new DateTime(2024, 6, 11, 23, 30, 9, 586, DateTimeKind.Local).AddTicks(1188), null, "Chronic Obstructive Pulmonary Disease (COPD)", "Reduced lung function on spirometry", null }
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
                name: "IX_Prescription_AppointmentId",
                table: "Prescription",
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
                name: "Prescription");

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
