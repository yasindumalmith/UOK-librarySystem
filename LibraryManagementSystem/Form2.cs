using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel1.Visible = false;

        }

        private void LoadFormInPanel(Form childForm)
        {
            panel1.Visible=true;
            panel1.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnMngBook_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new manageBook());
        }

        private void btnMngStu_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new manageStudent());
        }

        private void btnIssBook_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new issueBook());
        }

        private void BtnRtnBook_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new returnBook());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new report());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin fm=new formLogin();
            
            fm.ShowDialog();
            
        }
    }
}
