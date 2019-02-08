using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Data.Entities.Models
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(50)] public string Name { get; set; }
        public int NumberOfPages { get; set; }
        [MaxLength(50)] public string Genre { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
