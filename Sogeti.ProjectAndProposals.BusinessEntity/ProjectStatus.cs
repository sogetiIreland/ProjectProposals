using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sogeti.ProjectsAndProposals.Database;

namespace Sogeti.ProjectsAndProposals.BusinessEntity
{
    public class ProjectStatus
    {
        public static List<DataObjects.ProjectStatus> GetProjectStatus(int projectID)
        {
            return Database.ProjectStatus.GetAllStatusOfProject(projectID);
        }
    }
}
