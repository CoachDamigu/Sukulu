using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sukulu.DataAccessLibrary.Migrations
{
    public partial class EmploiDuTempsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoursPrevus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PortfolioEnseignantId = table.Column<long>(type: "bigint", nullable: false),
                    StatusCoursPrevu = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursPrevus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursPrevus_PortfolioEnseignants_PortfolioEnseignantId",
                        column: x => x.PortfolioEnseignantId,
                        principalTable: "PortfolioEnseignants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Presence",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoursPrevuId = table.Column<long>(type: "bigint", nullable: false),
                    EleveId = table.Column<long>(type: "bigint", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Presence_CoursPrevus_CoursPrevuId",
                        column: x => x.CoursPrevuId,
                        principalTable: "CoursPrevus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presence_Eleves_EleveId",
                        column: x => x.EleveId,
                        principalTable: "Eleves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoursPrevus_PortfolioEnseignantId",
                table: "CoursPrevus",
                column: "PortfolioEnseignantId");

            migrationBuilder.CreateIndex(
                name: "IX_Presence_CoursPrevuId",
                table: "Presence",
                column: "CoursPrevuId");

            migrationBuilder.CreateIndex(
                name: "IX_Presence_EleveId",
                table: "Presence",
                column: "EleveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presence");

            migrationBuilder.DropTable(
                name: "CoursPrevus");
        }
    }
}
