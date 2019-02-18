using System;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;
using Library.Infrastructure.Extensions;

namespace Library.Presentation.Forms.PublisherForms
{
    public partial class CreateEditPublisher : Form
    {
        private readonly PublishersRepository _publishersRepository;
        private readonly Publisher _publisherToEdit;

        public CreateEditPublisher()
        {
            InitializeComponent();
            var context = new LibraryContext();
            _publishersRepository = new PublishersRepository(context);
            createEditButton.Text = @"Create";
        }

        public CreateEditPublisher(Publisher publisherToEdit)
        {
            InitializeComponent();

            var context = new LibraryContext();
            _publishersRepository = new PublishersRepository(context);
            _publisherToEdit = publisherToEdit;
            createEditButton.Text = @"Edit";

            FillInputFields();
        }

        public void FillInputFields()
        {
            nameTextBox.Text = _publisherToEdit.Name;
        }

        public bool CheckInputFields()
        {
            if (!nameTextBox.Text.CheckForForbiddenCharacters())
            {
                MessageBox.Show(@"Forbidden characters used in name input!", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nameTextBox.Text != "") return true;
            MessageBox.Show(@"One or more input fields empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }

        private void CreateEdit(object sender, EventArgs e)
        {
            if (!CheckInputFields()) return;

            if (_publisherToEdit == null)
            {
                var newPublisher = new Publisher
                {
                    Name = nameTextBox.Text,
                };

                _publishersRepository.Add(newPublisher);
            }
            else
            {
                _publisherToEdit.Name = nameTextBox.Text;
                _publishersRepository.Edit(_publisherToEdit);
            }

            Close();
        }
    }
}
