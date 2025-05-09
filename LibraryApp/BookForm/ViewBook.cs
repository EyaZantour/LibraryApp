using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryNotebook.Data.Repositories;

namespace LibraryNotebook.BookForm
{
    public partial class ViewBook : Form
    {
        private readonly BookRepository _bookRepo;

        public ViewBook(BookRepository bookRepo)
        {
            InitializeComponent();
            _bookRepo = bookRepo ?? throw new ArgumentNullException(nameof(bookRepo));

            // ✅ Hook up the SelectionChanged event properly
            dataGridViewBooks.SelectionChanged += dataGridViewBooks_SelectionChanged;
            btnCancel.Click += btnCancel_Click;

        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            var books = _bookRepo.GetAll();

            dataGridViewBooks.DataSource = books.Select(b => new
            {
                b.Id,
                b.Title,
                b.Author,
                b.AddedDate,
                b.Quantity,
            }).ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }



        // ✅ Corrected this — was CellContentClick before
        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                var row = dataGridViewBooks.SelectedRows[0];

                txtEditTitle.Text = row.Cells["Title"].Value?.ToString();
                txtEditAuthor.Text = row.Cells["Author"].Value?.ToString();
                txtEditQuantity.Text = row.Cells["Quantity"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["AddedDate"].Value?.ToString(), out DateTime date))
                {
                    dateTimeEdit.Value = date;
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }

            var selectedId = (int)dataGridViewBooks.SelectedRows[0].Cells["Id"].Value;
            var book = _bookRepo.GetById(selectedId);

            book.Title = txtEditTitle.Text.Trim();
            book.Author = txtEditAuthor.Text.Trim();
            book.Quantity = int.TryParse(txtEditQuantity.Text.Trim(), out int q) ? q : 0;
            book.AddedDate = dateTimeEdit.Value;

            _bookRepo.Update(book);

            MessageBox.Show("Book updated successfully!");
            LoadBooks();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();

            var filteredBooks = _bookRepo.GetAll()
                .Where(b => b.Title.ToLower().Contains(search))
                .Select(b => new
                {
                    b.Id,
                    b.Title,
                    b.Author,
                    b.Quantity,
                    b.AddedDate
                }).ToList();

            dataGridViewBooks.DataSource = filteredBooks;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            var selectedId = Convert.ToInt32(dataGridViewBooks.SelectedRows[0].Cells["Id"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                _bookRepo.Delete(selectedId);
                LoadBooks();
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEditTitle.Clear();
            txtEditAuthor.Clear();
            txtEditQuantity.Clear();
            dateTimeEdit.Value = DateTime.Now;

            dataGridViewBooks.ClearSelection();

        }

        
    }
}
