namespace LibraryManagementSystem
{
    partial class manageBook
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBookTitle = new TextBox();
            txtBookAuthor = new TextBox();
            txtBookISBN = new TextBox();
            txtBookCategory = new TextBox();
            btnBookAdd = new Button();
            btnBookDelete = new Button();
            btnBookSearch = new Button();
            bookDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bookDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 51);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 103);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 152);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 203);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(215, 51);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(125, 27);
            txtBookTitle.TabIndex = 4;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Location = new Point(215, 103);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(125, 27);
            txtBookAuthor.TabIndex = 5;
            // 
            // txtBookISBN
            // 
            txtBookISBN.Location = new Point(215, 149);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(125, 27);
            txtBookISBN.TabIndex = 6;
            // 
            // txtBookCategory
            // 
            txtBookCategory.Location = new Point(215, 203);
            txtBookCategory.Name = "txtBookCategory";
            txtBookCategory.Size = new Size(125, 27);
            txtBookCategory.TabIndex = 7;
            // 
            // btnBookAdd
            // 
            btnBookAdd.Location = new Point(14, 314);
            btnBookAdd.Name = "btnBookAdd";
            btnBookAdd.Size = new Size(94, 29);
            btnBookAdd.TabIndex = 8;
            btnBookAdd.Text = "Add";
            btnBookAdd.UseVisualStyleBackColor = true;
            btnBookAdd.Click += btnBookAdd_Click;
            // 
            // btnBookDelete
            // 
            btnBookDelete.Location = new Point(137, 314);
            btnBookDelete.Name = "btnBookDelete";
            btnBookDelete.Size = new Size(94, 29);
            btnBookDelete.TabIndex = 9;
            btnBookDelete.Text = "Delete";
            btnBookDelete.UseVisualStyleBackColor = true;
            // 
            // btnBookSearch
            // 
            btnBookSearch.Location = new Point(267, 314);
            btnBookSearch.Name = "btnBookSearch";
            btnBookSearch.Size = new Size(94, 29);
            btnBookSearch.TabIndex = 10;
            btnBookSearch.Text = "Search";
            btnBookSearch.UseVisualStyleBackColor = true;
            // 
            // bookDataGrid
            // 
            bookDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGrid.Location = new Point(396, 36);
            bookDataGrid.Name = "bookDataGrid";
            bookDataGrid.RowHeadersWidth = 51;
            bookDataGrid.Size = new Size(435, 369);
            bookDataGrid.TabIndex = 11;
            // 
            // manageBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(842, 437);
            Controls.Add(bookDataGrid);
            Controls.Add(btnBookSearch);
            Controls.Add(btnBookDelete);
            Controls.Add(btnBookAdd);
            Controls.Add(txtBookCategory);
            Controls.Add(txtBookISBN);
            Controls.Add(txtBookAuthor);
            Controls.Add(txtBookTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "manageBook";
            Text = "Manage Book";
            ((System.ComponentModel.ISupportInitialize)bookDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBookTitle;
        private TextBox txtBookAuthor;
        private TextBox txtBookISBN;
        private TextBox txtBookCategory;
        private Button btnBookAdd;
        private Button btnBookDelete;
        private Button btnBookSearch;
        private DataGridView bookDataGrid;
    }
}