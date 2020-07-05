using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumns: new[] { "Id", "Filing", "LastModified", "Registration" },
                keyValues: new object[] { 1, new DateTime(2020, 7, 5, 22, 38, 2, 683, DateTimeKind.Local), new DateTime(2020, 7, 5, 22, 38, 2, 680, DateTimeKind.Local), new DateTime(2020, 7, 5, 22, 38, 2, 683, DateTimeKind.Local) });

            migrationBuilder.RenameColumn(
                name: "type",
                table: "thesis",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "StudenLastName",
                table: "thesis",
                newName: "StudentLastName");

            migrationBuilder.InsertData(
                table: "thesis",
                columns: new[] { "Id", "ContentVal", "ContentWt", "Description", "DifficultyVal", "DifficultyWt", "Email", "Evaluation", "Filing", "Grade", "LastModified", "LayoutVal", "LayoutWt", "LiteratureVal", "LiteratureWt", "NoveltyVal", "NoveltyWt", "ProgrammeId", "Registration", "RichnessVal", "RichnessWt", "Status", "Strengths", "StructureVal", "StructureWt", "StudentFirstName", "StudentID", "StudentLastName", "StyleVal", "StyleWt", "Summary", "SupervisorId", "Title", "Type", "Weaknesses" },
                values: new object[] { 1, 5, 0, "Wahnsinns Arbeit", 200, 0, "joschikahn@web.de", "war ganz ok", new DateTime(2020, 7, 5, 23, 30, 11, 932, DateTimeKind.Local), 1m, new DateTime(2020, 7, 5, 23, 30, 11, 928, DateTimeKind.Local), 5, 0, 5, 0, 5, 0, null, new DateTime(2020, 7, 5, 23, 30, 11, 932, DateTimeKind.Local), 5, 0, 3, "Alles Super", 5, 0, "Tschoschi", 2278467, "Hamburger", 5, 0, "Es geht um Omni Channels", null, "Omni Channel Retail", 0, "Weak was?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumns: new[] { "Id", "Filing", "LastModified", "Registration" },
                keyValues: new object[] { 1, new DateTime(2020, 7, 5, 23, 30, 11, 932, DateTimeKind.Local), new DateTime(2020, 7, 5, 23, 30, 11, 928, DateTimeKind.Local), new DateTime(2020, 7, 5, 23, 30, 11, 932, DateTimeKind.Local) });

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "thesis",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "StudentLastName",
                table: "thesis",
                newName: "StudenLastName");

            migrationBuilder.InsertData(
                table: "thesis",
                columns: new[] { "Id", "ContentVal", "ContentWt", "Description", "DifficultyVal", "DifficultyWt", "Email", "Evaluation", "Filing", "Grade", "LastModified", "LayoutVal", "LayoutWt", "LiteratureVal", "LiteratureWt", "NoveltyVal", "NoveltyWt", "ProgrammeId", "Registration", "RichnessVal", "RichnessWt", "Status", "Strengths", "StructureVal", "StructureWt", "StudenLastName", "StudentFirstName", "StudentID", "StyleVal", "StyleWt", "Summary", "SupervisorId", "Title", "Weaknesses", "type" },
                values: new object[] { 1, 5, 0, "Wahnsinns Arbeit", 5, 0, "joschikahn@web.de", "war ganz ok", new DateTime(2020, 7, 5, 22, 38, 2, 683, DateTimeKind.Local), 1m, new DateTime(2020, 7, 5, 22, 38, 2, 680, DateTimeKind.Local), 5, 0, 5, 0, 5, 0, null, new DateTime(2020, 7, 5, 22, 38, 2, 683, DateTimeKind.Local), 5, 0, 3, "Alles Super", 5, 0, "Hamburger", "Tschoschi", 2278467, 5, 0, "Es geht um Omni Channels", null, "Omni Channel Retail", "Weak was?", 0 });
        }
    }
}
