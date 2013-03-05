using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sogeti.ProjectsAndProposals.DataObjects;
using Sogeti.ProjectsAndProposals.BusinessEntity;

namespace Sogeti.ProjectsAndProposals.BusinessEntity
{
    public class Category
    {
        public static DataObjects.Category GetCategory(int categoryID)
        {
            return Sogeti.ProjectsAndProposals.Database.Category.GetCategory(categoryID);
        }

        public static List<DataObjects.Category> GetCategories(int projectID, int titleID, int statusID)
        {
            return Sogeti.ProjectsAndProposals.Database.Category.GetAllCategories(projectID, titleID, statusID);
        }
    }
}
