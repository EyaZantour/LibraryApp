namespace LibraryNotebook.BookForm
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtQuantity = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            BookQuantity = new Label();
            BookPurchaseDate = new Label();
            BookAuthor = new Label();
            BookName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 371);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 77);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 23);
            label1.Name = "label1";
            label1.Size = new Size(127, 35);
            label1.TabIndex = 1;
            label1.Text = "Add Book";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(270, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(txtTitle);
            panel2.Controls.Add(BookQuantity);
            panel2.Controls.Add(BookPurchaseDate);
            panel2.Controls.Add(BookAuthor);
            panel2.Controls.Add(BookName);
            panel2.Location = new Point(273, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 371);
            panel2.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnCancel.Location = new Point(379, 316);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnSave.Location = new Point(243, 316);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 10.8F);
            dateTimePicker1.Location = new Point(243, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 28);
            dateTimePicker1.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtQuantity.Location = new Point(243, 261);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 28);
            txtQuantity.TabIndex = 6;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtAuthor.Location = new Point(243, 140);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(250, 28);
            txtAuthor.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Microsoft Sans Serif", 10.8F);
            txtTitle.Location = new Point(243, 76);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(250, 28);
            txtTitle.TabIndex = 4;
            // 
            // BookQuantity
            // 
            BookQuantity.AutoSize = true;
            BookQuantity.Font = new Font("Calibri", 13.8F);
            BookQuantity.Location = new Point(26, 264);
            BookQuantity.Name = "BookQuantity";
            BookQuantity.Size = new Size(145, 28);
            BookQuantity.TabIndex = 3;
            BookQuantity.Text = "Book Quantity";
            // 
            // BookPurchaseDate
            // 
            BookPurchaseDate.AutoSize = true;
            BookPurchaseDate.Font = new Font("Calibri", 13.8F);
            BookPurchaseDate.Location = new Point(26, 204);
            BookPurchaseDate.Name = "BookPurchaseDate";
            BookPurchaseDate.Size = new Size(198, 28);
            BookPurchaseDate.TabIndex = 2;
            BookPurchaseDate.Text = "Book Purchase Date";
            // 
            // BookAuthor
            // 
            BookAuthor.AutoSize = true;
            BookAuthor.Font = new Font("Calibri", 13.8F);
            BookAuthor.Location = new Point(26, 143);
            BookAuthor.Name = "BookAuthor";
            BookAuthor.Size = new Size(129, 28);
            BookAuthor.TabIndex = 1;
            BookAuthor.Text = "Book Author";
            // 
            // BookName
            // 
            BookName.AutoSize = true;
            BookName.Font = new Font("Calibri", 13.8F);
            BookName.Location = new Point(26, 79);
            BookName.Name = "BookName";
            BookName.Size = new Size(119, 28);
            BookName.TabIndex = 0;
            BookName.Text = "Book Name";
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AddBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label BookPurchaseDate;
        private Label BookAuthor;
        private Label BookName;
        private DateTimePicker dateTimePicker1;
        private TextBox txtQuantity;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Label BookQuantity;
        private Button btnCancel;
        private Button btnSave;
    }
}