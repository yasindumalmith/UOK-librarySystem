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

        public Student()
        {


            InitializeComponent();
            loadCombo();
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


        }

        private void btnShowRes_Click(object sender, EventArgs e)
        {
            using SqlConnection conn=new SqlConnection(connectionString);
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
    }

    public class data
    {

        
    }
}
