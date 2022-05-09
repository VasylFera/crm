using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class AddedNewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Regions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regions_UserId",
                table: "Regions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_AspNetUsers_UserId",
                table: "Regions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regions_AspNetUsers_UserId",
                table: "Regions");

            migrationBuilder.DropIndex(
                name: "IX_Regions_UserId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Regions");
        }
    }
}
