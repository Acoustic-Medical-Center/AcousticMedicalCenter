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
                    { 1, new DateTime(2024, 6, 12, 1, 6, 50, 588, DateTimeKind.Local).AddTicks(9920), null, "Cerrah", null },
                    { 2, new DateTime(2024, 6, 12, 1, 6, 50, 588, DateTimeKind.Local).AddTicks(9950), null, "Kalp", null }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1241), null, "Kardiyoloji Araştırmaları", null },
                    { 2, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1252), null, "Çocuk Sağlığı", null },
                    { 3, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1256), null, "Onkoloji Tedavi", null },
                    { 4, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1260), null, "Nöroloji ve Beyin Cerrahisi", null },
                    { 5, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1263), null, "Endokrinoloji ve Metabolizma", null },
                    { 6, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1269), null, "Gastroenteroloji ve Sindirim Sistemi", null },
                    { 7, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1272), null, "Psikiyatri ve Mental Sağlık", null },
                    { 8, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1276), null, "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri", null },
                    { 9, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1280), null, "Parkinson Hastalığı", null },
                    { 10, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1284), null, "Bunama", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(73), null, "Admin", null },
                    { 2, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(80), null, "Appointment.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(701), null, "hasta1@example.com", "John", "Male", false, "Doe", new byte[] { 233, 97, 61, 2, 125, 16, 232, 220, 225, 30, 23, 71, 255, 122, 95, 71, 219, 61, 243, 252, 168, 1, 232, 183, 72, 172, 196, 138, 39, 12, 42, 105, 240, 132, 41, 230, 59, 17, 83, 21, 141, 92, 68, 189, 252, 148, 39, 164, 133, 239, 115, 142, 177, 193, 215, 46, 214, 180, 222, 222, 200, 145, 203, 219 }, new byte[] { 186, 65, 135, 84, 235, 18, 151, 37, 46, 128, 228, 177, 50, 71, 208, 2, 227, 213, 225, 234, 200, 44, 199, 249, 61, 227, 178, 210, 58, 134, 186, 63, 60, 194, 229, 214, 222, 53, 35, 168, 102, 183, 56, 85, 85, 90, 172, 213, 248, 67, 203, 247, 190, 130, 143, 147, 227, 61, 181, 241, 205, 170, 251, 21, 184, 172, 72, 32, 153, 248, 216, 100, 6, 149, 51, 213, 151, 215, 102, 11, 221, 212, 161, 18, 234, 195, 29, 117, 248, 234, 149, 180, 69, 23, 193, 88, 53, 86, 154, 30, 109, 32, 249, 96, 95, 205, 40, 191, 42, 225, 248, 133, 31, 112, 247, 59, 111, 47, 107, 224, 57, 196, 64, 187, 93, 67, 45, 166 }, "1234567890", null, 0 },
                    { 2, new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(713), null, "hasta2@example.com", "Jonathan", "Male", false, "Corwin", new byte[] { 233, 97, 61, 2, 125, 16, 232, 220, 225, 30, 23, 71, 255, 122, 95, 71, 219, 61, 243, 252, 168, 1, 232, 183, 72, 172, 196, 138, 39, 12, 42, 105, 240, 132, 41, 230, 59, 17, 83, 21, 141, 92, 68, 189, 252, 148, 39, 164, 133, 239, 115, 142, 177, 193, 215, 46, 214, 180, 222, 222, 200, 145, 203, 219 }, new byte[] { 186, 65, 135, 84, 235, 18, 151, 37, 46, 128, 228, 177, 50, 71, 208, 2, 227, 213, 225, 234, 200, 44, 199, 249, 61, 227, 178, 210, 58, 134, 186, 63, 60, 194, 229, 214, 222, 53, 35, 168, 102, 183, 56, 85, 85, 90, 172, 213, 248, 67, 203, 247, 190, 130, 143, 147, 227, 61, 181, 241, 205, 170, 251, 21, 184, 172, 72, 32, 153, 248, 216, 100, 6, 149, 51, 213, 151, 215, 102, 11, 221, 212, 161, 18, 234, 195, 29, 117, 248, 234, 149, 180, 69, 23, 193, 88, 53, 86, 154, 30, 109, 32, 249, 96, 95, 205, 40, 191, 42, 225, 248, 133, 31, 112, 247, 59, 111, 47, 107, 224, 57, 196, 64, 187, 93, 67, 45, 166 }, "1234512345", null, 0 },
                    { 3, new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(717), null, "doktor1@example.com", "batu", "Male", false, "cerrahlar", new byte[] { 233, 97, 61, 2, 125, 16, 232, 220, 225, 30, 23, 71, 255, 122, 95, 71, 219, 61, 243, 252, 168, 1, 232, 183, 72, 172, 196, 138, 39, 12, 42, 105, 240, 132, 41, 230, 59, 17, 83, 21, 141, 92, 68, 189, 252, 148, 39, 164, 133, 239, 115, 142, 177, 193, 215, 46, 214, 180, 222, 222, 200, 145, 203, 219 }, new byte[] { 186, 65, 135, 84, 235, 18, 151, 37, 46, 128, 228, 177, 50, 71, 208, 2, 227, 213, 225, 234, 200, 44, 199, 249, 61, 227, 178, 210, 58, 134, 186, 63, 60, 194, 229, 214, 222, 53, 35, 168, 102, 183, 56, 85, 85, 90, 172, 213, 248, 67, 203, 247, 190, 130, 143, 147, 227, 61, 181, 241, 205, 170, 251, 21, 184, 172, 72, 32, 153, 248, 216, 100, 6, 149, 51, 213, 151, 215, 102, 11, 221, 212, 161, 18, 234, 195, 29, 117, 248, 234, 149, 180, 69, 23, 193, 88, 53, 86, 154, 30, 109, 32, 249, 96, 95, 205, 40, 191, 42, 225, 248, 133, 31, 112, 247, 59, 111, 47, 107, 224, 57, 196, 64, 187, 93, 67, 45, 166 }, "1234512312", null, 1 },
                    { 4, new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(721), null, "doktor2@example.com", "kalp", "Male", false, "doktoru", new byte[] { 233, 97, 61, 2, 125, 16, 232, 220, 225, 30, 23, 71, 255, 122, 95, 71, 219, 61, 243, 252, 168, 1, 232, 183, 72, 172, 196, 138, 39, 12, 42, 105, 240, 132, 41, 230, 59, 17, 83, 21, 141, 92, 68, 189, 252, 148, 39, 164, 133, 239, 115, 142, 177, 193, 215, 46, 214, 180, 222, 222, 200, 145, 203, 219 }, new byte[] { 186, 65, 135, 84, 235, 18, 151, 37, 46, 128, 228, 177, 50, 71, 208, 2, 227, 213, 225, 234, 200, 44, 199, 249, 61, 227, 178, 210, 58, 134, 186, 63, 60, 194, 229, 214, 222, 53, 35, 168, 102, 183, 56, 85, 85, 90, 172, 213, 248, 67, 203, 247, 190, 130, 143, 147, 227, 61, 181, 241, 205, 170, 251, 21, 184, 172, 72, 32, 153, 248, 216, 100, 6, 149, 51, 213, 151, 215, 102, 11, 221, 212, 161, 18, 234, 195, 29, 117, 248, 234, 149, 180, 69, 23, 193, 88, 53, 86, 154, 30, 109, 32, 249, 96, 95, 205, 40, 191, 42, 225, 248, 133, 31, 112, 247, 59, 111, 47, 107, 224, 57, 196, 64, 187, 93, 67, 45, 166 }, "1234512313", null, 1 },
                    { 5, new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(725), null, "admin@example.com", "Admin", "Male", false, "Yöneticioğlu", new byte[] { 233, 97, 61, 2, 125, 16, 232, 220, 225, 30, 23, 71, 255, 122, 95, 71, 219, 61, 243, 252, 168, 1, 232, 183, 72, 172, 196, 138, 39, 12, 42, 105, 240, 132, 41, 230, 59, 17, 83, 21, 141, 92, 68, 189, 252, 148, 39, 164, 133, 239, 115, 142, 177, 193, 215, 46, 214, 180, 222, 222, 200, 145, 203, 219 }, new byte[] { 186, 65, 135, 84, 235, 18, 151, 37, 46, 128, 228, 177, 50, 71, 208, 2, 227, 213, 225, 234, 200, 44, 199, 249, 61, 227, 178, 210, 58, 134, 186, 63, 60, 194, 229, 214, 222, 53, 35, 168, 102, 183, 56, 85, 85, 90, 172, 213, 248, 67, 203, 247, 190, 130, 143, 147, 227, 61, 181, 241, 205, 170, 251, 21, 184, 172, 72, 32, 153, 248, 216, 100, 6, 149, 51, 213, 151, 215, 102, 11, 221, 212, 161, 18, 234, 195, 29, 117, 248, 234, 149, 180, 69, 23, 193, 88, 53, 86, 154, 30, 109, 32, 249, 96, 95, 205, 40, 191, 42, 225, 248, 133, 31, 112, 247, 59, 111, 47, 107, 224, 57, 196, 64, 187, 93, 67, 45, 166 }, "1234512345", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Biography", "CreatedDate", "DeletedDate", "DoctorSpecializationId", "Experience", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, "Id 3 olan Doktor Özgeçmiş Example", new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(932), null, 1, 10, null },
                    { 4, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(942), null, 2, 5, null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1234 Main St", 0, "A+", new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(831), null, null },
                    { 2, "1233 Main St", 0, "B+", new DateTime(2024, 6, 11, 22, 6, 50, 589, DateTimeKind.Utc).AddTicks(839), null, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(189), null, 1, null, 5 },
                    { 2, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(199), null, 2, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "CreatedDate", "DeletedDate", "DoctorId", "IsDeleted", "PatientId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1081), new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1083), null, 3, false, 1, 0, null },
                    { 2, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1095), new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1095), null, 4, false, 1, 0, null },
                    { 3, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1101), null, 3, false, 2, 0, null },
                    { 4, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1105), new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1106), null, 4, false, 2, 0, null }
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
                    { 1, 1, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1629), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 2, 2, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1645), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 3, 3, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1650), null, "Diabetes Mellitus", "Fasting blood sugar level of 140 mg/dL", null },
                    { 4, 4, new DateTime(2024, 6, 12, 1, 6, 50, 589, DateTimeKind.Local).AddTicks(1654), null, "Chronic Obstructive Pulmonary Disease (COPD)", "Reduced lung function on spirometry", null }
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
