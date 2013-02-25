using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sogeti.ProjectsAndProposals.DataObjects;
using Sogeti.ProjectsAndProposals.Database;

namespace Sogeti.ProjectsAndProposals.BusinessEntity
{
    public class Project
    {
        public DataObjects.Project LoadExistingProject(int projectID)
        {
            Database.Project prj = new Database.Project();
            return prj.LoadProject(projectID);
        }
    }
}
