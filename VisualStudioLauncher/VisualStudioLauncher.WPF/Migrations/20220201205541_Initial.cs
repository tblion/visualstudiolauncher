using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisualStudioLauncher.WPF.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LaunchLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Path = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LaunchItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Arguments = table.Column<string>(type: "TEXT", nullable: false),
                    ProgramItemId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LaunchItems_ProgramItems_ProgramItemId",
                        column: x => x.ProgramItemId,
                        principalTable: "ProgramItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LaunchItemLaunchList",
                columns: table => new
                {
                    LaunchItemsId = table.Column<int>(type: "INTEGER", nullable: false),
                    LaunchListsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaunchItemLaunchList", x => new { x.LaunchItemsId, x.LaunchListsId });
                    table.ForeignKey(
                        name: "FK_LaunchItemLaunchList_LaunchItems_LaunchItemsId",
                        column: x => x.LaunchItemsId,
                        principalTable: "LaunchItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaunchItemLaunchList_LaunchLists_LaunchListsId",
                        column: x => x.LaunchListsId,
                        principalTable: "LaunchLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LaunchItemLaunchList_LaunchListsId",
                table: "LaunchItemLaunchList",
                column: "LaunchListsId");

            migrationBuilder.CreateIndex(
                name: "IX_LaunchItems_ProgramItemId",
                table: "LaunchItems",
                column: "ProgramItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LaunchItemLaunchList");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "LaunchItems");

            migrationBuilder.DropTable(
                name: "LaunchLists");

            migrationBuilder.DropTable(
                name: "ProgramItems");
        }
    }
}
