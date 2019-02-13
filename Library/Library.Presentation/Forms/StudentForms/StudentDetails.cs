﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms
{
    public partial class StudentDetails : Form
    {
        private readonly Student _selectedStudent;
        private readonly LoansRepository _loansRepository;
        private Loan _currentLoan;

        public StudentDetails(Student selectedStudent)
        {
            InitializeComponent();

            var context = new LibraryContext();
            _selectedStudent = selectedStudent;
            _loansRepository = new LoansRepository(context);
            RefreshData();
        }

        private void RefreshData()
        {
            _currentLoan = null;

            // Didn't use FirstOrDefault because I need to track current loan in Edit() function, so that I don't have 2 trackings for the same id
            _selectedStudent.Loans.ToList().ForEach(loan =>
            {
                if (loan.ReturnDate == null)
                    _currentLoan = loan;
            });

            studentFullName.Text = _selectedStudent.FirstName + @" " + _selectedStudent.LastName;
            studentClass.Text = _selectedStudent.Class;
            birthdateLabel.Text = $@"Birthday: {_selectedStudent.Birthdate:d}";
            genderLabel.Text = $@"Gender: {_selectedStudent.Gender}";
            loansListBox.Items.Clear();

            _selectedStudent.Loans.ToList().ForEach(loan =>
            {
                if(loan.ReturnDate != null)
                    loansListBox.Items.Add(loan);
            });

            if (_currentLoan == null)
            {
                currentLoanLabel.Text = @"Current loan: No rented book";
                return;
            }

            currentLoanLabel.Text = $@"Current loan: {_currentLoan.Book.Name}";
        }

        private void Return(object sender, EventArgs e)
        {
            if (_currentLoan == null) return;
            var fine = DateTime.Now - _currentLoan.ReturnDeadline > TimeSpan.Zero
                ? (DateTime.Now - _currentLoan.ReturnDeadline).Days * 0.5
                : 0;

            var dialogResult = MessageBox.Show($@"Return delay fine: {fine}kn", @"Return", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult != DialogResult.OK) return;
        
            _currentLoan.ReturnDate = DateTime.Now;
            _loansRepository.Edit(_currentLoan);

            RefreshData();
        }
    }
}