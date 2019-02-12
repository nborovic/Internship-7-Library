using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms
{
    public partial class CreateEditPublisher : Form
    {
        private readonly PublishersRepository _publishersRepository;

        public CreateEditPublisher()
        {
            InitializeComponent();
            var context = new LibraryContext();
            _publishersRepository = new PublishersRepository(context);
        }

        public bool CheckInputFields()
        {
            if (nameTextBox.Text != "") return true;
            MessageBox.Show(@"One or more input fields empty!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }

        private void Create(object sender, EventArgs e)
        {
            if (!CheckInputFields()) return;

            var newPublisher = new Publisher
            {
                Name = nameTextBox.Text,
            };

            _publishersRepository.Add(newPublisher);
            Close();
        }
    }
}
