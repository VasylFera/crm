using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class AddNewAccountOfficerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountOfficerId",
                table: "PersonalData",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_AccountOfficerId",
                table: "PersonalData",
                column: "AccountOfficerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_AccountSergeant_AccountOfficerId",
                table: "PersonalData",
                column: "AccountOfficerId",
                principalTable: "AccountSergeant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_AccountSergeant_AccountOfficerId",
                table: "PersonalData");

            migrationBuilder.DropIndex(
                name: "IX_PersonalData_AccountOfficerId",
                table: "PersonalData");

            migrationBuilder.DropColumn(
                name: "AccountOfficerId",
                table: "PersonalData");
        }
    }
}
