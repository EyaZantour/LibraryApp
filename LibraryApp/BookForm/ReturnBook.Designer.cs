namespace LibraryNotebook.BookForm
{
    partial class ReturnBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            button3 = new Button();
            btnRefresh = new Button();
            btnSearchStudent = new Button();
            txtEnrollmentNo = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnCancel = new Button();
            btnReturnBook = new Button();
            dtpReturnDate = new DateTimePicker();
            txtIssueDate = new TextBox();
            txtBookName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            dataGridViewIssuedBooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIssuedBooks).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(207, 400);
            button3.Name = "button3";
            button3.Size = new Size(98, 43);
            button3.TabIndex = 5;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(56, 400);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 43);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.FlatStyle = FlatStyle.Popup;
            btnSearchStudent.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStudent.Location = new Point(99, 315);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(158, 48);
            btnSearchStudent.TabIndex = 3;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txtEnrollmentNo
            // 
            txtEnrollmentNo.Font = new Font("Microsoft Sans Serif", 12F);
            txtEnrollmentNo.Location = new Point(39, 255);
            txtEnrollmentNo.Name = "txtEnrollmentNo";
            txtEnrollmentNo.Size = new Size(281, 30);
            txtEnrollmentNo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F);
            label2.Location = new Point(56, 200);
            label2.Name = "label2";
            label2.Size = new Size(249, 29);
            label2.TabIndex = 1;
            label2.Text = "Enter Enrollement NO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(99, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnSearchStudent);
            panel2.Controls.Add(txtEnrollmentNo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(352, 478);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnReturnBook);
            panel3.Controls.Add(dtpReturnDate);
            panel3.Controls.Add(txtIssueDate);
            panel3.Controls.Add(txtBookName);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(370, 496);
            panel3.Name = "panel3";
            panel3.Size = new Size(633, 164);
            panel3.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(486, 92);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 33);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReturnBook
            // 
            btnReturnBook.FlatStyle = FlatStyle.Popup;
            btnReturnBook.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturnBook.Location = new Point(486, 37);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(94, 36);
            btnReturnBook.TabIndex = 7;
            btnReturnBook.Text = "Return";
            btnReturnBook.UseVisualStyleBackColor = true;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(251, 116);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(181, 27);
            dtpReturnDate.TabIndex = 6;
            // 
            // txtIssueDate
            // 
            txtIssueDate.Location = new Point(251, 72);
            txtIssueDate.Name = "txtIssueDate";
            txtIssueDate.Size = new Size(181, 27);
            txtIssueDate.TabIndex = 5;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(251, 22);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(181, 27);
            txtBookName.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(57, 72);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 4;
            label6.Text = "Book Issue Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(57, 118);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 3;
            label5.Text = "Book Return Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(57, 24);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // dataGridViewIssuedBooks
            // 
            dataGridViewIssuedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIssuedBooks.Location = new Point(370, 12);
            dataGridViewIssuedBooks.Name = "dataGridViewIssuedBooks";
            dataGridViewIssuedBooks.RowHeadersWidth = 51;
            dataGridViewIssuedBooks.Size = new Size(612, 478);
            dataGridViewIssuedBooks.TabIndex = 5;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1008, 649);
            Controls.Add(dataGridViewIssuedBooks);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "ReturnBook";
            Text = "ReturnBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIssuedBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button btnRefresh;
        private Button btnSearchStudent;
        private TextBox txtEnrollmentNo;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Label label1;
        private TextBox txtIssueDate;
        private TextBox txtBookName;
        private DateTimePicker dtpReturnDate;
        private Button btnCancel;
        private Button btnReturnBook;
        private DataGridView dataGridViewIssuedBooks;
    }
}