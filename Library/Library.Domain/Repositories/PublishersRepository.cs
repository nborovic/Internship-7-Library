using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;

namespace Library.Domain.Repositories
{
    public class PublishersRepository
    {
        public static LibraryContext Context = new LibraryContext();

        public void Add(Publisher publisherToAdd)
        {
            Context.Publishers.Add(publisherToAdd);

            Context.SaveChanges();
        }

        public void Remove(Publisher publisherToRemove)
        {
            Context.Publishers.Remove(publisherToRemove);

            Context.SaveChanges();
        }

        public void Edit(Loan editedPublisher)
        {
            var publisherToEdit = Context.Publishers.FirstOrDefault(publisher => publisher.Id == editedPublisher.Id);
            if (publisherToEdit == null) return;

            publisherToEdit.Name = publisherToEdit.Name;

            Context.SaveChanges();
        }

        public Publisher Get(int id) => Context.Publishers.Find(id);
        public List<Publisher> GetAll() => Context.Publishers.ToList();
    }
}
