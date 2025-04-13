using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationLayeredArchitecture.Migrations
{
    /// <inheritdoc />
    public partial class AddGenreToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "genreId",
                table: "movies",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    genre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genres", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_movies_genreId",
                table: "movies",
                column: "genreId");

            migrationBuilder.AddForeignKey(
                name: "FK_movies_genres_genreId",
                table: "movies",
                column: "genreId",
                principalTable: "genres",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movies_genres_genreId",
                table: "movies");

            migrationBuilder.DropTable(
                name: "genres");

            migrationBuilder.DropIndex(
                name: "IX_movies_genreId",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "genreId",
                table: "movies");
        }
    }
}
