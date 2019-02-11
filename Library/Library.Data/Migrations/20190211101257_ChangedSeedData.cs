using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class ChangedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 2, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341), new DateTime(2019, 2, 17, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341), new DateTime(2019, 2, 21, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 21, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 7, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 10, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341), new DateTime(2019, 2, 18, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341), new DateTime(2019, 2, 16, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 4, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341), new DateTime(2019, 2, 22, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341), new DateTime(2019, 2, 26, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 31, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341), new DateTime(2019, 2, 12, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341), new DateTime(2019, 2, 16, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2007, 2, 11, 11, 12, 56, 550, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2005, 2, 11, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Birthdate",
                value: new DateTime(2007, 2, 11, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Birthdate",
                value: new DateTime(2008, 2, 11, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Birthdate",
                value: new DateTime(2006, 2, 11, 11, 12, 56, 552, DateTimeKind.Local).AddTicks(8341));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 2, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358), new DateTime(2019, 2, 17, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358), new DateTime(2019, 2, 21, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 21, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358), new DateTime(2019, 2, 5, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358), new DateTime(2019, 2, 7, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 10, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358), new DateTime(2019, 2, 18, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358), new DateTime(2019, 2, 16, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 4, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358), new DateTime(2019, 2, 22, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358), new DateTime(2019, 2, 26, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 31, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358), new DateTime(2019, 2, 12, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358), new DateTime(2019, 2, 16, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2007, 2, 11, 11, 1, 59, 996, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2005, 2, 11, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Birthdate",
                value: new DateTime(2007, 2, 11, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Birthdate",
                value: new DateTime(2008, 2, 11, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Birthdate",
                value: new DateTime(2006, 2, 11, 11, 1, 59, 999, DateTimeKind.Local).AddTicks(358));
        }
    }
}
