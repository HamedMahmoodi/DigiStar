using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarket.DataLayer.Migrations
{
    public partial class mig_isDeleteProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentSites_Users_UserId",
                table: "CommentSites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommentSites",
                table: "CommentSites");

            migrationBuilder.RenameTable(
                name: "CommentSites",
                newName: "CommentSite");

            migrationBuilder.RenameIndex(
                name: "IX_CommentSites_UserId",
                table: "CommentSite",
                newName: "IX_CommentSite_UserId");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommentSite",
                table: "CommentSite",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentSite_Users_UserId",
                table: "CommentSite",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentSite_Users_UserId",
                table: "CommentSite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommentSite",
                table: "CommentSite");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "CommentSite",
                newName: "CommentSites");

            migrationBuilder.RenameIndex(
                name: "IX_CommentSite_UserId",
                table: "CommentSites",
                newName: "IX_CommentSites_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommentSites",
                table: "CommentSites",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentSites_Users_UserId",
                table: "CommentSites",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
