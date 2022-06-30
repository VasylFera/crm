using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class AddOfficerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_AccountSergeant_AccountOfficerId",
                table: "PersonalData");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_AccountOfficer_AccountOfficerId",
                table: "PersonalData",
                column: "AccountOfficerId",
                principalTable: "AccountOfficer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_AccountOfficer_AccountOfficerId",
                table: "PersonalData");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_AccountSergeant_AccountOfficerId",
                table: "PersonalData",
                column: "AccountOfficerId",
                principalTable: "AccountSergeant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
