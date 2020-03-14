using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ConfigEdit2_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Configs_CPU_CPUId",
                table: "Configs");

            migrationBuilder.DropForeignKey(
                name: "FK_Configs_GPU_GPUId",
                table: "Configs");

            migrationBuilder.DropForeignKey(
                name: "FK_Configs_OS_OSId",
                table: "Configs");

            migrationBuilder.DropForeignKey(
                name: "FK_SysReqCPU_CPU_CPUId",
                table: "SysReqCPU");

            migrationBuilder.DropForeignKey(
                name: "FK_SysReqGPU_GPU_GPUId",
                table: "SysReqGPU");

            migrationBuilder.DropForeignKey(
                name: "FK_SysReqOS_OS_OSId",
                table: "SysReqOS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OS",
                table: "OS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GPU",
                table: "GPU");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CPU",
                table: "CPU");

            migrationBuilder.RenameTable(
                name: "OS",
                newName: "OSes");

            migrationBuilder.RenameTable(
                name: "GPU",
                newName: "GPUs");

            migrationBuilder.RenameTable(
                name: "CPU",
                newName: "CPUs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OSes",
                table: "OSes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GPUs",
                table: "GPUs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CPUs",
                table: "CPUs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Configs_CPUs_CPUId",
                table: "Configs",
                column: "CPUId",
                principalTable: "CPUs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Configs_GPUs_GPUId",
                table: "Configs",
                column: "GPUId",
                principalTable: "GPUs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Configs_OSes_OSId",
                table: "Configs",
                column: "OSId",
                principalTable: "OSes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SysReqCPU_CPUs_CPUId",
                table: "SysReqCPU",
                column: "CPUId",
                principalTable: "CPUs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SysReqGPU_GPUs_GPUId",
                table: "SysReqGPU",
                column: "GPUId",
                principalTable: "GPUs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SysReqOS_OSes_OSId",
                table: "SysReqOS",
                column: "OSId",
                principalTable: "OSes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Configs_CPUs_CPUId",
                table: "Configs");

            migrationBuilder.DropForeignKey(
                name: "FK_Configs_GPUs_GPUId",
                table: "Configs");

            migrationBuilder.DropForeignKey(
                name: "FK_Configs_OSes_OSId",
                table: "Configs");

            migrationBuilder.DropForeignKey(
                name: "FK_SysReqCPU_CPUs_CPUId",
                table: "SysReqCPU");

            migrationBuilder.DropForeignKey(
                name: "FK_SysReqGPU_GPUs_GPUId",
                table: "SysReqGPU");

            migrationBuilder.DropForeignKey(
                name: "FK_SysReqOS_OSes_OSId",
                table: "SysReqOS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OSes",
                table: "OSes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GPUs",
                table: "GPUs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CPUs",
                table: "CPUs");

            migrationBuilder.RenameTable(
                name: "OSes",
                newName: "OS");

            migrationBuilder.RenameTable(
                name: "GPUs",
                newName: "GPU");

            migrationBuilder.RenameTable(
                name: "CPUs",
                newName: "CPU");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OS",
                table: "OS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GPU",
                table: "GPU",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CPU",
                table: "CPU",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SysReqCPU_CPU_CPUId",
                table: "SysReqCPU",
                column: "CPUId",
                principalTable: "CPU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SysReqGPU_GPU_GPUId",
                table: "SysReqGPU",
                column: "GPUId",
                principalTable: "GPU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SysReqOS_OS_OSId",
                table: "SysReqOS",
                column: "OSId",
                principalTable: "OS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
