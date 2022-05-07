using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCatalog.Domain.Migrations
{
    public partial class Catalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoledId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RoledId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RoledId",
                table: "User");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RoleId",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "RoledId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_RoledId",
                table: "User",
                column: "RoledId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoledId",
                table: "User",
                column: "RoledId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
