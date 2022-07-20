using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class AddedStatusMilitaryAccountingSpecialty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MilitaryAccountingSpecialtyId",
                table: "Status",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SoldierAndSergeantMilitaryAccountingSpecialtyId",
                table: "Status",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CodeMilitaryAccountingSpecialties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Letter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: false),
                    NeedToReimport = table.Column<bool>(type: "bit", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeMilitaryAccountingSpecialties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficerMilitaryAccountingSpecialties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: false),
                    NeedToReimport = table.Column<bool>(type: "bit", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficerMilitaryAccountingSpecialties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoldierAndSergeantMilitaryAccountingSpecialties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MilitaryAccountingSpecialty = table.Column<int>(type: "int", nullable: false),
                    CodeMilitaryAccountingSpecialtyId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: false),
                    NeedToReimport = table.Column<bool>(type: "bit", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldierAndSergeantMilitaryAccountingSpecialties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoldierAndSergeantMilitaryAccountingSpecialties_CodeMilitaryAccountingSpecialties_CodeMilitaryAccountingSpecialtyId",
                        column: x => x.CodeMilitaryAccountingSpecialtyId,
                        principalTable: "CodeMilitaryAccountingSpecialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Status_MilitaryAccountingSpecialtyId",
                table: "Status",
                column: "MilitaryAccountingSpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_Status_SoldierAndSergeantMilitaryAccountingSpecialtyId",
                table: "Status",
                column: "SoldierAndSergeantMilitaryAccountingSpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_SoldierAndSergeantMilitaryAccountingSpecialties_CodeMilitaryAccountingSpecialtyId",
                table: "SoldierAndSergeantMilitaryAccountingSpecialties",
                column: "CodeMilitaryAccountingSpecialtyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Status_OfficerMilitaryAccountingSpecialties_MilitaryAccountingSpecialtyId",
                table: "Status",
                column: "MilitaryAccountingSpecialtyId",
                principalTable: "OfficerMilitaryAccountingSpecialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Status_SoldierAndSergeantMilitaryAccountingSpecialties_SoldierAndSergeantMilitaryAccountingSpecialtyId",
                table: "Status",
                column: "SoldierAndSergeantMilitaryAccountingSpecialtyId",
                principalTable: "SoldierAndSergeantMilitaryAccountingSpecialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Status_OfficerMilitaryAccountingSpecialties_MilitaryAccountingSpecialtyId",
                table: "Status");

            migrationBuilder.DropForeignKey(
                name: "FK_Status_SoldierAndSergeantMilitaryAccountingSpecialties_SoldierAndSergeantMilitaryAccountingSpecialtyId",
                table: "Status");

            migrationBuilder.DropTable(
                name: "OfficerMilitaryAccountingSpecialties");

            migrationBuilder.DropTable(
                name: "SoldierAndSergeantMilitaryAccountingSpecialties");

            migrationBuilder.DropTable(
                name: "CodeMilitaryAccountingSpecialties");

            migrationBuilder.DropIndex(
                name: "IX_Status_MilitaryAccountingSpecialtyId",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Status_SoldierAndSergeantMilitaryAccountingSpecialtyId",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "MilitaryAccountingSpecialtyId",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "SoldierAndSergeantMilitaryAccountingSpecialtyId",
                table: "Status");
        }
    }
}
