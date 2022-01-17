using Microsoft.EntityFrameworkCore.Migrations;

namespace Sukulu.DataAccessLibrary.Migrations
{
    public partial class SchoolCodeAndSystemeScolaireAddedToEcole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Ecoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "SystemeScolaireId",
                table: "Ecoles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Ecoles_SystemeScolaireId",
                table: "Ecoles",
                column: "SystemeScolaireId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ecoles_SystemeScolaires_SystemeScolaireId",
                table: "Ecoles",
                column: "SystemeScolaireId",
                principalTable: "SystemeScolaires",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ecoles_SystemeScolaires_SystemeScolaireId",
                table: "Ecoles");

            migrationBuilder.DropIndex(
                name: "IX_Ecoles_SystemeScolaireId",
                table: "Ecoles");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Ecoles");

            migrationBuilder.DropColumn(
                name: "SystemeScolaireId",
                table: "Ecoles");
        }
    }
}
