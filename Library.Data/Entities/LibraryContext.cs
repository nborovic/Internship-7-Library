using System;
using System.Configuration;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Library.Data.Entities
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LibraryDatabase"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author { Id = 1, FirstName = "Autor", LastName = "Prvi" });
            modelBuilder.Entity<Author>().HasData(new Author { Id = 2, FirstName = "Autor", LastName = "Drugi" });
            modelBuilder.Entity<Author>().HasData(new Author { Id = 3, FirstName = "Autor", LastName = "Treći" });
            modelBuilder.Entity<Author>().HasData(new Author { Id = 4, FirstName = "Autor", LastName = "Četvrti" });
            modelBuilder.Entity<Author>().HasData(new Author { Id = 5, FirstName = "Autor", LastName = "Peti" });

            modelBuilder.Entity<Book>().HasData(new Book { Id = 1, Name = "Knjiga Prva", NumberOfPages = 115, NumberOfCopies = 15, Genre = Genre.Scifi, AuthorId = 1, PublisherId = 5 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 2, Name = "Knjiga Druga", NumberOfPages = 55, NumberOfCopies = 21, Genre = Genre.Action, AuthorId = 2, PublisherId = 4 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 3, Name = "Knjiga Treća", NumberOfPages = 315, NumberOfCopies = 11, Genre = Genre.Drama, AuthorId = 3, PublisherId = 3 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 4, Name = "Knjiga Četvrta", NumberOfPages = 125, NumberOfCopies = 14, Genre = Genre.Drama, AuthorId = 4, PublisherId = 2 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 5, Name = "Knjiga Peta", NumberOfPages = 135, NumberOfCopies = 12, Genre = Genre.Horror, AuthorId = 5, PublisherId = 1 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 6, Name = "Knjiga Šesta", NumberOfPages = 415, NumberOfCopies = 18, Genre = Genre.Scifi, AuthorId = 1, PublisherId = 5 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 7, Name = "Knjiga Sedma", NumberOfPages = 105, NumberOfCopies = 16, Genre = Genre.Detective, AuthorId = 2, PublisherId = 4 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 8, Name = "Knjiga Osma", NumberOfPages = 55, NumberOfCopies = 21, Genre = Genre.Horror, AuthorId = 3, PublisherId = 3 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 9, Name = "Knjiga Deveta", NumberOfPages = 422, NumberOfCopies = 26, Genre = Genre.Action, AuthorId = 4, PublisherId = 2 });
            modelBuilder.Entity<Book>().HasData(new Book { Id = 10, Name = "Knjiga Deseta", NumberOfPages = 88, NumberOfCopies = 38, Genre = Genre.Action, AuthorId = 5, PublisherId = 1 });

            modelBuilder.Entity<Publisher>().HasData(new Publisher { Id = 1, Name = "Izdavač Prvi" });
            modelBuilder.Entity<Publisher>().HasData(new Publisher { Id = 2, Name = "Izdavač Drugi" });
            modelBuilder.Entity<Publisher>().HasData(new Publisher { Id = 3, Name = "Izdavač Treći" });
            modelBuilder.Entity<Publisher>().HasData(new Publisher { Id = 4, Name = "Izdavač Četvrti" });
            modelBuilder.Entity<Publisher>().HasData(new Publisher { Id = 5, Name = "Izdavač Peti" });

            modelBuilder.Entity<Student>().HasData(new Student { Id = 1, FirstName = "Student", LastName = "Prvi", Birthdate = DateTime.Now.AddYears(-12), Class = "6.b", Gender = Gender.Male });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 2, FirstName = "Student", LastName = "Drugi", Birthdate = DateTime.Now.AddYears(-14), Class = "8.a", Gender = Gender.Male });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 3, FirstName = "Student", LastName = "Treći", Birthdate = DateTime.Now.AddYears(-12), Class = "6.c", Gender = Gender.Female });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 4, FirstName = "Student", LastName = "Četvrti", Birthdate = DateTime.Now.AddYears(-11), Class = "5.a", Gender = Gender.Male });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 5, FirstName = "Student", LastName = "Peti", Birthdate = DateTime.Now.AddYears(-13), Class = "7.b", Gender = Gender.Female });

            modelBuilder.Entity<Loan>().HasData(new Loan { Id = 1, StudentId = 1, BookId = 2, PickupDate = DateTime.Now.AddDays(-11), ReturnDeadline = DateTime.Now.AddDays(10), ReturnDate = DateTime.Now.AddDays(6) });
            modelBuilder.Entity<Loan>().HasData(new Loan { Id = 2, StudentId = 2, BookId = 2, PickupDate = DateTime.Now.AddDays(-20), ReturnDeadline = DateTime.Now.AddDays(1) });
            modelBuilder.Entity<Loan>().HasData(new Loan { Id = 3, StudentId = 3, BookId = 6, PickupDate = DateTime.Now.AddDays(-16), ReturnDeadline = DateTime.Now.AddDays(5), ReturnDate = DateTime.Now.AddDays(7) });
            modelBuilder.Entity<Loan>().HasData(new Loan { Id = 4, StudentId = 4, BookId = 4, PickupDate = DateTime.Now.AddDays(-121), ReturnDeadline = DateTime.Now.AddDays(-100) });
            modelBuilder.Entity<Loan>().HasData(new Loan { Id = 5, StudentId = 5, BookId = 7, PickupDate = DateTime.Now.AddDays(-41), ReturnDeadline = DateTime.Now.AddDays(-20) });

            modelBuilder.Entity<Loan>()
                .HasOne(loan => loan.Book)
                .WithMany(book => book.Loans)
                .HasForeignKey(loan => loan.BookId);
            modelBuilder.Entity<Loan>()
                .HasOne(loan => loan.Student)
                .WithMany(student => student.Loans)
                .HasForeignKey(loan => loan.StudentId);
        }
    }
}