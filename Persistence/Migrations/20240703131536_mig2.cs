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
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7649), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7658), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7663), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 7, 4, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7491), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7498), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7499), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7501), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7501), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7502), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7503), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7504), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7505), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7506), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7507), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7508), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7509), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7539), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7540), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7541), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7542), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7543), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7544), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7545), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7546), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7547), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7548), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7548), false });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7549), false });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 16, 15, 35, 941, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7212), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7222), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7226), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7230), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7231), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7233), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7234), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7236), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7237), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7239), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7240), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7241), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7243), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7244), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7246), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7247), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7249), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7250), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7252), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7253), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7255), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7256), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7257), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7259), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7260), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7262), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7263), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 7, 3, 13, 15, 35, 941, DateTimeKind.Utc).AddTicks(7278), new byte[] { 205, 82, 193, 236, 91, 243, 142, 33, 230, 132, 25, 131, 87, 210, 247, 87, 62, 155, 60, 142, 128, 33, 222, 78, 65, 214, 43, 15, 56, 62, 174, 167, 250, 54, 106, 45, 74, 191, 124, 152, 216, 144, 234, 173, 52, 201, 33, 71, 47, 58, 184, 72, 19, 218, 32, 7, 126, 101, 56, 234, 171, 145, 138, 70 }, new byte[] { 224, 144, 254, 193, 96, 154, 188, 45, 41, 219, 189, 119, 85, 223, 116, 38, 184, 40, 131, 123, 106, 139, 44, 227, 226, 149, 74, 40, 204, 47, 6, 185, 183, 147, 164, 67, 217, 140, 190, 69, 133, 12, 194, 137, 227, 31, 147, 149, 170, 185, 33, 118, 11, 43, 185, 63, 211, 19, 173, 172, 176, 166, 109, 237, 236, 231, 122, 47, 232, 138, 248, 161, 187, 177, 104, 134, 14, 105, 3, 169, 20, 135, 178, 177, 244, 159, 99, 249, 119, 232, 216, 128, 213, 0, 192, 213, 251, 48, 176, 137, 201, 130, 217, 99, 45, 4, 245, 227, 65, 101, 5, 192, 221, 4, 206, 240, 219, 37, 235, 200, 14, 85, 115, 118, 148, 147, 204, 82 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1640), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1652), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1656), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 10, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 10, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 11, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 12, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 13, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 14, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 15, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 30, 0, 0, DateTimeKind.Local), new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 27, 18, 13, 36, 530, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1049), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1059), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1063), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1068), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1070), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1072), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1073), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1075), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1077), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1079), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1081), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1083), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1084), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1086), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1088), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1090), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1092), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1094), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1095), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1097), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1099), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1101), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1103), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1105), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1107), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1108), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1110), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 13, 36, 530, DateTimeKind.Utc).AddTicks(1131), new byte[] { 134, 222, 48, 167, 155, 170, 154, 50, 4, 126, 7, 68, 171, 19, 111, 74, 143, 231, 32, 155, 142, 230, 156, 204, 96, 252, 141, 191, 75, 220, 201, 182, 170, 71, 156, 75, 170, 52, 40, 57, 12, 202, 124, 250, 144, 211, 23, 45, 172, 146, 146, 6, 160, 63, 163, 22, 46, 19, 204, 149, 34, 75, 170, 255 }, new byte[] { 146, 39, 212, 250, 132, 46, 232, 101, 224, 186, 12, 72, 127, 247, 44, 156, 233, 149, 45, 64, 156, 94, 50, 117, 37, 23, 220, 171, 53, 11, 169, 216, 40, 137, 164, 151, 5, 74, 93, 11, 151, 17, 178, 121, 136, 143, 70, 54, 76, 132, 123, 60, 220, 193, 22, 127, 46, 182, 236, 143, 84, 100, 252, 35, 47, 144, 67, 83, 106, 76, 161, 115, 67, 146, 53, 51, 143, 81, 253, 39, 115, 133, 83, 202, 30, 40, 111, 146, 243, 40, 67, 235, 50, 132, 51, 231, 44, 200, 74, 68, 95, 85, 39, 183, 34, 186, 77, 29, 202, 43, 246, 70, 207, 46, 248, 197, 244, 251, 30, 32, 168, 231, 234, 175, 97, 236, 219, 33 } });
        }
    }
}
