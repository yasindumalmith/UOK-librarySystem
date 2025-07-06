using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class issueBook : Form
    {
        public issueBook()
        {
            InitializeComponent();
            LoadComboBoxes();
        }
         string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=LibraryManagement; Integrated Security=True;";

        private void LoadComboBoxes()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            
            using SqlCommand cmd1 = new SqlCommand("SELECT StudentId FROM userInfo", conn);
            using SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                comIssStu.Items.Add(reader1["StudentId"].ToString());
            }
            reader1.Close();

            
            using SqlCommand cmd2 = new SqlCommand("SELECT Bookid FROM BOOK", conn);
            using SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                comIssBook.Items.Add(reader2["Bookid"].ToString());
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            DateTime now=DateTime.Now;
            string sql = "INSERT INTO issueBook (StudentId,BookId,Date,Time) " +
                       "VALUES (@stuId,@BookId,@Date,@Time)";
            using SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@BookId", comIssBook.Text);
            cmd.Parameters.AddWithValue("@stuId", comIssStu.Text);
            cmd.Parameters.AddWithValue("@Date", now.Date);
            cmd.Parameters.AddWithValue("@Time", now.TimeOfDay);
            connection.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succesfully Issued", "Issue");
        }
    }
   
}
