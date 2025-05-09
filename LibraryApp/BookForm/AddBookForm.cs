using LibraryApp;
using LibraryNotebook.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryNotebook.Data.Entities;
using Microsoft.Extensions.DependencyInjection;


namespace LibraryNotebook.BookForm
{
    public partial class AddBookForm : Form
    {
        private readonly BookRepository _bookRepo;

        public AddBookForm(BookRepository bookRepo)
        {
            InitializeComponent();
            _bookRepo = bookRepo ?? throw new ArgumentNullException(nameof(bookRepo));

            //_bookRepo = Program.ServiceProvider.GetService<BookRepository>();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You will delete your unsaved Data", "Are you sure?? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            var newBook = new Book
            {
                Title = title,
                Author = author,
                Quantity = int.Parse(txtQuantity.Text),
                AddedDate = dateTimePicker1.Value
            };


            _bookRepo.Add(newBook);

            MessageBox.Show("Book added successfully!");
            this.Close();
        }

    }
}


