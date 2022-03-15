using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sukulu.DataAccessLibrary.Migrations
{
    public partial class UpdateSKLUserHash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "SKLUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "SKLUsers",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
