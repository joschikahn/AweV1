using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations.My
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "thesis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastModified = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Registration = table.Column<DateTime>(nullable: false),
                    Filing = table.Column<DateTime>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    Summary = table.Column<string>(nullable: true),
                    StudentFirstName = table.Column<string>(nullable: true),
                    StudenLastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    StudentID = table.Column<int>(nullable: false),
                    Strengths = table.Column<string>(nullable: true),
                    Weaknesses = table.Column<string>(nullable: true),
                    Evaluation = table.Column<string>(nullable: true),
                    ContentVal = table.Column<int>(nullable: false),
                    LayoutVal = table.Column<int>(nullable: false),
                    StructureVal = table.Column<int>(nullable: false),
                    StyleVal = table.Column<int>(nullable: false),
                    LiteratureVal = table.Column<int>(nullable: false),
                    DifficultyVal = table.Column<int>(nullable: false),
                    NoveltyVal = table.Column<int>(nullable: false),
                    RichnessVal = table.Column<int>(nullable: false),
                    ContentWt = table.Column<int>(nullable: false),
                    LayoutWt = table.Column<int>(nullable: false),
                    StyleWt = table.Column<int>(nullable: false),
                    LiteratureWt = table.Column<int>(nullable: false),
                    StructureWt = table.Column<int>(nullable: false),
                    DifficultyWt = table.Column<int>(nullable: false),
                    NoveltyWt = table.Column<int>(nullable: false),
                    RichnessWt = table.Column<int>(nullable: false),
                    Grade = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thesis", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "thesis");
        }
    }
}
