using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6487), new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6497), new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6502), new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6508), new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5229), null, "Doctor", null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6008), new byte[] { 168, 242, 121, 130, 51, 108, 14, 70, 74, 240, 60, 154, 10, 240, 188, 159, 151, 242, 66, 101, 236, 128, 115, 125, 84, 215, 238, 5, 111, 199, 226, 241, 209, 215, 248, 168, 5, 49, 156, 239, 243, 162, 80, 174, 90, 10, 188, 63, 147, 177, 122, 244, 251, 48, 121, 53, 145, 200, 141, 46, 67, 137, 90, 86 }, new byte[] { 219, 243, 72, 62, 146, 57, 58, 61, 193, 65, 254, 50, 137, 141, 229, 58, 75, 226, 220, 200, 39, 118, 11, 156, 200, 249, 51, 187, 75, 161, 126, 124, 202, 166, 53, 123, 114, 145, 253, 166, 34, 156, 71, 42, 10, 153, 174, 7, 60, 136, 30, 39, 228, 238, 253, 226, 202, 4, 251, 63, 239, 152, 141, 161, 19, 255, 233, 145, 249, 224, 13, 43, 26, 95, 229, 108, 168, 30, 47, 154, 87, 190, 60, 159, 22, 42, 196, 65, 216, 124, 220, 174, 144, 14, 109, 85, 207, 149, 94, 112, 128, 226, 108, 166, 236, 56, 26, 202, 153, 66, 67, 250, 103, 47, 109, 22, 20, 33, 63, 241, 87, 167, 247, 79, 37, 156, 185, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6026), new byte[] { 168, 242, 121, 130, 51, 108, 14, 70, 74, 240, 60, 154, 10, 240, 188, 159, 151, 242, 66, 101, 236, 128, 115, 125, 84, 215, 238, 5, 111, 199, 226, 241, 209, 215, 248, 168, 5, 49, 156, 239, 243, 162, 80, 174, 90, 10, 188, 63, 147, 177, 122, 244, 251, 48, 121, 53, 145, 200, 141, 46, 67, 137, 90, 86 }, new byte[] { 219, 243, 72, 62, 146, 57, 58, 61, 193, 65, 254, 50, 137, 141, 229, 58, 75, 226, 220, 200, 39, 118, 11, 156, 200, 249, 51, 187, 75, 161, 126, 124, 202, 166, 53, 123, 114, 145, 253, 166, 34, 156, 71, 42, 10, 153, 174, 7, 60, 136, 30, 39, 228, 238, 253, 226, 202, 4, 251, 63, 239, 152, 141, 161, 19, 255, 233, 145, 249, 224, 13, 43, 26, 95, 229, 108, 168, 30, 47, 154, 87, 190, 60, 159, 22, 42, 196, 65, 216, 124, 220, 174, 144, 14, 109, 85, 207, 149, 94, 112, 128, 226, 108, 166, 236, 56, 26, 202, 153, 66, 67, 250, 103, 47, 109, 22, 20, 33, 63, 241, 87, 167, 247, 79, 37, 156, 185, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6031), new byte[] { 168, 242, 121, 130, 51, 108, 14, 70, 74, 240, 60, 154, 10, 240, 188, 159, 151, 242, 66, 101, 236, 128, 115, 125, 84, 215, 238, 5, 111, 199, 226, 241, 209, 215, 248, 168, 5, 49, 156, 239, 243, 162, 80, 174, 90, 10, 188, 63, 147, 177, 122, 244, 251, 48, 121, 53, 145, 200, 141, 46, 67, 137, 90, 86 }, new byte[] { 219, 243, 72, 62, 146, 57, 58, 61, 193, 65, 254, 50, 137, 141, 229, 58, 75, 226, 220, 200, 39, 118, 11, 156, 200, 249, 51, 187, 75, 161, 126, 124, 202, 166, 53, 123, 114, 145, 253, 166, 34, 156, 71, 42, 10, 153, 174, 7, 60, 136, 30, 39, 228, 238, 253, 226, 202, 4, 251, 63, 239, 152, 141, 161, 19, 255, 233, 145, 249, 224, 13, 43, 26, 95, 229, 108, 168, 30, 47, 154, 87, 190, 60, 159, 22, 42, 196, 65, 216, 124, 220, 174, 144, 14, 109, 85, 207, 149, 94, 112, 128, 226, 108, 166, 236, 56, 26, 202, 153, 66, 67, 250, 103, 47, 109, 22, 20, 33, 63, 241, 87, 167, 247, 79, 37, 156, 185, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6036), new byte[] { 168, 242, 121, 130, 51, 108, 14, 70, 74, 240, 60, 154, 10, 240, 188, 159, 151, 242, 66, 101, 236, 128, 115, 125, 84, 215, 238, 5, 111, 199, 226, 241, 209, 215, 248, 168, 5, 49, 156, 239, 243, 162, 80, 174, 90, 10, 188, 63, 147, 177, 122, 244, 251, 48, 121, 53, 145, 200, 141, 46, 67, 137, 90, 86 }, new byte[] { 219, 243, 72, 62, 146, 57, 58, 61, 193, 65, 254, 50, 137, 141, 229, 58, 75, 226, 220, 200, 39, 118, 11, 156, 200, 249, 51, 187, 75, 161, 126, 124, 202, 166, 53, 123, 114, 145, 253, 166, 34, 156, 71, 42, 10, 153, 174, 7, 60, 136, 30, 39, 228, 238, 253, 226, 202, 4, 251, 63, 239, 152, 141, 161, 19, 255, 233, 145, 249, 224, 13, 43, 26, 95, 229, 108, 168, 30, 47, 154, 87, 190, 60, 159, 22, 42, 196, 65, 216, 124, 220, 174, 144, 14, 109, 85, 207, 149, 94, 112, 128, 226, 108, 166, 236, 56, 26, 202, 153, 66, 67, 250, 103, 47, 109, 22, 20, 33, 63, 241, 87, 167, 247, 79, 37, 156, 185, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 18, 13, 44, 8, 993, DateTimeKind.Utc).AddTicks(6040), new byte[] { 168, 242, 121, 130, 51, 108, 14, 70, 74, 240, 60, 154, 10, 240, 188, 159, 151, 242, 66, 101, 236, 128, 115, 125, 84, 215, 238, 5, 111, 199, 226, 241, 209, 215, 248, 168, 5, 49, 156, 239, 243, 162, 80, 174, 90, 10, 188, 63, 147, 177, 122, 244, 251, 48, 121, 53, 145, 200, 141, 46, 67, 137, 90, 86 }, new byte[] { 219, 243, 72, 62, 146, 57, 58, 61, 193, 65, 254, 50, 137, 141, 229, 58, 75, 226, 220, 200, 39, 118, 11, 156, 200, 249, 51, 187, 75, 161, 126, 124, 202, 166, 53, 123, 114, 145, 253, 166, 34, 156, 71, 42, 10, 153, 174, 7, 60, 136, 30, 39, 228, 238, 253, 226, 202, 4, 251, 63, 239, 152, 141, 161, 19, 255, 233, 145, 249, 224, 13, 43, 26, 95, 229, 108, 168, 30, 47, 154, 87, 190, 60, 159, 22, 42, 196, 65, 216, 124, 220, 174, 144, 14, 109, 85, 207, 149, 94, 112, 128, 226, 108, 166, 236, 56, 26, 202, 153, 66, 67, 250, 103, 47, 109, 22, 20, 33, 63, 241, 87, 167, 247, 79, 37, 156, 185, 93 } });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5479), null, 3, null, 3 },
                    { 4, new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5485), null, 3, null, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4448), new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4461), new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4461) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4466), new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 45, 26, 914, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 45, 26, 914, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 45, 26, 914, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 45, 26, 914, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 20, 45, 26, 914, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 45, 26, 914, DateTimeKind.Utc).AddTicks(3807), new byte[] { 8, 98, 168, 233, 114, 94, 114, 135, 56, 247, 193, 31, 110, 161, 41, 65, 175, 25, 59, 202, 116, 167, 171, 84, 83, 34, 111, 74, 8, 108, 155, 33, 60, 202, 54, 23, 129, 32, 160, 191, 143, 124, 109, 6, 191, 11, 151, 184, 133, 7, 7, 207, 17, 68, 191, 160, 0, 230, 128, 242, 60, 95, 226, 172 }, new byte[] { 208, 63, 45, 16, 117, 214, 241, 53, 46, 9, 194, 87, 29, 57, 80, 172, 127, 54, 179, 180, 213, 149, 231, 52, 128, 64, 209, 80, 35, 57, 202, 205, 228, 235, 13, 222, 71, 184, 31, 201, 194, 100, 29, 219, 102, 81, 243, 117, 67, 58, 222, 221, 149, 243, 71, 6, 42, 132, 119, 246, 50, 140, 129, 4, 62, 219, 130, 18, 135, 199, 50, 9, 41, 118, 212, 59, 148, 116, 142, 142, 230, 211, 123, 13, 100, 187, 78, 5, 32, 179, 57, 243, 122, 101, 4, 14, 211, 47, 188, 94, 156, 223, 21, 33, 138, 60, 117, 151, 250, 33, 243, 92, 241, 137, 212, 173, 38, 76, 190, 8, 85, 84, 164, 37, 97, 100, 119, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 45, 26, 914, DateTimeKind.Utc).AddTicks(3824), new byte[] { 8, 98, 168, 233, 114, 94, 114, 135, 56, 247, 193, 31, 110, 161, 41, 65, 175, 25, 59, 202, 116, 167, 171, 84, 83, 34, 111, 74, 8, 108, 155, 33, 60, 202, 54, 23, 129, 32, 160, 191, 143, 124, 109, 6, 191, 11, 151, 184, 133, 7, 7, 207, 17, 68, 191, 160, 0, 230, 128, 242, 60, 95, 226, 172 }, new byte[] { 208, 63, 45, 16, 117, 214, 241, 53, 46, 9, 194, 87, 29, 57, 80, 172, 127, 54, 179, 180, 213, 149, 231, 52, 128, 64, 209, 80, 35, 57, 202, 205, 228, 235, 13, 222, 71, 184, 31, 201, 194, 100, 29, 219, 102, 81, 243, 117, 67, 58, 222, 221, 149, 243, 71, 6, 42, 132, 119, 246, 50, 140, 129, 4, 62, 219, 130, 18, 135, 199, 50, 9, 41, 118, 212, 59, 148, 116, 142, 142, 230, 211, 123, 13, 100, 187, 78, 5, 32, 179, 57, 243, 122, 101, 4, 14, 211, 47, 188, 94, 156, 223, 21, 33, 138, 60, 117, 151, 250, 33, 243, 92, 241, 137, 212, 173, 38, 76, 190, 8, 85, 84, 164, 37, 97, 100, 119, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 45, 26, 914, DateTimeKind.Utc).AddTicks(3829), new byte[] { 8, 98, 168, 233, 114, 94, 114, 135, 56, 247, 193, 31, 110, 161, 41, 65, 175, 25, 59, 202, 116, 167, 171, 84, 83, 34, 111, 74, 8, 108, 155, 33, 60, 202, 54, 23, 129, 32, 160, 191, 143, 124, 109, 6, 191, 11, 151, 184, 133, 7, 7, 207, 17, 68, 191, 160, 0, 230, 128, 242, 60, 95, 226, 172 }, new byte[] { 208, 63, 45, 16, 117, 214, 241, 53, 46, 9, 194, 87, 29, 57, 80, 172, 127, 54, 179, 180, 213, 149, 231, 52, 128, 64, 209, 80, 35, 57, 202, 205, 228, 235, 13, 222, 71, 184, 31, 201, 194, 100, 29, 219, 102, 81, 243, 117, 67, 58, 222, 221, 149, 243, 71, 6, 42, 132, 119, 246, 50, 140, 129, 4, 62, 219, 130, 18, 135, 199, 50, 9, 41, 118, 212, 59, 148, 116, 142, 142, 230, 211, 123, 13, 100, 187, 78, 5, 32, 179, 57, 243, 122, 101, 4, 14, 211, 47, 188, 94, 156, 223, 21, 33, 138, 60, 117, 151, 250, 33, 243, 92, 241, 137, 212, 173, 38, 76, 190, 8, 85, 84, 164, 37, 97, 100, 119, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 45, 26, 914, DateTimeKind.Utc).AddTicks(3836), new byte[] { 8, 98, 168, 233, 114, 94, 114, 135, 56, 247, 193, 31, 110, 161, 41, 65, 175, 25, 59, 202, 116, 167, 171, 84, 83, 34, 111, 74, 8, 108, 155, 33, 60, 202, 54, 23, 129, 32, 160, 191, 143, 124, 109, 6, 191, 11, 151, 184, 133, 7, 7, 207, 17, 68, 191, 160, 0, 230, 128, 242, 60, 95, 226, 172 }, new byte[] { 208, 63, 45, 16, 117, 214, 241, 53, 46, 9, 194, 87, 29, 57, 80, 172, 127, 54, 179, 180, 213, 149, 231, 52, 128, 64, 209, 80, 35, 57, 202, 205, 228, 235, 13, 222, 71, 184, 31, 201, 194, 100, 29, 219, 102, 81, 243, 117, 67, 58, 222, 221, 149, 243, 71, 6, 42, 132, 119, 246, 50, 140, 129, 4, 62, 219, 130, 18, 135, 199, 50, 9, 41, 118, 212, 59, 148, 116, 142, 142, 230, 211, 123, 13, 100, 187, 78, 5, 32, 179, 57, 243, 122, 101, 4, 14, 211, 47, 188, 94, 156, 223, 21, 33, 138, 60, 117, 151, 250, 33, 243, 92, 241, 137, 212, 173, 38, 76, 190, 8, 85, 84, 164, 37, 97, 100, 119, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 45, 26, 914, DateTimeKind.Utc).AddTicks(3840), new byte[] { 8, 98, 168, 233, 114, 94, 114, 135, 56, 247, 193, 31, 110, 161, 41, 65, 175, 25, 59, 202, 116, 167, 171, 84, 83, 34, 111, 74, 8, 108, 155, 33, 60, 202, 54, 23, 129, 32, 160, 191, 143, 124, 109, 6, 191, 11, 151, 184, 133, 7, 7, 207, 17, 68, 191, 160, 0, 230, 128, 242, 60, 95, 226, 172 }, new byte[] { 208, 63, 45, 16, 117, 214, 241, 53, 46, 9, 194, 87, 29, 57, 80, 172, 127, 54, 179, 180, 213, 149, 231, 52, 128, 64, 209, 80, 35, 57, 202, 205, 228, 235, 13, 222, 71, 184, 31, 201, 194, 100, 29, 219, 102, 81, 243, 117, 67, 58, 222, 221, 149, 243, 71, 6, 42, 132, 119, 246, 50, 140, 129, 4, 62, 219, 130, 18, 135, 199, 50, 9, 41, 118, 212, 59, 148, 116, 142, 142, 230, 211, 123, 13, 100, 187, 78, 5, 32, 179, 57, 243, 122, 101, 4, 14, 211, 47, 188, 94, 156, 223, 21, 33, 138, 60, 117, 151, 250, 33, 243, 92, 241, 137, 212, 173, 38, 76, 190, 8, 85, 84, 164, 37, 97, 100, 119, 149 } });
        }
    }
}
