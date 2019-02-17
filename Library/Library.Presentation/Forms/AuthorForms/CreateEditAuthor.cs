using System;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;
using Library.Infrastructure.Extensions;

namespace Library.Presentation.Forms
{
    public partial class CreateEditAuthor : Form
    {
        private readonly AuthorsRepository _authorsRepository;
        private readonly Author _authorToEdit;

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
            if (firstNameTextBox.Text == "" && lastNameTextBox.Text == "")
            {
                MessageBox.Show(@"One or more input fields empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (firstNameTextBox.Text.NameFormatting().Length < 30 ||
                lastNameTextBox.Text.NameFormatting().Length < 30) return true;
            MessageBox.Show(@"First name or last name input is too long! (max: 30 characters)", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }

        private void CreateEdit(object sender, EventArgs e)
        {
            if (!CheckInputFields()) return;

            if (_authorToEdit == null)
            {
                var newAuthor = new Author
                {
                    FirstName = firstNameTextBox.Text.NameFormatting(),
                    LastName = lastNameTextBox.Text.NameFormatting()
                };

                _authorsRepository.Add(newAuthor);
            }

            else
            {
                _authorToEdit.FirstName = firstNameTextBox.Text.NameFormatting();
                _authorToEdit.LastName = lastNameTextBox.Text.NameFormatting();
                _authorsRepository.Edit(_authorToEdit);
            }

            Close();
        }
    }
}