using System;
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
        private readonly Student _studentToEdit;

        public CreateEditStudent()
        {
            InitializeComponent();

            var context = new LibraryContext();
            _studentsRepository = new StudentsRepository(context);

            createEditButton.Text = @"Create";
            birthdayDatePicker.Value = DateTime.Now.AddYears(-5);
            RefreshClasses();
        }

        public CreateEditStudent(Student studentToEdit)
        {
            InitializeComponent();

            var context = new LibraryContext();
            _studentsRepository = new StudentsRepository(context);
            _studentToEdit = studentToEdit;

            createEditButton.Text = @"Edit";
            birthdayDatePicker.Value = DateTime.Now.AddYears(-5);
            RefreshClasses();
            FillInputFields();
        }

        private void FillInputFields()
        {
            firstNameTextBox.Text = _studentToEdit.FirstName;
            lastNameTextBox.Text = _studentToEdit.LastName;
            classComboBox.SelectedItem = _studentToEdit.Class;
            birthdayDatePicker.Value = _studentToEdit.Birthdate;
            maleRadioButton.Checked = _studentToEdit.Gender == Gender.Male;
            femaleRadioButton.Checked = _studentToEdit.Gender == Gender.Female;
        }

        private void RefreshClasses()
        {
            classComboBox.Items.AddRange(new object[] {"1.a", "1.b", "1.c", "2.a", "2.b", "2.c", "3.a", "3.b",
                "3.c", "4.a", "4.b", "4.c", "5.a", "5.b", "5.c", "6.a",
                "6.b", "6.c", "7.a","7.b", "7.c", "8.a", "8.b", "8.c" });
            classComboBox.SelectedIndex = 0;
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

        private void CreateEdit(object sender, EventArgs e)
        {
            if (!CheckInputFields()) return;

            if (_studentToEdit == null)
            {
                var newStudent = new Student
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Birthdate = birthdayDatePicker.Value.Date,
                    Class = classComboBox.SelectedItem.ToString(),
                    Gender = (maleRadioButton.Checked) ? Gender.Male : Gender.Female
                };

                _studentsRepository.Add(newStudent);
            }
            else
            {
                _studentToEdit.FirstName = firstNameTextBox.Text;
                _studentToEdit.LastName = lastNameTextBox.Text;
                _studentToEdit.Birthdate = birthdayDatePicker.Value.Date;
                _studentToEdit.Gender = (maleRadioButton.Checked) ? Gender.Male : Gender.Female;
                _studentToEdit.Class = classComboBox.SelectedItem.ToString();

                _studentsRepository.Edit(_studentToEdit);
            }

            Close();
        }
    }
}