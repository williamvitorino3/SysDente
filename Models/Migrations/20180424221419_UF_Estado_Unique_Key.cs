using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Models.Migrations
{
    public partial class UF_Estado_Unique_Key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "Estados",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estados_UF",
                table: "Estados",
                column: "UF",
                unique: true,
                filter: "[UF] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Estados_UF",
                table: "Estados");

            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "Estados",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
