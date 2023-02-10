using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission_6_alley725.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    categoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    ratingId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.ratingId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    movieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(nullable: false),
                    ratingId = table.Column<int>(nullable: false),
                    categoryId = table.Column<int>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.movieId);
                    table.ForeignKey(
                        name: "FK_Movies_Category_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Category",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Ratings_ratingId",
                        column: x => x.ratingId,
                        principalTable: "Ratings",
                        principalColumn: "ratingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "categoryId", "category" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "categoryId", "category" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "categoryId", "category" },
                values: new object[] { 3, "Sports" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "categoryId", "category" },
                values: new object[] { 4, "Drama" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "categoryId", "category" },
                values: new object[] { 5, "Family" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "categoryId", "category" },
                values: new object[] { 6, "Horror/Suspense" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "categoryId", "category" },
                values: new object[] { 7, "Miscellaneous" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "categoryId", "category" },
                values: new object[] { 8, "Television" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "categoryId", "category" },
                values: new object[] { 9, "VHS" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "ratingId", "rating" },
                values: new object[] { 1, "G" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "ratingId", "rating" },
                values: new object[] { 2, "PG" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "ratingId", "rating" },
                values: new object[] { 3, "PG-13" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "ratingId", "rating" },
                values: new object[] { 4, "R" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "movieId", "categoryId", "edited", "lentTo", "notes", "ratingId", "title", "year" },
                values: new object[] { 1, 3, false, "", "My all-time favorite", 2, "Invincible", 2006 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "movieId", "categoryId", "edited", "lentTo", "notes", "ratingId", "title", "year" },
                values: new object[] { 2, 2, false, "", "", 3, "Tommy Boy", 1995 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "movieId", "categoryId", "edited", "lentTo", "notes", "ratingId", "title", "year" },
                values: new object[] { 3, 1, false, "", "", 3, "Top Gun: Maverick", 2022 });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_categoryId",
                table: "Movies",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ratingId",
                table: "Movies",
                column: "ratingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Ratings");
        }
    }
}
