using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoulFire.Migrations
{
    public partial class OpinionsAndThoughtsTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeepOpinions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeepOpinions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MiddleOpinions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiddleOpinions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThoughtsSimpleForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThoughtsSimpleForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThoughtsWritingForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThoughtsWritingForms", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeepOpinions");

            migrationBuilder.DropTable(
                name: "MiddleOpinions");

            migrationBuilder.DropTable(
                name: "ThoughtsSimpleForms");

            migrationBuilder.DropTable(
                name: "ThoughtsWritingForms");
        }
    }
}
