using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sogeti.ProjectsAndProposals.Database;
using Sogeti.ProjectsAndProposals.DataObjects;

namespace Sogeti.ProjectsAndProposals.BusinessEntity
{
    public class StatusItem
    {
        public DataObjects.StatusItem GetTitle(int titleID, int statusID)
        {
            return Database.StatusItem.GetTitle(titleID, statusID);
        }

        public List<DataObjects.StatusItem> GetTitles(int categoryID, int statusID)
        {
            return Database.StatusItem.GetTitles(categoryID, statusID);
        }
    }
}
