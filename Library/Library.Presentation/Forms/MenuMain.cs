using System;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms
{
    public partial class MenuMain : Form
    {
        private readonly AuthorsRepository _authorsRepository;
        private readonly StudentsRepository _studentsRepository;
        private readonly PublishersRepository _publishersRepository;
        private readonly BooksRepository _booksRepository;
        private readonly LoansRepository _loansRepository;
        private int _option = 1;

        public MenuMain()
        {
            InitializeComponent();

            var context = new LibraryContext();
            _authorsRepository = new AuthorsRepository(context);
            _studentsRepository = new StudentsRepository(context);
            _publishersRepository = new PublishersRepository(context);
            _booksRepository = new BooksRepository(context);
            _loansRepository = new LoansRepository(context);
            RefreshList();
        }

        /* List refresh methods */

        private void RefreshList()
        {
            entitiesListBox.Items.Clear();

            switch (_option)
            {
                case 1:
                    _authorsRepository.GetAll().ForEach(author => entitiesListBox.Items.Add(author));
                    break;
                case 2:
                    _publishersRepository.GetAll().ForEach(publisher => entitiesListBox.Items.Add(publisher));

                    break;
                case 3:
                    _studentsRepository.GetAll().ForEach(student => entitiesListBox.Items.Add(student));
                    break;
                case 4:
                    _booksRepository.GetAll().ForEach(book => entitiesListBox.Items.Add(book));
                    break;
                case 5:
                    _loansRepository.GetAll().ForEach(loan => entitiesListBox.Items.Add(loan));
                    break;
                default:
                    MessageBox.Show(@"Something went wrong", @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void AuthorsRefresh(object sender, System.EventArgs e)
        {
            _option = 1;
            RefreshList();
        }

        private void PublishersRefresh(object sender, System.EventArgs e)
        {
            _option = 2;
            RefreshList();
        }

        private void StudentsRefresh(object sender, System.EventArgs e)
        {
            _option = 3;
            RefreshList();
        }

        private void BooksRefresh(object sender, System.EventArgs e)
        {
            _option = 4;
            RefreshList();
        }

        private void LoansRefresh(object sender, System.EventArgs e)
        {
            _option = 5;
            RefreshList();
        }

        private bool CheckForSelectedItem()
        {
            if (entitiesListBox.SelectedItem != null) return true;
            MessageBox.Show(@"No item selected", @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void CommonErrorMessage()
        {
            MessageBox.Show(@"Something went wrong", @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /* Details */

        private void Details(object sender, EventArgs e)
        {
            if (!CheckForSelectedItem()) return;
            switch (_option)
            {
                case 1:
                    var authorDetailsWindow = new AuthorDetails(entitiesListBox.SelectedItem as Author);
                    authorDetailsWindow.ShowDialog();
                    break;
                case 2:
                    var publisherDetailsWindow = new PublisherDetails(entitiesListBox.SelectedItem as Publisher);
                    publisherDetailsWindow.ShowDialog();
                    break;
                case 3:
                    var studentDetailsWindow = new StudentDetails(entitiesListBox.SelectedItem as Student);
                    studentDetailsWindow.ShowDialog();
                    break;
                case 4:
                    var bookDetailsWindow = new BookDetails(entitiesListBox.SelectedItem as Book);
                    bookDetailsWindow.ShowDialog();
                    break;
                case 5:
                    var loanDetailsWindow = new LoanDetails(entitiesListBox.SelectedItem as Loan);
                    loanDetailsWindow.ShowDialog();
                    break;
                default:
                    CommonErrorMessage();
                    break;
            }
        }

        /* Remove */

        private void Remove(object sender, System.EventArgs e)
        {
            if (!CheckForSelectedItem()) return;
            switch (_option)
            {
                case 1:
                    _authorsRepository.Remove(entitiesListBox.SelectedItem as Author);
                    break;
                case 2:
                    _publishersRepository.Remove(entitiesListBox.SelectedItem as Publisher);
                    break;
                case 3:
                    _studentsRepository.Remove(entitiesListBox.SelectedItem as Student);
                    break;
                case 4:
                    _booksRepository.Remove(entitiesListBox.SelectedItem as Book);
                    break;
                case 5:
                    _loansRepository.Remove(entitiesListBox.SelectedItem as Loan);
                    break;
                default:
                    MessageBox.Show(@"Something went wrong", @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            RefreshList();
        }
    }
}