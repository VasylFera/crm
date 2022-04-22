using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class AddUserIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PersonalData",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_UserId",
                table: "PersonalData",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_AspNetUsers_UserId",
                table: "PersonalData",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_AspNetUsers_UserId",
                table: "PersonalData");

            migrationBuilder.DropIndex(
                name: "IX_PersonalData_UserId",
                table: "PersonalData");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PersonalData");
        }
    }
}
