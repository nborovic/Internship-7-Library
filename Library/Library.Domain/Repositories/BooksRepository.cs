using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Repositories
{
    public class BooksRepository
    {
        private readonly LibraryContext _context;

        public BooksRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Book bookToAdd)
        {
            _context.Books.Add(bookToAdd);

            _context.SaveChanges();
        }

        public void Remove(Book bookToRemove)
        {
            _context.Books.Remove(bookToRemove);

            _context.SaveChanges();
        }

        public void Edit(Book editedBook)
        {
            var bookToEdit = _context.Books.Find(editedBook.Id);
            if (bookToEdit == null) return;

            bookToEdit.Name = editedBook.Name;
            bookToEdit.Genre = editedBook.Genre;
            bookToEdit.NumberOfPages = editedBook.NumberOfPages;
            bookToEdit.AuthorId = editedBook.AuthorId;
            bookToEdit.PublisherId = editedBook.PublisherId;
            bookToEdit.NumberOfCopies = editedBook.NumberOfCopies;

            _context.SaveChanges();
        }

        public Book Get(int id) => _context.Books.Include(book => book.Loans).FirstOrDefault(book => book.Id == id);
        public List<Book> GetAll() => _context.Books.Include(book => book.Loans).Include(book => book.Author).Include(book => book.Publisher).ToList();
    }
}