namespace LibraryManagementSystem
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtPw = new TextBox();
            btnRegister = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lime;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(191, 299);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 55);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(410, 299);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 55);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit ";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 146);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(153, 209);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(380, 150);
            txtName.Name = "txtName";
            txtName.Size = new Size(168, 27);
            txtName.TabIndex = 5;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(380, 213);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(168, 27);
            txtPw.TabIndex = 6;
            txtPw.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Lime;
            btnRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(636, 183);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(129, 57);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(327, 42);
            label3.Name = "label3";
            label3.Size = new Size(132, 46);
            label3.TabIndex = 8;
            label3.Text = "Sign In";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(804, 430);
            Controls.Add(label3);
            Controls.Add(btnRegister);
            Controls.Add(txtPw);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Name = "formLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtPw;
        private Button btnRegister;
        private Label label3;
    }
}
