using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sogeti.ProjectsAndProposals.Database;
using Sogeti.ProjectsAndProposals.DataObjects;

namespace Sogeti.ProjectsAndProposals.BusinessEntity
{
    public class DomainFacade
    {
        public static DataObjects.Project RetrieveProject(int projectID)
        {
            Database.Project prj = new Database.Project();
            return prj.LoadProject(projectID);
        }

        public static List<DataObjects.Project> GetProjectList()
        {
            return Database.Project.GetAllProjects();
        }

        public static List<DataObjects.ProjectSummary> GetProjectIDDTOList()
        {
            return Database.Project.GetAllProjectIDs();
        }

    }
}
