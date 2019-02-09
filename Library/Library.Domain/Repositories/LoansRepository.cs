using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;

namespace Library.Domain.Repositories
{
    public class LoansRepository
    {
        public static LibraryContext Context = new LibraryContext();

        public void Add(Loan loanToAdd)
        {
            Context.Loans.Add(loanToAdd);

            Context.SaveChanges();
        }

        public void Remove(Loan loanToRemove)
        {
            Context.Loans.Remove(loanToRemove);

            Context.SaveChanges();
        }

        public void Edit(Loan editedLoan)
        {
            var loanToEdit = Context.Loans.FirstOrDefault(loan => loan.Id == editedLoan.Id);
            if (loanToEdit == null) return;

            loanToEdit.Book = editedLoan.Book;
            loanToEdit.Student = editedLoan.Student;
            loanToEdit.PickupDate = editedLoan.PickupDate;
            loanToEdit.ReturnDate = editedLoan.ReturnDate;

            Context.SaveChanges();
        }

        public Loan Get(int id) => Context.Loans.Find(id);
        public List<Loan> GetAll() => Context.Loans.ToList();
    }
}