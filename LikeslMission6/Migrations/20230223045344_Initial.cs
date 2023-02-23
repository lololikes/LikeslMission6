using Microsoft.EntityFrameworkCore.Migrations;

namespace LikeslMission6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieName = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Rating = table.Column<string>(nullable: true),
                    DirectorName = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_responses_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Horror" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 5, "Romance" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Id", "CategoryId", "DirectorName", "Edited", "LentTo", "MovieName", "Notes", "Rating", "Year" },
                values: new object[] { 3, 1, "Joseph Kosinski", false, null, "Top Gun: Maverick", "A thrill!!", "PG-13", 2022 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Id", "CategoryId", "DirectorName", "Edited", "LentTo", "MovieName", "Notes", "Rating", "Year" },
                values: new object[] { 1, 3, "Tyler Nilson", false, null, "The Peanut Butter Falcon", "Best Movie EVER!", "PG", 2019 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Id", "CategoryId", "DirectorName", "Edited", "LentTo", "MovieName", "Notes", "Rating", "Year" },
                values: new object[] { 2, 5, "Gilbert Wong", true, "Abby Jensen", "10 Things I Hate About You", null, "PG-13", 1999 });

            migrationBuilder.CreateIndex(
                name: "IX_responses_CategoryId",
                table: "responses",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
