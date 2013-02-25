using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sogeti.ProjectsAndProposals;

namespace Sogeti.ProjectsAndProposals.Database
{
    public class Person
    {
        public static DataObjects.Person LoadUser(int userID)
        {
            DataObjects.Person person = new DataObjects.Person();
            person.firstName = "Abdul Muneeb";
            person.lastName = "Abbasi";
            person.personID = 1;

            return person;
        
        }

        public bool SaveUser(DataObjects.Person person)
        {
            return true;
        }

        public bool UpdateUser(DataObjects.Person person)
        {
            return true;
        }

        public static List<DataObjects.Person> GetAllUsers()
        {
            List<DataObjects.Person> users = new List<DataObjects.Person>();
            DataObjects.Person p1 = new DataObjects.Person();
            p1.firstName = "Abdul Muneeb";
            p1.lastName = "Abbasi";
            p1.personID = 1;
            users.Add(p1);

            DataObjects.Person p2 = new DataObjects.Person();
            p2.firstName = "Mark";
            p2.lastName = "Jones";
            p2.personID = 2;
            users.Add(p2);

            DataObjects.Person p3 = new DataObjects.Person();
            p3.firstName = "Barry";
            p3.lastName = "Hollywood";
            p3.personID = 3;
            users.Add(p3);

            return users;
        }
    }
}
