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

namespace LibraryManagementSystem
{
    public partial class manageStudent : Form
    {
        public manageStudent()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            string connectionString = "Data source=(localdb)\\MSSQLLocalDB; Initial Catalog=LibraryManagement; Integrated Security=True;";
            string query = "SELECT StudentId, StudentName, Year, Age, Gender FROM userInfo;";
            using SqlConnection conn=new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            studentDataGrid.DataSource = dataTable;
        }
    }
}
