using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class NullableVehicleBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da327ebf-0e7a-4dc8-8bda-5b6b1352e3e0", "AQAAAAIAAYagAAAAEDKBscgJIPdyE/tsARWlroOT56lgHJ7/qBZ+k5dxtoDv1ZfNNurLabPGmo1gD50Nbw==", "80408e4b-8a2b-4498-9f06-edfc311d9fc6" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(5965), new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(5978), new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(6284), new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(6287), new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(6460), new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(6462), new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(6464), new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(6465), new DateTime(2024, 1, 3, 1, 3, 27, 576, DateTimeKind.Local).AddTicks(6465) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
