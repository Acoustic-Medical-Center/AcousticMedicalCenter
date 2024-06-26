using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class doctorData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3561), new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3595), new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3600), new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3605), new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Biography", "CreatedDate", "DeletedDate", "DoctorSpecializationId", "Experience", "UpdatedDate" },
                values: new object[,]
                {
                    { 5, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3428), null, 7, 3, null },
                    { 6, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3430), null, 1, 10, null },
                    { 7, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3431), null, 4, 8, null },
                    { 8, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3432), null, 6, 6, null },
                    { 9, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3433), null, 9, 7, null },
                    { 10, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3434), null, 5, 2, null },
                    { 11, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3436), null, 10, 4, null },
                    { 12, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3437), null, 8, 9, null },
                    { 13, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3438), null, 3, 6, null },
                    { 14, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3439), null, 2, 5, null },
                    { 15, "Göz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3440), null, 7, 3, null },
                    { 16, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3441), null, 1, 10, null },
                    { 17, "Dahiliye Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3442), null, 4, 8, null },
                    { 18, "Nöroloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3443), null, 6, 6, null },
                    { 19, "Psikiyatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3445), null, 9, 7, null },
                    { 20, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3446), null, 5, 2, null },
                    { 21, "Dermatoloji Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3447), null, 10, 4, null },
                    { 22, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3448), null, 8, 9, null },
                    { 23, "Genel Cerrahi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3449), null, 3, 6, null },
                    { 24, "Kalp Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3451), null, 2, 5, null },
                    { 25, "Ortopedi Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3452), null, 1, 4, null },
                    { 26, "Pediatri Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3453), null, 5, 7, null },
                    { 27, "Kulak Burun Boğaz Doktoru Özgeçmiş Example", new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3454), null, 8, 3, null }
                });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 57, 41, 420, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3061), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3071), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3075), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3080), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3082), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3084), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3085), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3087), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3089), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3091), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3137), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3139), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3141), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3143), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3145), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3147), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3149), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3151), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3153), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3154), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3156), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3158), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3160), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3162), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3163), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3165), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3167), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 57, 41, 420, DateTimeKind.Utc).AddTicks(3189), new byte[] { 155, 201, 18, 146, 255, 67, 195, 242, 247, 159, 248, 166, 118, 201, 227, 23, 76, 235, 37, 172, 50, 143, 217, 37, 162, 7, 75, 187, 64, 59, 113, 171, 77, 247, 23, 227, 103, 154, 182, 132, 118, 140, 7, 26, 79, 164, 45, 199, 193, 123, 69, 17, 232, 165, 197, 157, 124, 232, 212, 179, 77, 247, 67, 83 }, new byte[] { 136, 115, 64, 99, 107, 19, 52, 19, 49, 208, 50, 103, 100, 95, 142, 141, 45, 222, 163, 67, 49, 120, 125, 255, 80, 156, 95, 188, 227, 98, 233, 255, 193, 110, 195, 92, 79, 90, 48, 183, 234, 253, 5, 58, 20, 51, 51, 182, 196, 144, 16, 81, 175, 236, 75, 38, 241, 230, 140, 223, 167, 87, 95, 81, 129, 129, 120, 246, 233, 220, 135, 236, 128, 187, 71, 43, 158, 154, 56, 54, 187, 227, 155, 96, 64, 70, 60, 250, 248, 242, 10, 142, 131, 216, 224, 169, 185, 66, 195, 100, 148, 73, 25, 131, 149, 200, 21, 182, 212, 52, 127, 101, 173, 154, 58, 89, 105, 204, 246, 68, 235, 93, 160, 232, 107, 168, 134, 66 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(7961), new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(7971), new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(7976), new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 52, 41, 778, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7420), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7431), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7436), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7440), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7442), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7444), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7446), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7448), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7450), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7452), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7454), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7456), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7555), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7557), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7559), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7561), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7563), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7565), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7567), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7569), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7570), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7572), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7574), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7576), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7578), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7580), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7582), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 41, 778, DateTimeKind.Utc).AddTicks(7604), new byte[] { 176, 123, 144, 99, 96, 232, 186, 120, 49, 147, 82, 51, 70, 227, 167, 199, 186, 190, 222, 148, 60, 243, 79, 196, 25, 157, 133, 6, 74, 57, 147, 189, 49, 21, 158, 135, 242, 125, 37, 169, 242, 187, 32, 36, 121, 126, 72, 155, 201, 64, 39, 106, 11, 100, 97, 147, 65, 245, 142, 245, 215, 156, 208, 55 }, new byte[] { 170, 233, 97, 66, 35, 173, 217, 139, 74, 241, 132, 181, 36, 193, 63, 164, 156, 161, 216, 232, 201, 180, 134, 55, 161, 127, 123, 29, 192, 15, 185, 11, 168, 208, 47, 28, 62, 40, 197, 131, 254, 208, 49, 101, 39, 70, 140, 159, 135, 118, 123, 181, 191, 191, 228, 106, 46, 243, 23, 220, 7, 99, 21, 236, 153, 109, 192, 100, 117, 17, 12, 161, 38, 200, 37, 66, 75, 240, 207, 184, 204, 113, 187, 190, 139, 65, 184, 10, 240, 142, 88, 0, 222, 31, 24, 56, 251, 208, 131, 39, 186, 55, 251, 222, 199, 172, 25, 69, 26, 33, 201, 239, 141, 5, 55, 61, 190, 93, 0, 210, 180, 79, 204, 49, 213, 82, 77, 37 } });
        }
    }
}
