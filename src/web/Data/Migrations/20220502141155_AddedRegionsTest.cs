using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class AddedRegionsTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Villages_VillageId",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Districts_DistrictId",
                table: "Regions");

            migrationBuilder.DropIndex(
                name: "IX_Regions_DistrictId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Regions");

            migrationBuilder.RenameColumn(
                name: "VillageId",
                table: "Districts",
                newName: "RegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Districts_VillageId",
                table: "Districts",
                newName: "IX_Districts_RegionId");

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Villages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Villages_DistrictId",
                table: "Villages",
                column: "DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Regions_RegionId",
                table: "Districts",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Villages_Districts_DistrictId",
                table: "Villages",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Regions_RegionId",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_Villages_Districts_DistrictId",
                table: "Villages");

            migrationBuilder.DropIndex(
                name: "IX_Villages_DistrictId",
                table: "Villages");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Villages");

            migrationBuilder.RenameColumn(
                name: "RegionId",
                table: "Districts",
                newName: "VillageId");

            migrationBuilder.RenameIndex(
                name: "IX_Districts_RegionId",
                table: "Districts",
                newName: "IX_Districts_VillageId");

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Regions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regions_DistrictId",
                table: "Regions",
                column: "DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Villages_VillageId",
                table: "Districts",
                column: "VillageId",
                principalTable: "Villages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Districts_DistrictId",
                table: "Regions",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
