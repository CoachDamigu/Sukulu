using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sukulu.DataAccessLibrary.Migrations
{
    public partial class UserManagementChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "SKLClientUsers");

            migrationBuilder.AddColumn<long>(
                name: "SKLClientEcoleId",
                table: "SKLUsers",
                type: "bigint",
                nullable: true,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_SKLUsers_SKLClientEcoleId",
                table: "SKLUsers",
                column: "SKLClientEcoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SKLUsers_SKLClientEcoles_SKLClientEcoleId",
                table: "SKLUsers",
                column: "SKLClientEcoleId",
                principalTable: "SKLClientEcoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_SKLUsers_SKLClientEcoles_SKLClientEcoleId",
            //    table: "SKLUsers");

            //migrationBuilder.DropIndex(
            //    name: "IX_SKLUsers_SKLClientEcoleId",
            //    table: "SKLUsers");

            //migrationBuilder.DropColumn(
            //    name: "SKLClientEcoleId",
            //    table: "SKLUsers");

            //migrationBuilder.CreateTable(
            //    name: "SKLClientUsers",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        SKLClientId = table.Column<long>(type: "bigint", nullable: false),
            //        SKLUserId = table.Column<long>(type: "bigint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SKLClientUsers", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_SKLClientUsers_SKLClients_SKLClientId",
            //            column: x => x.SKLClientId,
            //            principalTable: "SKLClients",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_SKLClientUsers_SKLUsers_SKLUserId",
            //            column: x => x.SKLUserId,
            //            principalTable: "SKLUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_SKLClientUsers_SKLClientId",
            //    table: "SKLClientUsers",
            //    column: "SKLClientId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SKLClientUsers_SKLUserId",
            //    table: "SKLClientUsers",
            //    column: "SKLUserId");
        }
    }
}
