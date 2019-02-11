using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class AddedNumberOfCopiesForBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfCopies",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "NumberOfCopies",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "NumberOfCopies",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "NumberOfCopies",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "NumberOfCopies",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "NumberOfCopies",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "NumberOfCopies",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "NumberOfCopies",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "NumberOfCopies",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "NumberOfCopies",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "NumberOfCopies",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PickupDate", "ReturnDate" },
                values: new object[] { new DateTime(2019, 1, 2, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316), new DateTime(2019, 2, 17, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PickupDate", "ReturnDate" },
                values: new object[] { new DateTime(2019, 1, 21, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316), new DateTime(2019, 2, 5, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PickupDate", "ReturnDate" },
                values: new object[] { new DateTime(2019, 1, 10, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316), new DateTime(2019, 2, 18, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PickupDate", "ReturnDate" },
                values: new object[] { new DateTime(2019, 1, 4, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316), new DateTime(2019, 2, 22, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PickupDate", "ReturnDate" },
                values: new object[] { new DateTime(2019, 1, 31, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316), new DateTime(2019, 2, 12, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2007, 2, 11, 10, 26, 19, 626, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2005, 2, 11, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Birthdate",
                value: new DateTime(2007, 2, 11, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Birthdate",
                value: new DateTime(2008, 2, 11, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Birthdate",
                value: new DateTime(2006, 2, 11, 10, 26, 19, 629, DateTimeKind.Local).AddTicks(2316));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfCopies",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PickupDate", "ReturnDate" },
                values: new object[] { new DateTime(2019, 1, 1, 23, 27, 34, 303, DateTimeKind.Local).AddTicks(8440), new DateTime(2019, 2, 16, 23, 27, 34, 304, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PickupDate", "ReturnDate" },
                values: new object[] { new DateTime(2019, 1, 20, 23, 27, 34, 304, DateTimeKind.Local).AddTicks(8492), new DateTime(2019, 2, 4, 23, 27, 34, 304, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PickupDate", "ReturnDate" },
                values: new object[] { new DateTime(2019, 1, 9, 23, 27, 34, 304, DateTimeKind.Local).AddTicks(8492), new DateTime(2019, 2, 17, 23, 27, 34, 304, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PickupDate", "ReturnDate" },
                values: new object[] { new DateTime(2019, 1, 3, 23, 27, 34, 304, DateTimeKind.Local).AddTicks(8492), new DateTime(2019, 2, 21, 23, 27, 34, 304, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PickupDate", "ReturnDate" },
                values: new object[] { new DateTime(2019, 1, 30, 23, 27, 34, 304, DateTimeKind.Local).AddTicks(8492), new DateTime(2019, 2, 11, 23, 27, 34, 304, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2007, 2, 10, 23, 27, 34, 301, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2005, 2, 10, 23, 27, 34, 303, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "Birthdate",
                value: new DateTime(2007, 2, 10, 23, 27, 34, 303, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "Birthdate",
                value: new DateTime(2008, 2, 10, 23, 27, 34, 303, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "Birthdate",
                value: new DateTime(2006, 2, 10, 23, 27, 34, 303, DateTimeKind.Local).AddTicks(8440));
        }
    }
}
