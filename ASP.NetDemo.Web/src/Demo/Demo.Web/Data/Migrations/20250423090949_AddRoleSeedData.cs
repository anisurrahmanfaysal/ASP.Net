using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("4110987a-9f25-4ea0-a3e1-7cd916bad7fa"), "4/19/2025 1:02:03 AM", "HR", "HR" },
                    { new Guid("630d47dd-8932-434d-abcd-fcd1ede0e37c"), "4/19/2025 1:02:04 AM", "Author", "AUTHOR" },
                    { new Guid("63f5ead6-4119-4063-9f64-82df67de00d4"), "4/19/2025 1:02:01 AM", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4110987a-9f25-4ea0-a3e1-7cd916bad7fa"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("630d47dd-8932-434d-abcd-fcd1ede0e37c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("63f5ead6-4119-4063-9f64-82df67de00d4"));
        }
    }
}
