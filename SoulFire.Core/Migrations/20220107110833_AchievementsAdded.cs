using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoulFire.Migrations
{
    public partial class AchievementsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiaryNotes_Users_UserId",
                table: "DiaryNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievements_Achievements_AchievementId",
                table: "UserAchievements");

            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropIndex(
                name: "IX_UserAchievements_AchievementId",
                table: "UserAchievements");

            migrationBuilder.DropIndex(
                name: "IX_DiaryNotes_UserId",
                table: "DiaryNotes");

            migrationBuilder.DropColumn(
                name: "AchievementId",
                table: "UserAchievements");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "UserAchievements");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "UserAchievements",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "UserAchievements",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "UserAchievements",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "UserAchievements");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "UserAchievements");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "UserAchievements");

            migrationBuilder.AddColumn<Guid>(
                name: "AchievementId",
                table: "UserAchievements",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "UserAchievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_AchievementId",
                table: "UserAchievements",
                column: "AchievementId");

            migrationBuilder.CreateIndex(
                name: "IX_DiaryNotes_UserId",
                table: "DiaryNotes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiaryNotes_Users_UserId",
                table: "DiaryNotes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievements_Achievements_AchievementId",
                table: "UserAchievements",
                column: "AchievementId",
                principalTable: "Achievements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
