using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scientific_Research_Center.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Addednamefieldtoregion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Regions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_RegionId",
                table: "Patients",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Regions_RegionId",
                table: "Patients",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Regions_RegionId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_RegionId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Patients");
        }
    }
}
