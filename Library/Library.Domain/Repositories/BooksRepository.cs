using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;

namespace Library.Domain.Repositories
{
    public class BooksRepository
    {
        public static LibraryContext Context = new LibraryContext();

        public void Add(Book bookToAdd)
        {
            Context.Books.Add(bookToAdd);

            Context.SaveChanges();
        }

        public void Remove(Book bookToRemove)
        {
            Context.Books.Remove(bookToRemove);

            Context.SaveChanges();
        }

        public void Edit(Book editedBook)
        {
            var bookToEdit = Context.Books.FirstOrDefault(book => book.Id == editedBook.Id);
            if (bookToEdit == null) return;

            bookToEdit.Name = editedBook.Name;
            bookToEdit.Genre = editedBook.Genre;
            bookToEdit.NumberOfPages = editedBook.NumberOfPages;

            Context.SaveChanges();
        }

        public Book Get(int id) => Context.Books.Find(id);
        public List<Book> GetAll() => Context.Books.ToList();
    }
}