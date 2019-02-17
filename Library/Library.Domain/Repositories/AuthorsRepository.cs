using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Repositories
{
    public class AuthorsRepository
    {
        private readonly LibraryContext _context;

        public AuthorsRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Author authorToAdd)
        {
            _context.Authors.Add(authorToAdd);

            _context.SaveChanges();
        }

        public void Remove(Author authorToRemove)
        {
            _context.Authors.Remove(authorToRemove);

            _context.SaveChanges();
        }

        public void Edit(Author editedAuthor)
        {
            var authorToEdit = _context.Authors.FirstOrDefault(author => author.Id == editedAuthor.Id);
            if (authorToEdit == null) return;

            authorToEdit.FirstName = editedAuthor.FirstName;
            authorToEdit.LastName = editedAuthor.LastName;

            _context.SaveChanges();
        }

        public Author Get(int id) => _context.Authors.Include(author => author.Books).FirstOrDefault(author => author.Id == id);
        public List<Author> GetAll() => _context.Authors.Include(author => author.Books).ToList();
    }
}
