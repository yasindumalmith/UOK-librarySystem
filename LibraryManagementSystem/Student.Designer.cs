namespace LibraryManagementSystem
{
    partial class Student
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
            panel1 = new Panel();
            button5 = new Button();
            button2 = new Button();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            stuPanel1 = new Panel();
            btnShowRes = new Button();
            addToCart = new Button();
            stuClear = new Button();
            stuGrid = new DataGridView();
            stuCategory = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            stuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stuGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 522);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.Location = new Point(39, 290);
            button5.Name = "button5";
            button5.Size = new Size(109, 55);
            button5.TabIndex = 5;
            button5.Text = "Feedback";
            button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(39, 373);
            button2.Name = "button2";
            button2.Size = new Size(109, 55);
            button2.TabIndex = 2;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Location = new Point(39, 220);
            button4.Name = "button4";
            button4.Size = new Size(109, 55);
            button4.TabIndex = 4;
            button4.Text = "Cart";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(39, 56);
            button1.Name = "button1";
            button1.Size = new Size(109, 54);
            button1.TabIndex = 1;
            button1.Text = "Show Book";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(39, 137);
            button3.Name = "button3";
            button3.Size = new Size(109, 55);
            button3.TabIndex = 3;
            button3.Text = "Search Book";
            button3.UseVisualStyleBackColor = false;
            // 
            // stuPanel1
            // 
            stuPanel1.Controls.Add(btnShowRes);
            stuPanel1.Controls.Add(addToCart);
            stuPanel1.Controls.Add(stuClear);
            stuPanel1.Controls.Add(stuGrid);
            stuPanel1.Controls.Add(stuCategory);
            stuPanel1.Controls.Add(label1);
            stuPanel1.Location = new Point(308, 68);
            stuPanel1.Name = "stuPanel1";
            stuPanel1.Size = new Size(844, 567);
            stuPanel1.TabIndex = 1;
            // 
            // btnShowRes
            // 
            btnShowRes.Location = new Point(302, 153);
            btnShowRes.Name = "btnShowRes";
            btnShowRes.Size = new Size(118, 52);
            btnShowRes.TabIndex = 7;
            btnShowRes.Text = "Show the Result";
            btnShowRes.UseVisualStyleBackColor = true;
            btnShowRes.Click += btnShowRes_Click;
            // 
            // addToCart
            // 
            addToCart.Location = new Point(660, 356);
            addToCart.Name = "addToCart";
            addToCart.Size = new Size(94, 29);
            addToCart.TabIndex = 6;
            addToCart.Text = "Add to Cart ";
            addToCart.UseVisualStyleBackColor = true;
            // 
            // stuClear
            // 
            stuClear.Location = new Point(660, 425);
            stuClear.Name = "stuClear";
            stuClear.Size = new Size(94, 29);
            stuClear.TabIndex = 5;
            stuClear.Text = "Clear";
            stuClear.UseVisualStyleBackColor = true;
            // 
            // stuGrid
            // 
            stuGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stuGrid.Location = new Point(31, 234);
            stuGrid.Name = "stuGrid";
            stuGrid.RowHeadersWidth = 51;
            stuGrid.Size = new Size(502, 302);
            stuGrid.TabIndex = 4;
            // 
            // stuCategory
            // 
            stuCategory.FormattingEnabled = true;
            stuCategory.Location = new Point(446, 81);
            stuCategory.Name = "stuCategory";
            stuCategory.Size = new Size(151, 28);
            stuCategory.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 84);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 678);
            Controls.Add(stuPanel1);
            Controls.Add(panel1);
            Name = "Student";
            Text = "Student";
            panel1.ResumeLayout(false);
            stuPanel1.ResumeLayout(false);
            stuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stuGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button2;
        private Button button4;
        private Button button1;
        private Button button3;
        private Panel stuPanel1;
        private Button btnShowRes;
        private Button addToCart;
        private Button stuClear;
        private DataGridView stuGrid;
        private ComboBox stuCategory;
        private Label label1;
    }
}