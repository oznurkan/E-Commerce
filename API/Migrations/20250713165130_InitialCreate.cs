using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Telefon açıklaması", "1.jpg", false, "Iphone 15", 70000m, 1 },
                    { 2, "Telefon açıklaması", "2.jpg", false, "Iphone 15 Pro", 78000m, 5 },
                    { 3, "Telefon açıklaması", "3.jpg", true, "Iphone 15 Pro Max", 85000m, 100 },
                    { 4, "Telefon açıklaması", "4.jpg", true, "Iphone 16", 890000m, 73 },
                    { 5, "Telefon açıklaması", "5.jpg", true, "Iphone 16 Pro", 90000m, 100 },
                    { 6, "Telefon açıklaması", "6.jpg", false, "Iphone 16 Pro Max", 100000m, 87 },
                    { 7, "Telefon açıklaması", "7.jpg", true, "Iphone 17", 120000m, 92 },
                    { 8, "Telefon açıklaması", "7.jpg", true, "Iphone 17 Pro", 130000m, 65 },
                    { 9, "Telefon açıklaması", "7.jpg", true, "Iphone 17 Pro Max", 150000m, 10 },
                    { 10, "Apple Watch Series", "1.jpg", true, "Apple Watch Series 1", 70000m, 100 },
                    { 11, "Telefon açıklaması", "2.jpg", true, "Apple Watch Series 2", 80000m, 100 },
                    { 12, "Telefon açıklaması", "3.jpg", false, "Apple Watch Series 3", 90000m, 100 },
                    { 13, "Telefon açıklaması", "4.jpg", true, "Xiaomi Redmi Watch 1", 100000m, 100 },
                    { 14, "Telefon açıklaması", "5.jpg", true, "Xiaomi Redmi Watch 2", 100000m, 100 },
                    { 15, "Telefon açıklaması", "6.jpg", true, "Xiaomi Redmi Watch 3", 100000m, 100 },
                    { 16, "Telefon açıklaması", "7.jpg", true, "Xiaomi Redmi Watch 4", 100000m, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
