using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Sogeti.ProjectsAndProposals.DataObjects;

namespace Sogeti.ProjectsAndProposals.Database
{
    public class Project
    {
        public DataObjects.Project LoadProject(int projectID)
        {
            List<DataObjects.Project> prjList = new List<DataObjects.Project>();

            DataObjects.Project prj = new DataObjects.Project();

            prj.accountManager = new DataObjects.Person();
            prj.accountManager = Sogeti.ProjectsAndProposals.Database.Person.LoadUser(1);

            prj.administrator = new DataObjects.Person();
            prj.administrator = Sogeti.ProjectsAndProposals.Database.Person.GetAllUsers()[1];

            prj.client = new DataObjects.Client();
            prj.client = Sogeti.ProjectsAndProposals.Database.Client.GetAllClients()[1];

            prj.description = "Demonstration of Project And Proposals";
            prj.endDate = System.DateTime.Today.AddYears(2);
            prj.name = "Project And Proposals";
            prj.projectID = 0;
            prj.revisedDate = System.DateTime.Today;
            prj.sogetiPractitioner = new DataObjects.Person();
            prj.sogetiPractitioner = Sogeti.ProjectsAndProposals.Database.Person.GetAllUsers()[2];

            prj.startDate = System.DateTime.Today.AddYears(-1);
            prjList.Add(prj);

            DataObjects.Project prj1 = new DataObjects.Project();

            prj1.accountManager = new DataObjects.Person();
            prj1.accountManager = Sogeti.ProjectsAndProposals.Database.Person.LoadUser(0);

            prj1.administrator = new DataObjects.Person();
            prj1.administrator = Sogeti.ProjectsAndProposals.Database.Person.GetAllUsers()[2];

            prj1.client = new DataObjects.Client();
            prj1.client = Sogeti.ProjectsAndProposals.Database.Client.GetAllClients()[0];

            prj1.description = "Demo";
            prj1.endDate = System.DateTime.Today.AddMonths(6);
            prj1.name = "Internal Projects";
            prj1.projectID = 1;
            prj1.revisedDate = System.DateTime.Today.AddDays(-1);
            prj1.sogetiPractitioner = new DataObjects.Person();
            prj1.sogetiPractitioner = Sogeti.ProjectsAndProposals.Database.Person.GetAllUsers()[1];

            prj1.startDate = System.DateTime.Today.AddMonths(-2);
            prjList.Add(prj1);

            return prjList[projectID];
        }

        public static bool SaveProject(DataObjects.Project project)
        {
            return true;
        }

        public static bool UpdateProject(DataObjects.Project project)
        {
            return true;
        }

        public List<DataObjects.Project> GetAllProjects()
        {
            Database.Generics gen = new Generics();
            List<DataObjects.Project> prjList = new List<DataObjects.Project>();
            DataObjects.Project prj;
            using (DataSet ds = gen.GetDataFromDB("SELECT * FROM SelectProjects()", CommandType.Text))
            {
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        prj = new DataObjects.Project();
                        prj.projectID = Convert.ToInt32(row["ProjectID"]);
                        prj.name = row["ProjectName"].ToString();
                        prj.description = row["ProjectDescription"].ToString();
                        prj.startDate = Convert.ToDateTime(row["ProjectStartDate"]);
                        prj.endDate = Convert.ToDateTime(row["ProjectEndDate"]);
                        prj.revisedDate = Convert.ToDateTime(row["ProjectRevisedDate"]);
                        prj.client = Database.Client.GetClient(Convert.ToInt32(row["ClientID"]));
                        prj.administrator = Database.Person.LoadUser(Convert.ToInt32(row["Administrator"]));
                        prj.accountManager = Database.Person.LoadUser(Convert.ToInt32(row["AccountManager"]));
                        prj.deliveryManager = Database.Person.LoadUser(Convert.ToInt32(row["DeliveryManager"]));
                        prj.sogetiPractitioner = Database.Person.LoadUser(Convert.ToInt32(row["SogetiPractitioner"]));
                        prjList.Add(prj);
                    }
                }
            }

            return prjList;
        }
    }
}
