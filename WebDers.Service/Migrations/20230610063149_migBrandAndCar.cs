using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDers.Migrations
{
    /// <inheritdoc />
    public partial class migBrandAndCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Yorumlars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ArabaMarkaID",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ArabaMarka",
                columns: table => new
                {
                    ArabaMarkaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabaMarkaName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaMarka", x => x.ArabaMarkaID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brands_ArabaMarkaID",
                table: "Brands",
                column: "ArabaMarkaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_ArabaMarka_ArabaMarkaID",
                table: "Brands",
                column: "ArabaMarkaID",
                principalTable: "ArabaMarka",
                principalColumn: "ArabaMarkaID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_ArabaMarka_ArabaMarkaID",
                table: "Brands");

            migrationBuilder.DropTable(
                name: "ArabaMarka");

            migrationBuilder.DropIndex(
                name: "IX_Brands_ArabaMarkaID",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Yorumlars");

            migrationBuilder.DropColumn(
                name: "ArabaMarkaID",
                table: "Brands");
        }
    }
}
