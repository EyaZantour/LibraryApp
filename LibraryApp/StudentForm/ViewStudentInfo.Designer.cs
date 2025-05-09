namespace LibraryNotebook.StudentForm
{
    partial class ViewStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentInfo));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtEnrollmentSearch = new TextBox();
            btnSearch = new Button();
            dataGridViewStudents = new DataGridView();
            panel2 = new Panel();
            btnDelete = new Button();
            btnCancel = new Button();
            txtEnrollmentNo = new TextBox();
            txtDept = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnUpdate = new Button();
            txtFullName = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 102);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(355, 36);
            label1.Name = "label1";
            label1.Size = new Size(171, 37);
            label1.TabIndex = 1;
            label1.Text = "Student Info";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(230, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(167, 130);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 1;
            label2.Text = "Enrollement  No";
            // 
            // txtEnrollmentSearch
            // 
            txtEnrollmentSearch.Location = new Point(323, 130);
            txtEnrollmentSearch.Name = "txtEnrollmentSearch";
            txtEnrollmentSearch.Size = new Size(164, 27);
            txtEnrollmentSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(508, 130);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(12, 167);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(776, 273);
            dataGridViewStudents.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(txtEnrollmentNo);
            panel2.Controls.Add(txtDept);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtFullName);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 450);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 204);
            panel2.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(495, 163);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnCancel.Location = new Point(632, 163);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtEnrollmentNo
            // 
            txtEnrollmentNo.Location = new Point(199, 90);
            txtEnrollmentNo.Name = "txtEnrollmentNo";
            txtEnrollmentNo.Size = new Size(160, 27);
            txtEnrollmentNo.TabIndex = 9;
            // 
            // txtDept
            // 
            txtDept.Location = new Point(566, 23);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(160, 27);
            txtDept.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(566, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(160, 27);
            txtEmail.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F);
            label6.Location = new Point(436, 93);
            label6.Name = "label6";
            label6.Size = new Size(57, 24);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F);
            label5.Location = new Point(46, 93);
            label5.Name = "label5";
            label5.Size = new Size(142, 24);
            label5.TabIndex = 4;
            label5.Text = "Enrollement No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.Location = new Point(436, 24);
            label4.Name = "label4";
            label4.Size = new Size(112, 24);
            label4.TabIndex = 3;
            label4.Text = "Department ";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnUpdate.Location = new Point(352, 163);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(199, 21);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(160, 27);
            txtFullName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F);
            label3.Location = new Point(46, 24);
            label3.Name = "label3";
            label3.Size = new Size(130, 24);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // ViewStudentInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(dataGridViewStudents);
            Controls.Add(btnSearch);
            Controls.Add(txtEnrollmentSearch);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ViewStudentInfo";
            Text = "ViewStudentInfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtEnrollmentSearch;
        private Button btnSearch;
        private DataGridView dataGridViewStudents;
        private Panel panel2;
        private Label label4;
        private Button btnUpdate;
        private TextBox txtFullName;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox txtEnrollmentNo;
        private TextBox txtDept;
        private TextBox txtEmail;
        private Button btnDelete;
        private Button btnCancel;
    }
}