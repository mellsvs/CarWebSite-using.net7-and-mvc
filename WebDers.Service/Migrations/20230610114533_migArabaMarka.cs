using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDers.Migrations
{
    /// <inheritdoc />
    public partial class migArabaMarka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_ArabaMarka_ArabaMarkaID",
                table: "Brands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArabaMarka",
                table: "ArabaMarka");

            migrationBuilder.RenameTable(
                name: "ArabaMarka",
                newName: "ArabaMarkas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArabaMarkas",
                table: "ArabaMarkas",
                column: "ArabaMarkaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_ArabaMarkas_ArabaMarkaID",
                table: "Brands",
                column: "ArabaMarkaID",
                principalTable: "ArabaMarkas",
                principalColumn: "ArabaMarkaID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_ArabaMarkas_ArabaMarkaID",
                table: "Brands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArabaMarkas",
                table: "ArabaMarkas");

            migrationBuilder.RenameTable(
                name: "ArabaMarkas",
                newName: "ArabaMarka");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArabaMarka",
                table: "ArabaMarka",
                column: "ArabaMarkaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_ArabaMarka_ArabaMarkaID",
                table: "Brands",
                column: "ArabaMarkaID",
                principalTable: "ArabaMarka",
                principalColumn: "ArabaMarkaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
