using System;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms.BookForms
{
    public partial class CreateEditBook : Form
    {
        private readonly BooksRepository _booksRepository;
        private readonly AuthorsRepository _authorsRepository;
        private readonly PublishersRepository _publishersRepository;
        private readonly Book _bookToEdit;

        public CreateEditBook()
        {
            InitializeComponent();

            var context = new LibraryContext();
            _booksRepository = new BooksRepository(context);
            _authorsRepository = new AuthorsRepository(context);
            _publishersRepository = new PublishersRepository(context);

            createEditButton.Text = @"Edit";
            RefreshPublishersAndAuthorsList();
            SearchAutoComplete();
        }

        public CreateEditBook(Book bookToEdit)
        {
            InitializeComponent();

            var context = new LibraryContext();
            _booksRepository = new BooksRepository(context);
            _authorsRepository = new AuthorsRepository(context);
            _publishersRepository = new PublishersRepository(context);
            _bookToEdit = bookToEdit;

            createEditButton.Text = @"Edit";
            RefreshPublishersAndAuthorsList();
            FillInputFields();
            SearchAutoComplete();
        }

        public void FillInputFields()
        {
            nameTextBox.Text = _bookToEdit.Name;
            genreTextBox.Text = _bookToEdit.Genre;
            numberOfCopiesTextBox.Text = _bookToEdit.NumberOfCopies.ToString();
            numberOfPagesTextBox.Text = _bookToEdit.NumberOfPages.ToString();
            authorsListBox.Text = _bookToEdit.Author.ToString();
            publishersListBox.Text = _bookToEdit.Publisher.ToString();
        }

        private void RefreshPublishersAndAuthorsList()
        {
            _authorsRepository.GetAll().ForEach(author => authorsListBox.Items.Add(author));
            _publishersRepository.GetAll().ForEach(publisher => publishersListBox.Items.Add(publisher));
        }

        private void SearchAutoComplete()
        {
            searchAuthor.AutoCompleteCustomSource.Clear();
            searchPublisher.AutoCompleteCustomSource.Clear();

            _authorsRepository.GetAll().ForEach(author => searchAuthor.AutoCompleteCustomSource.Add(author.FirstName + " " + author.LastName));
            _authorsRepository.GetAll().ForEach(author => searchAuthor.AutoCompleteCustomSource.Add(author.LastName + " " + author.FirstName));
            _publishersRepository.GetAll().ForEach(publisher => searchPublisher.AutoCompleteCustomSource.Add(publisher.Name));
        }

        private void SearchAuthor(object sender, EventArgs e)
        {
            authorsListBox.Items.Clear();

            _authorsRepository.GetAll().ForEach(author =>
            {
                if ((author.FirstName.ToLower() + " " + author.LastName.ToLower()).Contains(searchAuthor.Text.ToLower()) || 
                    (author.LastName.ToLower() + " " + author.FirstName.ToLower()).Contains(searchAuthor.Text.ToLower()))
                    authorsListBox.Items.Add(author);
            });
        }

        private void SearchPublisher(object sender, EventArgs e)
        {
            publishersListBox.Items.Clear();

            _publishersRepository.GetAll().ForEach(publisher =>
            {
                if (publisher.Name.ToLower().Contains(searchPublisher.Text.ToLower()))
                    publishersListBox.Items.Add(publisher);
            });
        }

        private bool CheckInputFields()
        {
            if (nameTextBox.Text != "" && genreTextBox.Text != "" && numberOfCopiesTextBox.Text != "" &&
                numberOfPagesTextBox.Text != "" && authorsListBox.SelectedItem != null &&
                publishersListBox.SelectedItem != null) return true;
            MessageBox.Show(@"One or more input fields empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }

        private void CreateEdit(object sender, EventArgs e)
        {
            if (!CheckInputFields()) return;

            if (_bookToEdit == null)
            {
                var newBook = new Book
                {
                    Name = nameTextBox.Text,
                    Genre = genreTextBox.Text,
                    NumberOfCopies = int.Parse(numberOfCopiesTextBox.Text),
                    NumberOfPages = int.Parse(numberOfPagesTextBox.Text),
                    AuthorId = ((Author)authorsListBox.SelectedItem).Id,
                    PublisherId = ((Publisher)publishersListBox.SelectedItem).Id,
                };

                _booksRepository.Add(newBook);
            }
            else
            {
                _bookToEdit.Name = nameTextBox.Text;
                _bookToEdit.AuthorId = ((Author) authorsListBox.SelectedItem).Id;
                _bookToEdit.PublisherId = ((Publisher) publishersListBox.SelectedItem).Id;
                _bookToEdit.Genre = genreTextBox.Text;
                _bookToEdit.NumberOfPages = int.Parse(numberOfPagesTextBox.Text);
                _bookToEdit.NumberOfCopies = int.Parse(numberOfCopiesTextBox.Text);

                _booksRepository.Edit(_bookToEdit);
            }

            Close();
        }
    }
}