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
            stuPanel1 = new Panel();
            cartGridView = new DataGridView();
            label2 = new Label();
            btnShowRes = new Button();
            addToCart = new Button();
            stuClear = new Button();
            stuGrid = new DataGridView();
            stuCategory = new ComboBox();
            label1 = new Label();
            button3 = new Button();
            btnShowBook = new Button();
            btnCart = new Button();
            button2 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            btnLogout = new Button();
            stuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stuGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // stuPanel1
            // 
            stuPanel1.Controls.Add(cartGridView);
            stuPanel1.Controls.Add(label2);
            stuPanel1.Controls.Add(btnShowRes);
            stuPanel1.Controls.Add(addToCart);
            stuPanel1.Controls.Add(stuClear);
            stuPanel1.Controls.Add(stuGrid);
            stuPanel1.Controls.Add(stuCategory);
            stuPanel1.Controls.Add(label1);
            stuPanel1.Location = new Point(49, 145);
            stuPanel1.Name = "stuPanel1";
            stuPanel1.Size = new Size(1082, 559);
            stuPanel1.TabIndex = 1;
            // 
            // cartGridView
            // 
            cartGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartGridView.Location = new Point(612, 164);
            cartGridView.Name = "cartGridView";
            cartGridView.RowHeadersWidth = 51;
            cartGridView.Size = new Size(400, 330);
            cartGridView.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(761, 119);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "Your Cart";
            // 
            // btnShowRes
            // 
            btnShowRes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowRes.Location = new Point(546, 56);
            btnShowRes.Name = "btnShowRes";
            btnShowRes.Size = new Size(150, 50);
            btnShowRes.TabIndex = 7;
            btnShowRes.Text = "Show the Result";
            btnShowRes.UseVisualStyleBackColor = true;
            btnShowRes.Click += btnShowRes_Click;
            // 
            // addToCart
            // 
            addToCart.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            addToCart.Location = new Point(494, 224);
            addToCart.Name = "addToCart";
            addToCart.Size = new Size(100, 70);
            addToCart.TabIndex = 6;
            addToCart.Text = "Add to Cart ";
            addToCart.UseVisualStyleBackColor = true;
            addToCart.Click += addToCart_Click;
            // 
            // stuClear
            // 
            stuClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            stuClear.Location = new Point(494, 430);
            stuClear.Name = "stuClear";
            stuClear.Size = new Size(100, 35);
            stuClear.TabIndex = 5;
            stuClear.Text = "Clear";
            stuClear.UseVisualStyleBackColor = true;
            // 
            // stuGrid
            // 
            stuGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stuGrid.Location = new Point(74, 164);
            stuGrid.Name = "stuGrid";
            stuGrid.RowHeadersWidth = 51;
            stuGrid.Size = new Size(400, 330);
            stuGrid.TabIndex = 4;
            stuGrid.CellContentClick += stuGrid_CellContentClick;
            // 
            // stuCategory
            // 
            stuCategory.FormattingEnabled = true;
            stuCategory.Location = new Point(211, 69);
            stuCategory.Name = "stuCategory";
            stuCategory.Size = new Size(263, 28);
            stuCategory.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 69);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // button3
            // 
            button3.BackColor = Color.AliceBlue;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button3.Location = new Point(221, 20);
            button3.Name = "button3";
            button3.Size = new Size(120, 50);
            button3.TabIndex = 3;
            button3.Text = "Search Book";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnShowBook
            // 
            btnShowBook.BackColor = Color.AliceBlue;
            btnShowBook.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnShowBook.Location = new Point(57, 20);
            btnShowBook.Name = "btnShowBook";
            btnShowBook.Size = new Size(120, 50);
            btnShowBook.TabIndex = 1;
            btnShowBook.Text = "Show Book";
            btnShowBook.UseVisualStyleBackColor = false;
            btnShowBook.Click += btnShowBook_Click;
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.AliceBlue;
            btnCart.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCart.Location = new Point(387, 20);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(120, 50);
            btnCart.TabIndex = 4;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.AliceBlue;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button2.Location = new Point(712, 20);
            button2.Name = "button2";
            button2.Size = new Size(120, 50);
            button2.TabIndex = 2;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button5.Location = new Point(551, 20);
            button5.Name = "button5";
            button5.Size = new Size(120, 50);
            button5.TabIndex = 5;
            button5.Text = "Feedback";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnShowBook);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnCart);
            panel1.Location = new Point(-8, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 100);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightPink;
            btnLogout.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnLogout.Location = new Point(1039, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 50);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1182, 753);
            Controls.Add(stuPanel1);
            Controls.Add(panel1);
            Name = "Student";
            Text = "Student";
            stuPanel1.ResumeLayout(false);
            stuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cartGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)stuGrid).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel stuPanel1;
        private Button btnShowRes;
        private Button addToCart;
        private Button stuClear;
        private DataGridView stuGrid;
        private ComboBox stuCategory;
        private Label label1;
        private Label label2;
        private DataGridView cartGridView;
        private Button button3;
        private Button btnShowBook;
        private Button btnCart;
        private Button button2;
        private Button button5;
        private Panel panel1;
        private Button btnLogout;
    }
}