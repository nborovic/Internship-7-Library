using System;
using System.Windows.Forms;
using Library.Data.Entities.Models;

namespace Library.Presentation.Forms.LoanForms
{
    public partial class LoanDetails : Form
    {
        private readonly Loan _selectedLoan;

        public LoanDetails(Loan selectedLoan)
        {
            InitializeComponent();

            _selectedLoan = selectedLoan;
            RefreshData();
        }

        private void RefreshData()
        {
            studentName.Text = _selectedLoan.Student.FirstName + @" " + _selectedLoan.Student.LastName;
            bookName.Text = _selectedLoan.Book.Name;
            pickupDateLabel.Text = $@"Pickup date: {_selectedLoan.PickupDate:d}";
            returnDeadlineLabel.Text = $@"Return deadline: {_selectedLoan.ReturnDeadline:d}";
            returnDateLabel.Text = _selectedLoan.ReturnDate == null ? @"Return date: Not returned" : $@"Return date: {_selectedLoan.ReturnDate:d}";
        }

        private void Back(object sender, EventArgs e)
        {
            Close();
        }
    }
}
