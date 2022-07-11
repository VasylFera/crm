using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class DeleteRelationShip1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_PersonalDataCountries_PersonalDataCountryId",
                table: "PersonalData");

            migrationBuilder.DropIndex(
                name: "IX_PersonalData_PersonalDataCountryId",
                table: "PersonalData");

            migrationBuilder.DropColumn(
                name: "PersonalDataCountryId",
                table: "PersonalData");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonalDataCountryId",
                table: "PersonalData",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_PersonalDataCountryId",
                table: "PersonalData",
                column: "PersonalDataCountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_PersonalDataCountries_PersonalDataCountryId",
                table: "PersonalData",
                column: "PersonalDataCountryId",
                principalTable: "PersonalDataCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
