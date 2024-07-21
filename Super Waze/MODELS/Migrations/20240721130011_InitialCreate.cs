using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id_Customer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id_Customer);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id_Product = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Count_Products = table.Column<int>(type: "int", nullable: false),
                    Id_Shop = table.Column<int>(type: "int", nullable: false),
                    CustomerId_Customer = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id_Product);
                    table.ForeignKey(
                        name: "FK_Product_Customer_CustomerId_Customer",
                        column: x => x.CustomerId_Customer,
                        principalTable: "Customer",
                        principalColumn: "Id_Customer");
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    Id_Shop = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId_Customer = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.Id_Shop);
                    table.ForeignKey(
                        name: "FK_Shop_Customer_CustomerId_Customer",
                        column: x => x.CustomerId_Customer,
                        principalTable: "Customer",
                        principalColumn: "Id_Customer");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CustomerId_Customer",
                table: "Product",
                column: "CustomerId_Customer");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_CustomerId_Customer",
                table: "Shop",
                column: "CustomerId_Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
