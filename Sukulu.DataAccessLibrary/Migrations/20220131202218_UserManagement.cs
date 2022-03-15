using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sukulu.DataAccessLibrary.Migrations
{
    public partial class UserManagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SKLClient",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SKLClient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SKLUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstTimeLogging = table.Column<bool>(type: "bit", nullable: false),
                    AccountLocked = table.Column<bool>(type: "bit", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    LatTimeLogging = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SKLUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SKLClientEcoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKLClientId = table.Column<long>(type: "bigint", nullable: false),
                    EcoleId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SKLClientEcoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SKLClientEcoles_Ecoles_EcoleId",
                        column: x => x.EcoleId,
                        principalTable: "Ecoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SKLClientEcoles_SKLClient_SKLClientId",
                        column: x => x.SKLClientId,
                        principalTable: "SKLClient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SKLClientUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKLClientId = table.Column<long>(type: "bigint", nullable: false),
                    SKLUserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SKLClientUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SKLClientUsers_SKLClient_SKLClientId",
                        column: x => x.SKLClientId,
                        principalTable: "SKLClient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SKLClientUsers_SKLUsers_SKLUserId",
                        column: x => x.SKLUserId,
                        principalTable: "SKLUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SKLUserResources",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKLUserId = table.Column<long>(type: "bigint", nullable: false),
                    ResourceType = table.Column<int>(type: "int", nullable: false),
                    ResourceId = table.Column<long>(type: "bigint", nullable: false),
                    ResourceLocked = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SKLUserResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SKLUserResources_SKLUsers_SKLUserId",
                        column: x => x.SKLUserId,
                        principalTable: "SKLUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SKLClientEcoles_EcoleId",
                table: "SKLClientEcoles",
                column: "EcoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SKLClientEcoles_SKLClientId",
                table: "SKLClientEcoles",
                column: "SKLClientId");

            migrationBuilder.CreateIndex(
                name: "IX_SKLClientUsers_SKLClientId",
                table: "SKLClientUsers",
                column: "SKLClientId");

            migrationBuilder.CreateIndex(
                name: "IX_SKLClientUsers_SKLUserId",
                table: "SKLClientUsers",
                column: "SKLUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SKLUserResources_SKLUserId",
                table: "SKLUserResources",
                column: "SKLUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SKLClientEcoles");

            migrationBuilder.DropTable(
                name: "SKLClientUsers");

            migrationBuilder.DropTable(
                name: "SKLUserResources");

            migrationBuilder.DropTable(
                name: "SKLClient");

            migrationBuilder.DropTable(
                name: "SKLUsers");
        }
    }
}
