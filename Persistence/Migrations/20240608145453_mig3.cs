using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[] { 16, new DateTime(2024, 6, 8, 14, 54, 53, 650, DateTimeKind.Utc).AddTicks(9449), null, "Jonathancorwin@hotmail.com", "Jonathan", "male", false, "Corwin", new byte[] { 210, 92, 132, 160, 56, 248, 72, 112, 237, 43, 232, 54, 106, 1, 53, 54, 221, 170, 172, 89, 250, 74, 117, 96, 227, 130, 139, 239, 70, 148, 63, 138, 27, 189, 100, 73, 74, 88, 249, 44, 210, 115, 149, 38, 215, 200, 249, 41, 38, 106, 4, 246, 24, 146, 26, 26, 74, 178, 116, 160, 49, 178, 187, 250 }, new byte[] { 77, 26, 136, 74, 243, 8, 238, 108, 212, 195, 44, 231, 91, 245, 158, 52, 190, 103, 54, 88, 55, 201, 231, 103, 218, 131, 38, 150, 88, 46, 58, 2, 39, 188, 171, 211, 124, 150, 226, 81, 209, 155, 91, 203, 124, 211, 174, 144, 58, 207, 88, 186, 40, 206, 3, 167, 215, 146, 159, 13, 134, 54, 193, 112, 160, 202, 52, 135, 136, 72, 156, 197, 16, 190, 68, 106, 17, 163, 248, 32, 50, 50, 178, 108, 38, 217, 21, 215, 244, 85, 66, 218, 255, 52, 136, 50, 46, 24, 98, 136, 197, 35, 176, 88, 173, 42, 46, 101, 144, 90, 203, 221, 165, 141, 52, 47, 107, 148, 162, 238, 233, 148, 85, 193, 81, 98, 225, 200 }, "123123", null, 0 });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { 16, "Varsak", 0, "A Rh+", new DateTime(2024, 6, 8, 17, 54, 53, 650, DateTimeKind.Local).AddTicks(9596), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[] { 20, new DateTime(2024, 6, 8, 14, 49, 38, 392, DateTimeKind.Utc).AddTicks(1742), null, "john.doe@example.com", "John", "Male", false, "Doe", new byte[] { 224, 219, 242, 146, 94, 183, 72, 147, 28, 238, 23, 65, 52, 177, 1, 63, 98, 4, 111, 81, 208, 244, 219, 245, 26, 149, 227, 136, 86, 214, 139, 208, 164, 133, 116, 136, 74, 107, 101, 11, 169, 18, 209, 218, 218, 246, 232, 249, 28, 115, 182, 248, 222, 91, 229, 148, 73, 70, 193, 121, 90, 239, 252, 196 }, new byte[] { 86, 183, 254, 240, 252, 184, 37, 97, 23, 60, 64, 62, 45, 243, 225, 164, 255, 61, 145, 28, 186, 106, 24, 128, 82, 76, 10, 239, 147, 13, 137, 140, 89, 162, 68, 101, 34, 8, 131, 154, 251, 197, 130, 94, 248, 243, 250, 33, 226, 68, 124, 50, 35, 53, 174, 103, 144, 194, 46, 55, 127, 67, 8, 95, 56, 28, 118, 43, 168, 122, 74, 251, 4, 33, 91, 19, 177, 246, 197, 62, 207, 200, 205, 187, 191, 79, 48, 214, 81, 233, 161, 231, 238, 137, 137, 120, 30, 219, 216, 174, 110, 228, 88, 5, 219, 167, 176, 16, 233, 154, 80, 48, 226, 101, 57, 44, 148, 1, 66, 45, 41, 81, 43, 100, 89, 70, 88, 55 }, "1234567890", null, 0 });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { 20, "1234 Main St", 0, "A+", new DateTime(2024, 6, 8, 14, 49, 38, 392, DateTimeKind.Utc).AddTicks(1930), null, null });
        }
    }
}
