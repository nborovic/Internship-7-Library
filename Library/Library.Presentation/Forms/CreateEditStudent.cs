﻿using System;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms
{
    public partial class CreateEditStudent : Form
    {
        private readonly StudentsRepository _studentsRepository;

        public CreateEditStudent()
        {
            InitializeComponent();

            var context = new LibraryContext();
            _studentsRepository = new StudentsRepository(context);
            birthdayDatePicker.Value = DateTime.Now.AddYears(-5);

            RefreshClasses();
        }

        private void RefreshClasses()
        {
            classComboBox.Items.AddRange(new object[] {"1.a", "2.a", "3.a", "4.a", "5.a", "6.a", "7.a", "8.a",
                "1.b", "2.b", "3.b", "4.b", "5.b", "6.b", "7.b", "8.b",
                "1.c", "2.c", "3.c","4.c", "5.c", "6.c", "7.c", "8.c" });
        }

        private bool CheckIfBirthdayAndGradeCoincide(int year)
        {
            for (var grade = 1; grade <= 8; grade++)
                if (classComboBox.SelectedItem.ToString().Contains(grade.ToString()) && year >= grade + 4 &&
                    year <= grade + 7)
                    return true;

            return false;
        }

        private bool CheckInputFields()
        {
            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" ||
                !maleRadioButton.Checked && !femaleRadioButton.Checked)
            {
                MessageBox.Show(@"One or more input fields empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Check if birthday and grade coincide 

            if (CheckIfBirthdayAndGradeCoincide(DateTime.Now.Year - birthdayDatePicker.Value.Date.Year)) return true;
            MessageBox.Show(@"Birthday and grade don't coincide!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void Create(object sender, EventArgs e)
        {
            if (!CheckInputFields()) return;

            var newStudent = new Student
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Birthdate = birthdayDatePicker.Value.Date,
                Class = classComboBox.SelectedItem.ToString(),
                Gender = (maleRadioButton.Checked) ? Gender.Male : Gender.Female

            };

            _studentsRepository.Add(newStudent);
            Close();
        }
    }
}