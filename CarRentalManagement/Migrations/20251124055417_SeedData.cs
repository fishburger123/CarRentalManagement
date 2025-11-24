using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1025), new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1039), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1041), new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1041), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1281), new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1283), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1284), new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1285), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1372), new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1373), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1374), new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1375), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1376), new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1377), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1378), new DateTime(2025, 11, 24, 13, 54, 16, 852, DateTimeKind.Local).AddTicks(1378), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
