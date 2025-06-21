using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace LibraryManagementSystem
{
    public partial class manageBook : Form
    {
        public manageBook()
        {
            InitializeComponent();
            loadData();
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            string title=txtBookTitle.Text;
            string author=txtBookAuthor.Text;
            string isbn=txtBookISBN.Text;
            string category=txtBookCategory.Text;
            Book bk = new Book(title, author, isbn, category);
            bk.addBook();
            loadData();
            
        }
        public void loadData()
        {
            string connectionString = "Data source=(localdb)\\MSSQLLocalDB; Initial Catalog=LibraryManagement; Integrated Security=True;";
            using SqlConnection conn = new SqlConnection(connectionString);
            string query = "SELECT * FROM BOOK";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            bookDataGrid.DataSource = dataTable;

        }
    }
    public class Book
    {
        private string title;
        private string author;
        private string isbn;
        private string category;
        string connectionString = "Data source=(localdb)\\MSSQLLocalDB; Initial Catalog=LibraryManagement; Integrated Security=True;";
        public Book(string title, string author, string isbn, string category)
        {
            this.author = author;
            this.title = title;
            this.isbn = isbn;
            this.category = category;
        }
        public void addBook()
        {
            using SqlConnection conn=new SqlConnection(connectionString);
            string query = "INSERT INTO book(BookId,Title,Author,ISBN,Category)" + "VALUES(@BookId,@Title,@Author,@ISBN,@Category)";
            using SqlCommand cmd =new SqlCommand(query, conn);
            string bId=generateBookId();
            cmd.Parameters.AddWithValue("@BookId", bId);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Author", author);
            cmd.Parameters.AddWithValue ("@ISBN", isbn);
            cmd.Parameters.AddWithValue("@Category", category);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
        public string generateBookId()
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT TOP 1 BookId FROM BOOK ORDER BY BookId DESC";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            object lastId = cmd.ExecuteScalar();
            connection.Close();

            string newId = "B001";
            if (lastId != null)
            {
                int num = int.Parse(lastId.ToString().Substring(1));
                newId = "B" + (num + 1).ToString("D3");
            }
            return newId;
        }
        
    }
    
}
