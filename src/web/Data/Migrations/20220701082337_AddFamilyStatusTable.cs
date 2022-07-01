using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class AddFamilyStatusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaritalStatusNameId",
                table: "PersonalData",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MaritalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: false),
                    NeedToReimport = table.Column<bool>(type: "bit", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatuses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_MaritalStatusNameId",
                table: "PersonalData",
                column: "MaritalStatusNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_MaritalStatuses_MaritalStatusNameId",
                table: "PersonalData",
                column: "MaritalStatusNameId",
                principalTable: "MaritalStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_MaritalStatuses_MaritalStatusNameId",
                table: "PersonalData");

            migrationBuilder.DropTable(
                name: "MaritalStatuses");

            migrationBuilder.DropIndex(
                name: "IX_PersonalData_MaritalStatusNameId",
                table: "PersonalData");

            migrationBuilder.DropColumn(
                name: "MaritalStatusNameId",
                table: "PersonalData");
        }
    }
}
