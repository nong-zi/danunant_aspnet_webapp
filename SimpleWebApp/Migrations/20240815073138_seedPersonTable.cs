using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleWebApp.Migrations
{
    /// <inheritdoc />
    public partial class seedPersonTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person_Info",
                columns: new[] { "Id", "Address", "Age", "BirthDate", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "123 William Street, Melbourne VIC 6969, Australia", "50", new DateOnly(1950, 1, 1), "Antony Fetucini", "012345678" },
                    { 2, "123 William Street, Melbourne VIC 6969, Australia", "49", new DateOnly(1960, 2, 1), "Felipa Fetucini", "012345678" },
                    { 3, "123 William Street, Melbourne VIC 6969, Australia", "23", new DateOnly(1990, 9, 30), "Androzy Fetucini", "012345678" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person_Info",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person_Info",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person_Info",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
