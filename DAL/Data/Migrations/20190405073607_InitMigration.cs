using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JOKRStore.DAL.Data.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    GameName = table.Column<string>(nullable: true),
                    Developer = table.Column<string>(nullable: true),
                    CoverArt = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Rate = table.Column<double>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Release = table.Column<DateTime>(nullable: false),
                    DownloadLink = table.Column<string>(nullable: true),
                    DemoLink = table.Column<string>(nullable: true),
                    NumOfDownloads = table.Column<int>(nullable: false),
                    MinSysReqId = table.Column<Guid>(nullable: true),
                    RecSysReqId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Registration = table.Column<DateTime>(nullable: false),
                    BankAccount = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    LastLogin = table.Column<DateTime>(nullable: false),
                    ConfigId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(nullable: false),
                    Commenter = table.Column<Guid>(nullable: false),
                    CommentDate = table.Column<DateTime>(nullable: false),
                    Contain = table.Column<string>(nullable: true),
                    GameId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_GameId",
                table: "Comments",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "StoreUsers");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
