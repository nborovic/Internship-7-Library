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
                values: new object[] { new DateTime(2019, 2, 7, 22, 15, 38, 943, DateTimeKind.Local).AddTicks(1183), new DateTime(2019, 2, 24, 22, 15, 38, 943, DateTimeKind.Local).AddTicks(1183), new DateTime(2019, 2, 28, 22, 15, 38, 943, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PickupDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 29, 22, 15, 38, 943, DateTimeKind.Local).AddTicks(1183), new DateTime(2019, 2, 19, 22, 15, 38, 943, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 2, 2, 22, 15, 38, 943, DateTimeKind.Local).AddTicks(1183), new DateTime(2019, 2, 25, 22, 15, 38, 943, DateTimeKind.Local).AddTicks(1183), new DateTime(2019, 2, 23, 22, 15, 38, 943, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2018, 10, 20, 22, 15, 38, 943, DateTimeKind.Local).AddTicks(1183), null, new DateTime(2018, 11, 10, 22, 15, 38, 943, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 8, 22, 15, 38, 943, DateTimeKind.Local).AddTicks(1183), null, new DateTime(2019, 1, 29, 22, 15, 38, 943, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "Class" },
                values: new object[] { new DateTime(2007, 2, 18, 22, 15, 38, 940, DateTimeKind.Local).AddTicks(1183), "6.b" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "Class" },
                values: new object[] { new DateTime(2005, 2, 18, 22, 15, 38, 942, DateTimeKind.Local).AddTicks(1183), "8.a" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthdate", "Class" },
                values: new object[] { new DateTime(2007, 2, 18, 22, 15, 38, 942, DateTimeKind.Local).AddTicks(1183), "6.c" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Birthdate", "Class" },
                values: new object[] { new DateTime(2008, 2, 18, 22, 15, 38, 942, DateTimeKind.Local).AddTicks(1183), "5.a" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Birthdate", "Class" },
                values: new object[] { new DateTime(2006, 2, 18, 22, 15, 38, 942, DateTimeKind.Local).AddTicks(1183), "7.b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 9, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 2, 24, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 2, 28, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PickupDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 28, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 2, 14, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 17, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 2, 25, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 2, 23, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 1, 11, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 3, 1, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 3, 5, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PickupDate", "ReturnDate", "ReturnDeadline" },
                values: new object[] { new DateTime(2019, 2, 7, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 2, 19, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 2, 23, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "Class" },
                values: new object[] { new DateTime(2007, 2, 18, 16, 56, 3, 844, DateTimeKind.Local).AddTicks(8861), "6.B" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "Class" },
                values: new object[] { new DateTime(2005, 2, 18, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), "8.A" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthdate", "Class" },
                values: new object[] { new DateTime(2007, 2, 18, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), "6.C" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Birthdate", "Class" },
                values: new object[] { new DateTime(2008, 2, 18, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), "5.A" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Birthdate", "Class" },
                values: new object[] { new DateTime(2006, 2, 18, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), "7.B" });
        }
    }
}
