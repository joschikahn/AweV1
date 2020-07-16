using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class fdgs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProgrammId",
                table: "thesis",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "programme",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProgrammId",
                table: "thesis");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "programme",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
