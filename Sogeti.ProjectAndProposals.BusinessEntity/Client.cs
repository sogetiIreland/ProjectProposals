using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sogeti.ProjectsAndProposals.Database;

namespace Sogeti.ProjectsAndProposals.BusinessEntity
{
    public class Client
    {
        public static List<DataObjects.Client> GetAllClients()
        {
            return Database.Client.GetAllClients();
        }
    }
}
