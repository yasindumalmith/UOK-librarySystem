using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class report : Form
    {
        string connStr = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=LibraryManagement; Integrated Security=True;";

        public report()
        {
            InitializeComponent();

            var reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill,
                ProcessingMode = ProcessingMode.Local
            };

            this.Controls.Add(reportViewer);
            reportViewer.LocalReport.ReportPath = "D:\\University Academic\\3rd Year\\1st sem\\Vissual Programming\\Project\\UOKLibrarySystem\\UOK-librarySystem\\LibraryManagementSystem\\LibraryReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();

            // ✅ Use the correct method name
            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("DataSet1", GetIssueData()));

            reportViewer.RefreshReport();
        }

        // ✅ Moved here — inside the 'report' form
        private List<IssueData> GetIssueData()
        {
            List<IssueData> list = new List<IssueData>();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT s.StudentName, b.Title, i.Date, i.Time " +
                               "FROM issueBook i " +
                               "JOIN userInfo s ON s.StudentID = i.StudentID " +
                               "JOIN Book b ON b.BookiD = i.BookID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new IssueData
                        {
                            StudentName = reader.GetString(0),
                            BookTitle = reader.GetString(1),
                            IssueDate = reader.GetDateTime(2),      // for DATE column
                            IssueTime = reader.GetTimeSpan(3)
                        });
                    }
                }
            }
            return list;
        }
    }

    // ✅ Keep your data model clean
    public class IssueData
    {
        public string StudentName { get; set; }
        public string BookTitle { get; set; }
        public DateTime IssueDate { get; set; }
        public TimeSpan IssueTime { get; set; }
    }
}
