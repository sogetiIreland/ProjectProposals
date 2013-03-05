using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sogeti.ProjectsAndProposals.Database;

namespace Sogeti.ProjectsAndProposals.BusinessEntity
{
    public class Status
    {
        public DataObjects.Status GetStatus(int id)
        {
            return Database.Status.GetStatus(id);
        }

        public List<DataObjects.Status> GetAllStatus()
        {
            return Database.Status.GetAllStatus();
        }
    }
}
