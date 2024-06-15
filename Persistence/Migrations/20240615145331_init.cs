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
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicationDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DosageInstructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrescriptionStatus = table.Column<int>(type: "int", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
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
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4374), null, "Cerrah", null },
                    { 2, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4404), null, "Kalp", null }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5604), null, "Kardiyoloji Araştırmaları", null },
                    { 2, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5611), null, "Çocuk Sağlığı", null },
                    { 3, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5615), null, "Onkoloji Tedavi", null },
                    { 4, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5618), null, "Nöroloji ve Beyin Cerrahisi", null },
                    { 5, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5621), null, "Endokrinoloji ve Metabolizma", null },
                    { 6, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5627), null, "Gastroenteroloji ve Sindirim Sistemi", null },
                    { 7, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5630), null, "Psikiyatri ve Mental Sağlık", null },
                    { 8, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5633), null, "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri", null },
                    { 9, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5637), null, "Parkinson Hastalığı", null },
                    { 10, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5640), null, "Bunama", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4530), null, "Admin", null },
                    { 2, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4540), null, "Appointment.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5096), null, "hasta1@example.com", "John", "Male", false, "Doe", new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 }, new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 }, "1234567890", null, 0 },
                    { 2, new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5106), null, "hasta2@example.com", "Jonathan", "Male", false, "Corwin", new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 }, new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 }, "1234512345", null, 0 },
                    { 3, new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5111), null, "doktor1@example.com", "batu", "Male", false, "cerrahlar", new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 }, new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 }, "1234512312", null, 1 },
                    { 4, new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5115), null, "doktor2@example.com", "kalp", "Male", false, "doktoru", new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 }, new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 }, "1234512313", null, 1 },
                    { 5, new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5119), null, "admin@example.com", "Admin", "Male", false, "Yöneticioğlu", new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 }, new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 }, "1234512345", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Biography", "CreatedDate", "DeletedDate", "DoctorSpecializationId", "Experience", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, "Id 3 olan Doktor Özgeçmiş Example", new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5375), null, 1, 10, null },
                    { 4, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5382), null, 2, 5, null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1234 Main St", 0, "A+", new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5226), null, null },
                    { 2, "1233 Main St", 0, "B+", new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5234), null, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4650), null, 1, null, 5 },
                    { 2, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4660), null, 2, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "CreatedDate", "DeletedDate", "DoctorId", "IsDeleted", "PatientId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5484), new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5485), null, 3, false, 1, 0, null },
                    { 2, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5492), new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5493), null, 4, false, 1, 0, null },
                    { 3, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5497), new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5498), null, 3, false, 2, 0, null },
                    { 4, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5501), new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5502), null, 4, false, 2, 0, null }
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
                    { 1, 1, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5836), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 2, 2, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5848), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 3, 3, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5852), null, "Diabetes Mellitus", "Fasting blood sugar level of 140 mg/dL", null },
                    { 4, 4, new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5855), null, "Chronic Obstructive Pulmonary Disease (COPD)", "Reduced lung function on spirometry", null }
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
