using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission_6_alley725.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    movieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    category = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.movieId);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "movieId", "category", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Sports", false, "", "My all-time favorite", "PG", "Invincible", 2006 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "movieId", "category", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Comedy", false, "", "", "PG-13", "Tommy Boy", 1995 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "movieId", "category", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Action", false, "", "", "PG-13", "Top Gun: Maverick", 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
