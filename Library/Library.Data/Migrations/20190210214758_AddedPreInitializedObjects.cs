using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class AddedPreInitializedObjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Autor", "Prvi" },
                    { 2, "Autor", "Drugi" },
                    { 3, "Autor", "Treći" },
                    { 4, "Autor", "Četvrti" },
                    { 5, "Autor", "Peti" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Izdavač Prvi" },
                    { 2, "Izdavač Drugi" },
                    { 3, "Izdavač Treći" },
                    { 4, "Izdavač Četvrti" },
                    { 5, "Izdavač Peti" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthdate", "Class", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2007, 2, 10, 22, 47, 57, 207, DateTimeKind.Local).AddTicks(6242), "6.B", "Student", 0, "Prvi" },
                    { 2, new DateTime(2005, 2, 10, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), "8.A", "Student", 0, "Drugi" },
                    { 3, new DateTime(2007, 2, 10, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), "6.C", "Student", 1, "Treći" },
                    { 4, new DateTime(2008, 2, 10, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), "5.A", "Student", 0, "Četvrti" },
                    { 5, new DateTime(2006, 2, 10, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), "7.B", "Student", 1, "Peti" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Genre", "Name", "NumberOfPages", "PublisherId" },
                values: new object[,]
                {
                    { 5, 5, "horror", "Knjiga Peta", 135, 1 },
                    { 10, 5, "action", "Knjiga Deseta", 88, 1 },
                    { 4, 4, "drama", "Knjiga Četvrta", 125, 2 },
                    { 9, 4, "action", "Knjiga Deveta", 422, 2 },
                    { 3, 3, "drama", "Knjiga Treća", 315, 3 },
                    { 8, 3, "horror", "Knjiga Osma", 55, 3 },
                    { 2, 2, "action", "Knjiga Druga", 55, 4 },
                    { 7, 2, "sci-fi", "Knjiga Sedma", 105, 4 },
                    { 1, 1, "sci-fi", "Knjiga Prva", 115, 5 },
                    { 6, 1, "sci-fi", "Knjiga Šesta", 415, 5 }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "BookId", "PickupDate", "ReturnDate", "StudentId" },
                values: new object[,]
                {
                    { 4, 4, new DateTime(2019, 1, 3, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), new DateTime(2019, 2, 21, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), 4 },
                    { 1, 2, new DateTime(2019, 1, 1, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), new DateTime(2019, 2, 16, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), 1 },
                    { 2, 2, new DateTime(2019, 1, 20, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), new DateTime(2019, 2, 4, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), 2 },
                    { 5, 7, new DateTime(2019, 1, 30, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), new DateTime(2019, 2, 11, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), 5 },
                    { 3, 6, new DateTime(2019, 1, 9, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), new DateTime(2019, 2, 17, 22, 47, 57, 210, DateTimeKind.Local).AddTicks(6242), 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
