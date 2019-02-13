﻿using System;
using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms.LoanForms
{
    public partial class CreateEditLoan : Form
    {
        private readonly LoansRepository _loansRepository;
        private readonly StudentsRepository _studentsRepository;
        private readonly BooksRepository _booksRepository;

        public CreateEditLoan()
        {
            InitializeComponent();

            var context = new LibraryContext();
            _loansRepository = new LoansRepository(context);
            _studentsRepository = new StudentsRepository(context);
            _booksRepository = new BooksRepository(context);

            RefreshStudentsAndBooksList();
        }

        private void RefreshStudentsAndBooksList()
        {
            _studentsRepository.GetAll().ForEach(student => studentsListBox.Items.Add(student));
            _booksRepository.GetAll().ForEach(book => booksListBox.Items.Add(book));
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

            if (currentStudentLoan != null)
            {
                MessageBox.Show(@"Selected student has active loan!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (booksListBox.SelectedItem is Book selectedItemAsBook && selectedItemAsBook.NumberOfCopies - selectedItemAsBook.GetNumberOfTakenCopies() != 0) return true;
            MessageBox.Show(@"Selected book has no available copies!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }

        private void Create(object sender, EventArgs e)
        {
            if (!CheckInputFields()) return;

            var newLoan = new Loan
            {
                StudentId = ((Student) studentsListBox.SelectedItem).Id,
                BookId = ((Book) booksListBox.SelectedItem).Id,
                PickupDate = DateTime.Now,
                ReturnDeadline = DateTime.Now.AddDays(21)
            };

            _loansRepository.Add(newLoan);
            Close();
        }
    }
}