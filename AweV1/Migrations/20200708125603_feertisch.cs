using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class feertisch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "thesis",
                nullable: true,
                oldClrType: typeof(double),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Grade",
                table: "thesis",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
