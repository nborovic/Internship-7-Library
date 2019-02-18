using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Data.Entities.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        [MaxLength(50)] public string Name { get; set; }
        public ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Name}";
        }
    }
}
