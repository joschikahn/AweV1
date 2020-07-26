using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class TestdatenID1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "programme",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.InsertData(
                table: "programme",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "BA Wirtschaftsinformatik" });

            migrationBuilder.InsertData(
                table: "supervisors",
                columns: new[] { "Id", "Active", "Email", "FirstName", "LastName" },
                values: new object[] { 1, true, "maschneider@mail.mail", "Markus", "Schneider" });

            migrationBuilder.InsertData(
                table: "thesis",
                columns: new[] { "Id", "Bachelor", "ContentVal", "ContentWt", "Description", "DifficultyVal", "DifficultyWt", "Email", "Evaluation", "Filing", "Grade", "LastModified", "LayoutVal", "LayoutWt", "LiteratureVal", "LiteratureWt", "Master", "NoveltyVal", "NoveltyWt", "Points", "ProgrammeId", "Registration", "RichnessVal", "RichnessWt", "Status", "Strengths", "StructureVal", "StructureWt", "StudentFirstName", "StudentID", "StudentLastName", "StyleVal", "StyleWt", "Summary", "SupervisorId", "Title", "Type", "UploadFile", "Weaknesses" },
                values: new object[] { 1, true, 5, 30, "In diesem Paper geht es um verschiedene Vertriebskanäle", 5, 5, "joschikahn@web.de", "Unterm Strich eine gute strukturierte Arbeit nach vom Brocke zum Thema Omni Channel Retail.", new DateTime(2020, 7, 26, 16, 26, 4, 569, DateTimeKind.Local), 1, new DateTime(2020, 7, 26, 16, 26, 4, 569, DateTimeKind.Local), 5, 15, 5, 10, true, 5, 10, null, 1, new DateTime(2020, 7, 26, 16, 26, 4, 569, DateTimeKind.Local), 5, 10, 4, "Quellenarbeit, Zitieren und Synthese sind hervorragned ausgearbeitet.", 5, 10, "Josua", "2278467", "Homberger", 5, 10, "Omni Channel Retail eignet sich besonders für große Unternehemen. Eher ungeeignet in der Lebensmittelbranche.", 1, "Omni Channel Retail", 0, null, "Abstract und Fazit ausbaufähig." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "programme",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "programme",
                columns: new[] { "Id", "Name" },
                values: new object[] { 100, "BA Wirtschaftsinformatik" });

            migrationBuilder.InsertData(
                table: "supervisors",
                columns: new[] { "Id", "Active", "Email", "FirstName", "LastName" },
                values: new object[] { 100, true, "maschneider@mail.mail", "Markus", "Schneider" });

            migrationBuilder.InsertData(
                table: "thesis",
                columns: new[] { "Id", "Bachelor", "ContentVal", "ContentWt", "Description", "DifficultyVal", "DifficultyWt", "Email", "Evaluation", "Filing", "Grade", "LastModified", "LayoutVal", "LayoutWt", "LiteratureVal", "LiteratureWt", "Master", "NoveltyVal", "NoveltyWt", "Points", "ProgrammeId", "Registration", "RichnessVal", "RichnessWt", "Status", "Strengths", "StructureVal", "StructureWt", "StudentFirstName", "StudentID", "StudentLastName", "StyleVal", "StyleWt", "Summary", "SupervisorId", "Title", "Type", "UploadFile", "Weaknesses" },
                values: new object[] { 100, true, 5, 30, "In diesem Paper geht es um verschiedene Vertriebskanäle", 5, 5, "joschikahn@web.de", "Unterm Strich eine gute strukturierte Arbeit nach vom Brocke zum Thema Omni Channel Retail.", new DateTime(2020, 7, 26, 11, 56, 47, 486, DateTimeKind.Local), 1, new DateTime(2020, 7, 26, 11, 56, 47, 485, DateTimeKind.Local), 5, 15, 5, 10, true, 5, 10, null, 100, new DateTime(2020, 7, 26, 11, 56, 47, 486, DateTimeKind.Local), 5, 10, 4, "Quellenarbeit, Zitieren und Synthese sind hervorragned ausgearbeitet.", 5, 10, "Josua", "2278467", "Homberger", 5, 10, "Omni Channel Retail eignet sich besonders für große Unternehemen. Eher ungeeignet in der Lebensmittelbranche.", 100, "Omni Channel Retail", 0, null, "Abstract und Fazit ausbaufähig." });
        }
    }
}
