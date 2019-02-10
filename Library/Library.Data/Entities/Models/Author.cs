using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Data.Entities.Models
{
    public class Author
    {
        public int Id { get; set; }
        [MaxLength(30)] public string FirstName { get; set; }
        [MaxLength(30)] public string LastName { get; set; }
        public ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return $"{Id} | {FirstName} {LastName}";
        }
    }
}
