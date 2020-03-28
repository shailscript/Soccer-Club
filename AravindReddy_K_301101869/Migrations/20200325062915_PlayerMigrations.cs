using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AravindReddy_K_301101869.Migrations
{
    public partial class PlayerMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayersinClub");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayersinClub",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    clubName = table.Column<string>(nullable: true),
                    playerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayersinClub", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayersinClub_clubitems_clubName",
                        column: x => x.clubName,
                        principalTable: "clubitems",
                        principalColumn: "clubName",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayersinClub_playeritems_playerName",
                        column: x => x.playerName,
                        principalTable: "playeritems",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayersinClub_clubName",
                table: "PlayersinClub",
                column: "clubName");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersinClub_playerName",
                table: "PlayersinClub",
                column: "playerName");
        }
    }
}
