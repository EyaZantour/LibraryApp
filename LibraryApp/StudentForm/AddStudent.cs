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
    public partial class AddStudent : Form
    {
        private readonly StudentRepository _studentRepo;

        public AddStudent(StudentRepository studentRepo)
        {
            InitializeComponent();
            _studentRepo = studentRepo ?? throw new ArgumentNullException(nameof(studentRepo));
        }



       

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            {
                var student = new Student
                {
                    FullName = txtFullName.Text.Trim(),
                    EnrollmentNumber = txtEnrollment.Text.Trim(),
                    Department = txtDept.Text.Trim(),
                    Semester = txtSemester.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                if (string.IsNullOrEmpty(student.FullName) || string.IsNullOrEmpty(student.EnrollmentNumber))
                {
                    MessageBox.Show("Please fill in at least Name and Enrollment No.");
                    return;
                }

                _studentRepo.Add(student);
                MessageBox.Show("Student added successfully!");
                this.Close();
            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}