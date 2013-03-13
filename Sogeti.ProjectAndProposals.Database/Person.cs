using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Sogeti.ProjectsAndProposals;

namespace Sogeti.ProjectsAndProposals.Database
{
    public class Person
    {
        public static DataObjects.Person LoadUser(int userID)
        {
            DataObjects.Person person = new DataObjects.Person();
            SqlParameter param = new SqlParameter("@PersonID", typeof(System.Int32));
            param.Value = userID;

            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(param);

            Database.Generics gen = new Generics();
            using (DataSet dsPersonDetails = gen.GetDataFromDB("SELECT * FROM SelectPersonDetails(@PersonID)", CommandType.Text, paramList))
            {
                if ((dsPersonDetails != null) && (dsPersonDetails.Tables.Count > 0))
                {
                    person.PersonID = Convert.ToInt32(dsPersonDetails.Tables[0].Rows[0]["PersonID"]);
                    person.FirstName = dsPersonDetails.Tables[0].Rows[0]["FirstName"].ToString();
                    person.LastName = dsPersonDetails.Tables[0].Rows[0]["LastName"].ToString();
                }
            }

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
            p1.FirstName = "Abdul Muneeb";
            p1.LastName = "Abbasi";
            p1.PersonID = 1;
            users.Add(p1);

            DataObjects.Person p2 = new DataObjects.Person();
            p2.FirstName = "Mark";
            p2.LastName = "Jones";
            p2.PersonID = 2;
            users.Add(p2);

            DataObjects.Person p3 = new DataObjects.Person();
            p3.FirstName = "Barry";
            p3.LastName = "Hollywood";
            p3.PersonID = 3;
            users.Add(p3);

            return users;
        }
    }
}
