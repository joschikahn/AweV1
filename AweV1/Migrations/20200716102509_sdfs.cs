using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class sdfs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_thesis_supervisors_SupervisorId",
                table: "thesis");

            migrationBuilder.AlterColumn<int>(
                name: "SupervisorId",
                table: "thesis",
                nullable: true,
                oldClrType: typeof(int));

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
                name: "FK_thesis_supervisors_SupervisorId",
                table: "thesis");

            migrationBuilder.AlterColumn<int>(
                name: "SupervisorId",
                table: "thesis",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_thesis_supervisors_SupervisorId",
                table: "thesis",
                column: "SupervisorId",
                principalTable: "supervisors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
