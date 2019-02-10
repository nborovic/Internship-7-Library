using System.Windows.Forms;
using Library.Data.Entities.Models;

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
        }
    }
}
