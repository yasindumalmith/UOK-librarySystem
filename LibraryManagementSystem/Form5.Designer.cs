namespace LibraryManagementSystem
{
    partial class issueBook
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
            btnIssueBook = new Button();
            label1 = new Label();
            label2 = new Label();
            comIssStu = new ComboBox();
            comIssBook = new ComboBox();
            SuspendLayout();
            // 
            // btnIssueBook
            // 
            btnIssueBook.Location = new Point(357, 320);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(104, 29);
            btnIssueBook.TabIndex = 0;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = true;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 177);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 239);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 2;
            label2.Text = "Book";
            // 
            // comIssStu
            // 
            comIssStu.FormattingEnabled = true;
            comIssStu.Location = new Point(465, 174);
            comIssStu.Name = "comIssStu";
            comIssStu.Size = new Size(151, 28);
            comIssStu.TabIndex = 3;
            // 
            // comIssBook
            // 
            comIssBook.FormattingEnabled = true;
            comIssBook.Location = new Point(465, 236);
            comIssBook.Name = "comIssBook";
            comIssBook.Size = new Size(151, 28);
            comIssBook.TabIndex = 4;
            // 
            // issueBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(812, 452);
            Controls.Add(comIssBook);
            Controls.Add(comIssStu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIssueBook);
            Name = "issueBook";
            Text = "Issue Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIssueBook;
        private Label label1;
        private Label label2;
        private ComboBox comIssStu;
        private ComboBox comIssBook;
    }
}