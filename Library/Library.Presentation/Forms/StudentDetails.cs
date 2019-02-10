using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities.Models;

namespace Library.Presentation.Forms
{
    public partial class StudentDetails : Form
    {
        private readonly Student _selectedStudent;

        public StudentDetails(Student selectedStudent)
        {
            InitializeComponent();

            _selectedStudent = selectedStudent;
            RefreshData();
        }

        private void RefreshData()
        {
            studentFullName.Text = _selectedStudent.FirstName + @" " + _selectedStudent.LastName;
            studentBirthdate.Text = _selectedStudent.Birthdate.ToString("d");
            classLabel.Text += _selectedStudent.Class;
            genderLabel.Text += _selectedStudent.Gender.ToString();
            _selectedStudent.Loans.ToList().ForEach(student => loansListBox.Items.Add(student));
        }
    }
}