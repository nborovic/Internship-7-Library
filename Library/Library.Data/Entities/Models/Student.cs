using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Library.Data.Enums;

namespace Library.Data.Entities.Models
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(30)] public string FirstName { get; set; }
        [MaxLength(30)] public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        [MaxLength(3)] public string Class { get; set; }
        public Gender Gender { get; set; }
        public ICollection<Loan> Loans { get; set; }

        public override string ToString()
        {
            return $"{Id} | {FirstName} {LastName} | {Class}";
        }
    }
}
