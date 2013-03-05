using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sogeti.ProjectsAndProposals.BusinessEntity;

namespace Sogeti.ProjectsAndProposals.UI.Models
{
    public class ProjectModel
    {
        public long projectID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string client { get; set; }
        public string sogetiPractitioner { get; set; }
        public string accountManager { get; set; }
        public string deliveryManager { get; set; }
        public string administrator { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime revisedDate { get; set; }
        //public List<ProjectStatus> projectStatus { get; set; }

        public ProjectModel()
        {
        }

        public ProjectModel(long ID, string name, string description, string client, string sogetiPractitioner)
        {
            this.projectID = ID;
            this.name = name;
            this.description = description;
            this.client = client;
            this.sogetiPractitioner = sogetiPractitioner;

            this.accountManager = "Account Manager";
            this.deliveryManager = "Delivery Manager";
            this.administrator = "Administrator";
            this.startDate = new DateTime();
            this.endDate = new DateTime();
            this.revisedDate = new DateTime();
        }
    }
}