namespace LibraryNotebook.BookForm
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            dataGridViewBooks = new DataGridView();
            panel2 = new Panel();
            dateTimeEdit = new DateTimePicker();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdateBook = new Button();
            txtEditQuantity = new TextBox();
            txtEditAuthor = new TextBox();
            txtEditTitle = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 108);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(373, 39);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 1;
            label1.Text = "View Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(246, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(246, 150);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(385, 152);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(186, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(605, 152);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(12, 192);
            dataGridViewBooks.MultiSelect = false;
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks.Size = new Size(944, 245);
            dataGridViewBooks.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(dateTimeEdit);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdateBook);
            panel2.Controls.Add(txtEditQuantity);
            panel2.Controls.Add(txtEditAuthor);
            panel2.Controls.Add(txtEditTitle);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 466);
            panel2.Name = "panel2";
            panel2.Size = new Size(944, 262);
            panel2.TabIndex = 5;
            // 
            // dateTimeEdit
            // 
            dateTimeEdit.Location = new Point(699, 63);
            dateTimeEdit.Name = "dateTimeEdit";
            dateTimeEdit.Size = new Size(207, 27);
            dateTimeEdit.TabIndex = 21;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnCancel.Location = new Point(812, 208);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 32);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(678, 208);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 32);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.FlatStyle = FlatStyle.Popup;
            btnUpdateBook.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnUpdateBook.Location = new Point(549, 208);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(94, 32);
            btnUpdateBook.TabIndex = 17;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // txtEditQuantity
            // 
            txtEditQuantity.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtEditQuantity.Location = new Point(699, 134);
            txtEditQuantity.Name = "txtEditQuantity";
            txtEditQuantity.Size = new Size(207, 27);
            txtEditQuantity.TabIndex = 16;
            // 
            // txtEditAuthor
            // 
            txtEditAuthor.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtEditAuthor.Location = new Point(198, 134);
            txtEditAuthor.Name = "txtEditAuthor";
            txtEditAuthor.Size = new Size(207, 27);
            txtEditAuthor.TabIndex = 13;
            // 
            // txtEditTitle
            // 
            txtEditTitle.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtEditTitle.Location = new Point(198, 58);
            txtEditTitle.Name = "txtEditTitle";
            txtEditTitle.Size = new Size(207, 27);
            txtEditTitle.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(467, 139);
            label8.Name = "label8";
            label8.Size = new Size(135, 25);
            label8.TabIndex = 11;
            label8.Text = "Book Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(467, 63);
            label7.Name = "label7";
            label7.Size = new Size(191, 25);
            label7.TabIndex = 10;
            label7.Text = "Book Purchase Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(33, 139);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 9;
            label6.Text = "Book Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(33, 63);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 6;
            label3.Text = "Book Name";
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1002, 708);
            Controls.Add(panel2);
            Controls.Add(dataGridViewBooks);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ViewBook";
            Text = "ViewBook";
            Load += ViewBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtSearch;
        private Button btnRefresh;
        private DataGridView dataGridViewBooks;
        private Panel panel2;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtEditAuthor;
        private TextBox txtEditTitle;
        private TextBox txtEditQuantity;
        private Button btnDelete;
        private Button btnUpdateBook;
        private Button btnCancel;
        private DateTimePicker dateTimeEdit;
    }
}