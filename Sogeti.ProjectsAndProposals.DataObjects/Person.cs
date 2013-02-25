using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class Person
    {
        public int personID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public bool loadUser(int personID)
        {
            // 
            return false;
        }

        public bool saveUser() 
        { 
            //
            return false;
        }

        public bool updateUser() 
        { 
            //
            return false;
        }

        public static List<Person> getAllUsers() 
        {
            List<Person> personList = new List<Person>();
            //
            return personList;
        }
    }
}
