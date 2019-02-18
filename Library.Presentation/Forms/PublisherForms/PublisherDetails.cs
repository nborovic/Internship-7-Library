using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities.Models;

namespace Library.Presentation.Forms.PublisherForms
{
    public partial class PublisherDetails : Form
    {
        private readonly Publisher _selectedPublisher;

        public PublisherDetails(Publisher selectedPublisher)
        {
            InitializeComponent();

            _selectedPublisher = selectedPublisher;
            RefreshData();
        }

        public void RefreshData()
        {
            publisherName.Text = _selectedPublisher.Name;
            _selectedPublisher.Books.ToList().ForEach(publisher => booksListBox.Items.Add(publisher));
        }

        private void Back(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
