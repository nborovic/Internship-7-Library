using System;

namespace Library.Data.Entities.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Book Book { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
