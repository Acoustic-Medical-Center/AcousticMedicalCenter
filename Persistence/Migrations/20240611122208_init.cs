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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    { 1, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(187), null, "Cerrah", null },
                    { 2, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(223), null, "Kalp", null }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1323), null, "Kardiyoloji Araştırmaları", null },
                    { 2, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1331), null, "Çocuk Sağlığı", null },
                    { 3, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1334), null, "Onkoloji Tedavi", null },
                    { 4, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1338), null, "Nöroloji ve Beyin Cerrahisi", null },
                    { 5, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1341), null, "Endokrinoloji ve Metabolizma", null },
                    { 6, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1345), null, "Gastroenteroloji ve Sindirim Sistemi", null },
                    { 7, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1388), null, "Psikiyatri ve Mental Sağlık", null },
                    { 8, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1391), null, "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri", null },
                    { 9, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1394), null, "Parkinson Hastalığı", null },
                    { 10, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1399), null, "Bunama", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(333), null, "Admin", null },
                    { 2, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(342), null, "Appointment.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(884), null, "hasta1@example.com", "John", "Male", false, "Doe", new byte[] { 243, 150, 71, 42, 143, 223, 78, 205, 33, 8, 230, 209, 139, 157, 103, 171, 38, 136, 189, 188, 98, 21, 226, 24, 203, 66, 60, 254, 1, 204, 137, 142, 27, 91, 148, 133, 16, 237, 104, 152, 151, 74, 154, 124, 11, 143, 133, 153, 61, 236, 53, 73, 85, 14, 109, 252, 157, 105, 169, 107, 96, 98, 26, 158 }, new byte[] { 37, 49, 100, 185, 106, 53, 47, 217, 90, 122, 94, 190, 135, 227, 201, 233, 168, 196, 241, 193, 109, 217, 118, 91, 69, 150, 192, 38, 210, 33, 40, 71, 3, 178, 14, 173, 78, 213, 191, 157, 146, 188, 0, 82, 12, 234, 77, 176, 151, 49, 95, 45, 153, 66, 58, 137, 92, 154, 71, 28, 68, 17, 58, 65, 2, 180, 131, 148, 233, 137, 44, 104, 45, 120, 171, 105, 134, 210, 98, 107, 129, 232, 161, 8, 156, 109, 99, 139, 192, 234, 146, 195, 9, 219, 19, 197, 223, 146, 149, 170, 41, 226, 162, 139, 112, 222, 224, 198, 100, 70, 245, 97, 150, 169, 28, 90, 217, 240, 111, 203, 82, 71, 55, 232, 102, 47, 91, 228 }, "1234567890", null, 0 },
                    { 2, new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(894), null, "hasta2@example.com", "Jonathan", "Male", false, "Corwin", new byte[] { 243, 150, 71, 42, 143, 223, 78, 205, 33, 8, 230, 209, 139, 157, 103, 171, 38, 136, 189, 188, 98, 21, 226, 24, 203, 66, 60, 254, 1, 204, 137, 142, 27, 91, 148, 133, 16, 237, 104, 152, 151, 74, 154, 124, 11, 143, 133, 153, 61, 236, 53, 73, 85, 14, 109, 252, 157, 105, 169, 107, 96, 98, 26, 158 }, new byte[] { 37, 49, 100, 185, 106, 53, 47, 217, 90, 122, 94, 190, 135, 227, 201, 233, 168, 196, 241, 193, 109, 217, 118, 91, 69, 150, 192, 38, 210, 33, 40, 71, 3, 178, 14, 173, 78, 213, 191, 157, 146, 188, 0, 82, 12, 234, 77, 176, 151, 49, 95, 45, 153, 66, 58, 137, 92, 154, 71, 28, 68, 17, 58, 65, 2, 180, 131, 148, 233, 137, 44, 104, 45, 120, 171, 105, 134, 210, 98, 107, 129, 232, 161, 8, 156, 109, 99, 139, 192, 234, 146, 195, 9, 219, 19, 197, 223, 146, 149, 170, 41, 226, 162, 139, 112, 222, 224, 198, 100, 70, 245, 97, 150, 169, 28, 90, 217, 240, 111, 203, 82, 71, 55, 232, 102, 47, 91, 228 }, "1234512345", null, 0 },
                    { 3, new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(899), null, "doktor1@example.com", "batu", "Male", false, "cerrahlar", new byte[] { 243, 150, 71, 42, 143, 223, 78, 205, 33, 8, 230, 209, 139, 157, 103, 171, 38, 136, 189, 188, 98, 21, 226, 24, 203, 66, 60, 254, 1, 204, 137, 142, 27, 91, 148, 133, 16, 237, 104, 152, 151, 74, 154, 124, 11, 143, 133, 153, 61, 236, 53, 73, 85, 14, 109, 252, 157, 105, 169, 107, 96, 98, 26, 158 }, new byte[] { 37, 49, 100, 185, 106, 53, 47, 217, 90, 122, 94, 190, 135, 227, 201, 233, 168, 196, 241, 193, 109, 217, 118, 91, 69, 150, 192, 38, 210, 33, 40, 71, 3, 178, 14, 173, 78, 213, 191, 157, 146, 188, 0, 82, 12, 234, 77, 176, 151, 49, 95, 45, 153, 66, 58, 137, 92, 154, 71, 28, 68, 17, 58, 65, 2, 180, 131, 148, 233, 137, 44, 104, 45, 120, 171, 105, 134, 210, 98, 107, 129, 232, 161, 8, 156, 109, 99, 139, 192, 234, 146, 195, 9, 219, 19, 197, 223, 146, 149, 170, 41, 226, 162, 139, 112, 222, 224, 198, 100, 70, 245, 97, 150, 169, 28, 90, 217, 240, 111, 203, 82, 71, 55, 232, 102, 47, 91, 228 }, "1234512312", null, 1 },
                    { 4, new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(904), null, "doktor2@example.com", "kalp", "Male", false, "doktoru", new byte[] { 243, 150, 71, 42, 143, 223, 78, 205, 33, 8, 230, 209, 139, 157, 103, 171, 38, 136, 189, 188, 98, 21, 226, 24, 203, 66, 60, 254, 1, 204, 137, 142, 27, 91, 148, 133, 16, 237, 104, 152, 151, 74, 154, 124, 11, 143, 133, 153, 61, 236, 53, 73, 85, 14, 109, 252, 157, 105, 169, 107, 96, 98, 26, 158 }, new byte[] { 37, 49, 100, 185, 106, 53, 47, 217, 90, 122, 94, 190, 135, 227, 201, 233, 168, 196, 241, 193, 109, 217, 118, 91, 69, 150, 192, 38, 210, 33, 40, 71, 3, 178, 14, 173, 78, 213, 191, 157, 146, 188, 0, 82, 12, 234, 77, 176, 151, 49, 95, 45, 153, 66, 58, 137, 92, 154, 71, 28, 68, 17, 58, 65, 2, 180, 131, 148, 233, 137, 44, 104, 45, 120, 171, 105, 134, 210, 98, 107, 129, 232, 161, 8, 156, 109, 99, 139, 192, 234, 146, 195, 9, 219, 19, 197, 223, 146, 149, 170, 41, 226, 162, 139, 112, 222, 224, 198, 100, 70, 245, 97, 150, 169, 28, 90, 217, 240, 111, 203, 82, 71, 55, 232, 102, 47, 91, 228 }, "1234512313", null, 1 },
                    { 5, new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(907), null, "admin@example.com", "Admin", "Male", false, "Yöneticioğlu", new byte[] { 243, 150, 71, 42, 143, 223, 78, 205, 33, 8, 230, 209, 139, 157, 103, 171, 38, 136, 189, 188, 98, 21, 226, 24, 203, 66, 60, 254, 1, 204, 137, 142, 27, 91, 148, 133, 16, 237, 104, 152, 151, 74, 154, 124, 11, 143, 133, 153, 61, 236, 53, 73, 85, 14, 109, 252, 157, 105, 169, 107, 96, 98, 26, 158 }, new byte[] { 37, 49, 100, 185, 106, 53, 47, 217, 90, 122, 94, 190, 135, 227, 201, 233, 168, 196, 241, 193, 109, 217, 118, 91, 69, 150, 192, 38, 210, 33, 40, 71, 3, 178, 14, 173, 78, 213, 191, 157, 146, 188, 0, 82, 12, 234, 77, 176, 151, 49, 95, 45, 153, 66, 58, 137, 92, 154, 71, 28, 68, 17, 58, 65, 2, 180, 131, 148, 233, 137, 44, 104, 45, 120, 171, 105, 134, 210, 98, 107, 129, 232, 161, 8, 156, 109, 99, 139, 192, 234, 146, 195, 9, 219, 19, 197, 223, 146, 149, 170, 41, 226, 162, 139, 112, 222, 224, 198, 100, 70, 245, 97, 150, 169, 28, 90, 217, 240, 111, 203, 82, 71, 55, 232, 102, 47, 91, 228 }, "1234512345", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Biography", "CreatedDate", "DeletedDate", "DoctorSpecializationId", "Experience", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, "Id 3 olan Doktor Özgeçmiş Example", new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(1110), null, 1, 10, null },
                    { 4, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(1117), null, 2, 5, null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1234 Main St", 0, "A+", new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(1012), null, null },
                    { 2, "1233 Main St", 0, "B+", new DateTime(2024, 6, 11, 12, 22, 7, 939, DateTimeKind.Utc).AddTicks(1021), null, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(449), null, 1, null, 5 },
                    { 2, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(458), null, 2, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "CreatedDate", "DeletedDate", "DoctorId", "IsDeleted", "PatientId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1216), new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1217), null, 3, false, 1, 0, null },
                    { 2, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1224), new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1225), null, 4, false, 1, 0, null },
                    { 3, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1229), new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1230), null, 3, false, 2, 0, null },
                    { 4, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1233), new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1234), null, 4, false, 2, 0, null }
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
                    { 1, 1, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1693), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 2, 2, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1701), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 3, 3, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1705), null, "Diabetes Mellitus", "Fasting blood sugar level of 140 mg/dL", null },
                    { 4, 4, new DateTime(2024, 6, 11, 15, 22, 7, 939, DateTimeKind.Local).AddTicks(1709), null, "Chronic Obstructive Pulmonary Disease (COPD)", "Reduced lung function on spirometry", null }
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
