namespace LibraryManagementSystem
{
    partial class Form2
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
            btnMngBook = new Button();
            btnLogOut = new Button();
            btnReport = new Button();
            BtnRtnBook = new Button();
            btnIssBook = new Button();
            btnMngStu = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btnMngBook
            // 
            btnMngBook.BackColor = Color.LightCyan;
            btnMngBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMngBook.Image = Properties.Resources.stack_of_books1;
            btnMngBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnMngBook.Location = new Point(26, 21);
            btnMngBook.Name = "btnMngBook";
            btnMngBook.Size = new Size(103, 50);
            btnMngBook.TabIndex = 0;
            btnMngBook.Text = "Manage Book";
            btnMngBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngBook.UseVisualStyleBackColor = false;
            btnMngBook.Click += btnMngBook_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.LightCyan;
            btnLogOut.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.Image = Properties.Resources.logout;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(571, 21);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(103, 50);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "LogOut";
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.LightCyan;
            btnReport.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.Image = Properties.Resources.seo_report;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(462, 21);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(103, 50);
            btnReport.TabIndex = 2;
            btnReport.Text = "Reports";
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // BtnRtnBook
            // 
            BtnRtnBook.BackColor = Color.LightCyan;
            BtnRtnBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRtnBook.Image = Properties.Resources._return;
            BtnRtnBook.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRtnBook.Location = new Point(353, 21);
            BtnRtnBook.Name = "BtnRtnBook";
            BtnRtnBook.Size = new Size(103, 50);
            BtnRtnBook.TabIndex = 3;
            BtnRtnBook.Text = "Return Book";
            BtnRtnBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRtnBook.UseVisualStyleBackColor = false;
            BtnRtnBook.Click += BtnRtnBook_Click;
            // 
            // btnIssBook
            // 
            btnIssBook.BackColor = Color.LightCyan;
            btnIssBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssBook.Image = Properties.Resources.return__1_;
            btnIssBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnIssBook.Location = new Point(244, 21);
            btnIssBook.Name = "btnIssBook";
            btnIssBook.Size = new Size(103, 50);
            btnIssBook.TabIndex = 4;
            btnIssBook.Text = "Issue Book";
            btnIssBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIssBook.UseVisualStyleBackColor = false;
            btnIssBook.Click += btnIssBook_Click;
            // 
            // btnMngStu
            // 
            btnMngStu.BackColor = Color.LightCyan;
            btnMngStu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMngStu.Image = Properties.Resources.graduated;
            btnMngStu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMngStu.Location = new Point(135, 21);
            btnMngStu.Name = "btnMngStu";
            btnMngStu.Size = new Size(103, 50);
            btnMngStu.TabIndex = 5;
            btnMngStu.Text = "Manage Student";
            btnMngStu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngStu.UseVisualStyleBackColor = false;
            btnMngStu.Click += btnMngStu_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(84, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 481);
            panel1.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.libraryIm2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1117, 663);
            Controls.Add(panel1);
            Controls.Add(btnMngStu);
            Controls.Add(btnIssBook);
            Controls.Add(BtnRtnBook);
            Controls.Add(btnReport);
            Controls.Add(btnLogOut);
            Controls.Add(btnMngBook);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMngBook;
        private Button btnLogOut;
        private Button btnReport;
        private Button BtnRtnBook;
        private Button btnIssBook;
        private Button btnMngStu;
        private Panel panel1;
    }
}