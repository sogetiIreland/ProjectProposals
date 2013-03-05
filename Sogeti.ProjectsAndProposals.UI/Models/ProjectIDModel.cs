using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sogeti.ProjectsAndProposals.BusinessEntity;
using Sogeti.ProjectsAndProposals.DataObjects;

namespace Sogeti.ProjectsAndProposals.UI.Models
{
    public class ProjectIDModel
    {
        public long projectID { get; set; }
        public string name { get; set; }

        public ProjectIDModel()
        {
        }

        public ProjectIDModel(long ID, string name)
        {
            this.projectID = ID;
            this.name = name;
        }
    }
}