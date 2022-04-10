using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoulFire.Migrations
{
    public partial class AddDiaryNotesHelp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaryNoteHelps",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    CanSkip = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryNoteHelps", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaryNoteHelps");
        }
    }
}
