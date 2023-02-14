using Microsoft.EntityFrameworkCore.Migrations;

namespace LikeslMission6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    ApplicatioId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieName = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Rating = table.Column<string>(nullable: true),
                    DirectorName = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.ApplicatioId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicatioId", "Category", "DirectorName", "Edited", "LentTo", "MovieName", "Notes", "Rating", "Year" },
                values: new object[] { 1, "Adventure/Drama", "Tyler Nilson", false, null, "The Peanut Butter Falcon", "Best Movie EVER!", "PG", 2019 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicatioId", "Category", "DirectorName", "Edited", "LentTo", "MovieName", "Notes", "Rating", "Year" },
                values: new object[] { 2, "Romance/Comedy", "Gilbert Wong", true, "Abby Jensen", "10 Things I Hate About You", null, "PG-13", 1999 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicatioId", "Category", "DirectorName", "Edited", "LentTo", "MovieName", "Notes", "Rating", "Year" },
                values: new object[] { 3, "Action/Adventure", "Joseph Kosinski", false, null, "Top Gun: Maverick", "A thrill!!", "PG-13", 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
