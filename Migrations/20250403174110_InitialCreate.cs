using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimplyBooks_BE.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Favorite = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Sale = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthorsId = table.Column<int>(type: "integer", nullable: false),
                    BooksId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.AuthorsId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "UserName" },
                values: new object[,]
                {
                    { 1, "skylinevibe42@gmail.com", "skylineVibe42" },
                    { 2, "crimson.otter9@yahoo.com", "crimsonOtter9" },
                    { 3, "frostnova_88@outlook.com", "frostNova_88" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "Favorite", "FirstName", "Image", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, "lena.marquez@example.com", true, "Lena", "https://example.com/images/lena.jpg", "Marquez", 1 },
                    { 2, "jasper.thorne@example.com", false, "Jasper", "https://example.com/images/jasper.jpg", "Thorne", 2 },
                    { 3, "mira.ellwood@example.com", true, "Mira", "https://example.com/images/mira.jpg", "Ellwood", 3 },
                    { 4, "ronan.vale@example.com", false, "Ronan", "https://example.com/images/ronan.jpg", "Vale", 1 },
                    { 5, "tessa.hart@example.com", true, "Tessa", "https://example.com/images/tessa.jpg", "Hart", 2 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Image", "Price", "Sale", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "A journey through forgotten realms and memory.", "https://example.com/images/starlit.jpg", 19.99m, true, "The Starlit Archive", 1 },
                    { 2, 1, "Hope and loss in a fractured future.", "https://example.com/images/echoes.jpg", 15.49m, false, "Echoes of the Sun", 1 },
                    { 3, 2, "A detective uncovers more than just crime.", "https://example.com/images/fog.jpg", 12.00m, false, "Whispers in Fog", 2 },
                    { 4, 2, "A thriller told through the eyes of a blind photographer.", "https://example.com/images/lens.jpg", 18.25m, true, "The Ivory Lens", 2 },
                    { 5, 3, "A poetic journey through time.", "https://example.com/images/fragments.jpg", 9.99m, true, "Fragments of Tomorrow", 3 },
                    { 6, 4, "Dark fantasy meets introspective drama.", "https://example.com/images/reverie.jpg", 22.95m, false, "Midnight Reverie", 1 },
                    { 7, 4, "A city reborn from the flames of betrayal.", "https://example.com/images/ashes.jpg", 17.50m, true, "Ashes & Amber", 1 },
                    { 8, 5, "A librarian incites a revolution with banned books.", "https://example.com/images/rebellion.jpg", 13.75m, false, "The Quiet Rebellion", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_UserId",
                table: "Authors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserId",
                table: "Books",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
