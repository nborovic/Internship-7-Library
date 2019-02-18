using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Repositories
{
    public class LoansRepository
    {
        private readonly LibraryContext _context;

        public LoansRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Loan loanToAdd)
        {
            _context.Loans.Add(loanToAdd);

            _context.SaveChanges();
        }

        public void Remove(Loan loanToRemove)
        {
            _context.Loans.Remove(loanToRemove);

            _context.SaveChanges();
        }

        public void Edit(Loan editedLoan)
        {
            var loanToEdit = _context.Loans.Find(editedLoan.Id);
            if (loanToEdit == null) return;

            loanToEdit.BookId = editedLoan.BookId;
            loanToEdit.StudentId = editedLoan.StudentId;
            loanToEdit.PickupDate = editedLoan.PickupDate;
            loanToEdit.ReturnDeadline = editedLoan.ReturnDeadline;
            loanToEdit.ReturnDate = editedLoan.ReturnDate;

            _context.SaveChanges();
        }

        public List<Loan> GetAll() => _context.Loans.
            Include(loan => loan.Student).
            Include(loan => loan.Book).
            Include(loan => loan.Book.Author).
            ToList();
    }
}