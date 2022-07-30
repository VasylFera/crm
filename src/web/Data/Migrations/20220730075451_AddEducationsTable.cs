using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class AddEducationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EducationDataGenerals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    ProfessionalTechnicalSchoolId = table.Column<int>(type: "int", nullable: false),
                    HigherEducationId = table.Column<int>(type: "int", nullable: false),
                    ProfessionalTechnicalMilitaryId = table.Column<int>(type: "int", nullable: false),
                    HigherEducationlMilitaryId = table.Column<int>(type: "int", nullable: false),
                    PersonalDataId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: false),
                    NeedToReimport = table.Column<bool>(type: "bit", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDataGenerals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationDataGenerals_PersonalData_PersonalDataId",
                        column: x => x.PersonalDataId,
                        principalTable: "PersonalData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationProfessionalTechnicalMilitarySchool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RVCReferralNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RVCReferralDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NameProfessionalTechnicalMilitarySchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialtyProfessionalTechnicalMilitarySchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationDataGeneralsId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: false),
                    NeedToReimport = table.Column<bool>(type: "bit", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationProfessionalTechnicalMilitarySchool", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationProfessionalTechnicalMilitarySchool_EducationDataGenerals_EducationDataGeneralsId",
                        column: x => x.EducationDataGeneralsId,
                        principalTable: "EducationDataGenerals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationProfessionalTechnicalSchool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusProfessionalTechnicalSchoolCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameProfessionalTechnicalSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriaProfessionalTechnicalSchoolCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberProfessionalTechnicalSchoolCertificate = table.Column<int>(type: "int", nullable: false),
                    SpecialtyProfessionalTechnicalSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationDataGeneralsId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: false),
                    NeedToReimport = table.Column<bool>(type: "bit", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationProfessionalTechnicalSchool", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationProfessionalTechnicalSchool_EducationDataGenerals_EducationDataGeneralsId",
                        column: x => x.EducationDataGeneralsId,
                        principalTable: "EducationDataGenerals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationSchool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusSchoolCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfClasses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriaSchoolCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberSchoolCertificate = table.Column<int>(type: "int", nullable: false),
                    EducationDataGeneralsId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: false),
                    NeedToReimport = table.Column<bool>(type: "bit", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationSchool", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationSchool_EducationDataGenerals_EducationDataGeneralsId",
                        column: x => x.EducationDataGeneralsId,
                        principalTable: "EducationDataGenerals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HigherEducation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusHigherEducationlCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameHigherEducation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriaHigherEducationCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberHigherEducationCertificate = table.Column<int>(type: "int", nullable: false),
                    SpecialtyHigherEducation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ТameOfTheMilitaryDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilitarySpecialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationDataGeneralsId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: false),
                    NeedToReimport = table.Column<bool>(type: "bit", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HigherEducation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HigherEducation_EducationDataGenerals_EducationDataGeneralsId",
                        column: x => x.EducationDataGeneralsId,
                        principalTable: "EducationDataGenerals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HigherEducationMilitary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusHigherEducationlMilitaryCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameHigherEducationMilitary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriaHigherEducationMilitaryCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberHigherEducationMilitaryCertificate = table.Column<int>(type: "int", nullable: false),
                    MilitarySpecialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationDataGeneralsId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsImported = table.Column<bool>(type: "bit", nullable: false),
                    NeedToReimport = table.Column<bool>(type: "bit", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HigherEducationMilitary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HigherEducationMilitary_EducationDataGenerals_EducationDataGeneralsId",
                        column: x => x.EducationDataGeneralsId,
                        principalTable: "EducationDataGenerals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationDataGenerals_PersonalDataId",
                table: "EducationDataGenerals",
                column: "PersonalDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationProfessionalTechnicalMilitarySchool_EducationDataGeneralsId",
                table: "EducationProfessionalTechnicalMilitarySchool",
                column: "EducationDataGeneralsId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationProfessionalTechnicalSchool_EducationDataGeneralsId",
                table: "EducationProfessionalTechnicalSchool",
                column: "EducationDataGeneralsId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationSchool_EducationDataGeneralsId",
                table: "EducationSchool",
                column: "EducationDataGeneralsId");

            migrationBuilder.CreateIndex(
                name: "IX_HigherEducation_EducationDataGeneralsId",
                table: "HigherEducation",
                column: "EducationDataGeneralsId");

            migrationBuilder.CreateIndex(
                name: "IX_HigherEducationMilitary_EducationDataGeneralsId",
                table: "HigherEducationMilitary",
                column: "EducationDataGeneralsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationProfessionalTechnicalMilitarySchool");

            migrationBuilder.DropTable(
                name: "EducationProfessionalTechnicalSchool");

            migrationBuilder.DropTable(
                name: "EducationSchool");

            migrationBuilder.DropTable(
                name: "HigherEducation");

            migrationBuilder.DropTable(
                name: "HigherEducationMilitary");

            migrationBuilder.DropTable(
                name: "EducationDataGenerals");
        }
    }
}
