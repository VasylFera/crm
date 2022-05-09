using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class FixedNewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Villages_Districts_DistrictId",
                table: "Villages");

            migrationBuilder.RenameColumn(
                name: "DistrictId",
                table: "Villages",
                newName: "OtgId");

            migrationBuilder.RenameIndex(
                name: "IX_Villages_DistrictId",
                table: "Villages",
                newName: "IX_Villages_OtgId");

            migrationBuilder.CreateTable(
                name: "Otgs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: false),
                    NeedToReimport = table.Column<bool>(type: "bit", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otgs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Otgs_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Otgs_DistrictId",
                table: "Otgs",
                column: "DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_Villages_Otgs_OtgId",
                table: "Villages",
                column: "OtgId",
                principalTable: "Otgs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Villages_Otgs_OtgId",
                table: "Villages");

            migrationBuilder.DropTable(
                name: "Otgs");

            migrationBuilder.RenameColumn(
                name: "OtgId",
                table: "Villages",
                newName: "DistrictId");

            migrationBuilder.RenameIndex(
                name: "IX_Villages_OtgId",
                table: "Villages",
                newName: "IX_Villages_DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_Villages_Districts_DistrictId",
                table: "Villages",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
