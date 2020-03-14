using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ConfigEdit_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Config_ConfigId",
                table: "AspNetUsers");*/

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Games_GameId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Config_CPU_CPUId",
                table: "Config");

            migrationBuilder.DropForeignKey(
                name: "FK_Config_GPU_GPUId",
                table: "Config");

            migrationBuilder.DropForeignKey(
                name: "FK_Config_OS_OSId",
                table: "Config");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Config",
                table: "Config");

            migrationBuilder.RenameTable(
                name: "Config",
                newName: "Configs");

            migrationBuilder.RenameIndex(
                name: "IX_Config_OSId",
                table: "Configs",
                newName: "IX_Configs_OSId");

            migrationBuilder.RenameIndex(
                name: "IX_Config_GPUId",
                table: "Configs",
                newName: "IX_Configs_GPUId");

            migrationBuilder.RenameIndex(
                name: "IX_Config_CPUId",
                table: "Configs",
                newName: "IX_Configs_CPUId");

            migrationBuilder.AlterColumn<Guid>(
                name: "GameId",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Configs",
                table: "Configs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Configs_ConfigId",
                table: "AspNetUsers",
                column: "ConfigId",
                principalTable: "Configs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Games_GameId",
                table: "Comments",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Configs_CPU_CPUId",
                table: "Configs",
                column: "CPUId",
                principalTable: "CPU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Configs_GPU_GPUId",
                table: "Configs",
                column: "GPUId",
                principalTable: "GPU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Configs_OS_OSId",
                table: "Configs",
                column: "OSId",
                principalTable: "OS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Configs_ConfigId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Games_GameId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Configs_CPU_CPUId",
                table: "Configs");

            migrationBuilder.DropForeignKey(
                name: "FK_Configs_GPU_GPUId",
                table: "Configs");

            migrationBuilder.DropForeignKey(
                name: "FK_Configs_OS_OSId",
                table: "Configs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Configs",
                table: "Configs");

            migrationBuilder.RenameTable(
                name: "Configs",
                newName: "Config");

            migrationBuilder.RenameIndex(
                name: "IX_Configs_OSId",
                table: "Config",
                newName: "IX_Config_OSId");

            migrationBuilder.RenameIndex(
                name: "IX_Configs_GPUId",
                table: "Config",
                newName: "IX_Config_GPUId");

            migrationBuilder.RenameIndex(
                name: "IX_Configs_CPUId",
                table: "Config",
                newName: "IX_Config_CPUId");

            migrationBuilder.AlterColumn<Guid>(
                name: "GameId",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Config",
                table: "Config",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Config_ConfigId",
                table: "AspNetUsers",
                column: "ConfigId",
                principalTable: "Config",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Games_GameId",
                table: "Comments",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Config_CPU_CPUId",
                table: "Config",
                column: "CPUId",
                principalTable: "CPU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Config_GPU_GPUId",
                table: "Config",
                column: "GPUId",
                principalTable: "GPU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Config_OS_OSId",
                table: "Config",
                column: "OSId",
                principalTable: "OS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
