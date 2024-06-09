﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "AppointmentId", "BloodType", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { 2, "1233 Main St", 0, "B+", new DateTime(2024, 6, 8, 15, 18, 16, 381, DateTimeKind.Utc).AddTicks(5991), null, null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 17, 17, 523, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 15, 17, 17, 523, DateTimeKind.Utc).AddTicks(2093));

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
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 17, 17, 523, DateTimeKind.Utc).AddTicks(1820), new byte[] { 205, 98, 218, 9, 36, 81, 26, 61, 35, 213, 83, 250, 155, 142, 109, 27, 140, 220, 86, 83, 141, 240, 102, 40, 154, 128, 78, 226, 214, 241, 129, 108, 241, 70, 202, 204, 254, 102, 184, 44, 180, 229, 28, 136, 1, 230, 93, 235, 170, 128, 61, 187, 6, 171, 100, 251, 219, 19, 131, 86, 237, 44, 247, 219 }, new byte[] { 144, 223, 213, 59, 202, 103, 114, 41, 10, 236, 249, 72, 225, 14, 154, 75, 12, 16, 220, 33, 197, 87, 84, 85, 54, 166, 28, 0, 41, 144, 155, 58, 76, 137, 128, 86, 197, 247, 42, 165, 52, 61, 140, 137, 102, 66, 33, 32, 11, 20, 191, 34, 22, 155, 219, 195, 197, 197, 74, 130, 179, 237, 131, 219, 218, 0, 188, 145, 181, 60, 160, 173, 46, 1, 76, 109, 226, 66, 178, 34, 117, 17, 239, 245, 197, 176, 201, 13, 155, 60, 194, 172, 148, 12, 254, 50, 239, 9, 59, 242, 12, 102, 15, 38, 245, 24, 44, 221, 108, 171, 195, 159, 176, 229, 130, 74, 8, 86, 128, 174, 142, 210, 152, 239, 60, 112, 237, 192 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 17, 17, 523, DateTimeKind.Utc).AddTicks(1838), new byte[] { 205, 98, 218, 9, 36, 81, 26, 61, 35, 213, 83, 250, 155, 142, 109, 27, 140, 220, 86, 83, 141, 240, 102, 40, 154, 128, 78, 226, 214, 241, 129, 108, 241, 70, 202, 204, 254, 102, 184, 44, 180, 229, 28, 136, 1, 230, 93, 235, 170, 128, 61, 187, 6, 171, 100, 251, 219, 19, 131, 86, 237, 44, 247, 219 }, new byte[] { 144, 223, 213, 59, 202, 103, 114, 41, 10, 236, 249, 72, 225, 14, 154, 75, 12, 16, 220, 33, 197, 87, 84, 85, 54, 166, 28, 0, 41, 144, 155, 58, 76, 137, 128, 86, 197, 247, 42, 165, 52, 61, 140, 137, 102, 66, 33, 32, 11, 20, 191, 34, 22, 155, 219, 195, 197, 197, 74, 130, 179, 237, 131, 219, 218, 0, 188, 145, 181, 60, 160, 173, 46, 1, 76, 109, 226, 66, 178, 34, 117, 17, 239, 245, 197, 176, 201, 13, 155, 60, 194, 172, 148, 12, 254, 50, 239, 9, 59, 242, 12, 102, 15, 38, 245, 24, 44, 221, 108, 171, 195, 159, 176, 229, 130, 74, 8, 86, 128, 174, 142, 210, 152, 239, 60, 112, 237, 192 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 17, 17, 523, DateTimeKind.Utc).AddTicks(1842), new byte[] { 205, 98, 218, 9, 36, 81, 26, 61, 35, 213, 83, 250, 155, 142, 109, 27, 140, 220, 86, 83, 141, 240, 102, 40, 154, 128, 78, 226, 214, 241, 129, 108, 241, 70, 202, 204, 254, 102, 184, 44, 180, 229, 28, 136, 1, 230, 93, 235, 170, 128, 61, 187, 6, 171, 100, 251, 219, 19, 131, 86, 237, 44, 247, 219 }, new byte[] { 144, 223, 213, 59, 202, 103, 114, 41, 10, 236, 249, 72, 225, 14, 154, 75, 12, 16, 220, 33, 197, 87, 84, 85, 54, 166, 28, 0, 41, 144, 155, 58, 76, 137, 128, 86, 197, 247, 42, 165, 52, 61, 140, 137, 102, 66, 33, 32, 11, 20, 191, 34, 22, 155, 219, 195, 197, 197, 74, 130, 179, 237, 131, 219, 218, 0, 188, 145, 181, 60, 160, 173, 46, 1, 76, 109, 226, 66, 178, 34, 117, 17, 239, 245, 197, 176, 201, 13, 155, 60, 194, 172, 148, 12, 254, 50, 239, 9, 59, 242, 12, 102, 15, 38, 245, 24, 44, 221, 108, 171, 195, 159, 176, 229, 130, 74, 8, 86, 128, 174, 142, 210, 152, 239, 60, 112, 237, 192 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 17, 17, 523, DateTimeKind.Utc).AddTicks(1846), new byte[] { 205, 98, 218, 9, 36, 81, 26, 61, 35, 213, 83, 250, 155, 142, 109, 27, 140, 220, 86, 83, 141, 240, 102, 40, 154, 128, 78, 226, 214, 241, 129, 108, 241, 70, 202, 204, 254, 102, 184, 44, 180, 229, 28, 136, 1, 230, 93, 235, 170, 128, 61, 187, 6, 171, 100, 251, 219, 19, 131, 86, 237, 44, 247, 219 }, new byte[] { 144, 223, 213, 59, 202, 103, 114, 41, 10, 236, 249, 72, 225, 14, 154, 75, 12, 16, 220, 33, 197, 87, 84, 85, 54, 166, 28, 0, 41, 144, 155, 58, 76, 137, 128, 86, 197, 247, 42, 165, 52, 61, 140, 137, 102, 66, 33, 32, 11, 20, 191, 34, 22, 155, 219, 195, 197, 197, 74, 130, 179, 237, 131, 219, 218, 0, 188, 145, 181, 60, 160, 173, 46, 1, 76, 109, 226, 66, 178, 34, 117, 17, 239, 245, 197, 176, 201, 13, 155, 60, 194, 172, 148, 12, 254, 50, 239, 9, 59, 242, 12, 102, 15, 38, 245, 24, 44, 221, 108, 171, 195, 159, 176, 229, 130, 74, 8, 86, 128, 174, 142, 210, 152, 239, 60, 112, 237, 192 } });
        }
    }
}