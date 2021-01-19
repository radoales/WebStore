using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.MVC.Migrations
{
    public partial class AddStockItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockItemId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StockItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockItem", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_StockItemId",
                table: "Products",
                column: "StockItemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_StockItem_StockItemId",
                table: "Products",
                column: "StockItemId",
                principalTable: "StockItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_StockItem_StockItemId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "StockItem");

            migrationBuilder.DropIndex(
                name: "IX_Products_StockItemId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StockItemId",
                table: "Products");
        }
    }
}
