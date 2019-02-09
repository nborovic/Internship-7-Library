using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms
{
    public partial class MenuMain : Form
    {
        private readonly AuthorsRepository _authorsRepository  = new AuthorsRepository();
        private readonly StudentsRepository _studentsRepository = new StudentsRepository();
        private readonly PublishersRepository _publishersRepository = new PublishersRepository();
        private readonly BooksRepository _booksRepository = new BooksRepository();
        private readonly LoansRepository _loansRepository = new LoansRepository();

        public MenuMain()
        {
            InitializeComponent();
        }
    }
}