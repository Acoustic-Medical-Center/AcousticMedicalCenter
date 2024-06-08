using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 8, 18, 26, 45, 216, DateTimeKind.Local).AddTicks(9563), null, "Admin", null },
                    { 2, new DateTime(2024, 6, 8, 18, 26, 45, 216, DateTimeKind.Local).AddTicks(9570), null, "Appointment.Delete", null }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 25, 20, 186, DateTimeKind.Utc).AddTicks(2823), new byte[] { 240, 228, 203, 30, 229, 185, 173, 129, 124, 105, 159, 195, 29, 111, 226, 66, 162, 83, 72, 244, 193, 189, 255, 211, 57, 129, 213, 6, 201, 175, 199, 232, 198, 195, 198, 32, 10, 81, 209, 255, 229, 77, 95, 148, 96, 0, 38, 151, 146, 208, 141, 243, 187, 25, 139, 99, 199, 75, 76, 82, 175, 212, 52, 39 }, new byte[] { 206, 112, 99, 80, 140, 182, 98, 200, 241, 193, 168, 158, 189, 84, 198, 225, 116, 117, 210, 199, 59, 210, 0, 251, 145, 236, 239, 249, 163, 30, 95, 188, 246, 240, 17, 250, 251, 4, 99, 210, 187, 169, 232, 171, 127, 81, 26, 45, 137, 75, 215, 240, 148, 100, 196, 244, 116, 94, 180, 194, 100, 170, 69, 219, 135, 92, 168, 80, 174, 169, 138, 59, 17, 208, 197, 213, 153, 171, 191, 162, 231, 215, 177, 233, 70, 64, 117, 175, 13, 120, 36, 18, 105, 241, 12, 14, 72, 79, 150, 108, 178, 55, 210, 172, 141, 119, 60, 46, 98, 134, 140, 217, 7, 241, 149, 225, 9, 236, 176, 241, 90, 113, 39, 35, 203, 69, 103, 0 } });
        }
    }
}
