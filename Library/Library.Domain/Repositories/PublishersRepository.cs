using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;

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

        public void Edit(Loan editedPublisher)
        {
            var publisherToEdit = _context.Publishers.FirstOrDefault(publisher => publisher.Id == editedPublisher.Id);
            if (publisherToEdit == null) return;

            publisherToEdit.Name = publisherToEdit.Name;

            _context.SaveChanges();
        }

        public Publisher Get(int id) => _context.Publishers.Find(id);
        public List<Publisher> GetAll() => _context.Publishers.ToList();
    }
}
