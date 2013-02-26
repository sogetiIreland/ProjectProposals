using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sogeti.ProjectsAndProposals.WebInterface
{
    public partial class ProjectDetails : System.Web.UI.Page
    {
        private DataObjects.Project prjDetails;
        private BusinessEntity.Project prjBAL;

        protected void Page_Load(object sender, EventArgs e)
        {
            prjDetails = new DataObjects.Project();
            prjBAL = new BusinessEntity.Project();

            prjDetails = prjBAL.LoadExistingProject(0);

            LoadDropDowns();
            BindProjectDetails();
        }

        private void LoadDropDowns()
        {
            this.cb_client.DataSource = BusinessEntity.Client.GetAllClients();
            this.cb_client.DataBind();
            this.cb_practitioner.DataSource = BusinessEntity.Person.GetAllPersons();
            this.cb_practitioner.DataBind();
            this.cb_accountManager.DataSource = BusinessEntity.Person.GetAllPersons();
            this.cb_accountManager.DataBind();
            this.cb_deliveryManager.DataSource = BusinessEntity.Person.GetAllPersons();
            this.cb_deliveryManager.DataBind();
            this.cb_administrator.DataSource = BusinessEntity.Person.GetAllPersons();
            this.cb_administrator.DataBind();
        }

        private void BindProjectDetails()
        {
            this.tb_name.Text = prjDetails.name;

            //this.cb_client.DataBind DataBindings.Add("SelectedValue", prjDetails.client, "clientID");

            //this.tb_description.DataBindings.Add("Text", prjDetails, "description");
            this.tb_description.Text = prjDetails.description;

            //this.cb_practitioner.DataBindings.Add("SelectedValue", prjDetails.sogetiPractitioner, "personID");
            //this.cb_accountManager.DataBindings.Add("SelectedValue", prjDetails.accountManager, "personID");
            //this.cb_administrator.DataBindings.Add("SelectedValue", prjDetails.administrator, "personID");

            //this.dtp_startDate.DataBindings.Add("Value", prjDetails, "startDate");
            //this.dtp_endDate.DataBindings.Add("Value", prjDetails, "endDate");
            //this.dtp_revisedDate.DataBindings.Add("Value", prjDetails, "revisedDate");
        }

        private void ClearBinding()
        {
            this.tb_name.Text = "";
            //this.cb_client.DataSourceObject.GetViewNames();

            //this.tb_description.DataBindings.Clear();
            //this.cb_practitioner.DataBindings.Clear();
            //this.cb_accountManager.DataBindings.Clear();
            //this.cb_administrator.DataBindings.Clear();
            //this.dtp_startDate.DataBindings.Clear();
            //this.dtp_endDate.DataBindings.Clear();
            //this.dtp_revisedDate.DataBindings.Clear();
        }

        private void btn_LoadNext_Click(object sender, EventArgs e)
        {
            ClearBinding();
            prjDetails = prjBAL.LoadExistingProject(1);
            BindProjectDetails();
        }
    }
}