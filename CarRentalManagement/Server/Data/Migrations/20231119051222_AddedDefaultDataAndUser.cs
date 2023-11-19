using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "baa53160-d8f5-4000-90a8-eb0da62a1c2a", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBrNYpsGVi+zBEqoCmdy0jxu1FyYVgTllOjgBxnTHoHFlv1PcFx49OHw5dzq8IHJKw==", null, false, "29d6cfbe-7b11-4248-b65f-e1b127681df9", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(6694), new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(6707), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(6711), new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(6712), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(7182), new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(7183), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(7185), new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(7185), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(7385), new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(7385), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(7387), new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(7387), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(7389), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(7390), new DateTime(2023, 11, 19, 13, 12, 22, 73, DateTimeKind.Local).AddTicks(7390), "Rav4", "System" }
                });

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
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
