using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static List<DataObjects.Project> GetAllProjects()
        {
            return new List<DataObjects.Project>();
        }
    }
}
