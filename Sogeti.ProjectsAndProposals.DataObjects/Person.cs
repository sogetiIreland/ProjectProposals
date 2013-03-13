using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class Person
    {
        #region Constructors
        public Person ()
        {
            this.PersonID = 0;
            this.FirstName = "";
            this.LastName = "";
        }

        public Person(int id, string fName, string lName)
        {
            this.PersonID = id;
            this.FirstName = fName;
            this.LastName = lName;
        }
        #endregion

        #region Properties
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion

        #region Methods
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
        #endregion
    }
}
