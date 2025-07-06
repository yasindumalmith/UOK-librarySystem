using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystem
{
    public partial class formLogin : Form
    {


        public formLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string userPW = txtPw.Text;
            user us = new user(userName, userPW);
            string role = us.checkUser();
            bool checkUserNamePw = us.ValidateUser(userName, userPW);


            if (role == "admin")
            {
                this.Hide();
                Admin dashboard = new Admin();
                dashboard.ShowDialog();
                this.Close();
            }
            else if (checkUserNamePw)
            {
                string studentId = us.saveStuId(userName, userPW);
                this.Hide();
                Student st = new Student(studentId);
                st.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter valid User Name and Password");
            }


        }




        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register reg = new register();
            reg.ShowDialog();
        }
    }
    public class user
    {
        private string userName;
        private string userPw;
        string connectionString = "Data source=(localdb)\\MSSQLLocalDB; Initial Catalog=LibraryManagement; Integrated Security=True;";
        public user(string userName, string userPw)
        {
            this.userName = userName;
            this.userPw = userPw;
        }
        public string checkUser()
        {
            if (userName == "admin" && userPw == "adminPW")
            {
                return "admin";
            }
            else
            {
                return "invalid";
            }
        }
        public bool ValidateUser(string username, string password)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT COUNT(*) FROM userInfo WHERE Username = @username AND Password = @password";

            using SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            
            connection.Open();
            int count = (int)cmd.ExecuteScalar();
            
            

            return count > 0;
            
        }
        public string saveStuId(string username,string password)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            string query1 = "SELECT Studentid FROM userInfo WHERE Username = @username AND Password = @password";
            using SqlCommand cmd1 = new SqlCommand(query1, connection);
            cmd1.Parameters.AddWithValue("@username", username);
            cmd1.Parameters.AddWithValue("@password", password);
            connection.Open();
            object stuid = cmd1.ExecuteScalar();
            string loggedInUser = stuid.ToString();
            return loggedInUser;
        }


    }
    

}
