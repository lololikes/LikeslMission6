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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieName = table.Column<string>(nullable: true),
                    MovieCategoryId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Rating = table.Column<string>(nullable: true),
                    DirectorName = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_responses_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 4, "Horror" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 5, "Romance" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Id", "CategoryId", "DirectorName", "Edited", "LentTo", "MovieCategoryId", "MovieName", "Notes", "Rating", "Year" },
                values: new object[] { 1, null, "Tyler Nilson", false, null, 3, "The Peanut Butter Falcon", "Best Movie EVER!", "PG", 2019 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Id", "CategoryId", "DirectorName", "Edited", "LentTo", "MovieCategoryId", "MovieName", "Notes", "Rating", "Year" },
                values: new object[] { 2, null, "Gilbert Wong", true, "Abby Jensen", 5, "10 Things I Hate About You", null, "PG-13", 1999 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Id", "CategoryId", "DirectorName", "Edited", "LentTo", "MovieCategoryId", "MovieName", "Notes", "Rating", "Year" },
                values: new object[] { 3, null, "Joseph Kosinski", false, null, 1, "Top Gun: Maverick", "A thrill!!", "PG-13", 2022 });

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
