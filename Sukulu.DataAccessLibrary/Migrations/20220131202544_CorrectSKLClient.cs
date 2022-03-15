using Microsoft.EntityFrameworkCore.Migrations;

namespace Sukulu.DataAccessLibrary.Migrations
{
    public partial class CorrectSKLClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SKLClientEcoles_SKLClient_SKLClientId",
                table: "SKLClientEcoles");

            migrationBuilder.DropForeignKey(
                name: "FK_SKLClientUsers_SKLClient_SKLClientId",
                table: "SKLClientUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SKLClient",
                table: "SKLClient");

            migrationBuilder.RenameTable(
                name: "SKLClient",
                newName: "SKLClients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SKLClients",
                table: "SKLClients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SKLClientEcoles_SKLClients_SKLClientId",
                table: "SKLClientEcoles",
                column: "SKLClientId",
                principalTable: "SKLClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SKLClientUsers_SKLClients_SKLClientId",
                table: "SKLClientUsers",
                column: "SKLClientId",
                principalTable: "SKLClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SKLClientEcoles_SKLClients_SKLClientId",
                table: "SKLClientEcoles");

            migrationBuilder.DropForeignKey(
                name: "FK_SKLClientUsers_SKLClients_SKLClientId",
                table: "SKLClientUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SKLClients",
                table: "SKLClients");

            migrationBuilder.RenameTable(
                name: "SKLClients",
                newName: "SKLClient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SKLClient",
                table: "SKLClient",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SKLClientEcoles_SKLClient_SKLClientId",
                table: "SKLClientEcoles",
                column: "SKLClientId",
                principalTable: "SKLClient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SKLClientUsers_SKLClient_SKLClientId",
                table: "SKLClientUsers",
                column: "SKLClientId",
                principalTable: "SKLClient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
