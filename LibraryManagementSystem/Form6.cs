using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class returnBook : Form
    {
        public returnBook()
        {
            InitializeComponent();
            loadCom();

        }
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=LibraryManagement; Integrated Security=True;";

        public void loadCom()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand cmd2 = new SqlCommand("SELECT BookId FROM issueBook", conn);
            using SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                comIssued.Items.Add(reader2["BookId"].ToString());
            }
            reader2.Close();
        }

        private void comIssued_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string sql = "DELETE FROM issueBook WHERE BookId = @bookId";
            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@bookId", comIssued.Text);
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Book returned successfully.");
            }
            else
            {
                MessageBox.Show("Book ID not found.");
            }
            loadCom();
        }
    }
}
