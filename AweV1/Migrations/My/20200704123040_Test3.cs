using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations.My
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProgrammeId",
                table: "thesis",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupervisorId",
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

            migrationBuilder.CreateTable(
                name: "supervisors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supervisors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_thesis_ProgrammeId",
                table: "thesis",
                column: "ProgrammeId");

            migrationBuilder.CreateIndex(
                name: "IX_thesis_SupervisorId",
                table: "thesis",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_thesis_programme_ProgrammeId",
                table: "thesis",
                column: "ProgrammeId",
                principalTable: "programme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_thesis_supervisors_SupervisorId",
                table: "thesis",
                column: "SupervisorId",
                principalTable: "supervisors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_thesis_programme_ProgrammeId",
                table: "thesis");

            migrationBuilder.DropForeignKey(
                name: "FK_thesis_supervisors_SupervisorId",
                table: "thesis");

            migrationBuilder.DropTable(
                name: "programme");

            migrationBuilder.DropTable(
                name: "supervisors");

            migrationBuilder.DropIndex(
                name: "IX_thesis_ProgrammeId",
                table: "thesis");

            migrationBuilder.DropIndex(
                name: "IX_thesis_SupervisorId",
                table: "thesis");

            migrationBuilder.DropColumn(
                name: "ProgrammeId",
                table: "thesis");

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "thesis");
        }
    }
}
