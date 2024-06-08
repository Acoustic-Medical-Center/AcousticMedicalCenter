using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 25, 20, 186, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 25, 20, 186, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 25, 20, 186, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 25, 20, 186, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 25, 20, 186, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 25, 20, 186, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 25, 20, 186, DateTimeKind.Utc).AddTicks(2799), new byte[] { 240, 228, 203, 30, 229, 185, 173, 129, 124, 105, 159, 195, 29, 111, 226, 66, 162, 83, 72, 244, 193, 189, 255, 211, 57, 129, 213, 6, 201, 175, 199, 232, 198, 195, 198, 32, 10, 81, 209, 255, 229, 77, 95, 148, 96, 0, 38, 151, 146, 208, 141, 243, 187, 25, 139, 99, 199, 75, 76, 82, 175, 212, 52, 39 }, new byte[] { 206, 112, 99, 80, 140, 182, 98, 200, 241, 193, 168, 158, 189, 84, 198, 225, 116, 117, 210, 199, 59, 210, 0, 251, 145, 236, 239, 249, 163, 30, 95, 188, 246, 240, 17, 250, 251, 4, 99, 210, 187, 169, 232, 171, 127, 81, 26, 45, 137, 75, 215, 240, 148, 100, 196, 244, 116, 94, 180, 194, 100, 170, 69, 219, 135, 92, 168, 80, 174, 169, 138, 59, 17, 208, 197, 213, 153, 171, 191, 162, 231, 215, 177, 233, 70, 64, 117, 175, 13, 120, 36, 18, 105, 241, 12, 14, 72, 79, 150, 108, 178, 55, 210, 172, 141, 119, 60, 46, 98, 134, 140, 217, 7, 241, 149, 225, 9, 236, 176, 241, 90, 113, 39, 35, 203, 69, 103, 0 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 25, 20, 186, DateTimeKind.Utc).AddTicks(2811), new byte[] { 240, 228, 203, 30, 229, 185, 173, 129, 124, 105, 159, 195, 29, 111, 226, 66, 162, 83, 72, 244, 193, 189, 255, 211, 57, 129, 213, 6, 201, 175, 199, 232, 198, 195, 198, 32, 10, 81, 209, 255, 229, 77, 95, 148, 96, 0, 38, 151, 146, 208, 141, 243, 187, 25, 139, 99, 199, 75, 76, 82, 175, 212, 52, 39 }, new byte[] { 206, 112, 99, 80, 140, 182, 98, 200, 241, 193, 168, 158, 189, 84, 198, 225, 116, 117, 210, 199, 59, 210, 0, 251, 145, 236, 239, 249, 163, 30, 95, 188, 246, 240, 17, 250, 251, 4, 99, 210, 187, 169, 232, 171, 127, 81, 26, 45, 137, 75, 215, 240, 148, 100, 196, 244, 116, 94, 180, 194, 100, 170, 69, 219, 135, 92, 168, 80, 174, 169, 138, 59, 17, 208, 197, 213, 153, 171, 191, 162, 231, 215, 177, 233, 70, 64, 117, 175, 13, 120, 36, 18, 105, 241, 12, 14, 72, 79, 150, 108, 178, 55, 210, 172, 141, 119, 60, 46, 98, 134, 140, 217, 7, 241, 149, 225, 9, 236, 176, 241, 90, 113, 39, 35, 203, 69, 103, 0 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 25, 20, 186, DateTimeKind.Utc).AddTicks(2816), new byte[] { 240, 228, 203, 30, 229, 185, 173, 129, 124, 105, 159, 195, 29, 111, 226, 66, 162, 83, 72, 244, 193, 189, 255, 211, 57, 129, 213, 6, 201, 175, 199, 232, 198, 195, 198, 32, 10, 81, 209, 255, 229, 77, 95, 148, 96, 0, 38, 151, 146, 208, 141, 243, 187, 25, 139, 99, 199, 75, 76, 82, 175, 212, 52, 39 }, new byte[] { 206, 112, 99, 80, 140, 182, 98, 200, 241, 193, 168, 158, 189, 84, 198, 225, 116, 117, 210, 199, 59, 210, 0, 251, 145, 236, 239, 249, 163, 30, 95, 188, 246, 240, 17, 250, 251, 4, 99, 210, 187, 169, 232, 171, 127, 81, 26, 45, 137, 75, 215, 240, 148, 100, 196, 244, 116, 94, 180, 194, 100, 170, 69, 219, 135, 92, 168, 80, 174, 169, 138, 59, 17, 208, 197, 213, 153, 171, 191, 162, 231, 215, 177, 233, 70, 64, 117, 175, 13, 120, 36, 18, 105, 241, 12, 14, 72, 79, 150, 108, 178, 55, 210, 172, 141, 119, 60, 46, 98, 134, 140, 217, 7, 241, 149, 225, 9, 236, 176, 241, 90, 113, 39, 35, 203, 69, 103, 0 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 25, 20, 186, DateTimeKind.Utc).AddTicks(2820), new byte[] { 240, 228, 203, 30, 229, 185, 173, 129, 124, 105, 159, 195, 29, 111, 226, 66, 162, 83, 72, 244, 193, 189, 255, 211, 57, 129, 213, 6, 201, 175, 199, 232, 198, 195, 198, 32, 10, 81, 209, 255, 229, 77, 95, 148, 96, 0, 38, 151, 146, 208, 141, 243, 187, 25, 139, 99, 199, 75, 76, 82, 175, 212, 52, 39 }, new byte[] { 206, 112, 99, 80, 140, 182, 98, 200, 241, 193, 168, 158, 189, 84, 198, 225, 116, 117, 210, 199, 59, 210, 0, 251, 145, 236, 239, 249, 163, 30, 95, 188, 246, 240, 17, 250, 251, 4, 99, 210, 187, 169, 232, 171, 127, 81, 26, 45, 137, 75, 215, 240, 148, 100, 196, 244, 116, 94, 180, 194, 100, 170, 69, 219, 135, 92, 168, 80, 174, 169, 138, 59, 17, 208, 197, 213, 153, 171, 191, 162, 231, 215, 177, 233, 70, 64, 117, 175, 13, 120, 36, 18, 105, 241, 12, 14, 72, 79, 150, 108, 178, 55, 210, 172, 141, 119, 60, 46, 98, 134, 140, 217, 7, 241, 149, 225, 9, 236, 176, 241, 90, 113, 39, 35, 203, 69, 103, 0 } });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[] { 5, new DateTime(2024, 6, 8, 15, 25, 20, 186, DateTimeKind.Utc).AddTicks(2823), null, "admin@example.com", "Admin", "Male", false, "Yöneticioğlu", new byte[] { 240, 228, 203, 30, 229, 185, 173, 129, 124, 105, 159, 195, 29, 111, 226, 66, 162, 83, 72, 244, 193, 189, 255, 211, 57, 129, 213, 6, 201, 175, 199, 232, 198, 195, 198, 32, 10, 81, 209, 255, 229, 77, 95, 148, 96, 0, 38, 151, 146, 208, 141, 243, 187, 25, 139, 99, 199, 75, 76, 82, 175, 212, 52, 39 }, new byte[] { 206, 112, 99, 80, 140, 182, 98, 200, 241, 193, 168, 158, 189, 84, 198, 225, 116, 117, 210, 199, 59, 210, 0, 251, 145, 236, 239, 249, 163, 30, 95, 188, 246, 240, 17, 250, 251, 4, 99, 210, 187, 169, 232, 171, 127, 81, 26, 45, 137, 75, 215, 240, 148, 100, 196, 244, 116, 94, 180, 194, 100, 170, 69, 219, 135, 92, 168, 80, 174, 169, 138, 59, 17, 208, 197, 213, 153, 171, 191, 162, 231, 215, 177, 233, 70, 64, 117, 175, 13, 120, 36, 18, 105, 241, 12, 14, 72, 79, 150, 108, 178, 55, 210, 172, 141, 119, 60, 46, 98, 134, 140, 217, 7, 241, 149, 225, 9, 236, 176, 241, 90, 113, 39, 35, 203, 69, 103, 0 }, "1234512345", null, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 18, 16, 381, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 18, 16, 381, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 18, 16, 381, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 18, 16, 381, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 18, 16, 381, DateTimeKind.Utc).AddTicks(5850), new byte[] { 107, 71, 223, 185, 129, 101, 121, 208, 146, 58, 21, 146, 19, 147, 181, 137, 102, 204, 132, 14, 74, 180, 4, 253, 160, 247, 200, 38, 11, 157, 240, 49, 142, 107, 63, 71, 170, 134, 229, 254, 90, 51, 175, 166, 58, 200, 242, 244, 59, 77, 37, 143, 27, 33, 66, 45, 14, 228, 86, 224, 169, 87, 214, 192 }, new byte[] { 74, 167, 247, 128, 39, 129, 9, 104, 176, 172, 210, 25, 37, 245, 236, 245, 131, 182, 243, 36, 177, 186, 214, 74, 16, 255, 83, 82, 225, 108, 182, 125, 15, 231, 65, 71, 19, 222, 254, 156, 253, 123, 186, 117, 119, 105, 216, 209, 141, 120, 52, 240, 197, 121, 95, 206, 209, 83, 238, 168, 60, 55, 195, 119, 254, 172, 110, 37, 131, 253, 104, 187, 178, 97, 116, 184, 74, 26, 93, 248, 73, 228, 230, 120, 67, 218, 5, 162, 137, 144, 81, 116, 16, 242, 200, 112, 171, 121, 145, 254, 188, 100, 75, 113, 115, 221, 107, 231, 246, 123, 69, 236, 12, 25, 80, 125, 191, 112, 37, 127, 149, 240, 214, 88, 21, 20, 58, 67 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 18, 16, 381, DateTimeKind.Utc).AddTicks(5866), new byte[] { 107, 71, 223, 185, 129, 101, 121, 208, 146, 58, 21, 146, 19, 147, 181, 137, 102, 204, 132, 14, 74, 180, 4, 253, 160, 247, 200, 38, 11, 157, 240, 49, 142, 107, 63, 71, 170, 134, 229, 254, 90, 51, 175, 166, 58, 200, 242, 244, 59, 77, 37, 143, 27, 33, 66, 45, 14, 228, 86, 224, 169, 87, 214, 192 }, new byte[] { 74, 167, 247, 128, 39, 129, 9, 104, 176, 172, 210, 25, 37, 245, 236, 245, 131, 182, 243, 36, 177, 186, 214, 74, 16, 255, 83, 82, 225, 108, 182, 125, 15, 231, 65, 71, 19, 222, 254, 156, 253, 123, 186, 117, 119, 105, 216, 209, 141, 120, 52, 240, 197, 121, 95, 206, 209, 83, 238, 168, 60, 55, 195, 119, 254, 172, 110, 37, 131, 253, 104, 187, 178, 97, 116, 184, 74, 26, 93, 248, 73, 228, 230, 120, 67, 218, 5, 162, 137, 144, 81, 116, 16, 242, 200, 112, 171, 121, 145, 254, 188, 100, 75, 113, 115, 221, 107, 231, 246, 123, 69, 236, 12, 25, 80, 125, 191, 112, 37, 127, 149, 240, 214, 88, 21, 20, 58, 67 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 18, 16, 381, DateTimeKind.Utc).AddTicks(5871), new byte[] { 107, 71, 223, 185, 129, 101, 121, 208, 146, 58, 21, 146, 19, 147, 181, 137, 102, 204, 132, 14, 74, 180, 4, 253, 160, 247, 200, 38, 11, 157, 240, 49, 142, 107, 63, 71, 170, 134, 229, 254, 90, 51, 175, 166, 58, 200, 242, 244, 59, 77, 37, 143, 27, 33, 66, 45, 14, 228, 86, 224, 169, 87, 214, 192 }, new byte[] { 74, 167, 247, 128, 39, 129, 9, 104, 176, 172, 210, 25, 37, 245, 236, 245, 131, 182, 243, 36, 177, 186, 214, 74, 16, 255, 83, 82, 225, 108, 182, 125, 15, 231, 65, 71, 19, 222, 254, 156, 253, 123, 186, 117, 119, 105, 216, 209, 141, 120, 52, 240, 197, 121, 95, 206, 209, 83, 238, 168, 60, 55, 195, 119, 254, 172, 110, 37, 131, 253, 104, 187, 178, 97, 116, 184, 74, 26, 93, 248, 73, 228, 230, 120, 67, 218, 5, 162, 137, 144, 81, 116, 16, 242, 200, 112, 171, 121, 145, 254, 188, 100, 75, 113, 115, 221, 107, 231, 246, 123, 69, 236, 12, 25, 80, 125, 191, 112, 37, 127, 149, 240, 214, 88, 21, 20, 58, 67 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 18, 16, 381, DateTimeKind.Utc).AddTicks(5874), new byte[] { 107, 71, 223, 185, 129, 101, 121, 208, 146, 58, 21, 146, 19, 147, 181, 137, 102, 204, 132, 14, 74, 180, 4, 253, 160, 247, 200, 38, 11, 157, 240, 49, 142, 107, 63, 71, 170, 134, 229, 254, 90, 51, 175, 166, 58, 200, 242, 244, 59, 77, 37, 143, 27, 33, 66, 45, 14, 228, 86, 224, 169, 87, 214, 192 }, new byte[] { 74, 167, 247, 128, 39, 129, 9, 104, 176, 172, 210, 25, 37, 245, 236, 245, 131, 182, 243, 36, 177, 186, 214, 74, 16, 255, 83, 82, 225, 108, 182, 125, 15, 231, 65, 71, 19, 222, 254, 156, 253, 123, 186, 117, 119, 105, 216, 209, 141, 120, 52, 240, 197, 121, 95, 206, 209, 83, 238, 168, 60, 55, 195, 119, 254, 172, 110, 37, 131, 253, 104, 187, 178, 97, 116, 184, 74, 26, 93, 248, 73, 228, 230, 120, 67, 218, 5, 162, 137, 144, 81, 116, 16, 242, 200, 112, 171, 121, 145, 254, 188, 100, 75, 113, 115, 221, 107, 231, 246, 123, 69, 236, 12, 25, 80, 125, 191, 112, 37, 127, 149, 240, 214, 88, 21, 20, 58, 67 } });
        }
    }
}
