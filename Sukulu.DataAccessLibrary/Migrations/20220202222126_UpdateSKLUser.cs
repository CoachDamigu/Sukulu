using Microsoft.EntityFrameworkCore.Migrations;

namespace Sukulu.DataAccessLibrary.Migrations
{
    public partial class UpdateSKLUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "SKLUsers");

            migrationBuilder.RenameColumn(
                name: "LatTimeLogging",
                table: "SKLUsers",
                newName: "LastTimeLogging");

            migrationBuilder.AddColumn<string>(
                name: "PasswordHashed",
                table: "SKLUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PasswordSalt",
                table: "SKLUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHashed",
                table: "SKLUsers");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "SKLUsers");

            migrationBuilder.RenameColumn(
                name: "LastTimeLogging",
                table: "SKLUsers",
                newName: "LatTimeLogging");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "SKLUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
