using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 30, nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Class = table.Column<string>(maxLength: 3, nullable: true),
                    Gender = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    NumberOfPages = table.Column<int>(nullable: false),
                    NumberOfCopies = table.Column<int>(nullable: false),
                    Genre = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    PublisherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    PickupDate = table.Column<DateTime>(nullable: false),
                    ReturnDeadline = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { 1, new DateTime(2007, 2, 18, 16, 56, 3, 844, DateTimeKind.Local).AddTicks(8861), "6.B", "Student", 0, "Prvi" },
                    { 2, new DateTime(2005, 2, 18, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), "8.A", "Student", 0, "Drugi" },
                    { 3, new DateTime(2007, 2, 18, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), "6.C", "Student", 1, "Treći" },
                    { 4, new DateTime(2008, 2, 18, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), "5.A", "Student", 0, "Četvrti" },
                    { 5, new DateTime(2006, 2, 18, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), "7.B", "Student", 1, "Peti" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Genre", "Name", "NumberOfCopies", "NumberOfPages", "PublisherId" },
                values: new object[,]
                {
                    { 5, 5, 1, "Knjiga Peta", 12, 135, 1 },
                    { 10, 5, 0, "Knjiga Deseta", 38, 88, 1 },
                    { 4, 4, 3, "Knjiga Četvrta", 14, 125, 2 },
                    { 9, 4, 0, "Knjiga Deveta", 26, 422, 2 },
                    { 3, 3, 3, "Knjiga Treća", 11, 315, 3 },
                    { 8, 3, 1, "Knjiga Osma", 21, 55, 3 },
                    { 2, 2, 0, "Knjiga Druga", 21, 55, 4 },
                    { 7, 2, 5, "Knjiga Sedma", 16, 105, 4 },
                    { 1, 1, 2, "Knjiga Prva", 15, 115, 5 },
                    { 6, 1, 2, "Knjiga Šesta", 18, 415, 5 }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "BookId", "PickupDate", "ReturnDate", "ReturnDeadline", "StudentId" },
                values: new object[,]
                {
                    { 4, 4, new DateTime(2019, 1, 11, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 3, 1, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 3, 5, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), 4 },
                    { 1, 2, new DateTime(2019, 1, 9, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 2, 24, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 2, 28, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), 1 },
                    { 2, 2, new DateTime(2019, 1, 28, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), null, new DateTime(2019, 2, 14, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), 2 },
                    { 5, 7, new DateTime(2019, 2, 7, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 2, 19, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 2, 23, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), 5 },
                    { 3, 6, new DateTime(2019, 1, 17, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 2, 25, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), new DateTime(2019, 2, 23, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910), 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BookId",
                table: "Loans",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_StudentId",
                table: "Loans",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
