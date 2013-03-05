using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sogeti.ProjectsAndProposals.Database;

namespace Sogeti.ProjectsAndProposals.BusinessEntity
{
    public class Title
    {
        public DataObjects.Title GetTitle(int titleID)
        {
            return Database.Title.GetTitle(titleID);
        }

        public List<DataObjects.Title> GetTitles(int categoryID, int statusID)
        {
            return Database.Title.GetTitles(categoryID, statusID);
        }
    }
}
