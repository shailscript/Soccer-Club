using Microsoft.EntityFrameworkCore.Migrations;

namespace AravindReddy_K_301101869.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clubitems",
                columns: table => new
                {
                    clubName = table.Column<string>(nullable: false),
                    nation = table.Column<string>(nullable: true),
                    nWins = table.Column<int>(nullable: true),
                    nDraws = table.Column<int>(nullable: true),
                    totalPoints = table.Column<int>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    sponsor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clubitems", x => x.clubName);
                });

            migrationBuilder.CreateTable(
                name: "playeritems",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Club = table.Column<string>(nullable: true),
                    JersyNumber = table.Column<int>(nullable: false),
                    Rank = table.Column<int>(nullable: false),
                    totalGoals = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_playeritems", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clubitems");

            migrationBuilder.DropTable(
                name: "playeritems");
        }
    }
}
