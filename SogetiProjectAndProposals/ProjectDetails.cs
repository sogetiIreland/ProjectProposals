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
    public partial class ProjectDetails : Form
    {
        #region constructors
        public ProjectDetails()
        {
            InitializeComponent();
        }
        #endregion

        #region events
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.ShowDialog();
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                focusNextControl();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region privateMethods
        private void focusNextControl()
        {
            SendKeys.Send("{TAB}");
        }
        #endregion


    }
}
