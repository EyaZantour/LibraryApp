using LibraryApp;
using LibraryNotebook.BookForm;
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
using Microsoft.Extensions.DependencyInjection;
using LibraryNotebook.StudentForm; // Required for GetRequiredService


namespace LibraryNotebook
{


    public partial class DashboardForm : Form
    {

        /* private readonly IServiceProvider _serviceProvider;

         public DashboardForm(IServiceProvider serviceProvider)
         {
             _serviceProvider = serviceProvider;
             InitializeComponent();
         } */

        private readonly BookRepository _bookRepo;

        public DashboardForm(BookRepository bookRepo)
        {
            InitializeComponent();
            _bookRepo = bookRepo;
        }



        /*  public DashboardForm()
          {
              InitializeComponent();
          } */

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addBookForm = Program.ServiceProvider.GetRequiredService<AddBookForm>();

            // var form = new AddBookForm();
            addBookForm.ShowDialog();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vb = Program.ServiceProvider.GetRequiredService<ViewBook>();
            vb.ShowDialog();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var issB = Program.ServiceProvider.GetRequiredService<IssueBooks>();
            issB.ShowDialog();

        }



        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var returnF = Program.ServiceProvider.GetRequiredService<ReturnBook>();
            returnF.ShowDialog();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<AddStudent>();
            form.ShowDialog();

        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studInfoform = Program.ServiceProvider.GetRequiredService<ViewStudentInfo>();
            studInfoform.ShowDialog();

        }
    }
}
    