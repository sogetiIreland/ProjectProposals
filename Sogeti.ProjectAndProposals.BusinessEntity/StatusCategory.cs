using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sogeti.ProjectsAndProposals.DataObjects;
using Sogeti.ProjectsAndProposals.BusinessEntity;

namespace Sogeti.ProjectsAndProposals.BusinessEntity
{
    public class StatusCategory
    {
        public static DataObjects.StatusCategory GetCategory(int categoryID)
        {
            return Sogeti.ProjectsAndProposals.Database.StatusCategory.GetCategory(categoryID);
        }

        public static List<DataObjects.StatusCategory> GetCategories(int projectID, int titleID, int statusID)
        {
            return Sogeti.ProjectsAndProposals.Database.StatusCategory.GetAllCategories(projectID, titleID, statusID);
        }
    }
}
