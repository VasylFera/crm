using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class AddNewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullNameDriver",
                table: "Vehicles",
                newName: "FullNameDriver3");

            migrationBuilder.AddColumn<string>(
                name: "FullNameDriver1",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullNameDriver2",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullNameDriver1",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FullNameDriver2",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "FullNameDriver3",
                table: "Vehicles",
                newName: "FullNameDriver");
        }
    }
}
