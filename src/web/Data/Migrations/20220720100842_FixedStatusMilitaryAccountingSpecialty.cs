using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class FixedStatusMilitaryAccountingSpecialty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoldierAndSergeantMilitaryAccountingSpecialties_CodeMilitaryAccountingSpecialties_CodeMilitaryAccountingSpecialtyId",
                table: "SoldierAndSergeantMilitaryAccountingSpecialties");

            migrationBuilder.DropIndex(
                name: "IX_SoldierAndSergeantMilitaryAccountingSpecialties_CodeMilitaryAccountingSpecialtyId",
                table: "SoldierAndSergeantMilitaryAccountingSpecialties");

            migrationBuilder.DropColumn(
                name: "CodeMilitaryAccountingSpecialtyId",
                table: "SoldierAndSergeantMilitaryAccountingSpecialties");

            migrationBuilder.AddColumn<int>(
                name: "SoldierAndSergeantMilitaryAccountingSpecialtiesId",
                table: "CodeMilitaryAccountingSpecialties",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CodeMilitaryAccountingSpecialties_SoldierAndSergeantMilitaryAccountingSpecialtiesId",
                table: "CodeMilitaryAccountingSpecialties",
                column: "SoldierAndSergeantMilitaryAccountingSpecialtiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CodeMilitaryAccountingSpecialties_SoldierAndSergeantMilitaryAccountingSpecialties_SoldierAndSergeantMilitaryAccountingSpecia~",
                table: "CodeMilitaryAccountingSpecialties",
                column: "SoldierAndSergeantMilitaryAccountingSpecialtiesId",
                principalTable: "SoldierAndSergeantMilitaryAccountingSpecialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeMilitaryAccountingSpecialties_SoldierAndSergeantMilitaryAccountingSpecialties_SoldierAndSergeantMilitaryAccountingSpecia~",
                table: "CodeMilitaryAccountingSpecialties");

            migrationBuilder.DropIndex(
                name: "IX_CodeMilitaryAccountingSpecialties_SoldierAndSergeantMilitaryAccountingSpecialtiesId",
                table: "CodeMilitaryAccountingSpecialties");

            migrationBuilder.DropColumn(
                name: "SoldierAndSergeantMilitaryAccountingSpecialtiesId",
                table: "CodeMilitaryAccountingSpecialties");

            migrationBuilder.AddColumn<int>(
                name: "CodeMilitaryAccountingSpecialtyId",
                table: "SoldierAndSergeantMilitaryAccountingSpecialties",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SoldierAndSergeantMilitaryAccountingSpecialties_CodeMilitaryAccountingSpecialtyId",
                table: "SoldierAndSergeantMilitaryAccountingSpecialties",
                column: "CodeMilitaryAccountingSpecialtyId");

            migrationBuilder.AddForeignKey(
                name: "FK_SoldierAndSergeantMilitaryAccountingSpecialties_CodeMilitaryAccountingSpecialties_CodeMilitaryAccountingSpecialtyId",
                table: "SoldierAndSergeantMilitaryAccountingSpecialties",
                column: "CodeMilitaryAccountingSpecialtyId",
                principalTable: "CodeMilitaryAccountingSpecialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
