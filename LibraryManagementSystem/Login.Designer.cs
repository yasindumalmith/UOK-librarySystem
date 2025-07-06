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
            label3 = new Label();
            registerLink = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lime;
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(419, 332);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 42);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightCoral;
            btnExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(596, 332);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 42);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(211, 174);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(211, 237);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(419, 174);
            txtName.Name = "txtName";
            txtName.Size = new Size(293, 27);
            txtName.TabIndex = 5;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(419, 237);
            txtPw.Name = "txtPw";
            txtPw.PasswordChar = '*';
            txtPw.Size = new Size(293, 27);
            txtPw.TabIndex = 6;
            txtPw.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(167, 77);
            label3.Name = "label3";
            label3.Size = new Size(620, 46);
            label3.TabIndex = 8;
            label3.Text = "Library Management System";
            // 
            // registerLink
            // 
            registerLink.AutoSize = true;
            registerLink.BackColor = Color.White;
            registerLink.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerLink.Location = new Point(531, 424);
            registerLink.Name = "registerLink";
            registerLink.Size = new Size(117, 23);
            registerLink.TabIndex = 9;
            registerLink.TabStop = true;
            registerLink.Text = "Register Here!";
            registerLink.LinkClicked += registerLink_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(274, 417);
            label4.Name = "label4";
            label4.Size = new Size(251, 31);
            label4.TabIndex = 10;
            label4.Text = "Don’t have an account?";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 553);
            Controls.Add(label4);
            Controls.Add(registerLink);
            Controls.Add(label3);
            Controls.Add(txtPw);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += formLogin_Load;
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
        private Label label3;
        private LinkLabel registerLink;
        private Label label4;
    }
}
