using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class AddCountryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Regions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: false),
                    NeedToReimport = table.Column<bool>(type: "bit", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Regions_CountryId",
                table: "Regions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_UserId",
                table: "Country",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Country_CountryId",
                table: "Regions",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Country_CountryId",
                table: "Regions");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Regions_CountryId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Regions");

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
    }
}
