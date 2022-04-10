using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoulFire.Migrations
{
    public partial class AddSelfBeliefs7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswers_Users_UserId",
                table: "UserAnswers");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswers_UserId",
                table: "UserAnswers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserAnswers");

            migrationBuilder.AddColumn<Guid>(
                name: "SelfBeliefId",
                table: "UserAnswers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_SelfBeliefId",
                table: "UserAnswers",
                column: "SelfBeliefId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswers_SelfBeliefs_SelfBeliefId",
                table: "UserAnswers",
                column: "SelfBeliefId",
                principalTable: "SelfBeliefs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswers_SelfBeliefs_SelfBeliefId",
                table: "UserAnswers");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswers_SelfBeliefId",
                table: "UserAnswers");

            migrationBuilder.DropColumn(
                name: "SelfBeliefId",
                table: "UserAnswers");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "UserAnswers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_UserId",
                table: "UserAnswers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswers_Users_UserId",
                table: "UserAnswers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
