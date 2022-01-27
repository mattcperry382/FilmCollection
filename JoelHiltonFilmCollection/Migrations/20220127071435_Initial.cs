using Microsoft.EntityFrameworkCore.Migrations;

namespace JoelHiltonFilmCollection.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "collection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<string>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_collection", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "collection",
                columns: new[] { "Id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "John McTiernan", true, null, null, "R", "Predator", "1987" });

            migrationBuilder.InsertData(
                table: "collection",
                columns: new[] { "Id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Adventure", "Joss Whedon", false, null, null, "PG-13", "Avengers, The", "2012" });

            migrationBuilder.InsertData(
                table: "collection",
                columns: new[] { "Id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "Peter Jackson", false, null, null, "PG-13", "Lord of the Rings: The Return of the King, The", "2003" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "collection");
        }
    }
}
