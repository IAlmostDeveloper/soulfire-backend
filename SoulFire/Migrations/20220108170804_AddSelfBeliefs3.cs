using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoulFire.Migrations
{
    public partial class AddSelfBeliefs3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SelfBeliefProofs_SelfBeliefs_SelfBeliefId",
                table: "SelfBeliefProofs");

            migrationBuilder.DropColumn(
                name: "BeliefId",
                table: "SelfBeliefProofs");

            migrationBuilder.AlterColumn<Guid>(
                name: "SelfBeliefId",
                table: "SelfBeliefProofs",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SelfBeliefProofs_SelfBeliefs_SelfBeliefId",
                table: "SelfBeliefProofs",
                column: "SelfBeliefId",
                principalTable: "SelfBeliefs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SelfBeliefProofs_SelfBeliefs_SelfBeliefId",
                table: "SelfBeliefProofs");

            migrationBuilder.AlterColumn<Guid>(
                name: "SelfBeliefId",
                table: "SelfBeliefProofs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "BeliefId",
                table: "SelfBeliefProofs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_SelfBeliefProofs_SelfBeliefs_SelfBeliefId",
                table: "SelfBeliefProofs",
                column: "SelfBeliefId",
                principalTable: "SelfBeliefs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
