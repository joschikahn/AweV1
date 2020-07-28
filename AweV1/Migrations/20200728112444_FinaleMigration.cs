using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AweV1.Migrations
{
    public partial class FinaleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "thesis",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Filing", "LastModified", "Registration" },
                values: new object[] { new DateTime(2020, 7, 28, 13, 24, 43, 120, DateTimeKind.Local), new DateTime(2020, 7, 28, 13, 24, 43, 119, DateTimeKind.Local), new DateTime(2020, 7, 28, 13, 24, 43, 120, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 200,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 13, 24, 43, 124, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "LastModified", "Type" },
                values: new object[] { new DateTime(2020, 7, 28, 13, 24, 43, 124, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "LastModified", "Type" },
                values: new object[] { new DateTime(2020, 7, 28, 13, 24, 43, 124, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 203,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 13, 24, 43, 124, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 204,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 13, 24, 43, 124, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "thesis",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Filing", "LastModified", "Registration" },
                values: new object[] { new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local), new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local), new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 200,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "LastModified", "Type" },
                values: new object[] { new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "LastModified", "Type" },
                values: new object[] { new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 203,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 204,
                column: "LastModified",
                value: new DateTime(2020, 7, 28, 1, 1, 39, 698, DateTimeKind.Local));
        }
    }
}
