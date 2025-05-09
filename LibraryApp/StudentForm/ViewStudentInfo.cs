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

namespace LibraryNotebook.StudentForm
{
    public partial class ViewStudentInfo : Form
    {
        private readonly StudentRepository _studentRepo;

        public ViewStudentInfo(StudentRepository studentRepo)
        {
            InitializeComponent();
            _studentRepo = studentRepo ?? throw new ArgumentNullException(nameof(studentRepo));
            dataGridViewStudents.SelectionChanged += dataGridViewStudents_SelectionChanged;
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                var row = dataGridViewStudents.SelectedRows[0];

                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtEnrollmentNo.Text = row.Cells["EnrollmentNumber"].Value?.ToString();
                txtDept.Text = row.Cells["Department"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
            }
        }




        private void btnSearch_Click(object sender, EventArgs e)
        {
            string enrollmentNo = txtEnrollmentSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(enrollmentNo))
            {
                MessageBox.Show("Please enter an enrollment number.");
                return;
            }

            var student = _studentRepo.GetByEnrollment(enrollmentNo);
            if (student != null)
            {
                dataGridViewStudents.DataSource = new List<Student> { student };
            }
            else
            {
                MessageBox.Show("No student found.");
                dataGridViewStudents.DataSource = null;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            var selectedId = (int)dataGridViewStudents.SelectedRows[0].Cells["Id"].Value;
            var student = _studentRepo.GetById(selectedId);

            student.FullName = txtFullName.Text.Trim();
            student.EnrollmentNumber = txtEnrollmentNo.Text.Trim();
            student.Department = txtDept.Text.Trim();
            student.Email = txtEmail.Text.Trim();

            _studentRepo.Update(student);
            MessageBox.Show("Student info updated!");

            dataGridViewStudents.DataSource = new List<Student> { student };
            dataGridViewStudents.AutoGenerateColumns = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var selectedId = (int)dataGridViewStudents.SelectedRows[0].Cells["Id"].Value;

            var confirm = MessageBox.Show("Are you sure you want to delete this student?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                _studentRepo.Delete(selectedId);
                MessageBox.Show("Student deleted.");
                dataGridViewStudents.DataSource = null;

                // Optionally clear the textboxes
                txtFullName.Clear();
                txtEnrollmentNo.Clear();
                txtDept.Clear();
                txtEmail.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
