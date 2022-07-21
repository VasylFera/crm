using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class DeleteFieldLetterForCodeMAS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Letter",
                table: "CodeMilitaryAccountingSpecialties");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Letter",
                table: "CodeMilitaryAccountingSpecialties",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
