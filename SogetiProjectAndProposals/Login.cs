using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SogetiProjectAndProposals
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tb_loginName.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_password.Text))
                return;

            if (tb_password.Text == "1234")
            {
                this.Hide();
                ProjectDetails frmProjectDetails = new ProjectDetails();
                frmProjectDetails.ShowDialog();
            }
        }
    }
}
