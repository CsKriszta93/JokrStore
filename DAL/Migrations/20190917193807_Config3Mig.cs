using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Config3Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Configs_ConfigId",
                table: "AspNetUsers");

            /*migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ConfigId",
                table: "AspNetUsers");*/

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Configs",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ConfigId1",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ConfigId1",
                table: "AspNetUsers",
                column: "ConfigId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Configs_ConfigId1",
                table: "AspNetUsers",
                column: "ConfigId1",
                principalTable: "Configs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Configs_ConfigId1",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ConfigId1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Configs");

            migrationBuilder.DropColumn(
                name: "ConfigId1",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ConfigId",
                table: "AspNetUsers",
                column: "ConfigId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Configs_ConfigId",
                table: "AspNetUsers",
                column: "ConfigId",
                principalTable: "Configs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
