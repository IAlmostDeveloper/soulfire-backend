using Microsoft.EntityFrameworkCore.Migrations;

namespace SoulFire.Migrations
{
    public partial class AddSelfBelief9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "SelfBeliefs");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "SelfBeliefs");

            migrationBuilder.AddColumn<string>(
                name: "NewSelfBelief",
                table: "SelfBeliefs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NewSelfBeliefRule",
                table: "SelfBeliefs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OldSelfBelief",
                table: "SelfBeliefs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OldSelfBeliefRule",
                table: "SelfBeliefs",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewSelfBelief",
                table: "SelfBeliefs");

            migrationBuilder.DropColumn(
                name: "NewSelfBeliefRule",
                table: "SelfBeliefs");

            migrationBuilder.DropColumn(
                name: "OldSelfBelief",
                table: "SelfBeliefs");

            migrationBuilder.DropColumn(
                name: "OldSelfBeliefRule",
                table: "SelfBeliefs");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "SelfBeliefs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "SelfBeliefs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
