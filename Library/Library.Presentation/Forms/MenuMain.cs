using System;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;
using Library.Presentation.Forms.BookForms;
using Library.Presentation.Forms.LoanForms;
using Library.Presentation.Forms.PublisherForms;

namespace Library.Presentation.Forms
{
    public partial class MenuMain : Form
    {
        private AuthorsRepository _authorsRepository;
        private StudentsRepository _studentsRepository;
        private PublishersRepository _publishersRepository;
        private BooksRepository _booksRepository;
        private LoansRepository _loansRepository;
        private int _option = 1;

        public MenuMain()
        {
            InitializeComponent();
            RefreshRepositories();
            RefreshList();
            SearchAutoComplete();
        }

        /* List refresh methods */

        private void RefreshRepositories()
        {
            var context = new LibraryContext();
            _authorsRepository = new AuthorsRepository(context);
            _studentsRepository = new StudentsRepository(context);
            _publishersRepository = new PublishersRepository(context);
            _booksRepository = new BooksRepository(context);
            _loansRepository = new LoansRepository(context);
        }

        private void RefreshList()
        {
            entitiesListBox.Items.Clear();

            switch (_option)
            {
                case 1:
                    _authorsRepository.GetAll().ForEach(author => entitiesListBox.Items.Add(author));
                    filterCheckBox.Visible = true;
                    break;
                case 2:
                    _publishersRepository.GetAll().ForEach(publisher => entitiesListBox.Items.Add(publisher));
                    filterCheckBox.Visible = false;
                    break;
                case 3:
                    _studentsRepository.GetAll().ForEach(student => entitiesListBox.Items.Add(student));
                    filterCheckBox.Visible = true;
                    break;
                case 4:
                    _booksRepository.GetAll().ForEach(book => entitiesListBox.Items.Add(book));
                    filterCheckBox.Visible = false;
                    break;
                case 5:
                    _loansRepository.GetAll().ForEach(loan => entitiesListBox.Items.Add(loan));
                    filterCheckBox.Visible = false;
                    break;
                default:
                    CommonErrorMessage();
                    break;
            }

            SearchAutoComplete();
        }

        private void AuthorsRefresh(object sender, EventArgs e)
        {
            _option = 1;
            RefreshList();
        }

        private void PublishersRefresh(object sender, EventArgs e)
        {
            _option = 2;
            RefreshList();
        }

        private void StudentsRefresh(object sender, EventArgs e)
        {
            _option = 3;
            RefreshList();
        }

        private void BooksRefresh(object sender, EventArgs e)
        {
            _option = 4;
            RefreshList();
        }

        private void LoansRefresh(object sender, EventArgs e)
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

        /* Search auto complete */

        private void SearchAutoComplete()
        {
            searchEntity.AutoCompleteCustomSource.Clear();

            switch (_option)
            {
                case 1:
                    _authorsRepository.GetAll().ForEach(author => searchEntity.AutoCompleteCustomSource.Add(author.FirstName + " " + author.LastName));
                    break;
                case 2:
                    _publishersRepository.GetAll().ForEach(publisher => searchEntity.AutoCompleteCustomSource.Add(publisher.Name));
                    break;
                case 3:
                    _studentsRepository.GetAll().ForEach(student => searchEntity.AutoCompleteCustomSource.Add(student.FirstName + " " + student.LastName));
                    break;
                case 4:
                    _booksRepository.GetAll().ForEach(book => searchEntity.AutoCompleteCustomSource.Add(book.Name));
                    break;
                case 5:
                    _loansRepository.GetAll().ForEach(loan => searchEntity.AutoCompleteCustomSource.Add(loan.Book.Name));
                    break;
                default:
                    CommonErrorMessage();
                    break;
            }
        }

        private void LastNameChecked(object sender, EventArgs e)
        {
            searchEntity.AutoCompleteCustomSource.Clear();

            if (filterCheckBox.Checked)
            {
                switch (_option)
                {
                    case 1:
                        _authorsRepository.GetAll().ForEach(author => searchEntity.AutoCompleteCustomSource.Add(author.LastName + " " + author.FirstName));
                        break;
                    case 2:
                        break;
                    case 3:
                        _studentsRepository.GetAll().ForEach(student => searchEntity.AutoCompleteCustomSource.Add(student.LastName + " " + student.FirstName));
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        CommonErrorMessage();
                        break;
                }
            }
            else
            {
                SearchAutoComplete();
            }         
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

        private void Remove(object sender, EventArgs e)
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
                    CommonErrorMessage();
                    break;
            }

            RefreshList();
        }

        /* Create */

        private void Create(object sender, EventArgs e)
        {
            switch (_option)
            {
                case 1:
                    var createAuthorWindow = new CreateEditAuthor();
                    createAuthorWindow.ShowDialog();
                    break;
                case 2:
                    var createPublisherWindow = new CreateEditPublisher();
                    createPublisherWindow.ShowDialog();
                    break;
                case 3:
                    var createStudentWindow = new CreateEditStudent();
                    createStudentWindow.ShowDialog();
                    break;
                case 4:
                    var createBookWindow = new CreateEditBook();
                    createBookWindow.ShowDialog();
                    break;
                case 5:
                    var createLoanWindow = new CreateEditLoan();
                    createLoanWindow.ShowDialog();
                    break;
                default:
                    CommonErrorMessage();
                    break;
            }

            RefreshList();
        }

        /* Edit */

        private void Edit(object sender, EventArgs e)
        {
            if (!CheckForSelectedItem()) return;

            switch (_option)
            {
                case 1:
                    var editAuthorWindow = new CreateEditAuthor(entitiesListBox.SelectedItem as Author);
                    editAuthorWindow.ShowDialog();
                    break;
                case 2:
                    var editPublisherWindow = new CreateEditPublisher(entitiesListBox.SelectedItem as Publisher);
                    editPublisherWindow.ShowDialog();
                    break;
                case 3:
                    var editStudentWindow = new CreateEditStudent(entitiesListBox.SelectedItem as Student);
                    editStudentWindow.ShowDialog();
                    break;
                case 4:
                    var editBookWindow = new CreateEditBook(entitiesListBox.SelectedItem as Book);
                    editBookWindow.ShowDialog();
                    break;
                case 5:
                    var editLoanWindow = new CreateEditLoan(entitiesListBox.SelectedItem as Loan);
                    editLoanWindow.ShowDialog();
                    break;
                default:
                    CommonErrorMessage();
                    break;
            }

            RefreshRepositories();
            RefreshList();
        }
    }
}