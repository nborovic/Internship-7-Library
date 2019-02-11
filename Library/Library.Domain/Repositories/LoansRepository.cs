using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            _context.SaveChanges();
        }

        public Loan Get(int id) => _context.Loans.Include(loan => loan.Student).Include(loan => loan.Book).FirstOrDefault(loan => loan.Id == id);
        public List<Loan> GetAll() => _context.Loans.Include(loan => loan.Student).Include(loan => loan.Book).ToList();
    }
}