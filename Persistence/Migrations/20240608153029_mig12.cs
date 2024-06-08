using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6453), new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "CreatedDate", "DeletedDate", "DoctorId", "IsDeleted", "PatientId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6461), new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6462), null, 4, false, 1, 0, null },
                    { 3, new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6466), new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6467), null, 3, false, 2, 0, null },
                    { 4, new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6470), new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(6471), null, 4, false, 2, 0, null }
                });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 18, 30, 28, 985, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6146), new byte[] { 18, 13, 68, 150, 24, 55, 94, 64, 179, 183, 105, 138, 200, 0, 96, 248, 232, 104, 82, 252, 4, 220, 157, 84, 231, 66, 65, 46, 129, 36, 85, 99, 30, 121, 87, 29, 214, 142, 152, 167, 164, 142, 158, 127, 221, 57, 233, 208, 21, 99, 15, 169, 103, 59, 244, 206, 81, 164, 170, 19, 68, 113, 36, 206 }, new byte[] { 7, 134, 243, 89, 191, 211, 55, 187, 180, 229, 82, 71, 69, 51, 255, 164, 132, 172, 237, 173, 24, 61, 64, 156, 237, 35, 155, 25, 39, 223, 12, 24, 244, 114, 142, 172, 195, 214, 231, 210, 210, 243, 121, 176, 170, 80, 83, 59, 114, 194, 140, 79, 15, 86, 23, 58, 111, 98, 217, 255, 7, 166, 52, 10, 213, 42, 141, 38, 209, 52, 93, 156, 138, 104, 246, 150, 127, 163, 158, 199, 12, 210, 243, 169, 61, 225, 253, 234, 27, 50, 200, 245, 100, 248, 2, 85, 251, 227, 131, 124, 255, 122, 153, 142, 223, 240, 87, 165, 100, 88, 125, 68, 13, 106, 81, 127, 219, 185, 108, 111, 76, 35, 102, 204, 144, 231, 253, 104 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6154), new byte[] { 18, 13, 68, 150, 24, 55, 94, 64, 179, 183, 105, 138, 200, 0, 96, 248, 232, 104, 82, 252, 4, 220, 157, 84, 231, 66, 65, 46, 129, 36, 85, 99, 30, 121, 87, 29, 214, 142, 152, 167, 164, 142, 158, 127, 221, 57, 233, 208, 21, 99, 15, 169, 103, 59, 244, 206, 81, 164, 170, 19, 68, 113, 36, 206 }, new byte[] { 7, 134, 243, 89, 191, 211, 55, 187, 180, 229, 82, 71, 69, 51, 255, 164, 132, 172, 237, 173, 24, 61, 64, 156, 237, 35, 155, 25, 39, 223, 12, 24, 244, 114, 142, 172, 195, 214, 231, 210, 210, 243, 121, 176, 170, 80, 83, 59, 114, 194, 140, 79, 15, 86, 23, 58, 111, 98, 217, 255, 7, 166, 52, 10, 213, 42, 141, 38, 209, 52, 93, 156, 138, 104, 246, 150, 127, 163, 158, 199, 12, 210, 243, 169, 61, 225, 253, 234, 27, 50, 200, 245, 100, 248, 2, 85, 251, 227, 131, 124, 255, 122, 153, 142, 223, 240, 87, 165, 100, 88, 125, 68, 13, 106, 81, 127, 219, 185, 108, 111, 76, 35, 102, 204, 144, 231, 253, 104 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6159), new byte[] { 18, 13, 68, 150, 24, 55, 94, 64, 179, 183, 105, 138, 200, 0, 96, 248, 232, 104, 82, 252, 4, 220, 157, 84, 231, 66, 65, 46, 129, 36, 85, 99, 30, 121, 87, 29, 214, 142, 152, 167, 164, 142, 158, 127, 221, 57, 233, 208, 21, 99, 15, 169, 103, 59, 244, 206, 81, 164, 170, 19, 68, 113, 36, 206 }, new byte[] { 7, 134, 243, 89, 191, 211, 55, 187, 180, 229, 82, 71, 69, 51, 255, 164, 132, 172, 237, 173, 24, 61, 64, 156, 237, 35, 155, 25, 39, 223, 12, 24, 244, 114, 142, 172, 195, 214, 231, 210, 210, 243, 121, 176, 170, 80, 83, 59, 114, 194, 140, 79, 15, 86, 23, 58, 111, 98, 217, 255, 7, 166, 52, 10, 213, 42, 141, 38, 209, 52, 93, 156, 138, 104, 246, 150, 127, 163, 158, 199, 12, 210, 243, 169, 61, 225, 253, 234, 27, 50, 200, 245, 100, 248, 2, 85, 251, 227, 131, 124, 255, 122, 153, 142, 223, 240, 87, 165, 100, 88, 125, 68, 13, 106, 81, 127, 219, 185, 108, 111, 76, 35, 102, 204, 144, 231, 253, 104 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6162), new byte[] { 18, 13, 68, 150, 24, 55, 94, 64, 179, 183, 105, 138, 200, 0, 96, 248, 232, 104, 82, 252, 4, 220, 157, 84, 231, 66, 65, 46, 129, 36, 85, 99, 30, 121, 87, 29, 214, 142, 152, 167, 164, 142, 158, 127, 221, 57, 233, 208, 21, 99, 15, 169, 103, 59, 244, 206, 81, 164, 170, 19, 68, 113, 36, 206 }, new byte[] { 7, 134, 243, 89, 191, 211, 55, 187, 180, 229, 82, 71, 69, 51, 255, 164, 132, 172, 237, 173, 24, 61, 64, 156, 237, 35, 155, 25, 39, 223, 12, 24, 244, 114, 142, 172, 195, 214, 231, 210, 210, 243, 121, 176, 170, 80, 83, 59, 114, 194, 140, 79, 15, 86, 23, 58, 111, 98, 217, 255, 7, 166, 52, 10, 213, 42, 141, 38, 209, 52, 93, 156, 138, 104, 246, 150, 127, 163, 158, 199, 12, 210, 243, 169, 61, 225, 253, 234, 27, 50, 200, 245, 100, 248, 2, 85, 251, 227, 131, 124, 255, 122, 153, 142, 223, 240, 87, 165, 100, 88, 125, 68, 13, 106, 81, 127, 219, 185, 108, 111, 76, 35, 102, 204, 144, 231, 253, 104 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 30, 28, 985, DateTimeKind.Utc).AddTicks(6165), new byte[] { 18, 13, 68, 150, 24, 55, 94, 64, 179, 183, 105, 138, 200, 0, 96, 248, 232, 104, 82, 252, 4, 220, 157, 84, 231, 66, 65, 46, 129, 36, 85, 99, 30, 121, 87, 29, 214, 142, 152, 167, 164, 142, 158, 127, 221, 57, 233, 208, 21, 99, 15, 169, 103, 59, 244, 206, 81, 164, 170, 19, 68, 113, 36, 206 }, new byte[] { 7, 134, 243, 89, 191, 211, 55, 187, 180, 229, 82, 71, 69, 51, 255, 164, 132, 172, 237, 173, 24, 61, 64, 156, 237, 35, 155, 25, 39, 223, 12, 24, 244, 114, 142, 172, 195, 214, 231, 210, 210, 243, 121, 176, 170, 80, 83, 59, 114, 194, 140, 79, 15, 86, 23, 58, 111, 98, 217, 255, 7, 166, 52, 10, 213, 42, 141, 38, 209, 52, 93, 156, 138, 104, 246, 150, 127, 163, 158, 199, 12, 210, 243, 169, 61, 225, 253, 234, 27, 50, 200, 245, 100, 248, 2, 85, 251, 227, 131, 124, 255, 122, 153, 142, 223, 240, 87, 165, 100, 88, 125, 68, 13, 106, 81, 127, 219, 185, 108, 111, 76, 35, 102, 204, 144, 231, 253, 104 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(3262), new DateTime(2024, 6, 8, 18, 29, 37, 766, DateTimeKind.Local).AddTicks(3263) });

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
    }
}
