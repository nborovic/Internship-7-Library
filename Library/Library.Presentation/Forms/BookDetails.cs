using System;
using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms
{
    public partial class BookDetails : Form
    {
        private readonly Book _selectedBook;

        public BookDetails(Book selectedBook)
        {
            InitializeComponent();

            _selectedBook = selectedBook;

            RefreshData();
        }

        private void RefreshData()
        {
            bookName.Text = _selectedBook.Name;
            bookGenre.Text = _selectedBook.Genre;
            numberOfPagesLabel.Text += _selectedBook.NumberOfPages;
            authorLabel.Text += _selectedBook.Author.FirstName + @" " +_selectedBook.Author.LastName;
            publisherLabel.Text += _selectedBook.Publisher.Name;
            rentedLabel.Text += $@"{_selectedBook.Loans.Count(loan => loan.ReturnDate - DateTime.Now > TimeSpan.Zero)}/{_selectedBook.NumberOfCopies}";
        }
    }
}
