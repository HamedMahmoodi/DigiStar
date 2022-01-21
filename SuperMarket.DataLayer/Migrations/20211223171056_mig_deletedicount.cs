using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarket.DataLayer.Migrations
{
    public partial class mig_deletedicount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Discounts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Discounts");
        }
    }
}
