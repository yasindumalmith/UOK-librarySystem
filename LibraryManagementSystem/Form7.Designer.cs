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
            issuedReport = new DataGridView();
            returnedDataGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)issuedReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnedDataGrid).BeginInit();
            SuspendLayout();
            // 
            // issuedReport
            // 
            issuedReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            issuedReport.Location = new Point(12, 24);
            issuedReport.Name = "issuedReport";
            issuedReport.RowHeadersWidth = 51;
            issuedReport.Size = new Size(391, 301);
            issuedReport.TabIndex = 0;
            // 
            // returnedDataGrid
            // 
            returnedDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            returnedDataGrid.Location = new Point(419, 24);
            returnedDataGrid.Name = "returnedDataGrid";
            returnedDataGrid.RowHeadersWidth = 51;
            returnedDataGrid.Size = new Size(398, 301);
            returnedDataGrid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 363);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "Issued Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(573, 363);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 3;
            label2.Text = "Returned Book";
            // 
            // report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(843, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(returnedDataGrid);
            Controls.Add(issuedReport);
            Name = "report";
            Text = "Report";
            ((System.ComponentModel.ISupportInitialize)issuedReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnedDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView issuedReport;
        private DataGridView returnedDataGrid;
        private Label label1;
        private Label label2;
    }
}