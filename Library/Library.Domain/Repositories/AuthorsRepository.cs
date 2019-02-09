using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Library.Data.Entities;
using Library.Data.Entities.Models;

namespace Library.Domain.Repositories
{
    public class AuthorsRepository
    {
        public static LibraryContext Context = new LibraryContext();

        public void Add(Author authorToAdd)
        {
            Context.Authors.Add(authorToAdd);

            Context.SaveChanges();
        }

        public void Remove(Author authorToRemove)
        {
            Context.Authors.Remove(authorToRemove);

            Context.SaveChanges();
        }

        public void Edit(Author editedAuthor)
        {
            var authorToEdit = Context.Authors.FirstOrDefault(author => author.Id == editedAuthor.Id);
            if (authorToEdit == null) return;

            authorToEdit.FirstName = editedAuthor.FirstName;
            authorToEdit.LastName = editedAuthor.LastName;
            authorToEdit.Books = editedAuthor.Books;

            Context.SaveChanges();
        }

        public Author Get(int id) => Context.Authors.Find(id);
        public List<Author> GetAll() => Context.Authors.ToList();
    }
}
