using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class NullableDateIn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bafcfb29-9d16-4717-9a73-f51155cd40f2", "AQAAAAIAAYagAAAAEBr3a1u19N9J0JKDwjFn4XlNZKNNiWUZjIy9WxRYHCURCkE0wQTNcDr40nt5SeiKpw==", "9c2f1d48-68a7-4bb7-b357-071165aac8dc" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(4805), new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(4834), new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(5318), new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(5321), new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(5561), new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(5565), new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(5566), new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(5568), new DateTime(2024, 1, 3, 0, 54, 45, 848, DateTimeKind.Local).AddTicks(5568) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ec4a98c-c4c5-41b8-8dd1-cb3886b1c3f8", "AQAAAAIAAYagAAAAEHqPjDHntMQInyC5ysGni8TX7wMR2lLFha1nOGcdkzG0Ca0mFe/UD7p80l9rjv7ZUQ==", "3b995188-9923-4fb4-a6d8-668ff12ff248" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 17, 53, 20, 379, DateTimeKind.Local).AddTicks(9847), new DateTime(2024, 1, 2, 17, 53, 20, 379, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 17, 53, 20, 379, DateTimeKind.Local).AddTicks(9866), new DateTime(2024, 1, 2, 17, 53, 20, 379, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 17, 53, 20, 380, DateTimeKind.Local).AddTicks(276), new DateTime(2024, 1, 2, 17, 53, 20, 380, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 17, 53, 20, 380, DateTimeKind.Local).AddTicks(279), new DateTime(2024, 1, 2, 17, 53, 20, 380, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 17, 53, 20, 380, DateTimeKind.Local).AddTicks(473), new DateTime(2024, 1, 2, 17, 53, 20, 380, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 17, 53, 20, 380, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 1, 2, 17, 53, 20, 380, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 17, 53, 20, 380, DateTimeKind.Local).AddTicks(477), new DateTime(2024, 1, 2, 17, 53, 20, 380, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 17, 53, 20, 380, DateTimeKind.Local).AddTicks(478), new DateTime(2024, 1, 2, 17, 53, 20, 380, DateTimeKind.Local).AddTicks(479) });
        }
    }
}
