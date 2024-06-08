using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "CreatedDate", "DeletedDate", "DoctorId", "IsDeleted", "PatientId", "Status", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(3262), new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(3263), null, 3, false, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(2960), new byte[] { 19, 112, 48, 82, 122, 170, 69, 75, 83, 24, 2, 243, 80, 202, 166, 120, 117, 33, 1, 229, 207, 205, 34, 199, 234, 190, 62, 83, 109, 7, 24, 92, 248, 30, 16, 233, 46, 71, 53, 218, 53, 115, 207, 130, 93, 209, 75, 49, 225, 70, 159, 231, 31, 64, 215, 129, 156, 46, 87, 114, 82, 72, 153, 74 }, new byte[] { 97, 30, 120, 255, 115, 234, 151, 99, 61, 38, 135, 78, 58, 248, 163, 225, 175, 190, 53, 127, 71, 238, 136, 143, 187, 110, 5, 84, 52, 151, 87, 183, 120, 8, 122, 240, 78, 10, 167, 14, 15, 106, 196, 121, 213, 90, 107, 102, 119, 204, 98, 205, 92, 100, 85, 230, 248, 118, 222, 139, 217, 211, 139, 134, 127, 202, 231, 104, 233, 160, 100, 38, 41, 11, 27, 208, 155, 214, 232, 18, 111, 107, 147, 173, 119, 110, 119, 70, 59, 145, 180, 124, 248, 79, 72, 57, 11, 106, 104, 141, 221, 239, 186, 86, 151, 117, 6, 19, 19, 166, 22, 167, 237, 77, 183, 104, 14, 157, 69, 101, 108, 240, 168, 25, 95, 186, 78, 67 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(2969), new byte[] { 19, 112, 48, 82, 122, 170, 69, 75, 83, 24, 2, 243, 80, 202, 166, 120, 117, 33, 1, 229, 207, 205, 34, 199, 234, 190, 62, 83, 109, 7, 24, 92, 248, 30, 16, 233, 46, 71, 53, 218, 53, 115, 207, 130, 93, 209, 75, 49, 225, 70, 159, 231, 31, 64, 215, 129, 156, 46, 87, 114, 82, 72, 153, 74 }, new byte[] { 97, 30, 120, 255, 115, 234, 151, 99, 61, 38, 135, 78, 58, 248, 163, 225, 175, 190, 53, 127, 71, 238, 136, 143, 187, 110, 5, 84, 52, 151, 87, 183, 120, 8, 122, 240, 78, 10, 167, 14, 15, 106, 196, 121, 213, 90, 107, 102, 119, 204, 98, 205, 92, 100, 85, 230, 248, 118, 222, 139, 217, 211, 139, 134, 127, 202, 231, 104, 233, 160, 100, 38, 41, 11, 27, 208, 155, 214, 232, 18, 111, 107, 147, 173, 119, 110, 119, 70, 59, 145, 180, 124, 248, 79, 72, 57, 11, 106, 104, 141, 221, 239, 186, 86, 151, 117, 6, 19, 19, 166, 22, 167, 237, 77, 183, 104, 14, 157, 69, 101, 108, 240, 168, 25, 95, 186, 78, 67 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(2974), new byte[] { 19, 112, 48, 82, 122, 170, 69, 75, 83, 24, 2, 243, 80, 202, 166, 120, 117, 33, 1, 229, 207, 205, 34, 199, 234, 190, 62, 83, 109, 7, 24, 92, 248, 30, 16, 233, 46, 71, 53, 218, 53, 115, 207, 130, 93, 209, 75, 49, 225, 70, 159, 231, 31, 64, 215, 129, 156, 46, 87, 114, 82, 72, 153, 74 }, new byte[] { 97, 30, 120, 255, 115, 234, 151, 99, 61, 38, 135, 78, 58, 248, 163, 225, 175, 190, 53, 127, 71, 238, 136, 143, 187, 110, 5, 84, 52, 151, 87, 183, 120, 8, 122, 240, 78, 10, 167, 14, 15, 106, 196, 121, 213, 90, 107, 102, 119, 204, 98, 205, 92, 100, 85, 230, 248, 118, 222, 139, 217, 211, 139, 134, 127, 202, 231, 104, 233, 160, 100, 38, 41, 11, 27, 208, 155, 214, 232, 18, 111, 107, 147, 173, 119, 110, 119, 70, 59, 145, 180, 124, 248, 79, 72, 57, 11, 106, 104, 141, 221, 239, 186, 86, 151, 117, 6, 19, 19, 166, 22, 167, 237, 77, 183, 104, 14, 157, 69, 101, 108, 240, 168, 25, 95, 186, 78, 67 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(2978), new byte[] { 19, 112, 48, 82, 122, 170, 69, 75, 83, 24, 2, 243, 80, 202, 166, 120, 117, 33, 1, 229, 207, 205, 34, 199, 234, 190, 62, 83, 109, 7, 24, 92, 248, 30, 16, 233, 46, 71, 53, 218, 53, 115, 207, 130, 93, 209, 75, 49, 225, 70, 159, 231, 31, 64, 215, 129, 156, 46, 87, 114, 82, 72, 153, 74 }, new byte[] { 97, 30, 120, 255, 115, 234, 151, 99, 61, 38, 135, 78, 58, 248, 163, 225, 175, 190, 53, 127, 71, 238, 136, 143, 187, 110, 5, 84, 52, 151, 87, 183, 120, 8, 122, 240, 78, 10, 167, 14, 15, 106, 196, 121, 213, 90, 107, 102, 119, 204, 98, 205, 92, 100, 85, 230, 248, 118, 222, 139, 217, 211, 139, 134, 127, 202, 231, 104, 233, 160, 100, 38, 41, 11, 27, 208, 155, 214, 232, 18, 111, 107, 147, 173, 119, 110, 119, 70, 59, 145, 180, 124, 248, 79, 72, 57, 11, 106, 104, 141, 221, 239, 186, 86, 151, 117, 6, 19, 19, 166, 22, 167, 237, 77, 183, 104, 14, 157, 69, 101, 108, 240, 168, 25, 95, 186, 78, 67 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 29, 37, 766, DateTimeKind.Utc).AddTicks(2981), new byte[] { 19, 112, 48, 82, 122, 170, 69, 75, 83, 24, 2, 243, 80, 202, 166, 120, 117, 33, 1, 229, 207, 205, 34, 199, 234, 190, 62, 83, 109, 7, 24, 92, 248, 30, 16, 233, 46, 71, 53, 218, 53, 115, 207, 130, 93, 209, 75, 49, 225, 70, 159, 231, 31, 64, 215, 129, 156, 46, 87, 114, 82, 72, 153, 74 }, new byte[] { 97, 30, 120, 255, 115, 234, 151, 99, 61, 38, 135, 78, 58, 248, 163, 225, 175, 190, 53, 127, 71, 238, 136, 143, 187, 110, 5, 84, 52, 151, 87, 183, 120, 8, 122, 240, 78, 10, 167, 14, 15, 106, 196, 121, 213, 90, 107, 102, 119, 204, 98, 205, 92, 100, 85, 230, 248, 118, 222, 139, 217, 211, 139, 134, 127, 202, 231, 104, 233, 160, 100, 38, 41, 11, 27, 208, 155, 214, 232, 18, 111, 107, 147, 173, 119, 110, 119, 70, 59, 145, 180, 124, 248, 79, 72, 57, 11, 106, 104, 141, 221, 239, 186, 86, 151, 117, 6, 19, 19, 166, 22, 167, 237, 77, 183, 104, 14, 157, 69, 101, 108, 240, 168, 25, 95, 186, 78, 67 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 27, 8, 382, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 27, 8, 382, DateTimeKind.Local).AddTicks(3643));

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
    }
}
