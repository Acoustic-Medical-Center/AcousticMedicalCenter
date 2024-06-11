using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class report : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Doctors");

            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1632), new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1642), new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1646), new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1651), new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Biography", "CreatedDate" },
                values: new object[] { "Id 3 olan Doktor Özgeçmiş Example", new DateTime(2024, 6, 11, 14, 16, 51, 897, DateTimeKind.Utc).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Biography", "CreatedDate" },
                values: new object[] { "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 11, 14, 16, 51, 897, DateTimeKind.Utc).AddTicks(1506) });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1756), null, "Kardiyoloji Araştırmaları", null },
                    { 2, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1767), null, "Çocuk Sağlığı", null },
                    { 3, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1770), null, "Onkoloji Tedavi", null },
                    { 4, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1774), null, "Nöroloji ve Beyin Cerrahisi", null },
                    { 5, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1778), null, "Endokrinoloji ve Metabolizma", null },
                    { 6, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1783), null, "Gastroenteroloji ve Sindirim Sistemi", null },
                    { 7, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1786), null, "Psikiyatri ve Mental Sağlık", null },
                    { 8, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1789), null, "Aile Hekimliği ve Birinci Basamak Sağlık Hizmetleri", null },
                    { 9, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1793), null, "Parkinson Hastalığı", null },
                    { 10, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(1797), null, "Bunama", null }
                });

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 14, 16, 51, 897, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 14, 16, 51, 897, DateTimeKind.Utc).AddTicks(1383));

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "AppointmentId", "CreatedDate", "DeletedDate", "Diagnosis", "ExaminationFindings", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(2024), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 2, 2, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(2033), null, " Hipertansiyon", "Yüksek kan basıncı", null },
                    { 3, 3, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(2036), null, "Diabetes Mellitus", "Fasting blood sugar level of 140 mg/dL", null },
                    { 4, 4, new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(2040), null, "Chronic Obstructive Pulmonary Disease (COPD)", "Reduced lung function on spirometry", null }
                });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 16, 51, 897, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 11, 14, 16, 51, 897, DateTimeKind.Utc).AddTicks(1185), new byte[] { 170, 192, 204, 105, 81, 147, 68, 210, 127, 92, 160, 253, 45, 228, 136, 217, 156, 93, 92, 38, 117, 52, 192, 250, 169, 55, 210, 245, 72, 75, 193, 214, 71, 96, 90, 164, 25, 207, 119, 71, 213, 157, 60, 48, 98, 114, 252, 95, 58, 154, 177, 27, 206, 161, 193, 133, 111, 165, 194, 37, 179, 185, 44, 7 }, new byte[] { 218, 231, 197, 94, 76, 143, 61, 13, 253, 13, 158, 116, 224, 231, 12, 72, 63, 184, 198, 242, 135, 77, 126, 50, 3, 127, 179, 99, 53, 222, 95, 160, 168, 125, 125, 156, 204, 33, 221, 124, 110, 184, 140, 87, 89, 129, 176, 86, 2, 191, 5, 175, 74, 0, 34, 225, 170, 247, 167, 211, 191, 71, 80, 98, 57, 74, 34, 157, 67, 116, 162, 85, 216, 147, 99, 92, 179, 109, 254, 163, 99, 68, 205, 61, 234, 88, 152, 69, 193, 44, 9, 254, 93, 195, 112, 30, 97, 96, 46, 90, 2, 116, 238, 246, 175, 237, 238, 115, 10, 132, 229, 27, 77, 162, 251, 38, 70, 191, 255, 164, 34, 155, 157, 96, 180, 19, 162, 233 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 11, 14, 16, 51, 897, DateTimeKind.Utc).AddTicks(1195), new byte[] { 170, 192, 204, 105, 81, 147, 68, 210, 127, 92, 160, 253, 45, 228, 136, 217, 156, 93, 92, 38, 117, 52, 192, 250, 169, 55, 210, 245, 72, 75, 193, 214, 71, 96, 90, 164, 25, 207, 119, 71, 213, 157, 60, 48, 98, 114, 252, 95, 58, 154, 177, 27, 206, 161, 193, 133, 111, 165, 194, 37, 179, 185, 44, 7 }, new byte[] { 218, 231, 197, 94, 76, 143, 61, 13, 253, 13, 158, 116, 224, 231, 12, 72, 63, 184, 198, 242, 135, 77, 126, 50, 3, 127, 179, 99, 53, 222, 95, 160, 168, 125, 125, 156, 204, 33, 221, 124, 110, 184, 140, 87, 89, 129, 176, 86, 2, 191, 5, 175, 74, 0, 34, 225, 170, 247, 167, 211, 191, 71, 80, 98, 57, 74, 34, 157, 67, 116, 162, 85, 216, 147, 99, 92, 179, 109, 254, 163, 99, 68, 205, 61, 234, 88, 152, 69, 193, 44, 9, 254, 93, 195, 112, 30, 97, 96, 46, 90, 2, 116, 238, 246, 175, 237, 238, 115, 10, 132, 229, 27, 77, 162, 251, 38, 70, 191, 255, 164, 34, 155, 157, 96, 180, 19, 162, 233 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 11, 14, 16, 51, 897, DateTimeKind.Utc).AddTicks(1199), new byte[] { 170, 192, 204, 105, 81, 147, 68, 210, 127, 92, 160, 253, 45, 228, 136, 217, 156, 93, 92, 38, 117, 52, 192, 250, 169, 55, 210, 245, 72, 75, 193, 214, 71, 96, 90, 164, 25, 207, 119, 71, 213, 157, 60, 48, 98, 114, 252, 95, 58, 154, 177, 27, 206, 161, 193, 133, 111, 165, 194, 37, 179, 185, 44, 7 }, new byte[] { 218, 231, 197, 94, 76, 143, 61, 13, 253, 13, 158, 116, 224, 231, 12, 72, 63, 184, 198, 242, 135, 77, 126, 50, 3, 127, 179, 99, 53, 222, 95, 160, 168, 125, 125, 156, 204, 33, 221, 124, 110, 184, 140, 87, 89, 129, 176, 86, 2, 191, 5, 175, 74, 0, 34, 225, 170, 247, 167, 211, 191, 71, 80, 98, 57, 74, 34, 157, 67, 116, 162, 85, 216, 147, 99, 92, 179, 109, 254, 163, 99, 68, 205, 61, 234, 88, 152, 69, 193, 44, 9, 254, 93, 195, 112, 30, 97, 96, 46, 90, 2, 116, 238, 246, 175, 237, 238, 115, 10, 132, 229, 27, 77, 162, 251, 38, 70, 191, 255, 164, 34, 155, 157, 96, 180, 19, 162, 233 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 11, 14, 16, 51, 897, DateTimeKind.Utc).AddTicks(1204), new byte[] { 170, 192, 204, 105, 81, 147, 68, 210, 127, 92, 160, 253, 45, 228, 136, 217, 156, 93, 92, 38, 117, 52, 192, 250, 169, 55, 210, 245, 72, 75, 193, 214, 71, 96, 90, 164, 25, 207, 119, 71, 213, 157, 60, 48, 98, 114, 252, 95, 58, 154, 177, 27, 206, 161, 193, 133, 111, 165, 194, 37, 179, 185, 44, 7 }, new byte[] { 218, 231, 197, 94, 76, 143, 61, 13, 253, 13, 158, 116, 224, 231, 12, 72, 63, 184, 198, 242, 135, 77, 126, 50, 3, 127, 179, 99, 53, 222, 95, 160, 168, 125, 125, 156, 204, 33, 221, 124, 110, 184, 140, 87, 89, 129, 176, 86, 2, 191, 5, 175, 74, 0, 34, 225, 170, 247, 167, 211, 191, 71, 80, 98, 57, 74, 34, 157, 67, 116, 162, 85, 216, 147, 99, 92, 179, 109, 254, 163, 99, 68, 205, 61, 234, 88, 152, 69, 193, 44, 9, 254, 93, 195, 112, 30, 97, 96, 46, 90, 2, 116, 238, 246, 175, 237, 238, 115, 10, 132, 229, 27, 77, 162, 251, 38, 70, 191, 255, 164, 34, 155, 157, 96, 180, 19, 162, 233 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 11, 14, 16, 51, 897, DateTimeKind.Utc).AddTicks(1247), new byte[] { 170, 192, 204, 105, 81, 147, 68, 210, 127, 92, 160, 253, 45, 228, 136, 217, 156, 93, 92, 38, 117, 52, 192, 250, 169, 55, 210, 245, 72, 75, 193, 214, 71, 96, 90, 164, 25, 207, 119, 71, 213, 157, 60, 48, 98, 114, 252, 95, 58, 154, 177, 27, 206, 161, 193, 133, 111, 165, 194, 37, 179, 185, 44, 7 }, new byte[] { 218, 231, 197, 94, 76, 143, 61, 13, 253, 13, 158, 116, 224, 231, 12, 72, 63, 184, 198, 242, 135, 77, 126, 50, 3, 127, 179, 99, 53, 222, 95, 160, 168, 125, 125, 156, 204, 33, 221, 124, 110, 184, 140, 87, 89, 129, 176, 86, 2, 191, 5, 175, 74, 0, 34, 225, 170, 247, 167, 211, 191, 71, 80, 98, 57, 74, 34, 157, 67, 116, 162, 85, 216, 147, 99, 92, 179, 109, 254, 163, 99, 68, 205, 61, 234, 88, 152, 69, 193, 44, 9, 254, 93, 195, 112, 30, 97, 96, 46, 90, 2, 116, 238, 246, 175, 237, 238, 115, 10, 132, 229, 27, 77, 162, 251, 38, 70, 191, 255, 164, 34, 155, 157, 96, 180, 19, 162, 233 } });

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

            migrationBuilder.CreateIndex(
                name: "IX_DoctorInterests_InterestId",
                table: "DoctorInterests",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_AppointmentId",
                table: "Prescription",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_AppointmentId",
                table: "Reports",
                column: "AppointmentId",
                unique: true);
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
                name: "Interests");

            migrationBuilder.DropColumn(
                name: "Biography",
                table: "Doctors");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6453), new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6461), new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6466), new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6470), new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentId", "CreatedDate" },
                values: new object[] { 0, new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentId", "CreatedDate" },
                values: new object[] { 0, new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6146), new byte[] { 18, 13, 68, 150, 24, 55, 94, 64, 179, 183, 105, 138, 200, 0, 96, 248, 232, 104, 82, 252, 4, 220, 157, 84, 231, 66, 65, 46, 129, 36, 85, 99, 30, 121, 87, 29, 214, 142, 152, 167, 164, 142, 158, 127, 221, 57, 233, 208, 21, 99, 15, 169, 103, 59, 244, 206, 81, 164, 170, 19, 68, 113, 36, 206 }, new byte[] { 7, 134, 243, 89, 191, 211, 55, 187, 180, 229, 82, 71, 69, 51, 255, 164, 132, 172, 237, 173, 24, 61, 64, 156, 237, 35, 155, 25, 39, 223, 12, 24, 244, 114, 142, 172, 195, 214, 231, 210, 210, 243, 121, 176, 170, 80, 83, 59, 114, 194, 140, 79, 15, 86, 23, 58, 111, 98, 217, 255, 7, 166, 52, 10, 213, 42, 141, 38, 209, 52, 93, 156, 138, 104, 246, 150, 127, 163, 158, 199, 12, 210, 243, 169, 61, 225, 253, 234, 27, 50, 200, 245, 100, 248, 2, 85, 251, 227, 131, 124, 255, 122, 153, 142, 223, 240, 87, 165, 100, 88, 125, 68, 13, 106, 81, 127, 219, 185, 108, 111, 76, 35, 102, 204, 144, 231, 253, 104 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6154), new byte[] { 18, 13, 68, 150, 24, 55, 94, 64, 179, 183, 105, 138, 200, 0, 96, 248, 232, 104, 82, 252, 4, 220, 157, 84, 231, 66, 65, 46, 129, 36, 85, 99, 30, 121, 87, 29, 214, 142, 152, 167, 164, 142, 158, 127, 221, 57, 233, 208, 21, 99, 15, 169, 103, 59, 244, 206, 81, 164, 170, 19, 68, 113, 36, 206 }, new byte[] { 7, 134, 243, 89, 191, 211, 55, 187, 180, 229, 82, 71, 69, 51, 255, 164, 132, 172, 237, 173, 24, 61, 64, 156, 237, 35, 155, 25, 39, 223, 12, 24, 244, 114, 142, 172, 195, 214, 231, 210, 210, 243, 121, 176, 170, 80, 83, 59, 114, 194, 140, 79, 15, 86, 23, 58, 111, 98, 217, 255, 7, 166, 52, 10, 213, 42, 141, 38, 209, 52, 93, 156, 138, 104, 246, 150, 127, 163, 158, 199, 12, 210, 243, 169, 61, 225, 253, 234, 27, 50, 200, 245, 100, 248, 2, 85, 251, 227, 131, 124, 255, 122, 153, 142, 223, 240, 87, 165, 100, 88, 125, 68, 13, 106, 81, 127, 219, 185, 108, 111, 76, 35, 102, 204, 144, 231, 253, 104 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6159), new byte[] { 18, 13, 68, 150, 24, 55, 94, 64, 179, 183, 105, 138, 200, 0, 96, 248, 232, 104, 82, 252, 4, 220, 157, 84, 231, 66, 65, 46, 129, 36, 85, 99, 30, 121, 87, 29, 214, 142, 152, 167, 164, 142, 158, 127, 221, 57, 233, 208, 21, 99, 15, 169, 103, 59, 244, 206, 81, 164, 170, 19, 68, 113, 36, 206 }, new byte[] { 7, 134, 243, 89, 191, 211, 55, 187, 180, 229, 82, 71, 69, 51, 255, 164, 132, 172, 237, 173, 24, 61, 64, 156, 237, 35, 155, 25, 39, 223, 12, 24, 244, 114, 142, 172, 195, 214, 231, 210, 210, 243, 121, 176, 170, 80, 83, 59, 114, 194, 140, 79, 15, 86, 23, 58, 111, 98, 217, 255, 7, 166, 52, 10, 213, 42, 141, 38, 209, 52, 93, 156, 138, 104, 246, 150, 127, 163, 158, 199, 12, 210, 243, 169, 61, 225, 253, 234, 27, 50, 200, 245, 100, 248, 2, 85, 251, 227, 131, 124, 255, 122, 153, 142, 223, 240, 87, 165, 100, 88, 125, 68, 13, 106, 81, 127, 219, 185, 108, 111, 76, 35, 102, 204, 144, 231, 253, 104 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6162), new byte[] { 18, 13, 68, 150, 24, 55, 94, 64, 179, 183, 105, 138, 200, 0, 96, 248, 232, 104, 82, 252, 4, 220, 157, 84, 231, 66, 65, 46, 129, 36, 85, 99, 30, 121, 87, 29, 214, 142, 152, 167, 164, 142, 158, 127, 221, 57, 233, 208, 21, 99, 15, 169, 103, 59, 244, 206, 81, 164, 170, 19, 68, 113, 36, 206 }, new byte[] { 7, 134, 243, 89, 191, 211, 55, 187, 180, 229, 82, 71, 69, 51, 255, 164, 132, 172, 237, 173, 24, 61, 64, 156, 237, 35, 155, 25, 39, 223, 12, 24, 244, 114, 142, 172, 195, 214, 231, 210, 210, 243, 121, 176, 170, 80, 83, 59, 114, 194, 140, 79, 15, 86, 23, 58, 111, 98, 217, 255, 7, 166, 52, 10, 213, 42, 141, 38, 209, 52, 93, 156, 138, 104, 246, 150, 127, 163, 158, 199, 12, 210, 243, 169, 61, 225, 253, 234, 27, 50, 200, 245, 100, 248, 2, 85, 251, 227, 131, 124, 255, 122, 153, 142, 223, 240, 87, 165, 100, 88, 125, 68, 13, 106, 81, 127, 219, 185, 108, 111, 76, 35, 102, 204, 144, 231, 253, 104 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6165), new byte[] { 18, 13, 68, 150, 24, 55, 94, 64, 179, 183, 105, 138, 200, 0, 96, 248, 232, 104, 82, 252, 4, 220, 157, 84, 231, 66, 65, 46, 129, 36, 85, 99, 30, 121, 87, 29, 214, 142, 152, 167, 164, 142, 158, 127, 221, 57, 233, 208, 21, 99, 15, 169, 103, 59, 244, 206, 81, 164, 170, 19, 68, 113, 36, 206 }, new byte[] { 7, 134, 243, 89, 191, 211, 55, 187, 180, 229, 82, 71, 69, 51, 255, 164, 132, 172, 237, 173, 24, 61, 64, 156, 237, 35, 155, 25, 39, 223, 12, 24, 244, 114, 142, 172, 195, 214, 231, 210, 210, 243, 121, 176, 170, 80, 83, 59, 114, 194, 140, 79, 15, 86, 23, 58, 111, 98, 217, 255, 7, 166, 52, 10, 213, 42, 141, 38, 209, 52, 93, 156, 138, 104, 246, 150, 127, 163, 158, 199, 12, 210, 243, 169, 61, 225, 253, 234, 27, 50, 200, 245, 100, 248, 2, 85, 251, 227, 131, 124, 255, 122, 153, 142, 223, 240, 87, 165, 100, 88, 125, 68, 13, 106, 81, 127, 219, 185, 108, 111, 76, 35, 102, 204, 144, 231, 253, 104 } });
        }
    }
}
