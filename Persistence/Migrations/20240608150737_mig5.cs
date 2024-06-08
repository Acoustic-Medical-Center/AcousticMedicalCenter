using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
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
                values: new object[] { 1, new DateTime(2024, 6, 8, 15, 7, 37, 379, DateTimeKind.Utc).AddTicks(4858), null, "john.doe@example.com", "John", "Male", false, "Doe", new byte[] { 44, 168, 250, 144, 76, 98, 174, 12, 70, 222, 127, 168, 248, 139, 164, 123, 83, 71, 155, 133, 103, 213, 158, 50, 175, 171, 57, 212, 189, 158, 174, 16, 15, 184, 67, 83, 206, 176, 155, 125, 236, 200, 126, 233, 153, 73, 77, 51, 187, 146, 129, 11, 39, 63, 103, 185, 228, 40, 73, 99, 21, 55, 139, 222 }, new byte[] { 48, 18, 230, 184, 115, 122, 5, 179, 207, 187, 150, 223, 66, 224, 217, 231, 3, 156, 38, 157, 69, 205, 46, 230, 102, 249, 32, 45, 101, 17, 142, 113, 77, 52, 255, 8, 23, 94, 231, 237, 123, 252, 186, 245, 16, 71, 89, 241, 107, 246, 22, 201, 43, 21, 56, 57, 183, 108, 179, 125, 216, 56, 235, 253, 238, 224, 127, 31, 107, 226, 156, 57, 9, 107, 156, 171, 67, 84, 5, 49, 108, 45, 168, 224, 1, 234, 245, 152, 204, 135, 192, 179, 3, 63, 101, 217, 202, 82, 24, 224, 254, 241, 221, 76, 14, 89, 175, 54, 46, 135, 22, 5, 228, 99, 36, 47, 238, 34, 166, 16, 179, 32, 149, 105, 200, 61, 194, 173 }, "1234567890", null, 0 });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { 1, "1234 Main St", 0, "A+", new DateTime(2024, 6, 8, 15, 7, 37, 379, DateTimeKind.Utc).AddTicks(4236), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[] { 20, new DateTime(2024, 6, 8, 14, 55, 27, 950, DateTimeKind.Utc).AddTicks(1458), null, "john.doe@example.com", "John", "Male", false, "Doe", new byte[] { 164, 139, 97, 233, 241, 90, 156, 29, 11, 25, 124, 180, 179, 4, 189, 77, 145, 84, 224, 247, 87, 5, 251, 62, 173, 109, 45, 211, 150, 235, 49, 202, 25, 36, 107, 73, 189, 247, 168, 189, 245, 248, 203, 108, 31, 253, 171, 214, 45, 231, 191, 11, 216, 178, 16, 172, 44, 190, 74, 104, 233, 212, 177, 71 }, new byte[] { 185, 172, 175, 20, 176, 80, 226, 205, 108, 29, 242, 246, 240, 67, 216, 3, 112, 143, 28, 138, 14, 180, 11, 6, 113, 163, 246, 2, 122, 115, 197, 186, 130, 227, 19, 144, 158, 185, 105, 91, 9, 40, 253, 75, 183, 96, 253, 236, 166, 64, 8, 163, 193, 10, 167, 245, 7, 184, 154, 70, 172, 138, 2, 112, 161, 252, 176, 242, 104, 146, 67, 141, 28, 153, 38, 85, 16, 150, 215, 160, 200, 177, 136, 245, 148, 121, 127, 46, 238, 235, 23, 76, 246, 216, 148, 178, 246, 187, 103, 45, 205, 73, 166, 159, 155, 133, 27, 121, 190, 90, 94, 0, 131, 38, 163, 247, 12, 100, 28, 104, 52, 7, 33, 252, 191, 166, 109, 240 }, "1234567890", null, 0 });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { 20, "1234 Main St", 0, "A+", new DateTime(2024, 6, 8, 14, 55, 27, 950, DateTimeKind.Utc).AddTicks(1597), null, null });
        }
    }
}
