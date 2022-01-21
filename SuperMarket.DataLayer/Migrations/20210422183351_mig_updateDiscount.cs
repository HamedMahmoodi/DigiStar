using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarket.DataLayer.Migrations
{
    public partial class mig_updateDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Percent",
                table: "Discounts");

            migrationBuilder.AddColumn<int>(
                name: "DiscountPercent",
                table: "Discounts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountPercent",
                table: "Discounts");

            migrationBuilder.AddColumn<int>(
                name: "Percent",
                table: "Discounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
