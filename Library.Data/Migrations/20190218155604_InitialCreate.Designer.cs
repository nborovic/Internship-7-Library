﻿// <auto-generated />
using System;
using Library.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Data.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20190218155604_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.Data.Entities.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Autor",
                            LastName = "Prvi"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Autor",
                            LastName = "Drugi"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Autor",
                            LastName = "Treći"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Autor",
                            LastName = "Četvrti"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Autor",
                            LastName = "Peti"
                        });
                });

            modelBuilder.Entity("Library.Data.Entities.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<int>("Genre");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int>("NumberOfCopies");

                    b.Property<int>("NumberOfPages");

                    b.Property<int>("PublisherId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Genre = 2,
                            Name = "Knjiga Prva",
                            NumberOfCopies = 15,
                            NumberOfPages = 115,
                            PublisherId = 5
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Genre = 0,
                            Name = "Knjiga Druga",
                            NumberOfCopies = 21,
                            NumberOfPages = 55,
                            PublisherId = 4
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Genre = 3,
                            Name = "Knjiga Treća",
                            NumberOfCopies = 11,
                            NumberOfPages = 315,
                            PublisherId = 3
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            Genre = 3,
                            Name = "Knjiga Četvrta",
                            NumberOfCopies = 14,
                            NumberOfPages = 125,
                            PublisherId = 2
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 5,
                            Genre = 1,
                            Name = "Knjiga Peta",
                            NumberOfCopies = 12,
                            NumberOfPages = 135,
                            PublisherId = 1
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 1,
                            Genre = 2,
                            Name = "Knjiga Šesta",
                            NumberOfCopies = 18,
                            NumberOfPages = 415,
                            PublisherId = 5
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 2,
                            Genre = 5,
                            Name = "Knjiga Sedma",
                            NumberOfCopies = 16,
                            NumberOfPages = 105,
                            PublisherId = 4
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 3,
                            Genre = 1,
                            Name = "Knjiga Osma",
                            NumberOfCopies = 21,
                            NumberOfPages = 55,
                            PublisherId = 3
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 4,
                            Genre = 0,
                            Name = "Knjiga Deveta",
                            NumberOfCopies = 26,
                            NumberOfPages = 422,
                            PublisherId = 2
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 5,
                            Genre = 0,
                            Name = "Knjiga Deseta",
                            NumberOfCopies = 38,
                            NumberOfPages = 88,
                            PublisherId = 1
                        });
                });

            modelBuilder.Entity("Library.Data.Entities.Models.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<DateTime>("PickupDate");

                    b.Property<DateTime?>("ReturnDate");

                    b.Property<DateTime>("ReturnDeadline");

                    b.Property<int>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("StudentId");

                    b.ToTable("Loans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 2,
                            PickupDate = new DateTime(2019, 1, 9, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            ReturnDate = new DateTime(2019, 2, 24, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            ReturnDeadline = new DateTime(2019, 2, 28, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            PickupDate = new DateTime(2019, 1, 28, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            ReturnDeadline = new DateTime(2019, 2, 14, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            StudentId = 2
                        },
                        new
                        {
                            Id = 3,
                            BookId = 6,
                            PickupDate = new DateTime(2019, 1, 17, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            ReturnDate = new DateTime(2019, 2, 25, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            ReturnDeadline = new DateTime(2019, 2, 23, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            StudentId = 3
                        },
                        new
                        {
                            Id = 4,
                            BookId = 4,
                            PickupDate = new DateTime(2019, 1, 11, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            ReturnDate = new DateTime(2019, 3, 1, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            ReturnDeadline = new DateTime(2019, 3, 5, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            StudentId = 4
                        },
                        new
                        {
                            Id = 5,
                            BookId = 7,
                            PickupDate = new DateTime(2019, 2, 7, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            ReturnDate = new DateTime(2019, 2, 19, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            ReturnDeadline = new DateTime(2019, 2, 23, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            StudentId = 5
                        });
                });

            modelBuilder.Entity("Library.Data.Entities.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Izdavač Prvi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Izdavač Drugi"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Izdavač Treći"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Izdavač Četvrti"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Izdavač Peti"
                        });
                });

            modelBuilder.Entity("Library.Data.Entities.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate");

                    b.Property<string>("Class")
                        .HasMaxLength(3);

                    b.Property<string>("FirstName")
                        .HasMaxLength(30);

                    b.Property<int>("Gender");

                    b.Property<string>("LastName")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = new DateTime(2007, 2, 18, 16, 56, 3, 844, DateTimeKind.Local).AddTicks(8861),
                            Class = "6.B",
                            FirstName = "Student",
                            Gender = 0,
                            LastName = "Prvi"
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = new DateTime(2005, 2, 18, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            Class = "8.A",
                            FirstName = "Student",
                            Gender = 0,
                            LastName = "Drugi"
                        },
                        new
                        {
                            Id = 3,
                            Birthdate = new DateTime(2007, 2, 18, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            Class = "6.C",
                            FirstName = "Student",
                            Gender = 1,
                            LastName = "Treći"
                        },
                        new
                        {
                            Id = 4,
                            Birthdate = new DateTime(2008, 2, 18, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            Class = "5.A",
                            FirstName = "Student",
                            Gender = 0,
                            LastName = "Četvrti"
                        },
                        new
                        {
                            Id = 5,
                            Birthdate = new DateTime(2006, 2, 18, 16, 56, 3, 847, DateTimeKind.Local).AddTicks(8910),
                            Class = "7.B",
                            FirstName = "Student",
                            Gender = 1,
                            LastName = "Peti"
                        });
                });

            modelBuilder.Entity("Library.Data.Entities.Models.Book", b =>
                {
                    b.HasOne("Library.Data.Entities.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Library.Data.Entities.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Library.Data.Entities.Models.Loan", b =>
                {
                    b.HasOne("Library.Data.Entities.Models.Book", "Book")
                        .WithMany("Loans")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Library.Data.Entities.Models.Student", "Student")
                        .WithMany("Loans")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
