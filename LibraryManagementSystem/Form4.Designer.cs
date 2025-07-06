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
            btnBookUpdate = new Button();
            bookDataGrid = new DataGridView();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)bookDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label1.Location = new Point(73, 71);
            label1.Name = "label1";
            label1.Size = new Size(55, 24);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label2.Location = new Point(73, 158);
            label2.Name = "label2";
            label2.Size = new Size(78, 24);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label3.Location = new Point(73, 246);
            label3.Name = "label3";
            label3.Size = new Size(57, 24);
            label3.TabIndex = 2;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label4.Location = new Point(73, 337);
            label4.Name = "label4";
            label4.Size = new Size(95, 24);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(196, 71);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(207, 27);
            txtBookTitle.TabIndex = 4;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Location = new Point(196, 158);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(207, 27);
            txtBookAuthor.TabIndex = 5;
            // 
            // txtBookISBN
            // 
            txtBookISBN.Location = new Point(196, 246);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(207, 27);
            txtBookISBN.TabIndex = 6;
            // 
            // txtBookCategory
            // 
            txtBookCategory.Location = new Point(196, 337);
            txtBookCategory.Name = "txtBookCategory";
            txtBookCategory.Size = new Size(207, 27);
            txtBookCategory.TabIndex = 7;
            // 
            // btnBookAdd
            // 
            btnBookAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBookAdd.Location = new Point(73, 465);
            btnBookAdd.Name = "btnBookAdd";
            btnBookAdd.Size = new Size(100, 35);
            btnBookAdd.TabIndex = 8;
            btnBookAdd.Text = "Add";
            btnBookAdd.UseVisualStyleBackColor = true;
            btnBookAdd.Click += btnBookAdd_Click;
            // 
            // btnBookDelete
            // 
            btnBookDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBookDelete.Location = new Point(209, 465);
            btnBookDelete.Name = "btnBookDelete";
            btnBookDelete.Size = new Size(100, 35);
            btnBookDelete.TabIndex = 9;
            btnBookDelete.Text = "Delete";
            btnBookDelete.UseVisualStyleBackColor = true;
            btnBookDelete.Click += btnBookDelete_Click;
            // 
            // btnBookUpdate
            // 
            btnBookUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnBookUpdate.Location = new Point(354, 465);
            btnBookUpdate.Name = "btnBookUpdate";
            btnBookUpdate.Size = new Size(100, 35);
            btnBookUpdate.TabIndex = 10;
            btnBookUpdate.Text = "Update";
            btnBookUpdate.UseVisualStyleBackColor = true;
            btnBookUpdate.Click += btnBookUpdate_Click;
            // 
            // bookDataGrid
            // 
            bookDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGrid.Location = new Point(475, 71);
            bookDataGrid.Name = "bookDataGrid";
            bookDataGrid.RowHeadersWidth = 51;
            bookDataGrid.Size = new Size(435, 366);
            bookDataGrid.TabIndex = 11;
            bookDataGrid.CellContentClick += bookDataGrid_CellContentClick;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnClear.Location = new Point(816, 465);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 35);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // manageBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            BackgroundImage = Properties.Resources.login;
            ClientSize = new Size(982, 553);
            Controls.Add(btnClear);
            Controls.Add(bookDataGrid);
            Controls.Add(btnBookUpdate);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnBookUpdate;
        private DataGridView bookDataGrid;
        private Button btnClear;
    }
}