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

        public CreateEditAuthor()
        {
            InitializeComponent();
            var context = new LibraryContext();
            _authorsRepository = new AuthorsRepository(context);
        }

        public bool CheckInputFields()
        {
            if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "") return true;
            MessageBox.Show(@"One or more input fields empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }

        private void Create(object sender, EventArgs e)
        {
            if (!CheckInputFields()) return;

            var newAuthor = new Author
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
            };

            _authorsRepository.Add(newAuthor);
            Close();
        }
    }
}