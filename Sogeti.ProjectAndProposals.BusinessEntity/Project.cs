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
        public DataObjects.Project LoadProject(int projectID)
        {
            Database.Project prj = new Database.Project();
            return prj.LoadProject(projectID);
        }

        public List<DataObjects.Project> GetAllProjects()
        {
            Database.Project prjDB = new Database.Project();
            List<DataObjects.Project> prjList = prjDB.GetAllProjects();

            foreach (DataObjects.Project prj in prjList)
            {
                prj.projectStatus = Database.ProjectStatus.GetAllStatusOfProject(prj.projectID);
            }

            return prjList;
        }
    }
}
