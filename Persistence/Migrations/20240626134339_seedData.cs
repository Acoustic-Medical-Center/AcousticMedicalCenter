using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
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
                    { 1, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(5978), null, "Neurosurgery", "Beyin ve Sinir Cerrahisi", null },
                    { 2, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(5987), null, "Dermatology", "Dermatoloji", null },
                    { 3, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(5988), null, "General Surgery", "Genel Cerrahi", null },
                    { 4, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(5989), null, "Ophthalmology", "Göz Hastalıkları", null },
                    { 5, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(5990), null, "Internal Medicine", "İç Hastalıkları", null },
                    { 6, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(5992), null, "Obstetrics and Gynecology", "Kadın Hastalıkları ve Doğum", null },
                    { 7, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(5993), null, "Otorhinolaryngology", "Kulak Burun Boğaz", null },
                    { 8, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(5994), null, "Orthopedics and Traumatology", "Ortopedi ve Travmatoloji", null },
                    { 9, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(5996), null, "Urology", "Üroloji", null },
                    { 10, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(5997), null, "Pediatrics", "Çocuk Sağlığı ve Hastalıkları", null }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7338), null, "Kardiyoloji Araştırmaları", null },
                    { 2, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7344), null, "Çocuk Sağlığı", null },
                    { 3, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7348), null, "Onkoloji Tedavi", null },
                    { 4, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7351), null, "Nöroloji ve Beyin Cerrahisi", null },
                    { 5, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7355), null, "Endokrinoloji ve Metabolizma", null },
                    { 6, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7359), null, "Gastroenteroloji ve Sindirim Sistemi", null },
                    { 7, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7363), null, "Psikiyatri ve Mental Sağlık", null },
                    { 8, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7366), null, "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri", null },
                    { 9, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7370), null, "Parkinson Hastalığı", null },
                    { 10, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7374), null, "Bunama", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(6202), null, "Admin", null },
                    { 2, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(6210), null, "Appointment.Delete", null },
                    { 3, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(6215), null, "Doctor", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6708), null, "hasta1@example.com", "John", "Male", false, "Doe", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234567890", null, 0 },
                    { 2, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6719), null, "hasta2@example.com", "Jonathan", "Male", false, "Corwin", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234512345", null, 0 },
                    { 3, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6724), null, "doktor1@example.com", "batu", "Male", false, "cerrahlar", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234512312", null, 1 },
                    { 4, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6728), null, "doktor4@example.com", "Fatma", "Female", false, "Koç", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500004", null, 1 },
                    { 5, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6766), null, "doktor5@example.com", "Mehmet", "Male", false, "Öz", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500005", null, 1 },
                    { 6, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6768), null, "doktor6@example.com", "Canan", "Female", false, "Çelik", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500006", null, 1 },
                    { 7, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6770), null, "doktor7@example.com", "Emre", "Male", false, "Arı", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500007", null, 1 },
                    { 8, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6772), null, "doktor8@example.com", "Burak", "Male", false, "Temiz", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500008", null, 1 },
                    { 9, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6774), null, "doktor9@example.com", "Seda", "Female", false, "Ak", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500009", null, 1 },
                    { 10, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6776), null, "doktor10@example.com", "Murat", "Male", false, "Tez", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500010", null, 1 },
                    { 11, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6778), null, "doktor11@example.com", "Zeynep", "Female", false, "Bal", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500011", null, 1 },
                    { 12, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6780), null, "doktor12@example.com", "Kemal", "Male", false, "Sağ", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500012", null, 1 },
                    { 13, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6782), null, "doktor13@example.com", "Cansu", "Female", false, "Dur", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500013", null, 1 },
                    { 14, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6784), null, "doktor14@example.com", "Oğuz", "Male", false, "Kurt", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500014", null, 1 },
                    { 15, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6786), null, "doktor15@example.com", "Esra", "Female", false, "Deniz", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500015", null, 1 },
                    { 16, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6788), null, "doktor16@example.com", "Baran", "Male", false, "Gül", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500016", null, 1 },
                    { 17, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6790), null, "doktor17@example.com", "Duygu", "Female", false, "Aydın", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500017", null, 1 },
                    { 18, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6792), null, "doktor18@example.com", "Tarkan", "Male", false, "Kara", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500018", null, 1 },
                    { 19, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6793), null, "doktor19@example.com", "Nil", "Female", false, "Koç", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500019", null, 1 },
                    { 20, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6795), null, "doktor20@example.com", "Sami", "Male", false, "Öztürk", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500020", null, 1 },
                    { 21, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6797), null, "doktor21@example.com", "Ece", "Female", false, "Uzun", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500021", null, 1 },
                    { 22, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6799), null, "doktor22@example.com", "Levent", "Male", false, "Yıldız", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500022", null, 1 },
                    { 23, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6801), null, "doktor23@example.com", "Selin", "Female", false, "Demirci", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500023", null, 1 },
                    { 24, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6803), null, "doktor24@example.com", "Onur", "Male", false, "Akar", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500024", null, 1 },
                    { 25, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6805), null, "doktor25@example.com", "İrem", "Female", false, "Dere", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500025", null, 1 },
                    { 26, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6806), null, "doktor26@example.com", "Cenk", "Male", false, "Taş", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500026", null, 1 },
                    { 27, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6810), null, "doktor27@example.com", "Hande", "Female", false, "Yener", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234500027", null, 1 },
                    { 99, new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6843), null, "admin@example.com", "Admin", "Male", false, "Yöneticioğlu", new byte[] { 4, 12, 78, 14, 16, 168, 118, 149, 135, 120, 6, 135, 15, 2, 110, 100, 168, 204, 206, 182, 195, 244, 202, 75, 59, 150, 117, 13, 126, 230, 196, 126, 203, 134, 46, 255, 10, 170, 168, 178, 15, 171, 136, 70, 129, 12, 185, 83, 27, 91, 102, 244, 31, 220, 31, 12, 32, 240, 37, 47, 14, 232, 71, 14 }, new byte[] { 5, 185, 172, 142, 241, 163, 48, 90, 21, 214, 81, 156, 185, 153, 173, 77, 1, 38, 156, 210, 169, 34, 51, 27, 87, 244, 79, 102, 65, 6, 200, 117, 159, 132, 63, 112, 63, 136, 68, 44, 220, 115, 98, 132, 2, 254, 25, 23, 237, 115, 190, 36, 143, 188, 25, 19, 4, 26, 134, 226, 71, 111, 203, 82, 30, 53, 58, 190, 179, 169, 91, 145, 113, 242, 43, 123, 46, 34, 155, 62, 255, 221, 116, 67, 72, 56, 7, 13, 34, 91, 146, 36, 222, 153, 125, 114, 85, 223, 212, 109, 22, 246, 39, 132, 226, 3, 218, 219, 105, 53, 237, 217, 90, 247, 105, 196, 81, 179, 153, 191, 239, 169, 235, 55, 56, 203, 20, 40 }, "1234512345", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Biography", "CreatedDate", "DeletedDate", "DoctorSpecializationId", "Experience", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, "Id 3 olan Doktor Özgeçmiş Example asd", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7048), null, 1, 10, null },
                    { 4, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7055), null, 2, 5, null },
                    { 5, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7056), null, 7, 3, null },
                    { 6, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7057), null, 1, 10, null },
                    { 7, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7059), null, 4, 8, null },
                    { 8, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7060), null, 6, 6, null },
                    { 9, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7061), null, 9, 7, null },
                    { 10, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7062), null, 5, 2, null },
                    { 11, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7063), null, 10, 4, null },
                    { 12, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7065), null, 8, 9, null },
                    { 13, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7066), null, 3, 6, null },
                    { 14, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7067), null, 2, 5, null },
                    { 15, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7069), null, 7, 3, null },
                    { 16, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7070), null, 1, 10, null },
                    { 17, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7071), null, 4, 8, null },
                    { 18, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7072), null, 6, 6, null },
                    { 19, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7074), null, 9, 7, null },
                    { 20, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7075), null, 5, 2, null },
                    { 21, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7076), null, 10, 4, null },
                    { 22, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7077), null, 8, 9, null },
                    { 23, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7078), null, 3, 6, null },
                    { 24, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7080), null, 2, 5, null },
                    { 25, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7081), null, 1, 4, null },
                    { 26, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7082), null, 5, 7, null },
                    { 27, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(7083), null, 8, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "1234 Main St", 0, "A+", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6951), null, null },
                    { 2, "1233 Main St", 0, "B+", new DateTime(2024, 6, 26, 13, 43, 38, 563, DateTimeKind.Utc).AddTicks(6959), null, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(6315), null, 1, null, 5 },
                    { 2, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(6326), null, 2, null, 3 },
                    { 3, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(6330), null, 3, null, 3 },
                    { 4, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(6334), null, 3, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "CreatedDate", "DeletedDate", "DoctorId", "IsDeleted", "PatientId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7226), new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7228), null, 3, false, 1, 0, null },
                    { 2, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7236), new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7236), null, 4, false, 1, 0, null },
                    { 3, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7241), new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7242), null, 3, false, 2, 0, null },
                    { 4, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7245), new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7246), null, 4, false, 2, 0, null }
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
                    { 1, 1, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7571), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 2, 2, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7579), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 3, 3, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7583), null, "Diabetes Mellitus", "Fasting blood sugar level of 140 mg/dL", null },
                    { 4, 4, new DateTime(2024, 6, 26, 16, 43, 38, 563, DateTimeKind.Local).AddTicks(7587), null, "Chronic Obstructive Pulmonary Disease (COPD)", "Reduced lung function on spirometry", null }
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
