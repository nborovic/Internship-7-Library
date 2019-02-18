using System;
using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Library.Domain.Repositories;
using Library.Infrastructure.Extensions;

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

            createEditButton.Text = @"Create";
            RefreshPublishersAndAuthorsList();
            RefreshGenres();
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
            RefreshGenres();
            FillInputFields();
            SearchAutoComplete();
        }

        public void FillInputFields()
        {
            nameTextBox.Text = _bookToEdit.Name;
            genreComboBox.Text = _bookToEdit.Genre.ToString();
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

        private void RefreshGenres()
        {
            Enum.GetValues(typeof(Genre)).Cast<Genre>().ToList().ForEach(genre => genreComboBox.Items.Add(genre));
        }

        private void SearchAutoComplete()
        {
            searchEntity.AutoCompleteCustomSource.Clear();

            _authorsRepository.GetAll().ForEach(author => searchEntity.AutoCompleteCustomSource.Add(author.FirstName + " " + author.LastName));
            _authorsRepository.GetAll().ForEach(author => searchEntity.AutoCompleteCustomSource.Add(author.LastName + " " + author.FirstName));
        }

        private void SearchAuthor(object sender, EventArgs e)
        {
            if (!searchCheckBox.Checked)
            {
                authorsListBox.Items.Clear();
                _authorsRepository.GetAll().ForEach(author =>
                {
                    if ((author.FirstName.ToLower() + " " + author.LastName.ToLower()).Contains(searchEntity.Text.ToLower()) ||
                        (author.LastName.ToLower() + " " + author.FirstName.ToLower()).Contains(searchEntity.Text.ToLower()))
                        authorsListBox.Items.Add(author);
                });
            }
            else
            {
                publishersListBox.Items.Clear();
                _publishersRepository.GetAll().ForEach(publisher =>
                {
                    if (publisher.Name.ToLower().Contains(searchEntity.Text.ToLower()))
                        publishersListBox.Items.Add(publisher);
                });
            }
        }

        private void SearchCheckedChanged(object sender, EventArgs e)
        {
            searchEntity.AutoCompleteCustomSource.Clear();

            if (searchCheckBox.Checked)
                _publishersRepository.GetAll().ForEach(publisher => searchEntity.AutoCompleteCustomSource.Add(publisher.Name));
            else
                SearchAutoComplete();
        }

        private bool CheckInputFields()
        {
            if (nameTextBox.Text == "" || genreComboBox.SelectedItem == null || numberOfCopiesTextBox.Text == "" ||
                numberOfPagesTextBox.Text == "" || authorsListBox.SelectedItem == null ||
                publishersListBox.SelectedItem == null)
            {
                MessageBox.Show(@"One or more input fields empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!nameTextBox.Text.CheckForForbiddenCharacters())
            {
                MessageBox.Show(@"Forbidden characters used in name input!", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (int.Parse(numberOfCopiesTextBox.Text) - _bookToEdit.GetNumberOfTakenCopies() < 0)
            {
                MessageBox.Show(@"You can't change number of copies to be lower than number of borrowed books!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nameTextBox.Text.NameFormatting().Length < 50) return true;

            MessageBox.Show(@"Name of the book is to long! (max: 50 characters)", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    Genre = (Genre)genreComboBox.SelectedItem,
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
                _bookToEdit.Genre = (Genre)genreComboBox.SelectedItem;
                _bookToEdit.NumberOfPages = int.Parse(numberOfPagesTextBox.Text);
                _bookToEdit.NumberOfCopies = int.Parse(numberOfCopiesTextBox.Text);

                _booksRepository.Edit(_bookToEdit);
            }

            Close();
        }

        private void Back(object sender, EventArgs e)
        {
            Close();
        }
    }
}