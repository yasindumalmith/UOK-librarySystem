using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{

    public partial class Student : Form

    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=LibraryManagement; Integrated Security=True;";
        private string user;

        public Student()
        {


            InitializeComponent();
            loadCombo();

        }
        public Student(string loggedInUser)
        {
            this.user = loggedInUser;
            MessageBox.Show(Text = "Welcome " + user + " to the Library Management System", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InitializeComponent();
            loadCombo();
            stuPanel1.Visible = false;


        }
        public void loadCombo()
        {

            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = @"SELECT DISTINCT b.Category, b.Author
                             FROM BOOK b
                            WHERE b.Bookid NOT IN (
                             SELECT DISTINCT i.BookId
                              FROM issueBook i
                                    )";

            using SqlCommand cmd = new SqlCommand(query, conn);
            using SqlDataReader reader1 = cmd.ExecuteReader();


            while (reader1.Read())
            {
                stuCategory.Items.Add(reader1["category"].ToString());

            }
            reader1.Close();
            showCart(user);


        }

        private void btnShowRes_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string category = stuCategory.Text;
            string query = "SELECT b.Bookid,b.Title,b.Author,b.ISBN FROM BOOK b WHERE b.category=@category";
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@category", category);
            using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            stuGrid.DataSource = dt;

        }

        private void stuGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = stuGrid.Rows[e.RowIndex];
                string bookId = row.Cells["Bookid"].Value.ToString();
                string title = row.Cells["Title"].Value.ToString();
                string author = row.Cells["Author"].Value.ToString();
                string isbn = row.Cells["ISBN"].Value.ToString();


            }
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Cart (BookId, StuId, Date) VALUES (@BookId, @StuId, @Date)";
            using SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@BookId", stuGrid.CurrentRow.Cells["Bookid"].Value);
            cmd.Parameters.AddWithValue("@StuId", user);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book added to cart successfully.");
                showCart(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book to cart: " + ex.Message);
            }

        }

        private void btnShowBook_Click(object sender, EventArgs e)
        {

            stuPanel1.Visible = true;

        }
        private void btnCart_Click(object sender, EventArgs e)
        {
            stuPanel1.Visible = false;
            showCart(user);
        }

        public void showCart(string stuId)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"SELECT b.Bookid, b.Title, b.Author, b.ISBN, c.Date
                 FROM BOOK b
                 INNER JOIN Cart c ON b.Bookid = c.BookId
                 WHERE c.StuId = @StuId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@StuId", stuId);


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cartGridView.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cartPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                formLogin loginForm = new formLogin();
                loginForm.ShowDialog();
                this.Show();
            }


        }
    }


}
