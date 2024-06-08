using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DoctorSpecializations",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cerrah", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kalp", null }
                });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 17, 17, 523, DateTimeKind.Utc).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Email", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 17, 17, 523, DateTimeKind.Utc).AddTicks(1820), "hasta1@example.com", new byte[] { 205, 98, 218, 9, 36, 81, 26, 61, 35, 213, 83, 250, 155, 142, 109, 27, 140, 220, 86, 83, 141, 240, 102, 40, 154, 128, 78, 226, 214, 241, 129, 108, 241, 70, 202, 204, 254, 102, 184, 44, 180, 229, 28, 136, 1, 230, 93, 235, 170, 128, 61, 187, 6, 171, 100, 251, 219, 19, 131, 86, 237, 44, 247, 219 }, new byte[] { 144, 223, 213, 59, 202, 103, 114, 41, 10, 236, 249, 72, 225, 14, 154, 75, 12, 16, 220, 33, 197, 87, 84, 85, 54, 166, 28, 0, 41, 144, 155, 58, 76, 137, 128, 86, 197, 247, 42, 165, 52, 61, 140, 137, 102, 66, 33, 32, 11, 20, 191, 34, 22, 155, 219, 195, 197, 197, 74, 130, 179, 237, 131, 219, 218, 0, 188, 145, 181, 60, 160, 173, 46, 1, 76, 109, 226, 66, 178, 34, 117, 17, 239, 245, 197, 176, 201, 13, 155, 60, 194, 172, 148, 12, 254, 50, 239, 9, 59, 242, 12, 102, 15, 38, 245, 24, 44, 221, 108, 171, 195, 159, 176, 229, 130, 74, 8, 86, 128, 174, 142, 210, 152, 239, 60, 112, 237, 192 } });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 6, 8, 15, 17, 17, 523, DateTimeKind.Utc).AddTicks(1838), null, "hasta2@example.com", "Jonathan", "Male", false, "Corwin", new byte[] { 205, 98, 218, 9, 36, 81, 26, 61, 35, 213, 83, 250, 155, 142, 109, 27, 140, 220, 86, 83, 141, 240, 102, 40, 154, 128, 78, 226, 214, 241, 129, 108, 241, 70, 202, 204, 254, 102, 184, 44, 180, 229, 28, 136, 1, 230, 93, 235, 170, 128, 61, 187, 6, 171, 100, 251, 219, 19, 131, 86, 237, 44, 247, 219 }, new byte[] { 144, 223, 213, 59, 202, 103, 114, 41, 10, 236, 249, 72, 225, 14, 154, 75, 12, 16, 220, 33, 197, 87, 84, 85, 54, 166, 28, 0, 41, 144, 155, 58, 76, 137, 128, 86, 197, 247, 42, 165, 52, 61, 140, 137, 102, 66, 33, 32, 11, 20, 191, 34, 22, 155, 219, 195, 197, 197, 74, 130, 179, 237, 131, 219, 218, 0, 188, 145, 181, 60, 160, 173, 46, 1, 76, 109, 226, 66, 178, 34, 117, 17, 239, 245, 197, 176, 201, 13, 155, 60, 194, 172, 148, 12, 254, 50, 239, 9, 59, 242, 12, 102, 15, 38, 245, 24, 44, 221, 108, 171, 195, 159, 176, 229, 130, 74, 8, 86, 128, 174, 142, 210, 152, 239, 60, 112, 237, 192 }, "1234512345", null, 0 },
                    { 3, new DateTime(2024, 6, 8, 15, 17, 17, 523, DateTimeKind.Utc).AddTicks(1842), null, "doktor1@example.com", "batu", "Male", false, "cerrahlar", new byte[] { 205, 98, 218, 9, 36, 81, 26, 61, 35, 213, 83, 250, 155, 142, 109, 27, 140, 220, 86, 83, 141, 240, 102, 40, 154, 128, 78, 226, 214, 241, 129, 108, 241, 70, 202, 204, 254, 102, 184, 44, 180, 229, 28, 136, 1, 230, 93, 235, 170, 128, 61, 187, 6, 171, 100, 251, 219, 19, 131, 86, 237, 44, 247, 219 }, new byte[] { 144, 223, 213, 59, 202, 103, 114, 41, 10, 236, 249, 72, 225, 14, 154, 75, 12, 16, 220, 33, 197, 87, 84, 85, 54, 166, 28, 0, 41, 144, 155, 58, 76, 137, 128, 86, 197, 247, 42, 165, 52, 61, 140, 137, 102, 66, 33, 32, 11, 20, 191, 34, 22, 155, 219, 195, 197, 197, 74, 130, 179, 237, 131, 219, 218, 0, 188, 145, 181, 60, 160, 173, 46, 1, 76, 109, 226, 66, 178, 34, 117, 17, 239, 245, 197, 176, 201, 13, 155, 60, 194, 172, 148, 12, 254, 50, 239, 9, 59, 242, 12, 102, 15, 38, 245, 24, 44, 221, 108, 171, 195, 159, 176, 229, 130, 74, 8, 86, 128, 174, 142, 210, 152, 239, 60, 112, 237, 192 }, "1234512312", null, 1 },
                    { 4, new DateTime(2024, 6, 8, 15, 17, 17, 523, DateTimeKind.Utc).AddTicks(1846), null, "doktor2@example.com", "kalp", "Male", false, "doktoru", new byte[] { 205, 98, 218, 9, 36, 81, 26, 61, 35, 213, 83, 250, 155, 142, 109, 27, 140, 220, 86, 83, 141, 240, 102, 40, 154, 128, 78, 226, 214, 241, 129, 108, 241, 70, 202, 204, 254, 102, 184, 44, 180, 229, 28, 136, 1, 230, 93, 235, 170, 128, 61, 187, 6, 171, 100, 251, 219, 19, 131, 86, 237, 44, 247, 219 }, new byte[] { 144, 223, 213, 59, 202, 103, 114, 41, 10, 236, 249, 72, 225, 14, 154, 75, 12, 16, 220, 33, 197, 87, 84, 85, 54, 166, 28, 0, 41, 144, 155, 58, 76, 137, 128, 86, 197, 247, 42, 165, 52, 61, 140, 137, 102, 66, 33, 32, 11, 20, 191, 34, 22, 155, 219, 195, 197, 197, 74, 130, 179, 237, 131, 219, 218, 0, 188, 145, 181, 60, 160, 173, 46, 1, 76, 109, 226, 66, 178, 34, 117, 17, 239, 245, 197, 176, 201, 13, 155, 60, 194, 172, 148, 12, 254, 50, 239, 9, 59, 242, 12, 102, 15, 38, 245, 24, 44, 221, 108, 171, 195, 159, 176, 229, 130, 74, 8, 86, 128, 174, 142, 210, 152, 239, 60, 112, 237, 192 }, "1234512313", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "AppointmentId", "CreatedDate", "DeletedDate", "DoctorSpecializationId", "Experience", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, 0, new DateTime(2024, 6, 8, 15, 17, 17, 523, DateTimeKind.Utc).AddTicks(2085), null, 1, 10, null },
                    { 4, 0, new DateTime(2024, 6, 8, 15, 17, 17, 523, DateTimeKind.Utc).AddTicks(2093), null, 2, 5, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 7, 37, 379, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Email", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 7, 37, 379, DateTimeKind.Utc).AddTicks(4858), "john.doe@example.com", new byte[] { 44, 168, 250, 144, 76, 98, 174, 12, 70, 222, 127, 168, 248, 139, 164, 123, 83, 71, 155, 133, 103, 213, 158, 50, 175, 171, 57, 212, 189, 158, 174, 16, 15, 184, 67, 83, 206, 176, 155, 125, 236, 200, 126, 233, 153, 73, 77, 51, 187, 146, 129, 11, 39, 63, 103, 185, 228, 40, 73, 99, 21, 55, 139, 222 }, new byte[] { 48, 18, 230, 184, 115, 122, 5, 179, 207, 187, 150, 223, 66, 224, 217, 231, 3, 156, 38, 157, 69, 205, 46, 230, 102, 249, 32, 45, 101, 17, 142, 113, 77, 52, 255, 8, 23, 94, 231, 237, 123, 252, 186, 245, 16, 71, 89, 241, 107, 246, 22, 201, 43, 21, 56, 57, 183, 108, 179, 125, 216, 56, 235, 253, 238, 224, 127, 31, 107, 226, 156, 57, 9, 107, 156, 171, 67, 84, 5, 49, 108, 45, 168, 224, 1, 234, 245, 152, 204, 135, 192, 179, 3, 63, 101, 217, 202, 82, 24, 224, 254, 241, 221, 76, 14, 89, 175, 54, 46, 135, 22, 5, 228, 99, 36, 47, 238, 34, 166, 16, 179, 32, 149, 105, 200, 61, 194, 173 } });
        }
    }
}
