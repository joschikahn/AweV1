using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class _22a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_thesis_programme_ProgrammeId",
                table: "thesis");

            migrationBuilder.AlterColumn<int>(
                name: "ProgrammeId",
                table: "thesis",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.AlterColumn<int>(
                name: "ProgrammeId",
                table: "thesis",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_thesis_programme_ProgrammeId",
                table: "thesis",
                column: "ProgrammeId",
                principalTable: "programme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
