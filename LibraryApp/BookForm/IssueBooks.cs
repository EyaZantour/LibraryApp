using LibraryNotebook.Data.Entities;
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
    public partial class IssueBooks : Form
    {
        private readonly StudentRepository _studentRepo;
        private readonly BookRepository _bookRepo;
        private readonly IssueRepository _issueRepo;


        public IssueBooks(StudentRepository studentRepo, BookRepository bookRepo, IssueRepository issueRepo)
        {
            InitializeComponent();
            _studentRepo = studentRepo ?? throw new ArgumentNullException(nameof(studentRepo));
            _bookRepo = bookRepo ?? throw new ArgumentNullException(nameof(bookRepo));
            _issueRepo = issueRepo ?? throw new ArgumentNullException(nameof(issueRepo));
        }


        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            var student = _studentRepo.GetByEnrollment(txtEnrollmentNo.Text.Trim());

            if (student != null)
            {
                txtName.Text = student.FullName;
                txtDept.Text = student.Department;
                txtSemester.Text = student.Semester;
                txtEmail.Text = student.Email;
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            var books = _bookRepo.GetAll().Where(b => b.Quantity > 0).ToList();
            cmbBookTitle.DataSource = books;
            cmbBookTitle.DisplayMember = "Title";
            cmbBookTitle.ValueMember = "Id";
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            var student = _studentRepo.GetByEnrollment(txtEnrollmentNo.Text.Trim());
            if (student == null) return;

            var bookId = (int)cmbBookTitle.SelectedValue;

            var issue = new Issue
            {
                StudentId = student.Id,
                BookId = bookId,
                IssueDate = dtpIssueDate.Value,
                ReturnDate = null
            };

            _issueRepo.Add(issue);

            // Decrease quantity
            var book = _bookRepo.GetById(bookId);
            book.Quantity -= 1;
            _bookRepo.Update(book);

            MessageBox.Show("Book issued successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollmentNo.Clear();
            txtName.Clear();
            txtDept.Clear();
            txtSemester.Clear();
            txtEmail.Clear();

            cmbBookTitle.SelectedIndex = -1; // Deselect book
            dtpIssueDate.Value = DateTime.Today;
        }


    }
}
