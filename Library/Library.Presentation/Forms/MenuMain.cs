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

        public MenuMain()
        {
            InitializeComponent();

            var context = new LibraryContext();
            _authorsRepository = new AuthorsRepository(context);
            _studentsRepository = new StudentsRepository(context);
            _publishersRepository = new PublishersRepository(context);
            _booksRepository = new BooksRepository(context);
            _loansRepository = new LoansRepository(context);
            _authorsRepository.GetAll().ForEach(author => entitiesListBox.Items.Add(author));
        }

        private void AuthorsRefresh(object sender, System.EventArgs e)
        {
            entitiesListBox.Items.Clear();
            _authorsRepository.GetAll().ForEach(author => entitiesListBox.Items.Add(author));
        }

        private void PublishersRefresh(object sender, System.EventArgs e)
        {
            entitiesListBox.Items.Clear();
            _publishersRepository.GetAll().ForEach(publisher => entitiesListBox.Items.Add(publisher));
        }

        private void StudentsRefresh(object sender, System.EventArgs e)
        {
            entitiesListBox.Items.Clear();
            _studentsRepository.GetAll().ForEach(student => entitiesListBox.Items.Add(student));
        }

        private void BooksRefresh(object sender, System.EventArgs e)
        {
            entitiesListBox.Items.Clear();
            _booksRepository.GetAll().ForEach(book => entitiesListBox.Items.Add(book));
        }

        private void LoansRefresh(object sender, System.EventArgs e)
        {
            entitiesListBox.Items.Clear();
            _loansRepository.GetAll().ForEach(loan => entitiesListBox.Items.Add(loan));
        }
    }
}