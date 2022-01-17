using Microsoft.EntityFrameworkCore.Migrations;

namespace Sukulu.DataAccessLibrary.Migrations
{
    public partial class AddEnseignement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enseignement_SystemeScolaires_SystemeScolaireId",
                table: "Enseignement");

            migrationBuilder.DropForeignKey(
                name: "FK_Niveaus_Enseignement_EnseignementId",
                table: "Niveaus");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Enseignement_EnseignementId",
                table: "Series");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enseignement",
                table: "Enseignement");

            migrationBuilder.RenameTable(
                name: "Enseignement",
                newName: "Enseignements");

            migrationBuilder.RenameIndex(
                name: "IX_Enseignement_SystemeScolaireId",
                table: "Enseignements",
                newName: "IX_Enseignements_SystemeScolaireId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enseignements",
                table: "Enseignements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enseignements_SystemeScolaires_SystemeScolaireId",
                table: "Enseignements",
                column: "SystemeScolaireId",
                principalTable: "SystemeScolaires",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Niveaus_Enseignements_EnseignementId",
                table: "Niveaus",
                column: "EnseignementId",
                principalTable: "Enseignements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Enseignements_EnseignementId",
                table: "Series",
                column: "EnseignementId",
                principalTable: "Enseignements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enseignements_SystemeScolaires_SystemeScolaireId",
                table: "Enseignements");

            migrationBuilder.DropForeignKey(
                name: "FK_Niveaus_Enseignements_EnseignementId",
                table: "Niveaus");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Enseignements_EnseignementId",
                table: "Series");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enseignements",
                table: "Enseignements");

            migrationBuilder.RenameTable(
                name: "Enseignements",
                newName: "Enseignement");

            migrationBuilder.RenameIndex(
                name: "IX_Enseignements_SystemeScolaireId",
                table: "Enseignement",
                newName: "IX_Enseignement_SystemeScolaireId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enseignement",
                table: "Enseignement",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enseignement_SystemeScolaires_SystemeScolaireId",
                table: "Enseignement",
                column: "SystemeScolaireId",
                principalTable: "SystemeScolaires",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Niveaus_Enseignement_EnseignementId",
                table: "Niveaus",
                column: "EnseignementId",
                principalTable: "Enseignement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Enseignement_EnseignementId",
                table: "Series",
                column: "EnseignementId",
                principalTable: "Enseignement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
