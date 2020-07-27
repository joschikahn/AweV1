using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class michaelsmiggi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Points",
                table: "thesis");

            migrationBuilder.InsertData(
                table: "programme",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 200, "BA Wirtschaftswissenschaften" },
                    { 201, "MA Information Systems" },
                    { 202, "MA Data Science" }
                });

            migrationBuilder.InsertData(
                table: "supervisors",
                columns: new[] { "Id", "Active", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 200, true, "mazimmerlin@web.de", "Max", "Zimmerlin" },
                    { 201, true, "groß@gmail.com", "Simone", "Groß" },
                    { 202, false, "lucian.bianco@gmx.com", "Lucia", "Bianco" }
                });

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Filing", "LastModified", "Registration" },
                values: new object[] { new DateTime(2020, 7, 27, 15, 39, 20, 545, DateTimeKind.Local), new DateTime(2020, 7, 27, 15, 39, 20, 544, DateTimeKind.Local), new DateTime(2020, 7, 27, 15, 39, 20, 545, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "thesis",
                columns: new[] { "Id", "Bachelor", "ContentVal", "ContentWt", "Description", "DifficultyVal", "DifficultyWt", "Email", "Evaluation", "Filing", "Grade", "LastModified", "LayoutVal", "LayoutWt", "LiteratureVal", "LiteratureWt", "Master", "NoveltyVal", "NoveltyWt", "ProgrammeId", "Registration", "RichnessVal", "RichnessWt", "Status", "Strengths", "StructureVal", "StructureWt", "StudentFirstName", "StudentID", "StudentLastName", "StyleVal", "StyleWt", "Summary", "SupervisorId", "Title", "Type", "UploadFile", "Weaknesses" },
                values: new object[] { 200, false, null, 30, "RPA gilt als die aufstrebende Technologie für die Automatisierung von Prozesse. In dieser Arbeit soll eine literarische Aufarbeitung von weiteren Möglichkeiten der Prozessautomatisierung erfolgen. Zusätzlich sollen qualitative Studien die aktuelle Situation aus der Praxis gegenüberstellen. Ziel soll die Einordnung von RPA im Vergleich zu anderen Technologien sein", null, 5, "claustern@web.de", "", new DateTime(2015, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 7, 27, 15, 39, 20, 547, DateTimeKind.Local), null, 15, null, 10, true, null, 10, 200, new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 3, "", null, 10, "Claudia", "2278467", "Stern", null, 10, "", 1, "Should you put all your Processes in one Basket?", 1, null, "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "programme",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "programme",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "programme",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "thesis",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Filing", "LastModified", "Registration" },
                values: new object[] { new DateTime(2020, 7, 26, 16, 26, 4, 569, DateTimeKind.Local), new DateTime(2020, 7, 26, 16, 26, 4, 569, DateTimeKind.Local), new DateTime(2020, 7, 26, 16, 26, 4, 569, DateTimeKind.Local) });
        }
    }
}
