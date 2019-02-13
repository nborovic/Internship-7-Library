using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms
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
    }
}
