using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrescriptionStatus",
                table: "Prescriptions");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Prescriptions",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Prescriptions");

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionStatus",
                table: "Prescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5484), new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5492), new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5497), new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5501), new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 15, 17, 53, 31, 260, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5096), new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 }, new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5106), new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 }, new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5111), new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 }, new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5115), new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 }, new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 15, 14, 53, 31, 260, DateTimeKind.Utc).AddTicks(5119), new byte[] { 29, 160, 172, 114, 96, 139, 146, 241, 225, 111, 210, 137, 161, 36, 199, 163, 148, 8, 184, 196, 110, 103, 89, 134, 41, 9, 245, 22, 196, 204, 70, 147, 197, 28, 200, 176, 233, 3, 211, 100, 81, 118, 208, 6, 211, 207, 57, 16, 138, 227, 218, 237, 134, 49, 56, 1, 181, 63, 18, 70, 134, 63, 175, 108 }, new byte[] { 134, 10, 242, 26, 183, 60, 130, 149, 152, 227, 245, 27, 132, 125, 44, 231, 106, 232, 152, 157, 230, 121, 167, 25, 230, 91, 65, 141, 71, 178, 202, 225, 182, 102, 71, 28, 132, 175, 5, 170, 85, 156, 20, 212, 39, 65, 172, 242, 131, 12, 188, 212, 46, 44, 218, 124, 232, 118, 66, 148, 245, 92, 83, 25, 42, 164, 68, 178, 97, 104, 204, 39, 4, 17, 240, 18, 239, 236, 205, 168, 214, 114, 165, 98, 195, 169, 58, 235, 198, 124, 253, 145, 57, 232, 217, 208, 27, 202, 202, 247, 180, 192, 127, 196, 36, 177, 252, 220, 243, 24, 200, 222, 137, 47, 99, 220, 195, 64, 52, 181, 49, 207, 50, 192, 203, 148, 147, 75 } });
        }
    }
}
