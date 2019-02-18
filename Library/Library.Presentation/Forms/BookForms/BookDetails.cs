using System.Drawing;
using System.Windows.Forms;
using Library.Data.Entities.Models;

namespace Library.Presentation.Forms.BookForms
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
            bookGenre.Text = _selectedBook.Genre.ToString();
            numberOfPagesLabel.Text += _selectedBook.NumberOfPages;
            authorLabel.Text += _selectedBook.Author.FirstName + @" " +_selectedBook.Author.LastName;
            publisherLabel.Text += _selectedBook.Publisher.Name;
            rentedLabel.Text += $@"{_selectedBook.GetNumberOfTakenCopies()}/{_selectedBook.NumberOfCopies}";

            var percentageOfTakenCopies = (double)_selectedBook.GetNumberOfTakenCopies() / _selectedBook.NumberOfCopies * 100;
            if (percentageOfTakenCopies < 50)
                copiesColorIndicator.BackColor = Color.Green;
            else if (percentageOfTakenCopies < 75)
                copiesColorIndicator.BackColor = Color.Yellow;
            else
                copiesColorIndicator.BackColor = Color.Red;
        }
    }
}