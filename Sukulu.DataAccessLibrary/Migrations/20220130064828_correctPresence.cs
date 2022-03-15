using Microsoft.EntityFrameworkCore.Migrations;

namespace Sukulu.DataAccessLibrary.Migrations
{
    public partial class correctPresence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presence_CoursPrevus_CoursPrevuId",
                table: "Presence");

            migrationBuilder.DropForeignKey(
                name: "FK_Presence_Eleves_EleveId",
                table: "Presence");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Presence",
                table: "Presence");

            migrationBuilder.RenameTable(
                name: "Presence",
                newName: "Presences");

            migrationBuilder.RenameIndex(
                name: "IX_Presence_EleveId",
                table: "Presences",
                newName: "IX_Presences_EleveId");

            migrationBuilder.RenameIndex(
                name: "IX_Presence_CoursPrevuId",
                table: "Presences",
                newName: "IX_Presences_CoursPrevuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Presences",
                table: "Presences",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Presences_CoursPrevus_CoursPrevuId",
                table: "Presences",
                column: "CoursPrevuId",
                principalTable: "CoursPrevus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Presences_Eleves_EleveId",
                table: "Presences",
                column: "EleveId",
                principalTable: "Eleves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presences_CoursPrevus_CoursPrevuId",
                table: "Presences");

            migrationBuilder.DropForeignKey(
                name: "FK_Presences_Eleves_EleveId",
                table: "Presences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Presences",
                table: "Presences");

            migrationBuilder.RenameTable(
                name: "Presences",
                newName: "Presence");

            migrationBuilder.RenameIndex(
                name: "IX_Presences_EleveId",
                table: "Presence",
                newName: "IX_Presence_EleveId");

            migrationBuilder.RenameIndex(
                name: "IX_Presences_CoursPrevuId",
                table: "Presence",
                newName: "IX_Presence_CoursPrevuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Presence",
                table: "Presence",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Presence_CoursPrevus_CoursPrevuId",
                table: "Presence",
                column: "CoursPrevuId",
                principalTable: "CoursPrevus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Presence_Eleves_EleveId",
                table: "Presence",
                column: "EleveId",
                principalTable: "Eleves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
