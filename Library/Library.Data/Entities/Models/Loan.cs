using System;

namespace Library.Data.Entities.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDeadline { get; set; }
        public DateTime? ReturnDate { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Student.FirstName} {Student.LastName} | {Book.Name}";
        }
    }
}