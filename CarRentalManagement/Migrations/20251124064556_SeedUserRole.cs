using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "04acca4d-5e8c-4ef0-ad49-c4eddd117512", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEKRPxq2Gztz5IfbFquayuUoLUyDuaKq40RXfKcqwOJvwQcUCu9G2KvVG+U0Z3QK2mg==", null, false, "552b4d9e-9b70-44a4-9a9e-1c8e30cb9add", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8099), new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8115), new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8365), new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8367), new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8459), new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8464), new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8465), new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8467), new DateTime(2025, 11, 24, 14, 45, 55, 619, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8499), new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8518), new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8753), new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8756), new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8855), new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8858), new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8860), new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8862), new DateTime(2025, 11, 24, 14, 38, 20, 289, DateTimeKind.Local).AddTicks(8862) });
        }
    }
}
