using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoulFire.Migrations
{
    public partial class AddSelfBeliefs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SelfBeliefs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelfBeliefs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SelfBeliefProofs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BeliefId = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    SelfBeliefId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelfBeliefProofs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelfBeliefProofs_SelfBeliefs_SelfBeliefId",
                        column: x => x.SelfBeliefId,
                        principalTable: "SelfBeliefs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SelfBeliefProofs_SelfBeliefId",
                table: "SelfBeliefProofs",
                column: "SelfBeliefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelfBeliefProofs");

            migrationBuilder.DropTable(
                name: "SelfBeliefs");
        }
    }
}
