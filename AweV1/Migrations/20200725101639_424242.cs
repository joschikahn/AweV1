using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class _424242 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "UploadFile",
                table: "thesis",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UploadFile",
                table: "thesis");
        }
    }
}
