using Microsoft.EntityFrameworkCore.Migrations;

namespace SoulFire.Migrations
{
    public partial class UserAchievementsDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievement_Achievements_AchievementId",
                table: "UserAchievement");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievement_Users_UserId",
                table: "UserAchievement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAchievement",
                table: "UserAchievement");

            migrationBuilder.RenameTable(
                name: "UserAchievement",
                newName: "UserAchievements");

            migrationBuilder.RenameIndex(
                name: "IX_UserAchievement_UserId",
                table: "UserAchievements",
                newName: "IX_UserAchievements_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAchievement_AchievementId",
                table: "UserAchievements",
                newName: "IX_UserAchievements_AchievementId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAchievements",
                table: "UserAchievements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievements_Achievements_AchievementId",
                table: "UserAchievements",
                column: "AchievementId",
                principalTable: "Achievements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievements_Users_UserId",
                table: "UserAchievements",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievements_Achievements_AchievementId",
                table: "UserAchievements");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAchievements_Users_UserId",
                table: "UserAchievements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAchievements",
                table: "UserAchievements");

            migrationBuilder.RenameTable(
                name: "UserAchievements",
                newName: "UserAchievement");

            migrationBuilder.RenameIndex(
                name: "IX_UserAchievements_UserId",
                table: "UserAchievement",
                newName: "IX_UserAchievement_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAchievements_AchievementId",
                table: "UserAchievement",
                newName: "IX_UserAchievement_AchievementId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAchievement",
                table: "UserAchievement",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievement_Achievements_AchievementId",
                table: "UserAchievement",
                column: "AchievementId",
                principalTable: "Achievements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAchievement_Users_UserId",
                table: "UserAchievement",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
