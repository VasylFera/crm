using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class AddNewAccountTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountConscriptId",
                table: "PersonalData",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountSergeantId",
                table: "PersonalData",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountSoldierId",
                table: "PersonalData",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccountConscrip",
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
                    table.PrimaryKey("PK_AccountConscrip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountOfficer",
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
                    table.PrimaryKey("PK_AccountOfficer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountSergeant",
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
                    table.PrimaryKey("PK_AccountSergeant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountSoldier",
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
                    table.PrimaryKey("PK_AccountSoldier", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_AccountConscriptId",
                table: "PersonalData",
                column: "AccountConscriptId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_AccountSergeantId",
                table: "PersonalData",
                column: "AccountSergeantId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_AccountSoldierId",
                table: "PersonalData",
                column: "AccountSoldierId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_AccountConscrip_AccountConscriptId",
                table: "PersonalData",
                column: "AccountConscriptId",
                principalTable: "AccountConscrip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_AccountSergeant_AccountSergeantId",
                table: "PersonalData",
                column: "AccountSergeantId",
                principalTable: "AccountSergeant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_AccountSoldier_AccountSoldierId",
                table: "PersonalData",
                column: "AccountSoldierId",
                principalTable: "AccountSoldier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_AccountConscrip_AccountConscriptId",
                table: "PersonalData");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_AccountSergeant_AccountSergeantId",
                table: "PersonalData");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_AccountSoldier_AccountSoldierId",
                table: "PersonalData");

            migrationBuilder.DropTable(
                name: "AccountConscrip");

            migrationBuilder.DropTable(
                name: "AccountOfficer");

            migrationBuilder.DropTable(
                name: "AccountSergeant");

            migrationBuilder.DropTable(
                name: "AccountSoldier");

            migrationBuilder.DropIndex(
                name: "IX_PersonalData_AccountConscriptId",
                table: "PersonalData");

            migrationBuilder.DropIndex(
                name: "IX_PersonalData_AccountSergeantId",
                table: "PersonalData");

            migrationBuilder.DropIndex(
                name: "IX_PersonalData_AccountSoldierId",
                table: "PersonalData");

            migrationBuilder.DropColumn(
                name: "AccountConscriptId",
                table: "PersonalData");

            migrationBuilder.DropColumn(
                name: "AccountSergeantId",
                table: "PersonalData");

            migrationBuilder.DropColumn(
                name: "AccountSoldierId",
                table: "PersonalData");
        }
    }
}
