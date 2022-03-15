using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sukulu.DataAccessLibrary.Migrations
{
    public partial class SKLClientEcoleUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SKLUsers_SKLClientEcoles_SKLClientEcoleId",
                table: "SKLUsers");

            migrationBuilder.DropIndex(
                name: "IX_SKLUsers_SKLClientEcoleId",
                table: "SKLUsers");

            migrationBuilder.DropColumn(
                name: "SKLClientEcoleId",
                table: "SKLUsers");

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "SKLClientEcoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "SKLClientEcoleUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKLClientEcoleId = table.Column<long>(type: "bigint", nullable: false),
                    SKLUserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SKLClientEcoleUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SKLClientEcoleUsers_SKLClientEcoles_SKLClientEcoleId",
                        column: x => x.SKLClientEcoleId,
                        principalTable: "SKLClientEcoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SKLClientEcoleUsers_SKLUsers_SKLUserId",
                        column: x => x.SKLUserId,
                        principalTable: "SKLUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SKLClientEcoleUsers_SKLClientEcoleId",
                table: "SKLClientEcoleUsers",
                column: "SKLClientEcoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SKLClientEcoleUsers_SKLUserId",
                table: "SKLClientEcoleUsers",
                column: "SKLUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SKLClientEcoleUsers");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "SKLClientEcoles");

            migrationBuilder.AddColumn<long>(
                name: "SKLClientEcoleId",
                table: "SKLUsers",
                type: "bigint",
                nullable: false,
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
    }
}
