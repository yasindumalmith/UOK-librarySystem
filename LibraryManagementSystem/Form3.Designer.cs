namespace LibraryManagementSystem
{
    partial class manageStudent
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
            btnStuAdd = new Button();
            btnStuUpdate = new Button();
            btnStuDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtStuName = new TextBox();
            txtStuId = new TextBox();
            txtStuEmail = new TextBox();
            txtStuContact = new TextBox();
            studentDataGrid = new DataGridView();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)studentDataGrid).BeginInit();
            SuspendLayout();
            // 
            // btnStuAdd
            // 
            btnStuAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnStuAdd.Location = new Point(59, 453);
            btnStuAdd.Name = "btnStuAdd";
            btnStuAdd.Size = new Size(100, 35);
            btnStuAdd.TabIndex = 0;
            btnStuAdd.Text = "Add";
            btnStuAdd.UseVisualStyleBackColor = true;
            // 
            // btnStuUpdate
            // 
            btnStuUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnStuUpdate.Location = new Point(185, 453);
            btnStuUpdate.Name = "btnStuUpdate";
            btnStuUpdate.Size = new Size(100, 35);
            btnStuUpdate.TabIndex = 1;
            btnStuUpdate.Text = "Update";
            btnStuUpdate.UseVisualStyleBackColor = true;
            btnStuUpdate.Click += btnStuUpdate_Click;
            // 
            // btnStuDelete
            // 
            btnStuDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnStuDelete.Location = new Point(312, 453);
            btnStuDelete.Name = "btnStuDelete";
            btnStuDelete.Size = new Size(100, 35);
            btnStuDelete.TabIndex = 2;
            btnStuDelete.Text = "Delete";
            btnStuDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label1.Location = new Point(59, 81);
            label1.Name = "label1";
            label1.Size = new Size(66, 24);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label2.Location = new Point(59, 157);
            label2.Name = "label2";
            label2.Size = new Size(34, 24);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label3.Location = new Point(59, 236);
            label3.Name = "label3";
            label3.Size = new Size(66, 24);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label4.Location = new Point(59, 314);
            label4.Name = "label4";
            label4.Size = new Size(85, 24);
            label4.TabIndex = 6;
            label4.Text = "Contact";
            // 
            // txtStuName
            // 
            txtStuName.Location = new Point(176, 80);
            txtStuName.Name = "txtStuName";
            txtStuName.Size = new Size(236, 27);
            txtStuName.TabIndex = 7;
            // 
            // txtStuId
            // 
            txtStuId.Location = new Point(176, 156);
            txtStuId.Name = "txtStuId";
            txtStuId.Size = new Size(236, 27);
            txtStuId.TabIndex = 8;
            // 
            // txtStuEmail
            // 
            txtStuEmail.Location = new Point(176, 235);
            txtStuEmail.Name = "txtStuEmail";
            txtStuEmail.Size = new Size(236, 27);
            txtStuEmail.TabIndex = 9;
            // 
            // txtStuContact
            // 
            txtStuContact.Location = new Point(176, 313);
            txtStuContact.Name = "txtStuContact";
            txtStuContact.Size = new Size(236, 27);
            txtStuContact.TabIndex = 10;
            // 
            // studentDataGrid
            // 
            studentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGrid.Location = new Point(491, 80);
            studentDataGrid.Name = "studentDataGrid";
            studentDataGrid.RowHeadersWidth = 51;
            studentDataGrid.ShowCellErrors = false;
            studentDataGrid.Size = new Size(426, 352);
            studentDataGrid.TabIndex = 11;
            studentDataGrid.CellContentClick += studentDataGrid_CellContentClick;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnClear.Location = new Point(817, 453);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 35);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // manageStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            BackgroundImage = Properties.Resources.login;
            ClientSize = new Size(982, 553);
            Controls.Add(btnClear);
            Controls.Add(studentDataGrid);
            Controls.Add(txtStuContact);
            Controls.Add(txtStuEmail);
            Controls.Add(txtStuId);
            Controls.Add(txtStuName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStuDelete);
            Controls.Add(btnStuUpdate);
            Controls.Add(btnStuAdd);
            Name = "manageStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Student";
            ((System.ComponentModel.ISupportInitialize)studentDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStuAdd;
        private Button btnStuUpdate;
        private Button btnStuDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtStuName;
        private TextBox txtStuId;
        private TextBox txtStuEmail;
        private TextBox txtStuContact;
        private DataGridView studentDataGrid;
        private Button btnClear;
    }
}