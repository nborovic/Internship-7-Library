using System;
using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms.LoanForms
{
    public partial class CreateEditLoan : Form
    {
        private readonly LoansRepository _loansRepository;
        private readonly StudentsRepository _studentsRepository;
        private readonly BooksRepository _booksRepository;
        private readonly Loan _loanToEdit;

        public CreateEditLoan()
        {
            InitializeComponent();

            var context = new LibraryContext();
            _loansRepository = new LoansRepository(context);
            _studentsRepository = new StudentsRepository(context);
            _booksRepository = new BooksRepository(context);

            createButton.Text = @"Create";
            RefreshStudentsAndBooksList();
            SearchAutoComplete();
        }

        public CreateEditLoan(Loan loanToEdit)
        {
            InitializeComponent();

            var context = new LibraryContext();
            _loansRepository = new LoansRepository(context);
            _studentsRepository = new StudentsRepository(context);
            _booksRepository = new BooksRepository(context);
            _loanToEdit = loanToEdit;

            createButton.Text = @"Edit";
            RefreshStudentsAndBooksList();
            FillInputFields();
            SearchAutoComplete();
        }

        private void FillInputFields()
        {
            studentsListBox.Text = _loanToEdit.Student.ToString();
            booksListBox.Text = _loanToEdit.Book.ToString();
        }

        private void RefreshStudentsAndBooksList()
        {
            _studentsRepository.GetAll().ForEach(student => studentsListBox.Items.Add(student));
            _booksRepository.GetAll().ForEach(book => booksListBox.Items.Add(book));
        }

        private void SearchAutoComplete()
        {
            searchEntity.AutoCompleteCustomSource.Clear();

            _studentsRepository.GetAll().ForEach(student => searchEntity.AutoCompleteCustomSource.Add(student.FirstName + " " + student.LastName));
            _studentsRepository.GetAll().ForEach(student => searchEntity.AutoCompleteCustomSource.Add(student.LastName + " " + student.FirstName));
        }

        private void SearchStudent(object sender, EventArgs e)
        {
            if (!searchCheckBox.Checked)
            {
                studentsListBox.Items.Clear();
                _studentsRepository.GetAll().ForEach(student =>
                {
                    if ((student.FirstName.ToLower() + " " + student.LastName.ToLower()).Contains(searchEntity.Text.ToLower()) ||
                        (student.LastName.ToLower() + " " + student.FirstName.ToLower()).Contains(searchEntity.Text.ToLower()))
                        studentsListBox.Items.Add(student);
                });
            }
            else
            {
                booksListBox.Items.Clear();
                _booksRepository.GetAll().ForEach(book =>
                {
                    if (book.Name.ToLower().Contains(searchEntity.Text.ToLower()) ||
                        (book.Author.FirstName.ToLower() + " " + book.Author.LastName.ToLower()).Contains(
                            searchEntity.Text.ToLower()) ||
                        (book.Author.LastName.ToLower() + " " + book.Author.FirstName.ToLower()).Contains(
                            searchEntity.Text.ToLower()) ||
                        book.Genre.ToString().ToLower().Contains(searchEntity.Text.ToLower()))
                        booksListBox.Items.Add(book);
                });
            }
        }

        private void SearchCheckedChanged(object sender, EventArgs e)
        {
            searchEntity.AutoCompleteCustomSource.Clear();

            if (searchCheckBox.Checked)
            {
                _booksRepository.GetAll().ForEach(book => searchEntity.AutoCompleteCustomSource.Add(book.Name));
                _booksRepository.GetAll().ForEach(book => searchEntity.AutoCompleteCustomSource.Add(book.Author.FirstName + " " + book.Author.LastName));
                _booksRepository.GetAll().ForEach(book => searchEntity.AutoCompleteCustomSource.Add(book.Author.LastName + " " + book.Author.FirstName));
                Enum.GetValues(typeof(Genre)).Cast<Genre>().ToList().ForEach(genre => searchEntity.AutoCompleteCustomSource.Add(genre.ToString()));
            }
            else
                SearchAutoComplete();

        }

        private bool CheckInputFields()
        {
            if (studentsListBox.SelectedItem == null && booksListBox.SelectedItem == null)
            {
                MessageBox.Show(@"One or more input fields empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var currentStudentLoan = ((Student) studentsListBox.SelectedItem)?.Loans.ToList()
                .FirstOrDefault(loan => loan.ReturnDate == null);

            if (currentStudentLoan != null && _loanToEdit == null)
            {
                MessageBox.Show(@"Selected student has active loan!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (booksListBox.SelectedItem is Book selectedItemAsBook && selectedItemAsBook.NumberOfCopies - selectedItemAsBook.GetNumberOfTakenCopies() != 0) return true;
            MessageBox.Show(@"Selected book has no available copies!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }

        private void CreateEdit(object sender, EventArgs e)
        {
            if (!CheckInputFields()) return;

            if (_loanToEdit == null)
            {
                var newLoan = new Loan
                {
                    StudentId = ((Student)studentsListBox.SelectedItem).Id,
                    BookId = ((Book)booksListBox.SelectedItem).Id,
                    PickupDate = DateTime.Now,
                    ReturnDeadline = DateTime.Now.AddDays(21)
                };

                _loansRepository.Add(newLoan);
            }
            else
            {
                _loanToEdit.StudentId = ((Student)studentsListBox.SelectedItem).Id;
                _loanToEdit.BookId = ((Book)booksListBox.SelectedItem).Id;

                _loansRepository.Edit(_loanToEdit);
            }

            Close();
        }

        private void Back(object sender, EventArgs e)
        {
            Close();
        }
    }
}