using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AweV1.Migrations
{
    public partial class MichaelTest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumns: new[] { "Id", "Filing", "LastModified", "Registration" },
                keyValues: new object[] { 1, new DateTime(2020, 7, 5, 23, 30, 11, 932, DateTimeKind.Local), new DateTime(2020, 7, 5, 23, 30, 11, 928, DateTimeKind.Local), new DateTime(2020, 7, 5, 23, 30, 11, 932, DateTimeKind.Local) });

            migrationBuilder.AlterColumn<double>(
                name: "Grade",
                table: "thesis",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<bool>(
                name: "Bachelor",
                table: "thesis",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Master",
                table: "thesis",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "thesis",
                columns: new[] { "Id", "Bachelor", "ContentVal", "ContentWt", "Description", "DifficultyVal", "DifficultyWt", "Email", "Evaluation", "Filing", "Grade", "LastModified", "LayoutVal", "LayoutWt", "LiteratureVal", "LiteratureWt", "Master", "NoveltyVal", "NoveltyWt", "ProgrammeId", "Registration", "RichnessVal", "RichnessWt", "Status", "Strengths", "StructureVal", "StructureWt", "StudentFirstName", "StudentID", "StudentLastName", "StyleVal", "StyleWt", "Summary", "SupervisorId", "Title", "Type", "Weaknesses" },
                values: new object[] { 1, true, 5, 30, "Wahnsinns Arbeit", 5, 5, "joschikahn@web.de", "war ganz ok", new DateTime(2020, 7, 7, 14, 25, 17, 550, DateTimeKind.Local), 1.0, new DateTime(2020, 7, 7, 14, 25, 17, 545, DateTimeKind.Local), 5, 15, 5, 10, true, 5, 10, null, new DateTime(2020, 7, 7, 14, 25, 17, 550, DateTimeKind.Local), 5, 10, 3, "Alles Super", 5, 10, "Tschoschi", 2278467, "Hamburger", 5, 10, "Es geht um Omni Channels", null, "Omni Channel Retail", 0, "Weak was?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumns: new[] { "Id", "Filing", "LastModified", "Registration" },
                keyValues: new object[] { 1, new DateTime(2020, 7, 7, 14, 25, 17, 550, DateTimeKind.Local), new DateTime(2020, 7, 7, 14, 25, 17, 545, DateTimeKind.Local), new DateTime(2020, 7, 7, 14, 25, 17, 550, DateTimeKind.Local) });

            migrationBuilder.DropColumn(
                name: "Bachelor",
                table: "thesis");

            migrationBuilder.DropColumn(
                name: "Master",
                table: "thesis");

            migrationBuilder.AlterColumn<decimal>(
                name: "Grade",
                table: "thesis",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.InsertData(
                table: "thesis",
                columns: new[] { "Id", "ContentVal", "ContentWt", "Description", "DifficultyVal", "DifficultyWt", "Email", "Evaluation", "Filing", "Grade", "LastModified", "LayoutVal", "LayoutWt", "LiteratureVal", "LiteratureWt", "NoveltyVal", "NoveltyWt", "ProgrammeId", "Registration", "RichnessVal", "RichnessWt", "Status", "Strengths", "StructureVal", "StructureWt", "StudentFirstName", "StudentID", "StudentLastName", "StyleVal", "StyleWt", "Summary", "SupervisorId", "Title", "Type", "Weaknesses" },
                values: new object[] { 1, 5, 0, "Wahnsinns Arbeit", 200, 0, "joschikahn@web.de", "war ganz ok", new DateTime(2020, 7, 5, 23, 30, 11, 932, DateTimeKind.Local), 1m, new DateTime(2020, 7, 5, 23, 30, 11, 928, DateTimeKind.Local), 5, 0, 5, 0, 5, 0, null, new DateTime(2020, 7, 5, 23, 30, 11, 932, DateTimeKind.Local), 5, 0, 3, "Alles Super", 5, 0, "Tschoschi", 2278467, "Hamburger", 5, 0, "Es geht um Omni Channels", null, "Omni Channel Retail", 0, "Weak was?" });
        }
    }
}
