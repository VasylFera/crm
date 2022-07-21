using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class MilitaryAccountingSpecialtyLetterFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MilitaryAccountingSpecialtyLetteries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Letter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionLetter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeMilitaryAccountingSpecialtiesId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: false),
                    NeedToReimport = table.Column<bool>(type: "bit", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryAccountingSpecialtyLetteries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MilitaryAccountingSpecialtyLetteries_CodeMilitaryAccountingSpecialties_CodeMilitaryAccountingSpecialtiesId",
                        column: x => x.CodeMilitaryAccountingSpecialtiesId,
                        principalTable: "CodeMilitaryAccountingSpecialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MilitaryAccountingSpecialtyLetteries_CodeMilitaryAccountingSpecialtiesId",
                table: "MilitaryAccountingSpecialtyLetteries",
                column: "CodeMilitaryAccountingSpecialtiesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MilitaryAccountingSpecialtyLetteries");
        }
    }
}
