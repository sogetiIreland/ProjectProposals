using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sogeti.ProjectsAndProposals.UserInterface
{
    public partial class ProjectDetails : Form
    {
        private DataObjects.Project prjDetails;
        private BusinessEntity.Project prjBAL;

        #region constructors
        public ProjectDetails()
        {
            InitializeComponent();
            prjDetails = new DataObjects.Project();
            prjBAL = new BusinessEntity.Project();

            prjDetails = prjBAL.LoadExistingProject(0);
        }
        #endregion

        #region events
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void ProjectDetails_Load(object sender, EventArgs e)
        {
            LoadDropDowns();
            BindProjectDetails();
        }

        private void LoadDropDowns()
        {
            this.cb_client.DataSource = BusinessEntity.Client.GetAllClients();
            this.cb_practitioner.DataSource = BusinessEntity.Person.GetAllPersons();
            this.cb_accountManager.DataSource = BusinessEntity.Person.GetAllPersons();
            this.cb_deliveryManager.DataSource = BusinessEntity.Person.GetAllPersons();
            this.cb_administrator.DataSource = BusinessEntity.Person.GetAllPersons();
        }

        private void BindProjectDetails()
        {
            this.tb_name.DataBindings.Add("Text", prjDetails, "name");
            this.cb_client.DataBindings.Add("SelectedValue", prjDetails.client, "clientID");
            this.tb_description.DataBindings.Add("Text", prjDetails, "description");
            this.cb_practitioner.DataBindings.Add("SelectedValue", prjDetails.sogetiPractitioner, "personID");
            this.cb_accountManager.DataBindings.Add("SelectedValue", prjDetails.accountManager, "personID");
            this.cb_administrator.DataBindings.Add("SelectedValue", prjDetails.administrator, "personID");
            this.dtp_startDate.DataBindings.Add("Value", prjDetails, "startDate");
            this.dtp_endDate.DataBindings.Add("Value", prjDetails, "endDate");
            this.dtp_revisedDate.DataBindings.Add("Value", prjDetails, "revisedDate");
        }

        private void ClearBinding()
        {
            this.tb_name.DataBindings.Clear();
            this.cb_client.DataBindings.Clear();
            this.tb_description.DataBindings.Clear();
            this.cb_practitioner.DataBindings.Clear();
            this.cb_accountManager.DataBindings.Clear();
            this.cb_administrator.DataBindings.Clear();
            this.dtp_startDate.DataBindings.Clear();
            this.dtp_endDate.DataBindings.Clear();
            this.dtp_revisedDate.DataBindings.Clear();
        }

        private void btn_LoadNext_Click(object sender, EventArgs e)
        {
            ClearBinding();
            prjDetails = prjBAL.LoadExistingProject(1);
            BindProjectDetails();
        }
    }
}
