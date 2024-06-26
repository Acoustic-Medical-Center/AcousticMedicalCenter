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
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeedbackMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9902), new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9912), new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9916), new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "DoctorSpecializations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 807, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 20, 57, 43, 806, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9584), new byte[] { 15, 146, 40, 79, 228, 15, 210, 36, 215, 250, 8, 49, 148, 120, 172, 179, 11, 106, 176, 60, 104, 240, 76, 181, 216, 186, 194, 118, 34, 199, 16, 92, 40, 48, 70, 95, 50, 87, 106, 3, 15, 138, 182, 155, 26, 250, 121, 189, 201, 117, 57, 17, 182, 165, 24, 215, 193, 95, 58, 247, 16, 217, 117, 160 }, new byte[] { 242, 78, 106, 6, 121, 25, 130, 133, 219, 160, 6, 45, 213, 8, 103, 129, 135, 195, 181, 17, 104, 203, 154, 99, 100, 234, 48, 48, 17, 29, 93, 210, 105, 240, 149, 187, 177, 165, 219, 78, 235, 192, 165, 236, 172, 193, 59, 34, 22, 172, 226, 28, 8, 62, 230, 83, 12, 255, 154, 57, 81, 175, 244, 144, 161, 111, 4, 52, 142, 115, 23, 78, 93, 43, 4, 244, 136, 38, 48, 195, 253, 46, 32, 90, 28, 143, 13, 130, 214, 237, 199, 131, 105, 202, 109, 75, 39, 15, 44, 169, 62, 203, 14, 25, 46, 132, 230, 116, 111, 61, 142, 198, 90, 26, 75, 36, 3, 87, 166, 131, 157, 183, 250, 155, 223, 240, 102, 185 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9593), new byte[] { 15, 146, 40, 79, 228, 15, 210, 36, 215, 250, 8, 49, 148, 120, 172, 179, 11, 106, 176, 60, 104, 240, 76, 181, 216, 186, 194, 118, 34, 199, 16, 92, 40, 48, 70, 95, 50, 87, 106, 3, 15, 138, 182, 155, 26, 250, 121, 189, 201, 117, 57, 17, 182, 165, 24, 215, 193, 95, 58, 247, 16, 217, 117, 160 }, new byte[] { 242, 78, 106, 6, 121, 25, 130, 133, 219, 160, 6, 45, 213, 8, 103, 129, 135, 195, 181, 17, 104, 203, 154, 99, 100, 234, 48, 48, 17, 29, 93, 210, 105, 240, 149, 187, 177, 165, 219, 78, 235, 192, 165, 236, 172, 193, 59, 34, 22, 172, 226, 28, 8, 62, 230, 83, 12, 255, 154, 57, 81, 175, 244, 144, 161, 111, 4, 52, 142, 115, 23, 78, 93, 43, 4, 244, 136, 38, 48, 195, 253, 46, 32, 90, 28, 143, 13, 130, 214, 237, 199, 131, 105, 202, 109, 75, 39, 15, 44, 169, 62, 203, 14, 25, 46, 132, 230, 116, 111, 61, 142, 198, 90, 26, 75, 36, 3, 87, 166, 131, 157, 183, 250, 155, 223, 240, 102, 185 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9597), new byte[] { 15, 146, 40, 79, 228, 15, 210, 36, 215, 250, 8, 49, 148, 120, 172, 179, 11, 106, 176, 60, 104, 240, 76, 181, 216, 186, 194, 118, 34, 199, 16, 92, 40, 48, 70, 95, 50, 87, 106, 3, 15, 138, 182, 155, 26, 250, 121, 189, 201, 117, 57, 17, 182, 165, 24, 215, 193, 95, 58, 247, 16, 217, 117, 160 }, new byte[] { 242, 78, 106, 6, 121, 25, 130, 133, 219, 160, 6, 45, 213, 8, 103, 129, 135, 195, 181, 17, 104, 203, 154, 99, 100, 234, 48, 48, 17, 29, 93, 210, 105, 240, 149, 187, 177, 165, 219, 78, 235, 192, 165, 236, 172, 193, 59, 34, 22, 172, 226, 28, 8, 62, 230, 83, 12, 255, 154, 57, 81, 175, 244, 144, 161, 111, 4, 52, 142, 115, 23, 78, 93, 43, 4, 244, 136, 38, 48, 195, 253, 46, 32, 90, 28, 143, 13, 130, 214, 237, 199, 131, 105, 202, 109, 75, 39, 15, 44, 169, 62, 203, 14, 25, 46, 132, 230, 116, 111, 61, 142, 198, 90, 26, 75, 36, 3, 87, 166, 131, 157, 183, 250, 155, 223, 240, 102, 185 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9601), new byte[] { 15, 146, 40, 79, 228, 15, 210, 36, 215, 250, 8, 49, 148, 120, 172, 179, 11, 106, 176, 60, 104, 240, 76, 181, 216, 186, 194, 118, 34, 199, 16, 92, 40, 48, 70, 95, 50, 87, 106, 3, 15, 138, 182, 155, 26, 250, 121, 189, 201, 117, 57, 17, 182, 165, 24, 215, 193, 95, 58, 247, 16, 217, 117, 160 }, new byte[] { 242, 78, 106, 6, 121, 25, 130, 133, 219, 160, 6, 45, 213, 8, 103, 129, 135, 195, 181, 17, 104, 203, 154, 99, 100, 234, 48, 48, 17, 29, 93, 210, 105, 240, 149, 187, 177, 165, 219, 78, 235, 192, 165, 236, 172, 193, 59, 34, 22, 172, 226, 28, 8, 62, 230, 83, 12, 255, 154, 57, 81, 175, 244, 144, 161, 111, 4, 52, 142, 115, 23, 78, 93, 43, 4, 244, 136, 38, 48, 195, 253, 46, 32, 90, 28, 143, 13, 130, 214, 237, 199, 131, 105, 202, 109, 75, 39, 15, 44, 169, 62, 203, 14, 25, 46, 132, 230, 116, 111, 61, 142, 198, 90, 26, 75, 36, 3, 87, 166, 131, 157, 183, 250, 155, 223, 240, 102, 185 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 57, 43, 806, DateTimeKind.Utc).AddTicks(9604), new byte[] { 15, 146, 40, 79, 228, 15, 210, 36, 215, 250, 8, 49, 148, 120, 172, 179, 11, 106, 176, 60, 104, 240, 76, 181, 216, 186, 194, 118, 34, 199, 16, 92, 40, 48, 70, 95, 50, 87, 106, 3, 15, 138, 182, 155, 26, 250, 121, 189, 201, 117, 57, 17, 182, 165, 24, 215, 193, 95, 58, 247, 16, 217, 117, 160 }, new byte[] { 242, 78, 106, 6, 121, 25, 130, 133, 219, 160, 6, 45, 213, 8, 103, 129, 135, 195, 181, 17, 104, 203, 154, 99, 100, 234, 48, 48, 17, 29, 93, 210, 105, 240, 149, 187, 177, 165, 219, 78, 235, 192, 165, 236, 172, 193, 59, 34, 22, 172, 226, 28, 8, 62, 230, 83, 12, 255, 154, 57, 81, 175, 244, 144, 161, 111, 4, 52, 142, 115, 23, 78, 93, 43, 4, 244, 136, 38, 48, 195, 253, 46, 32, 90, 28, 143, 13, 130, 214, 237, 199, 131, 105, 202, 109, 75, 39, 15, 44, 169, 62, 203, 14, 25, 46, 132, 230, 116, 111, 61, 142, 198, 90, 26, 75, 36, 3, 87, 166, 131, 157, 183, 250, 155, 223, 240, 102, 185 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

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

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5229));

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
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 18, 16, 44, 8, 993, DateTimeKind.Local).AddTicks(5485));

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
        }
    }
}
