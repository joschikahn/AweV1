using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class finishedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "programme",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumns: new[] { "Id", "Filing", "LastModified", "Registration" },
                keyValues: new object[] { 1, new DateTime(2020, 7, 7, 14, 25, 17, 550, DateTimeKind.Local), new DateTime(2020, 7, 7, 14, 25, 17, 545, DateTimeKind.Local), new DateTime(2020, 7, 7, 14, 25, 17, 550, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "programme",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Dichtael Schwarz" });

            migrationBuilder.InsertData(
                table: "supervisors",
                columns: new[] { "Id", "Active", "Email", "FirstName", "LastName" },
                values: new object[] { 1, true, "mail@mail.mail", "Elliot", "Anderson" });

            migrationBuilder.InsertData(
                table: "thesis",
                columns: new[] { "Id", "Bachelor", "ContentVal", "ContentWt", "Description", "DifficultyVal", "DifficultyWt", "Email", "Evaluation", "Filing", "Grade", "LastModified", "LayoutVal", "LayoutWt", "LiteratureVal", "LiteratureWt", "Master", "NoveltyVal", "NoveltyWt", "ProgrammeId", "Registration", "RichnessVal", "RichnessWt", "Status", "Strengths", "StructureVal", "StructureWt", "StudentFirstName", "StudentID", "StudentLastName", "StyleVal", "StyleWt", "Summary", "SupervisorId", "Title", "Type", "Weaknesses" },
                values: new object[] { 1, true, 5, 30, "Wahnsinns Arbeit", 5, 5, "joschikahn@web.de", "war ganz ok", new DateTime(2020, 7, 7, 14, 25, 17, 550, DateTimeKind.Local), 1.0, new DateTime(2020, 7, 7, 14, 25, 17, 545, DateTimeKind.Local), 5, 15, 5, 10, true, 5, 10, null, new DateTime(2020, 7, 7, 14, 25, 17, 550, DateTimeKind.Local), 5, 10, 3, "Alles Super", 5, 10, "Tschoschi", 2278467, "Hamburger", 5, 10, "Es geht um Omni Channels", null, "Omni Channel Retail", 0, "Weak was?" });
        }
    }
}
