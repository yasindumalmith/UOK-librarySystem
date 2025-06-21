namespace LibraryManagementSystem
{
    partial class returnBook
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
            comIssued = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 207);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Issued Book";
            // 
            // comIssued
            // 
            comIssued.FormattingEnabled = true;
            comIssued.Location = new Point(401, 204);
            comIssued.Name = "comIssued";
            comIssued.Size = new Size(151, 28);
            comIssued.TabIndex = 1;
            comIssued.SelectedIndexChanged += comIssued_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(315, 308);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Return Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // returnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(805, 450);
            Controls.Add(button1);
            Controls.Add(comIssued);
            Controls.Add(label1);
            Name = "returnBook";
            Text = "Return Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comIssued;
        private Button button1;
    }
}