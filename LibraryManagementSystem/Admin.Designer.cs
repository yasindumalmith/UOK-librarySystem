
namespace LibraryManagementSystem
{
    partial class Admin

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            btnMngBook = new Button();
            btnLogOut = new Button();
            btnReport = new Button();
            BtnRtnBook = new Button();
            btnIssBook = new Button();
            btnMngStu = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMngBook
            // 
            btnMngBook.BackColor = Color.WhiteSmoke;
            btnMngBook.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnMngBook.Image = Properties.Resources.stack_of_books1;
            btnMngBook.Location = new Point(67, 54);
            btnMngBook.Name = "btnMngBook";
            btnMngBook.Size = new Size(150, 50);
            btnMngBook.TabIndex = 0;
            btnMngBook.Text = "Manage Book";
            btnMngBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngBook.UseVisualStyleBackColor = false;
            btnMngBook.Click += btnMngBook_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.WhiteSmoke;
            btnLogOut.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnLogOut.Image = Properties.Resources.logout;
            btnLogOut.Location = new Point(987, 54);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(120, 50);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "LogOut";
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.WhiteSmoke;
            btnReport.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnReport.Image = Properties.Resources.seo_report;
            btnReport.Location = new Point(690, 54);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(150, 50);
            btnReport.TabIndex = 2;
            btnReport.Text = "Reports";
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // BtnRtnBook
            // 
            BtnRtnBook.BackColor = Color.WhiteSmoke;
            BtnRtnBook.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            BtnRtnBook.Image = Properties.Resources._return;
            BtnRtnBook.Location = new Point(535, 54);
            BtnRtnBook.Name = "BtnRtnBook";
            BtnRtnBook.Size = new Size(150, 50);
            BtnRtnBook.TabIndex = 3;
            BtnRtnBook.Text = "Return Book";
            BtnRtnBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRtnBook.UseVisualStyleBackColor = false;
            BtnRtnBook.Click += BtnRtnBook_Click;
            // 
            // btnIssBook
            // 
            btnIssBook.BackColor = Color.WhiteSmoke;
            btnIssBook.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnIssBook.Image = Properties.Resources.return__1_;
            btnIssBook.Location = new Point(379, 54);
            btnIssBook.Name = "btnIssBook";
            btnIssBook.Size = new Size(150, 50);
            btnIssBook.TabIndex = 4;
            btnIssBook.Text = "Issue Book";
            btnIssBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIssBook.UseVisualStyleBackColor = false;
            btnIssBook.Click += btnIssBook_Click;
            // 
            // btnMngStu
            // 
            btnMngStu.BackColor = Color.WhiteSmoke;
            btnMngStu.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnMngStu.Image = Properties.Resources.graduated;
            btnMngStu.Location = new Point(223, 54);
            btnMngStu.Name = "btnMngStu";
            btnMngStu.Size = new Size(150, 50);
            btnMngStu.TabIndex = 5;
            btnMngStu.Text = "Manage Student";
            btnMngStu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngStu.UseVisualStyleBackColor = false;
            btnMngStu.Click += btnMngStu_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(67, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 545);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(72, 59);
            label1.Name = "label1";
            label1.Size = new Size(190, 38);
            label1.TabIndex = 0;
            label1.Text = "Hello, Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(324, 171);
            label2.Name = "label2";
            label2.Size = new Size(365, 58);
            label2.TabIndex = 1;
            label2.Text = "Welcome to the";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(161, 250);
            label4.Name = "label4";
            label4.Size = new Size(699, 61);
            label4.TabIndex = 3;
            label4.Text = "Library Management System";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(278, 341);
            label6.Name = "label6";
            label6.Size = new Size(485, 54);
            label6.TabIndex = 5;
            label6.Text = "University of Kelaniya";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Controls.Add(btnMngStu);
            Controls.Add(btnIssBook);
            Controls.Add(BtnRtnBook);
            Controls.Add(btnReport);
            Controls.Add(btnLogOut);
            Controls.Add(btnMngBook);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnMngBook;
        private Button btnLogOut;
        private Button btnReport;
        private Button BtnRtnBook;
        private Button btnIssBook;
        private Button btnMngStu;
        private Panel panel1;
        private Label label1;
        private Label label6;
        private Label label4;
        private Label label2;
    }
}