using System;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms
{
    public partial class CreateEditAuthor : Form
    {
        private readonly AuthorsRepository _authorsRepository;
        private Author _authorToEdit;

        public CreateEditAuthor()
        {
            InitializeComponent();

            var context = new LibraryContext();
            _authorsRepository = new AuthorsRepository(context);
            createEditButton.Text = @"Create";
        }

        public CreateEditAuthor(Author authorToEdit)
        {
            InitializeComponent();

            var context = new LibraryContext();
            _authorsRepository = new AuthorsRepository(context);
            _authorToEdit = authorToEdit;
            createEditButton.Text = @"Edit";

            FillInputFields();
        }

        public void FillInputFields()
        {
            firstNameTextBox.Text = _authorToEdit.FirstName;
            lastNameTextBox.Text = _authorToEdit.LastName;
        }

        public bool CheckInputFields()
        {
            if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "") return true;
            MessageBox.Show(@"One or more input fields empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }

        private void CreateEdit(object sender, EventArgs e)
        {
            if (!CheckInputFields()) return;

            if (_authorToEdit == null)
            {
                var newAuthor = new Author
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                };

                _authorsRepository.Add(newAuthor);
            }

            else
            {
                _authorToEdit.FirstName = firstNameTextBox.Text;
                _authorToEdit.LastName = lastNameTextBox.Text;
                _authorsRepository.Edit(_authorToEdit);
            }

            Close();
        }
    }
}