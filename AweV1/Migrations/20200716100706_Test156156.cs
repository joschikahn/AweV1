﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AweV1.Migrations
{
    public partial class Test156156 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "programme",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Dichtael Schwarz" });

            migrationBuilder.InsertData(
                table: "supervisors",
                columns: new[] { "Id", "Active", "Email", "FirstName", "LastName" },
                values: new object[] { 1, true, "mail@mail.mail", "Elliot", "Anderson" });

            migrationBuilder.InsertData(
                table: "thesis",
                columns: new[] { "Id", "Bachelor", "ContentVal", "ContentWt", "Description", "DifficultyVal", "DifficultyWt", "Email", "Evaluation", "Filing", "Grade", "LastModified", "LayoutVal", "LayoutWt", "LiteratureVal", "LiteratureWt", "Master", "NoveltyVal", "NoveltyWt", "ProgrammeId", "Registration", "RichnessVal", "RichnessWt", "Status", "Strengths", "StructureVal", "StructureWt", "StudentFirstName", "StudentID", "StudentLastName", "StyleVal", "StyleWt", "Summary", "SupervisorId", "Title", "Type", "Weaknesses" },
                values: new object[] { 1, true, 5, 30, "Wahnsinns Arbeit", 5, 5, "joschikahn@web.de", "war ganz ok", new DateTime(2020, 7, 16, 12, 7, 5, 822, DateTimeKind.Local), 1, new DateTime(2020, 7, 16, 12, 7, 5, 822, DateTimeKind.Local), 5, 15, 5, 10, true, 5, 10, null, new DateTime(2020, 7, 16, 12, 7, 5, 822, DateTimeKind.Local), 5, 10, 3, "Alles Super", 5, 10, "Tschoschi", "2278467", "Hamburger", 5, 10, "Es geht um Omni Channels", 1, "Omni Channel Retail", 0, "Weak was?" });

            migrationBuilder.AddForeignKey(
                name: "FK_thesis_supervisors_SupervisorId",
                table: "thesis",
                column: "SupervisorId",
                principalTable: "supervisors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_thesis_supervisors_SupervisorId",
                table: "thesis");

            migrationBuilder.DeleteData(
                table: "programme",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "thesis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "supervisors",
                keyColumn: "Id",
                keyValue: 1);

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
    }
}
