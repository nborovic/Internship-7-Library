using System;
using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities.Models;

namespace Library.Presentation.Forms.AuthorForms
{
    public partial class AuthorDetails : Form
    {
        private readonly Author _selectedAuthor;

        public AuthorDetails(Author selectedAuthor)
        {
            InitializeComponent();

            _selectedAuthor = selectedAuthor;
            RefreshData();
        }

        public void RefreshData()
        {
            authorFullName.Text = _selectedAuthor.FirstName + @" " + _selectedAuthor.LastName;

            if (_selectedAuthor.Books.Any())
                _selectedAuthor.Books.ToList().ForEach(book => booksListBox.Items.Add(book));
        }

        private void Back(object sender, EventArgs e)
        {
            Close();
        }
    }
}
