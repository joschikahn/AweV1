using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProgrammeId",
                table: "thesis",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "programme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_programme", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "programme",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Dichtael Schwarz" });

            migrationBuilder.CreateIndex(
                name: "IX_thesis_ProgrammeId",
                table: "thesis",
                column: "ProgrammeId");

            migrationBuilder.AddForeignKey(
                name: "FK_thesis_programme_ProgrammeId",
                table: "thesis",
                column: "ProgrammeId",
                principalTable: "programme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_thesis_programme_ProgrammeId",
                table: "thesis");

            migrationBuilder.DropTable(
                name: "programme");

            migrationBuilder.DropIndex(
                name: "IX_thesis_ProgrammeId",
                table: "thesis");

            migrationBuilder.DropColumn(
                name: "ProgrammeId",
                table: "thesis");
        }
    }
}
