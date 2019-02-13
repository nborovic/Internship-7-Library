using System;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms
{
    public partial class CreateEditBook : Form
    {
        private readonly BooksRepository _booksRepository;
        private readonly AuthorsRepository _authorsRepository;
        private readonly PublishersRepository _publishersRepository;

        public CreateEditBook()
        {
            InitializeComponent();

            var context = new LibraryContext();
            _booksRepository = new BooksRepository(context);
            _authorsRepository = new AuthorsRepository(context);
            _publishersRepository = new PublishersRepository(context);

            RefreshPublishersAndAuthorsList();
        }

        private void RefreshPublishersAndAuthorsList()
        {
            _authorsRepository.GetAll().ForEach(author => authorsListBox.Items.Add(author));
            _publishersRepository.GetAll().ForEach(publisher => publishersListBox.Items.Add(publisher));
        }

        private bool CheckInputFields()
        {
            if (nameTextBox.Text != "" && genreTextBox.Text != "" && numberOfCopiesTextBox.Text != "" &&
                numberOfPagesTextBox.Text != "" && authorsListBox.SelectedItem != null &&
                publishersListBox.SelectedItem != null) return true;
            MessageBox.Show(@"One or more input fields empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }

        private void Create(object sender, EventArgs e)
        {
            if (!CheckInputFields()) return;

            var newBook = new Book
            {
                Name = nameTextBox.Text,
                Genre = genreTextBox.Text,
                NumberOfCopies = int.Parse(numberOfCopiesTextBox.Text),
                NumberOfPages = int.Parse(numberOfPagesTextBox.Text),
                AuthorId = ((Author) authorsListBox.SelectedItem).Id,
                PublisherId = ((Publisher) publishersListBox.SelectedItem).Id,
            };

            _booksRepository.Add(newBook);
            Close();
        }
    }
}