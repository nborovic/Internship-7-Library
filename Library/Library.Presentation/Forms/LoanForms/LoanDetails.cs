using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities.Models;

namespace Library.Presentation.Forms
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
    }
}
