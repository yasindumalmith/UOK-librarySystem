using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data;

namespace LibraryManagementSystem
{
    public partial class register : Form
    {
        string connectionString = "Data source=(localdb)\\MSSQLLocalDB; Initial Catalog=LibraryManagement; Integrated Security=True;";
        public register()
        {
            InitializeComponent();
            comboGender.Items.Add("Male");
            comboGender.Items.Add("Female");

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string stuName = regName.Text;
            int year = int.Parse(regYear.Text);
            int age = int.Parse(regAge.Text);
            string gender = comboGender.Text;
            string userName = regUserName.Text;
            string password = regPw.Text;

            RegisterInfo ri = new RegisterInfo(connectionString, stuName, year, age, gender, userName, password);
            ri.uploadToDatabase();
            clear();

        }
        public class RegisterInfo
        {
            private string connectionString;
            private string stuName;
            private int year;
            private int age;
            private string gender;
            private string userName;
            private string password;
            public RegisterInfo(string conn, string stuName, int year, int age, string gender, string userName, string password)
            {
                this.connectionString = conn;
                this.stuName = stuName;
                this.year = year;
                this.age = age;
                this.gender = gender;
                this.userName = userName;
                this.password = password;
            }

            public void uploadToDatabase()
            {
                try
                {

                    string sql = "INSERT INTO userInfo (StudentId,StudentName, Year, Age, Gender, Username, Password) " +
                           "VALUES (@id,@name, @year, @age, @gender, @username, @password)";
                    using SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    string stuId = generateStuId();
                    cmd.Parameters.AddWithValue("@id", stuId);
                    cmd.Parameters.AddWithValue("@name", stuName);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@password", password);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            public string generateStuId()
            {
                try
                {
                    using SqlConnection connection = new SqlConnection(connectionString);

                    string query = "SELECT TOP 1 StudentId FROM userInfo ORDER BY StudentId DESC";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    object lastId = cmd.ExecuteScalar();
                    connection.Close();

                    string newId = "S001";
                    if (lastId != null)
                    {
                        int num = int.Parse(lastId.ToString().Substring(1));
                        newId = "S" + (num + 1).ToString("D3");
                    }
                    return newId;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to generate student ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "S001";
                }
            }



        }

        private void regClear_Click(object sender, EventArgs e)
        {
             clear();
        }
        public void clear()
        {
            regName.Clear();
            regYear.Clear();
            regAge.Clear();
            comboGender.Items.Clear();
            regUserName.Clear();
            regPw.Clear();
        }
    }
}