using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { 20, new DateTime(2024, 6, 8, 14, 55, 27, 950, DateTimeKind.Utc).AddTicks(1458), null, "john.doe@example.com", "John", "Male", false, "Doe", new byte[] { 164, 139, 97, 233, 241, 90, 156, 29, 11, 25, 124, 180, 179, 4, 189, 77, 145, 84, 224, 247, 87, 5, 251, 62, 173, 109, 45, 211, 150, 235, 49, 202, 25, 36, 107, 73, 189, 247, 168, 189, 245, 248, 203, 108, 31, 253, 171, 214, 45, 231, 191, 11, 216, 178, 16, 172, 44, 190, 74, 104, 233, 212, 177, 71 }, new byte[] { 185, 172, 175, 20, 176, 80, 226, 205, 108, 29, 242, 246, 240, 67, 216, 3, 112, 143, 28, 138, 14, 180, 11, 6, 113, 163, 246, 2, 122, 115, 197, 186, 130, 227, 19, 144, 158, 185, 105, 91, 9, 40, 253, 75, 183, 96, 253, 236, 166, 64, 8, 163, 193, 10, 167, 245, 7, 184, 154, 70, 172, 138, 2, 112, 161, 252, 176, 242, 104, 146, 67, 141, 28, 153, 38, 85, 16, 150, 215, 160, 200, 177, 136, 245, 148, 121, 127, 46, 238, 235, 23, 76, 246, 216, 148, 178, 246, 187, 103, 45, 205, 73, 166, 159, 155, 133, 27, 121, 190, 90, 94, 0, 131, 38, 163, 247, 12, 100, 28, 104, 52, 7, 33, 252, 191, 166, 109, 240 }, "1234567890", null, 0 });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { 20, "1234 Main St", 0, "A+", new DateTime(2024, 6, 8, 14, 55, 27, 950, DateTimeKind.Utc).AddTicks(1597), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
