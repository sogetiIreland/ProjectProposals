using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sogeti.ProjectsAndProposals.DataObjects;
using Sogeti.ProjectsAndProposals.Database;

namespace Sogeti.ProjectsAndProposals.BusinessEntity
{
    public class Person
    {
        public static List<DataObjects.Person> GetAllPersons()
        {
            return Database.Person.GetAllUsers();
        }
    }
}
