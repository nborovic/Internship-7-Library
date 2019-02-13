using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Library.Data.Entities.Models
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(50)] public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public int NumberOfCopies { get; set; }
        [MaxLength(50)] public string Genre { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public Publisher Publisher { get; set; }
        public int PublisherId { get; set; }
        public ICollection<Loan> Loans { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Name} | {Author.LastName}";
        }

        public int GetNumberOfTakenCopies()
        {
            return Loans.Count(loan => loan.ReturnDate == null);
        }
    }
}
