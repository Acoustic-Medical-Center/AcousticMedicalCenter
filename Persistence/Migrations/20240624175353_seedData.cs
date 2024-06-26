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
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "DoctorSpecializations",
                newName: "NameTR");

            migrationBuilder.AddColumn<string>(
                name: "NameEN",
                table: "DoctorSpecializations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3705), new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3715), new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3721), new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3725), new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "NameEN", "NameTR" },
                values: new object[] { new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2594), "Neurosurgery", "Beyin ve Sinir Cerrahisi" });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "NameEN", "NameTR" },
                values: new object[] { new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2606), "Dermatology", "Dermatoloji" });

            migrationBuilder.InsertData(
                table: "DoctorSpecializations",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "NameEN", "NameTR", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2607), null, "General Surgery", "Genel Cerrahi", null },
                    { 4, new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2608), null, "Ophthalmology", "Göz Hastalıkları", null },
                    { 5, new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2609), null, "Internal Medicine", "İç Hastalıkları", null },
                    { 6, new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2611), null, "Obstetrics and Gynecology", "Kadın Hastalıkları ve Doğum", null },
                    { 7, new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2612), null, "Otorhinolaryngology", "Kulak Burun Boğaz", null },
                    { 8, new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2613), null, "Orthopedics and Traumatology", "Ortopedi ve Travmatoloji", null },
                    { 9, new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2614), null, "Urology", "Üroloji", null },
                    { 10, new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2615), null, "Pediatrics", "Çocuk Sağlığı ve Hastalıkları", null }
                });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 17, 53, 52, 658, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 17, 53, 52, 658, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 17, 53, 52, 658, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 17, 53, 52, 658, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 53, 52, 658, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 53, 52, 658, DateTimeKind.Utc).AddTicks(3289), new byte[] { 50, 98, 238, 109, 154, 97, 123, 128, 149, 99, 167, 9, 119, 145, 11, 58, 202, 209, 0, 218, 42, 34, 43, 86, 61, 138, 163, 164, 163, 193, 138, 225, 218, 148, 208, 130, 154, 10, 45, 75, 228, 121, 136, 185, 4, 29, 152, 52, 63, 105, 184, 30, 186, 253, 57, 159, 21, 103, 107, 50, 179, 83, 182, 64 }, new byte[] { 230, 193, 237, 20, 154, 21, 91, 193, 221, 228, 36, 178, 77, 146, 66, 147, 136, 67, 47, 191, 190, 127, 78, 12, 200, 199, 138, 48, 87, 74, 78, 255, 8, 151, 38, 137, 106, 178, 190, 187, 0, 64, 78, 207, 141, 237, 241, 125, 248, 221, 118, 43, 79, 226, 167, 69, 169, 21, 50, 27, 79, 18, 0, 90, 49, 112, 150, 66, 76, 221, 99, 166, 122, 236, 89, 197, 129, 214, 81, 52, 246, 157, 249, 15, 203, 206, 24, 206, 43, 114, 229, 13, 184, 88, 96, 169, 171, 209, 18, 94, 151, 109, 191, 51, 199, 190, 109, 50, 236, 52, 19, 244, 119, 27, 102, 0, 132, 246, 102, 15, 87, 164, 19, 123, 233, 220, 131, 161 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 53, 52, 658, DateTimeKind.Utc).AddTicks(3299), new byte[] { 50, 98, 238, 109, 154, 97, 123, 128, 149, 99, 167, 9, 119, 145, 11, 58, 202, 209, 0, 218, 42, 34, 43, 86, 61, 138, 163, 164, 163, 193, 138, 225, 218, 148, 208, 130, 154, 10, 45, 75, 228, 121, 136, 185, 4, 29, 152, 52, 63, 105, 184, 30, 186, 253, 57, 159, 21, 103, 107, 50, 179, 83, 182, 64 }, new byte[] { 230, 193, 237, 20, 154, 21, 91, 193, 221, 228, 36, 178, 77, 146, 66, 147, 136, 67, 47, 191, 190, 127, 78, 12, 200, 199, 138, 48, 87, 74, 78, 255, 8, 151, 38, 137, 106, 178, 190, 187, 0, 64, 78, 207, 141, 237, 241, 125, 248, 221, 118, 43, 79, 226, 167, 69, 169, 21, 50, 27, 79, 18, 0, 90, 49, 112, 150, 66, 76, 221, 99, 166, 122, 236, 89, 197, 129, 214, 81, 52, 246, 157, 249, 15, 203, 206, 24, 206, 43, 114, 229, 13, 184, 88, 96, 169, 171, 209, 18, 94, 151, 109, 191, 51, 199, 190, 109, 50, 236, 52, 19, 244, 119, 27, 102, 0, 132, 246, 102, 15, 87, 164, 19, 123, 233, 220, 131, 161 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 53, 52, 658, DateTimeKind.Utc).AddTicks(3305), new byte[] { 50, 98, 238, 109, 154, 97, 123, 128, 149, 99, 167, 9, 119, 145, 11, 58, 202, 209, 0, 218, 42, 34, 43, 86, 61, 138, 163, 164, 163, 193, 138, 225, 218, 148, 208, 130, 154, 10, 45, 75, 228, 121, 136, 185, 4, 29, 152, 52, 63, 105, 184, 30, 186, 253, 57, 159, 21, 103, 107, 50, 179, 83, 182, 64 }, new byte[] { 230, 193, 237, 20, 154, 21, 91, 193, 221, 228, 36, 178, 77, 146, 66, 147, 136, 67, 47, 191, 190, 127, 78, 12, 200, 199, 138, 48, 87, 74, 78, 255, 8, 151, 38, 137, 106, 178, 190, 187, 0, 64, 78, 207, 141, 237, 241, 125, 248, 221, 118, 43, 79, 226, 167, 69, 169, 21, 50, 27, 79, 18, 0, 90, 49, 112, 150, 66, 76, 221, 99, 166, 122, 236, 89, 197, 129, 214, 81, 52, 246, 157, 249, 15, 203, 206, 24, 206, 43, 114, 229, 13, 184, 88, 96, 169, 171, 209, 18, 94, 151, 109, 191, 51, 199, 190, 109, 50, 236, 52, 19, 244, 119, 27, 102, 0, 132, 246, 102, 15, 87, 164, 19, 123, 233, 220, 131, 161 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 53, 52, 658, DateTimeKind.Utc).AddTicks(3310), new byte[] { 50, 98, 238, 109, 154, 97, 123, 128, 149, 99, 167, 9, 119, 145, 11, 58, 202, 209, 0, 218, 42, 34, 43, 86, 61, 138, 163, 164, 163, 193, 138, 225, 218, 148, 208, 130, 154, 10, 45, 75, 228, 121, 136, 185, 4, 29, 152, 52, 63, 105, 184, 30, 186, 253, 57, 159, 21, 103, 107, 50, 179, 83, 182, 64 }, new byte[] { 230, 193, 237, 20, 154, 21, 91, 193, 221, 228, 36, 178, 77, 146, 66, 147, 136, 67, 47, 191, 190, 127, 78, 12, 200, 199, 138, 48, 87, 74, 78, 255, 8, 151, 38, 137, 106, 178, 190, 187, 0, 64, 78, 207, 141, 237, 241, 125, 248, 221, 118, 43, 79, 226, 167, 69, 169, 21, 50, 27, 79, 18, 0, 90, 49, 112, 150, 66, 76, 221, 99, 166, 122, 236, 89, 197, 129, 214, 81, 52, 246, 157, 249, 15, 203, 206, 24, 206, 43, 114, 229, 13, 184, 88, 96, 169, 171, 209, 18, 94, 151, 109, 191, 51, 199, 190, 109, 50, 236, 52, 19, 244, 119, 27, 102, 0, 132, 246, 102, 15, 87, 164, 19, 123, 233, 220, 131, 161 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 53, 52, 658, DateTimeKind.Utc).AddTicks(3315), new byte[] { 50, 98, 238, 109, 154, 97, 123, 128, 149, 99, 167, 9, 119, 145, 11, 58, 202, 209, 0, 218, 42, 34, 43, 86, 61, 138, 163, 164, 163, 193, 138, 225, 218, 148, 208, 130, 154, 10, 45, 75, 228, 121, 136, 185, 4, 29, 152, 52, 63, 105, 184, 30, 186, 253, 57, 159, 21, 103, 107, 50, 179, 83, 182, 64 }, new byte[] { 230, 193, 237, 20, 154, 21, 91, 193, 221, 228, 36, 178, 77, 146, 66, 147, 136, 67, 47, 191, 190, 127, 78, 12, 200, 199, 138, 48, 87, 74, 78, 255, 8, 151, 38, 137, 106, 178, 190, 187, 0, 64, 78, 207, 141, 237, 241, 125, 248, 221, 118, 43, 79, 226, 167, 69, 169, 21, 50, 27, 79, 18, 0, 90, 49, 112, 150, 66, 76, 221, 99, 166, 122, 236, 89, 197, 129, 214, 81, 52, 246, 157, 249, 15, 203, 206, 24, 206, 43, 114, 229, 13, 184, 88, 96, 169, 171, 209, 18, 94, 151, 109, 191, 51, 199, 190, 109, 50, 236, 52, 19, 244, 119, 27, 102, 0, 132, 246, 102, 15, 87, 164, 19, 123, 233, 220, 131, 161 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "NameEN",
                table: "DoctorSpecializations");

            migrationBuilder.RenameColumn(
                name: "NameTR",
                table: "DoctorSpecializations",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6487), new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6497), new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6502), new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6508), new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5006), "Cerrah" });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5046), "Kalp" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6008), new byte[] { 168, 242, 121, 130, 51, 108, 14, 70, 74, 240, 60, 154, 10, 240, 188, 159, 151, 242, 66, 101, 236, 128, 115, 125, 84, 215, 238, 5, 111, 199, 226, 241, 209, 215, 248, 168, 5, 49, 156, 239, 243, 162, 80, 174, 90, 10, 188, 63, 147, 177, 122, 244, 251, 48, 121, 53, 145, 200, 141, 46, 67, 137, 90, 86 }, new byte[] { 219, 243, 72, 62, 146, 57, 58, 61, 193, 65, 254, 50, 137, 141, 229, 58, 75, 226, 220, 200, 39, 118, 11, 156, 200, 249, 51, 187, 75, 161, 126, 124, 202, 166, 53, 123, 114, 145, 253, 166, 34, 156, 71, 42, 10, 153, 174, 7, 60, 136, 30, 39, 228, 238, 253, 226, 202, 4, 251, 63, 239, 152, 141, 161, 19, 255, 233, 145, 249, 224, 13, 43, 26, 95, 229, 108, 168, 30, 47, 154, 87, 190, 60, 159, 22, 42, 196, 65, 216, 124, 220, 174, 144, 14, 109, 85, 207, 149, 94, 112, 128, 226, 108, 166, 236, 56, 26, 202, 153, 66, 67, 250, 103, 47, 109, 22, 20, 33, 63, 241, 87, 167, 247, 79, 37, 156, 185, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6026), new byte[] { 168, 242, 121, 130, 51, 108, 14, 70, 74, 240, 60, 154, 10, 240, 188, 159, 151, 242, 66, 101, 236, 128, 115, 125, 84, 215, 238, 5, 111, 199, 226, 241, 209, 215, 248, 168, 5, 49, 156, 239, 243, 162, 80, 174, 90, 10, 188, 63, 147, 177, 122, 244, 251, 48, 121, 53, 145, 200, 141, 46, 67, 137, 90, 86 }, new byte[] { 219, 243, 72, 62, 146, 57, 58, 61, 193, 65, 254, 50, 137, 141, 229, 58, 75, 226, 220, 200, 39, 118, 11, 156, 200, 249, 51, 187, 75, 161, 126, 124, 202, 166, 53, 123, 114, 145, 253, 166, 34, 156, 71, 42, 10, 153, 174, 7, 60, 136, 30, 39, 228, 238, 253, 226, 202, 4, 251, 63, 239, 152, 141, 161, 19, 255, 233, 145, 249, 224, 13, 43, 26, 95, 229, 108, 168, 30, 47, 154, 87, 190, 60, 159, 22, 42, 196, 65, 216, 124, 220, 174, 144, 14, 109, 85, 207, 149, 94, 112, 128, 226, 108, 166, 236, 56, 26, 202, 153, 66, 67, 250, 103, 47, 109, 22, 20, 33, 63, 241, 87, 167, 247, 79, 37, 156, 185, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6031), new byte[] { 168, 242, 121, 130, 51, 108, 14, 70, 74, 240, 60, 154, 10, 240, 188, 159, 151, 242, 66, 101, 236, 128, 115, 125, 84, 215, 238, 5, 111, 199, 226, 241, 209, 215, 248, 168, 5, 49, 156, 239, 243, 162, 80, 174, 90, 10, 188, 63, 147, 177, 122, 244, 251, 48, 121, 53, 145, 200, 141, 46, 67, 137, 90, 86 }, new byte[] { 219, 243, 72, 62, 146, 57, 58, 61, 193, 65, 254, 50, 137, 141, 229, 58, 75, 226, 220, 200, 39, 118, 11, 156, 200, 249, 51, 187, 75, 161, 126, 124, 202, 166, 53, 123, 114, 145, 253, 166, 34, 156, 71, 42, 10, 153, 174, 7, 60, 136, 30, 39, 228, 238, 253, 226, 202, 4, 251, 63, 239, 152, 141, 161, 19, 255, 233, 145, 249, 224, 13, 43, 26, 95, 229, 108, 168, 30, 47, 154, 87, 190, 60, 159, 22, 42, 196, 65, 216, 124, 220, 174, 144, 14, 109, 85, 207, 149, 94, 112, 128, 226, 108, 166, 236, 56, 26, 202, 153, 66, 67, 250, 103, 47, 109, 22, 20, 33, 63, 241, 87, 167, 247, 79, 37, 156, 185, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6036), new byte[] { 168, 242, 121, 130, 51, 108, 14, 70, 74, 240, 60, 154, 10, 240, 188, 159, 151, 242, 66, 101, 236, 128, 115, 125, 84, 215, 238, 5, 111, 199, 226, 241, 209, 215, 248, 168, 5, 49, 156, 239, 243, 162, 80, 174, 90, 10, 188, 63, 147, 177, 122, 244, 251, 48, 121, 53, 145, 200, 141, 46, 67, 137, 90, 86 }, new byte[] { 219, 243, 72, 62, 146, 57, 58, 61, 193, 65, 254, 50, 137, 141, 229, 58, 75, 226, 220, 200, 39, 118, 11, 156, 200, 249, 51, 187, 75, 161, 126, 124, 202, 166, 53, 123, 114, 145, 253, 166, 34, 156, 71, 42, 10, 153, 174, 7, 60, 136, 30, 39, 228, 238, 253, 226, 202, 4, 251, 63, 239, 152, 141, 161, 19, 255, 233, 145, 249, 224, 13, 43, 26, 95, 229, 108, 168, 30, 47, 154, 87, 190, 60, 159, 22, 42, 196, 65, 216, 124, 220, 174, 144, 14, 109, 85, 207, 149, 94, 112, 128, 226, 108, 166, 236, 56, 26, 202, 153, 66, 67, 250, 103, 47, 109, 22, 20, 33, 63, 241, 87, 167, 247, 79, 37, 156, 185, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6040), new byte[] { 168, 242, 121, 130, 51, 108, 14, 70, 74, 240, 60, 154, 10, 240, 188, 159, 151, 242, 66, 101, 236, 128, 115, 125, 84, 215, 238, 5, 111, 199, 226, 241, 209, 215, 248, 168, 5, 49, 156, 239, 243, 162, 80, 174, 90, 10, 188, 63, 147, 177, 122, 244, 251, 48, 121, 53, 145, 200, 141, 46, 67, 137, 90, 86 }, new byte[] { 219, 243, 72, 62, 146, 57, 58, 61, 193, 65, 254, 50, 137, 141, 229, 58, 75, 226, 220, 200, 39, 118, 11, 156, 200, 249, 51, 187, 75, 161, 126, 124, 202, 166, 53, 123, 114, 145, 253, 166, 34, 156, 71, 42, 10, 153, 174, 7, 60, 136, 30, 39, 228, 238, 253, 226, 202, 4, 251, 63, 239, 152, 141, 161, 19, 255, 233, 145, 249, 224, 13, 43, 26, 95, 229, 108, 168, 30, 47, 154, 87, 190, 60, 159, 22, 42, 196, 65, 216, 124, 220, 174, 144, 14, 109, 85, 207, 149, 94, 112, 128, 226, 108, 166, 236, 56, 26, 202, 153, 66, 67, 250, 103, 47, 109, 22, 20, 33, 63, 241, 87, 167, 247, 79, 37, 156, 185, 93 } });
        }
    }
}
