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

namespace LibraryNotebook.BookForm
{
    public partial class ReturnBook : Form
    {
        private readonly StudentRepository _studentRepo;
        private readonly BookRepository _bookRepo;
        private readonly IssueRepository _issueRepo;


        public ReturnBook(StudentRepository studentRepo, BookRepository bookRepo, IssueRepository issueRepo)
        {
            InitializeComponent();
            _studentRepo = studentRepo ?? throw new ArgumentNullException(nameof(studentRepo));
            _bookRepo = bookRepo ?? throw new ArgumentNullException(nameof(bookRepo));
            _issueRepo = issueRepo ?? throw new ArgumentNullException(nameof(issueRepo));

            dataGridViewIssuedBooks.SelectionChanged += dataGridViewIssuedBooks_SelectionChanged;

        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            var student = _studentRepo.GetByEnrollment(txtEnrollmentNo.Text.Trim());
            if (student == null) return;

            var issues = _issueRepo.GetUnreturnedByStudent(student.Id);

            dataGridViewIssuedBooks.DataSource = issues.Select(i => new
            {
                i.Id,
                BookTitle = i.Book.Title,
                i.IssueDate
            }).ToList();
        }

        private void dataGridViewIssuedBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewIssuedBooks.SelectedRows.Count > 0)
            {
                var row = dataGridViewIssuedBooks.SelectedRows[0];

                txtBookName.Text = row.Cells["BookTitle"].Value?.ToString();
                txtIssueDate.Text = row.Cells["IssueDate"].Value?.ToString();
                dtpReturnDate.Value = DateTime.Today;
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewIssuedBooks.SelectedRows.Count == 0) return;

            var issueId = (int)dataGridViewIssuedBooks.SelectedRows[0].Cells["Id"].Value;

            var issue = _issueRepo.GetById(issueId);
            issue.ReturnDate = dtpReturnDate.Value;
            _issueRepo.Update(issue);

            // Restore book quantity
            var book = _bookRepo.GetById(issue.BookId);
            book.Quantity += 1;
            _bookRepo.Update(book);

            MessageBox.Show("Book returned successfully!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollmentNo.Clear();
            dataGridViewIssuedBooks.DataSource = null;

            txtBookName.Clear();
            txtIssueDate.Clear();
            dtpReturnDate.Value = DateTime.Today;
        }


    }
}
