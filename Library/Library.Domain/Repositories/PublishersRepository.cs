using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Library.Domain.Repositories
{
    public class PublishersRepository
    {
        private readonly LibraryContext _context;

        public PublishersRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Publisher publisherToAdd)
        {
            _context.Publishers.Add(publisherToAdd);

            _context.SaveChanges();
        }

        public void Remove(Publisher publisherToRemove)
        {
            _context.Publishers.Remove(publisherToRemove);

            _context.SaveChanges();
        }

        public void Edit(Publisher editedPublisher)
        {
            var publisherToEdit = _context.Publishers.Find(editedPublisher.Id);
            if (publisherToEdit == null) return;

            publisherToEdit.Name = editedPublisher.Name;

            _context.SaveChanges();
        }

        public List<Publisher> GetAll() => _context.Publishers.
            Include(publisher => publisher.Books).ThenInclude(book => book.Author).
            ToList();
    }
}
