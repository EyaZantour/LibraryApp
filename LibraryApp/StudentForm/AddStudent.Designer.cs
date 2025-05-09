namespace LibraryNotebook.StudentForm
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtFullName = new TextBox();
            txtEnrollment = new TextBox();
            txtDept = new TextBox();
            txtSemester = new TextBox();
            txtEmail = new TextBox();
            btnAddStudent = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(7, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 102);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(234, 37);
            label1.Name = "label1";
            label1.Size = new Size(251, 37);
            label1.TabIndex = 1;
            label1.Text = "Add a new student";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(7, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(309, 358);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(340, 141);
            label2.Name = "label2";
            label2.Size = new Size(124, 29);
            label2.TabIndex = 2;
            label2.Text = "Full Name\t";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(340, 261);
            label3.Name = "label3";
            label3.Size = new Size(138, 29);
            label3.TabIndex = 3;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(340, 374);
            label4.Name = "label4";
            label4.Size = new Size(74, 29);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(340, 320);
            label5.Name = "label5";
            label5.Size = new Size(117, 29);
            label5.TabIndex = 5;
            label5.Text = "Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(340, 201);
            label6.Name = "label6";
            label6.Size = new Size(181, 29);
            label6.TabIndex = 6;
            label6.Text = "Enrollement No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(340, 374);
            label7.Name = "label7";
            label7.Size = new Size(0, 29);
            label7.TabIndex = 7;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(519, 145);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(354, 28);
            txtFullName.TabIndex = 8;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnrollment.Location = new Point(519, 203);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(354, 28);
            txtEnrollment.TabIndex = 9;
            // 
            // txtDept
            // 
            txtDept.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDept.Location = new Point(519, 265);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(354, 28);
            txtDept.TabIndex = 10;
            // 
            // txtSemester
            // 
            txtSemester.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSemester.Location = new Point(519, 322);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(354, 28);
            txtSemester.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(519, 375);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(354, 28);
            txtEmail.TabIndex = 12;
            // 
            // btnAddStudent
            // 
            btnAddStudent.FlatStyle = FlatStyle.Popup;
            btnAddStudent.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.Location = new Point(650, 426);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(94, 38);
            btnAddStudent.TabIndex = 13;
            btnAddStudent.Text = "Save";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(779, 426);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 38);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(918, 490);
            Controls.Add(btnCancel);
            Controls.Add(btnAddStudent);
            Controls.Add(txtEmail);
            Controls.Add(txtSemester);
            Controls.Add(txtDept);
            Controls.Add(txtEnrollment);
            Controls.Add(txtFullName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "AddStudent";
            Text = "AddStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtFullName;
        private TextBox txtEnrollment;
        private TextBox txtDept;
        private TextBox txtSemester;
        private TextBox txtEmail;
        private Button btnAddStudent;
        private Button btnCancel;
    }
}