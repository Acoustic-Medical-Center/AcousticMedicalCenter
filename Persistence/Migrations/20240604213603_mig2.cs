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
            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DoctorSpecializationId",
                table: "Doctors",
                column: "DoctorSpecializationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_DoctorSpecializations_DoctorSpecializationId",
                table: "Doctors",
                column: "DoctorSpecializationId",
                principalTable: "DoctorSpecializations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_DoctorSpecializations_DoctorSpecializationId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_DoctorSpecializationId",
                table: "Doctors");
        }
    }
}
