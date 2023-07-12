using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDers.Migrations
{
    /// <inheritdoc />
    public partial class addcarblog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandPrice = table.Column<int>(type: "int", nullable: false),
                    BrandYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "CarBlogs",
                columns: table => new
                {
                    CarBlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarBlogTittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarBlogDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarBlogImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarBlogDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBlogs", x => x.CarBlogID);
                });

            migrationBuilder.CreateTable(
                name: "Hakkimizdas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkimizdas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mesaj = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserTel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Yorumlars",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumKullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YorumMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yorum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarBlogid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlars", x => x.YorumID);
                    table.ForeignKey(
                        name: "FK_Yorumlars_CarBlogs_CarBlogid",
                        column: x => x.CarBlogid,
                        principalTable: "CarBlogs",
                        principalColumn: "CarBlogID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sipariss",
                columns: table => new
                {
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sipariss", x => x.SiparisID);
                    table.ForeignKey(
                        name: "FK_Sipariss_Brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sipariss_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sipariss_BrandID",
                table: "Sipariss",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Sipariss_UserID",
                table: "Sipariss",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_CarBlogid",
                table: "Yorumlars",
                column: "CarBlogid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Hakkimizdas");

            migrationBuilder.DropTable(
                name: "Iletisims");

            migrationBuilder.DropTable(
                name: "Sipariss");

            migrationBuilder.DropTable(
                name: "Yorumlars");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CarBlogs");
        }
    }
}
