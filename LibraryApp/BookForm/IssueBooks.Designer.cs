namespace LibraryNotebook.BookForm
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            btnRefresh = new Button();
            btnSearchStudent = new Button();
            txtEnrollmentNo = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            cmbBookTitle = new ComboBox();
            label9 = new Label();
            btnIssueBook = new Button();
            dtpIssueDate = new DateTimePicker();
            txtDept = new TextBox();
            txtSemester = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label11 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 108);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(400, 40);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 1;
            label1.Text = "Issue Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(226, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnSearchStudent);
            panel2.Controls.Add(txtEnrollmentNo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(12, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 502);
            panel2.TabIndex = 1;
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
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(cmbBookTitle);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnIssueBook);
            panel3.Controls.Add(dtpIssueDate);
            panel3.Controls.Add(txtDept);
            panel3.Controls.Add(txtSemester);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(384, 126);
            panel3.Name = "panel3";
            panel3.Size = new Size(606, 502);
            panel3.TabIndex = 2;
            // 
            // cmbBookTitle
            // 
            cmbBookTitle.Font = new Font("Microsoft Sans Serif", 11F);
            cmbBookTitle.FormattingEnabled = true;
            cmbBookTitle.Location = new Point(270, 299);
            cmbBookTitle.Name = "cmbBookTitle";
            cmbBookTitle.Size = new Size(268, 30);
            cmbBookTitle.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(74, 465);
            label9.Name = "label9";
            label9.Size = new Size(469, 25);
            label9.TabIndex = 13;
            label9.Text = "Maximum 3 books can be ISSUED to a student!";
            // 
            // btnIssueBook
            // 
            btnIssueBook.FlatStyle = FlatStyle.Popup;
            btnIssueBook.Font = new Font("Microsoft Sans Serif", 12F);
            btnIssueBook.Location = new Point(444, 414);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(94, 38);
            btnIssueBook.TabIndex = 12;
            btnIssueBook.Text = "Submit";
            btnIssueBook.UseVisualStyleBackColor = true;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpIssueDate.Location = new Point(270, 366);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(268, 30);
            dtpIssueDate.TabIndex = 11;
            // 
            // txtDept
            // 
            txtDept.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDept.Location = new Point(270, 100);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(268, 30);
            txtDept.TabIndex = 10;
            // 
            // txtSemester
            // 
            txtSemester.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSemester.Location = new Point(270, 168);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(268, 30);
            txtSemester.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(270, 233);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 30);
            txtEmail.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(270, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(268, 30);
            txtName.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(49, 101);
            label11.Name = "label11";
            label11.Size = new Size(152, 29);
            label11.TabIndex = 5;
            label11.Text = "Departement";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(49, 169);
            label7.Name = "label7";
            label7.Size = new Size(205, 29);
            label7.TabIndex = 4;
            label7.Text = "Student Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(49, 299);
            label6.Name = "label6";
            label6.Size = new Size(123, 29);
            label6.TabIndex = 3;
            label6.Text = "Book Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 366);
            label5.Name = "label5";
            label5.Size = new Size(188, 29);
            label5.TabIndex = 2;
            label5.Text = "Book Issue Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 233);
            label4.Name = "label4";
            label4.Size = new Size(162, 29);
            label4.TabIndex = 1;
            label4.Text = "Student Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 31);
            label3.Name = "label3";
            label3.Size = new Size(166, 29);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1002, 649);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBooks";
            Text = "IssueBooks";
            Load += IssueBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox txtEnrollmentNo;
        private Button btnSearchStudent;
        private Button btnRefresh;
        private Button button3;
        private Panel panel3;
        private Label label3;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtDept;
        private TextBox txtSemester;
        private TextBox txtEmail;
        private TextBox txtName;
        private DateTimePicker dtpIssueDate;
        private Button btnIssueBook;
        private Label label9;
        private ComboBox cmbBookTitle;
    }
}