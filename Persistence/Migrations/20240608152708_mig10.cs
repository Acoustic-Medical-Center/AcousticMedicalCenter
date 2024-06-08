using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 27, 8, 382, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 27, 8, 382, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 27, 8, 382, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 27, 8, 382, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 27, 8, 382, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 27, 8, 382, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 27, 8, 382, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 27, 8, 382, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 8, 18, 27, 8, 382, DateTimeKind.Local).AddTicks(3633), null, 1, null, 5 },
                    { 2, new DateTime(2024, 6, 8, 18, 27, 8, 382, DateTimeKind.Local).AddTicks(3643), null, 2, null, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 27, 8, 382, DateTimeKind.Utc).AddTicks(4060), new byte[] { 67, 135, 224, 1, 165, 42, 89, 211, 19, 4, 91, 76, 150, 71, 31, 184, 201, 252, 92, 167, 66, 232, 3, 164, 113, 12, 95, 12, 29, 32, 107, 154, 233, 68, 147, 251, 194, 99, 44, 105, 146, 54, 253, 206, 54, 63, 5, 73, 190, 186, 59, 168, 27, 156, 168, 41, 233, 63, 80, 248, 186, 228, 4, 97 }, new byte[] { 217, 99, 238, 92, 4, 109, 73, 145, 40, 213, 162, 190, 141, 5, 129, 141, 95, 141, 7, 115, 235, 124, 222, 185, 125, 175, 164, 49, 209, 24, 226, 247, 160, 224, 35, 145, 132, 95, 192, 67, 147, 138, 230, 159, 179, 58, 4, 217, 68, 58, 45, 68, 27, 69, 3, 169, 134, 45, 15, 113, 168, 128, 134, 208, 195, 84, 197, 156, 151, 14, 29, 127, 117, 181, 26, 94, 81, 215, 205, 102, 172, 39, 154, 15, 166, 115, 135, 183, 196, 231, 4, 6, 60, 31, 110, 226, 155, 214, 111, 57, 42, 118, 230, 204, 120, 106, 185, 115, 192, 38, 228, 211, 133, 178, 181, 135, 218, 110, 154, 46, 243, 133, 251, 210, 182, 113, 44, 78 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 27, 8, 382, DateTimeKind.Utc).AddTicks(4069), new byte[] { 67, 135, 224, 1, 165, 42, 89, 211, 19, 4, 91, 76, 150, 71, 31, 184, 201, 252, 92, 167, 66, 232, 3, 164, 113, 12, 95, 12, 29, 32, 107, 154, 233, 68, 147, 251, 194, 99, 44, 105, 146, 54, 253, 206, 54, 63, 5, 73, 190, 186, 59, 168, 27, 156, 168, 41, 233, 63, 80, 248, 186, 228, 4, 97 }, new byte[] { 217, 99, 238, 92, 4, 109, 73, 145, 40, 213, 162, 190, 141, 5, 129, 141, 95, 141, 7, 115, 235, 124, 222, 185, 125, 175, 164, 49, 209, 24, 226, 247, 160, 224, 35, 145, 132, 95, 192, 67, 147, 138, 230, 159, 179, 58, 4, 217, 68, 58, 45, 68, 27, 69, 3, 169, 134, 45, 15, 113, 168, 128, 134, 208, 195, 84, 197, 156, 151, 14, 29, 127, 117, 181, 26, 94, 81, 215, 205, 102, 172, 39, 154, 15, 166, 115, 135, 183, 196, 231, 4, 6, 60, 31, 110, 226, 155, 214, 111, 57, 42, 118, 230, 204, 120, 106, 185, 115, 192, 38, 228, 211, 133, 178, 181, 135, 218, 110, 154, 46, 243, 133, 251, 210, 182, 113, 44, 78 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 27, 8, 382, DateTimeKind.Utc).AddTicks(4073), new byte[] { 67, 135, 224, 1, 165, 42, 89, 211, 19, 4, 91, 76, 150, 71, 31, 184, 201, 252, 92, 167, 66, 232, 3, 164, 113, 12, 95, 12, 29, 32, 107, 154, 233, 68, 147, 251, 194, 99, 44, 105, 146, 54, 253, 206, 54, 63, 5, 73, 190, 186, 59, 168, 27, 156, 168, 41, 233, 63, 80, 248, 186, 228, 4, 97 }, new byte[] { 217, 99, 238, 92, 4, 109, 73, 145, 40, 213, 162, 190, 141, 5, 129, 141, 95, 141, 7, 115, 235, 124, 222, 185, 125, 175, 164, 49, 209, 24, 226, 247, 160, 224, 35, 145, 132, 95, 192, 67, 147, 138, 230, 159, 179, 58, 4, 217, 68, 58, 45, 68, 27, 69, 3, 169, 134, 45, 15, 113, 168, 128, 134, 208, 195, 84, 197, 156, 151, 14, 29, 127, 117, 181, 26, 94, 81, 215, 205, 102, 172, 39, 154, 15, 166, 115, 135, 183, 196, 231, 4, 6, 60, 31, 110, 226, 155, 214, 111, 57, 42, 118, 230, 204, 120, 106, 185, 115, 192, 38, 228, 211, 133, 178, 181, 135, 218, 110, 154, 46, 243, 133, 251, 210, 182, 113, 44, 78 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 27, 8, 382, DateTimeKind.Utc).AddTicks(4076), new byte[] { 67, 135, 224, 1, 165, 42, 89, 211, 19, 4, 91, 76, 150, 71, 31, 184, 201, 252, 92, 167, 66, 232, 3, 164, 113, 12, 95, 12, 29, 32, 107, 154, 233, 68, 147, 251, 194, 99, 44, 105, 146, 54, 253, 206, 54, 63, 5, 73, 190, 186, 59, 168, 27, 156, 168, 41, 233, 63, 80, 248, 186, 228, 4, 97 }, new byte[] { 217, 99, 238, 92, 4, 109, 73, 145, 40, 213, 162, 190, 141, 5, 129, 141, 95, 141, 7, 115, 235, 124, 222, 185, 125, 175, 164, 49, 209, 24, 226, 247, 160, 224, 35, 145, 132, 95, 192, 67, 147, 138, 230, 159, 179, 58, 4, 217, 68, 58, 45, 68, 27, 69, 3, 169, 134, 45, 15, 113, 168, 128, 134, 208, 195, 84, 197, 156, 151, 14, 29, 127, 117, 181, 26, 94, 81, 215, 205, 102, 172, 39, 154, 15, 166, 115, 135, 183, 196, 231, 4, 6, 60, 31, 110, 226, 155, 214, 111, 57, 42, 118, 230, 204, 120, 106, 185, 115, 192, 38, 228, 211, 133, 178, 181, 135, 218, 110, 154, 46, 243, 133, 251, 210, 182, 113, 44, 78 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 27, 8, 382, DateTimeKind.Utc).AddTicks(4080), new byte[] { 67, 135, 224, 1, 165, 42, 89, 211, 19, 4, 91, 76, 150, 71, 31, 184, 201, 252, 92, 167, 66, 232, 3, 164, 113, 12, 95, 12, 29, 32, 107, 154, 233, 68, 147, 251, 194, 99, 44, 105, 146, 54, 253, 206, 54, 63, 5, 73, 190, 186, 59, 168, 27, 156, 168, 41, 233, 63, 80, 248, 186, 228, 4, 97 }, new byte[] { 217, 99, 238, 92, 4, 109, 73, 145, 40, 213, 162, 190, 141, 5, 129, 141, 95, 141, 7, 115, 235, 124, 222, 185, 125, 175, 164, 49, 209, 24, 226, 247, 160, 224, 35, 145, 132, 95, 192, 67, 147, 138, 230, 159, 179, 58, 4, 217, 68, 58, 45, 68, 27, 69, 3, 169, 134, 45, 15, 113, 168, 128, 134, 208, 195, 84, 197, 156, 151, 14, 29, 127, 117, 181, 26, 94, 81, 215, 205, 102, 172, 39, 154, 15, 166, 115, 135, 183, 196, 231, 4, 6, 60, 31, 110, 226, 155, 214, 111, 57, 42, 118, 230, 204, 120, 106, 185, 115, 192, 38, 228, 211, 133, 178, 181, 135, 218, 110, 154, 46, 243, 133, 251, 210, 182, 113, 44, 78 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 26, 45, 216, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 26, 45, 216, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 26, 45, 217, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 26, 45, 217, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 26, 45, 216, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 26, 45, 216, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 26, 45, 217, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 26, 45, 217, DateTimeKind.Utc).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 26, 45, 217, DateTimeKind.Utc), new byte[] { 195, 205, 193, 97, 88, 190, 181, 210, 16, 8, 12, 33, 133, 220, 172, 245, 100, 184, 218, 61, 242, 209, 142, 76, 196, 238, 219, 111, 102, 106, 157, 96, 186, 186, 104, 229, 20, 60, 77, 38, 191, 97, 64, 2, 121, 171, 221, 57, 129, 248, 51, 38, 33, 157, 104, 59, 194, 95, 101, 250, 77, 108, 242, 55 }, new byte[] { 10, 88, 136, 78, 145, 170, 59, 236, 69, 74, 147, 245, 255, 164, 102, 96, 139, 118, 239, 143, 237, 155, 104, 56, 194, 194, 91, 78, 218, 248, 63, 231, 138, 101, 92, 104, 5, 134, 208, 223, 56, 250, 135, 185, 54, 28, 17, 72, 89, 36, 166, 175, 173, 119, 229, 51, 255, 56, 136, 128, 107, 60, 9, 118, 166, 176, 92, 133, 31, 141, 191, 197, 107, 220, 33, 41, 223, 131, 222, 137, 98, 179, 3, 70, 217, 164, 21, 143, 187, 145, 140, 141, 236, 238, 11, 166, 239, 146, 201, 70, 71, 21, 165, 34, 234, 16, 48, 112, 110, 183, 182, 199, 86, 32, 133, 250, 180, 171, 183, 213, 79, 230, 66, 173, 136, 173, 177, 102 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 26, 45, 217, DateTimeKind.Utc).AddTicks(11), new byte[] { 195, 205, 193, 97, 88, 190, 181, 210, 16, 8, 12, 33, 133, 220, 172, 245, 100, 184, 218, 61, 242, 209, 142, 76, 196, 238, 219, 111, 102, 106, 157, 96, 186, 186, 104, 229, 20, 60, 77, 38, 191, 97, 64, 2, 121, 171, 221, 57, 129, 248, 51, 38, 33, 157, 104, 59, 194, 95, 101, 250, 77, 108, 242, 55 }, new byte[] { 10, 88, 136, 78, 145, 170, 59, 236, 69, 74, 147, 245, 255, 164, 102, 96, 139, 118, 239, 143, 237, 155, 104, 56, 194, 194, 91, 78, 218, 248, 63, 231, 138, 101, 92, 104, 5, 134, 208, 223, 56, 250, 135, 185, 54, 28, 17, 72, 89, 36, 166, 175, 173, 119, 229, 51, 255, 56, 136, 128, 107, 60, 9, 118, 166, 176, 92, 133, 31, 141, 191, 197, 107, 220, 33, 41, 223, 131, 222, 137, 98, 179, 3, 70, 217, 164, 21, 143, 187, 145, 140, 141, 236, 238, 11, 166, 239, 146, 201, 70, 71, 21, 165, 34, 234, 16, 48, 112, 110, 183, 182, 199, 86, 32, 133, 250, 180, 171, 183, 213, 79, 230, 66, 173, 136, 173, 177, 102 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 26, 45, 217, DateTimeKind.Utc).AddTicks(15), new byte[] { 195, 205, 193, 97, 88, 190, 181, 210, 16, 8, 12, 33, 133, 220, 172, 245, 100, 184, 218, 61, 242, 209, 142, 76, 196, 238, 219, 111, 102, 106, 157, 96, 186, 186, 104, 229, 20, 60, 77, 38, 191, 97, 64, 2, 121, 171, 221, 57, 129, 248, 51, 38, 33, 157, 104, 59, 194, 95, 101, 250, 77, 108, 242, 55 }, new byte[] { 10, 88, 136, 78, 145, 170, 59, 236, 69, 74, 147, 245, 255, 164, 102, 96, 139, 118, 239, 143, 237, 155, 104, 56, 194, 194, 91, 78, 218, 248, 63, 231, 138, 101, 92, 104, 5, 134, 208, 223, 56, 250, 135, 185, 54, 28, 17, 72, 89, 36, 166, 175, 173, 119, 229, 51, 255, 56, 136, 128, 107, 60, 9, 118, 166, 176, 92, 133, 31, 141, 191, 197, 107, 220, 33, 41, 223, 131, 222, 137, 98, 179, 3, 70, 217, 164, 21, 143, 187, 145, 140, 141, 236, 238, 11, 166, 239, 146, 201, 70, 71, 21, 165, 34, 234, 16, 48, 112, 110, 183, 182, 199, 86, 32, 133, 250, 180, 171, 183, 213, 79, 230, 66, 173, 136, 173, 177, 102 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 26, 45, 217, DateTimeKind.Utc).AddTicks(19), new byte[] { 195, 205, 193, 97, 88, 190, 181, 210, 16, 8, 12, 33, 133, 220, 172, 245, 100, 184, 218, 61, 242, 209, 142, 76, 196, 238, 219, 111, 102, 106, 157, 96, 186, 186, 104, 229, 20, 60, 77, 38, 191, 97, 64, 2, 121, 171, 221, 57, 129, 248, 51, 38, 33, 157, 104, 59, 194, 95, 101, 250, 77, 108, 242, 55 }, new byte[] { 10, 88, 136, 78, 145, 170, 59, 236, 69, 74, 147, 245, 255, 164, 102, 96, 139, 118, 239, 143, 237, 155, 104, 56, 194, 194, 91, 78, 218, 248, 63, 231, 138, 101, 92, 104, 5, 134, 208, 223, 56, 250, 135, 185, 54, 28, 17, 72, 89, 36, 166, 175, 173, 119, 229, 51, 255, 56, 136, 128, 107, 60, 9, 118, 166, 176, 92, 133, 31, 141, 191, 197, 107, 220, 33, 41, 223, 131, 222, 137, 98, 179, 3, 70, 217, 164, 21, 143, 187, 145, 140, 141, 236, 238, 11, 166, 239, 146, 201, 70, 71, 21, 165, 34, 234, 16, 48, 112, 110, 183, 182, 199, 86, 32, 133, 250, 180, 171, 183, 213, 79, 230, 66, 173, 136, 173, 177, 102 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 26, 45, 217, DateTimeKind.Utc).AddTicks(23), new byte[] { 195, 205, 193, 97, 88, 190, 181, 210, 16, 8, 12, 33, 133, 220, 172, 245, 100, 184, 218, 61, 242, 209, 142, 76, 196, 238, 219, 111, 102, 106, 157, 96, 186, 186, 104, 229, 20, 60, 77, 38, 191, 97, 64, 2, 121, 171, 221, 57, 129, 248, 51, 38, 33, 157, 104, 59, 194, 95, 101, 250, 77, 108, 242, 55 }, new byte[] { 10, 88, 136, 78, 145, 170, 59, 236, 69, 74, 147, 245, 255, 164, 102, 96, 139, 118, 239, 143, 237, 155, 104, 56, 194, 194, 91, 78, 218, 248, 63, 231, 138, 101, 92, 104, 5, 134, 208, 223, 56, 250, 135, 185, 54, 28, 17, 72, 89, 36, 166, 175, 173, 119, 229, 51, 255, 56, 136, 128, 107, 60, 9, 118, 166, 176, 92, 133, 31, 141, 191, 197, 107, 220, 33, 41, 223, 131, 222, 137, 98, 179, 3, 70, 217, 164, 21, 143, 187, 145, 140, 141, 236, 238, 11, 166, 239, 146, 201, 70, 71, 21, 165, 34, 234, 16, 48, 112, 110, 183, 182, 199, 86, 32, 133, 250, 180, 171, 183, 213, 79, 230, 66, 173, 136, 173, 177, 102 } });
        }
    }
}
