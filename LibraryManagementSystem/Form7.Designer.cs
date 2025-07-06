namespace LibraryManagementSystem
{
    partial class report
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Bold);
            label1.Location = new Point(189, 483);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 2;
            label1.Text = "Issued Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 13.8F, FontStyle.Bold);
            label2.Location = new Point(622, 483);
            label2.Name = "label2";
            label2.Size = new Size(177, 28);
            label2.TabIndex = 3;
            label2.Text = "Returned Book";
            // 
            // report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(982, 553);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "report";
            Text = "Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
    }
}