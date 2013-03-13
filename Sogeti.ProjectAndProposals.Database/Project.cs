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
            Database.Generics genDB = new Generics();

            DataObjects.Project prj = new DataObjects.Project();

            SqlParameter param = new SqlParameter("@ProjectID", typeof(System.Int32));
            param.Value = projectID;

            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(param);

            using (DataSet dsProjectDetails = genDB.GetDataFromDB("Select * From SelectProject(@ProjectID)", CommandType.Text, paramList))
            {
                if ((dsProjectDetails != null) && (dsProjectDetails.Tables.Count > 0))
                {
                    DataRow row = dsProjectDetails.Tables[0].Rows[0];
                    prj.ProjectID = Convert.ToInt32(row["ProjectID"]);
                    prj.Name = string.IsNullOrEmpty(row["ProjectName"].ToString()) ? " " : row["ProjectName"].ToString();
                    prj.Description = string.IsNullOrEmpty(row["ProjectDescription"].ToString()) ? " " : row["ProjectDescription"].ToString();
                    prj.StartDate = string.IsNullOrEmpty(row["ProjectStartDate"].ToString()) ? System.DateTime.MinValue : Convert.ToDateTime(row["ProjectStartDate"].ToString());
                    prj.EndDate = string.IsNullOrEmpty(row["ProjectEndDate"].ToString()) ? System.DateTime.MinValue : Convert.ToDateTime(row["ProjectEndDate"].ToString());
                    prj.RevisedDate = string.IsNullOrEmpty(row["ProjectRevisedDate"].ToString()) ? System.DateTime.MinValue : Convert.ToDateTime(row["ProjectRevisedDate"].ToString());
                    prj.Client = Database.Client.GetClient(Convert.ToInt32(row["ClientID"]));
                    prj.Administrator = Database.Person.LoadUser(Convert.ToInt32(row["AdminID"]));
                    prj.AccountManager = Database.Person.LoadUser(Convert.ToInt32(row["AccountManagerID"]));
                    prj.DeliveryManager = Database.Person.LoadUser(Convert.ToInt32(row["DeliverManagerID"]));
                    prj.SogetiPractitioner = Database.Person.LoadUser(Convert.ToInt32(row["SogetiPractitionerID"]));
                    prj.ProjectStatus = Database.ProjectStatus.GetAllStatusOfProject(projectID);
                }
            }

            return prj;
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
                        prj.ProjectID = Convert.ToInt32(row["ProjectID"]);
                        prj.Name = row["ProjectName"].ToString();
                        prj.Description = string.IsNullOrEmpty(row["ProjectDescription"].ToString()) ? " " : row["ProjectDescription"].ToString();
                        prj.StartDate = string.IsNullOrEmpty(row["ProjectStartDate"].ToString()) ? DateTime.MinValue : Convert.ToDateTime(row["ProjectStartDate"].ToString());
                        prj.EndDate = string.IsNullOrEmpty(row["ProjectEndDate"].ToString()) ? DateTime.MinValue : Convert.ToDateTime(row["ProjectEndDate"].ToString());
                        prj.RevisedDate = string.IsNullOrEmpty(row["ProjectRevisedDate"].ToString()) ? DateTime.MinValue : Convert.ToDateTime(row["ProjectRevisedDate"].ToString());
                        prj.Client = Database.Client.GetClient(Convert.ToInt32(row["ClientID"]));
                        prj.Administrator = Database.Person.LoadUser(Convert.ToInt32(row["AdminID"]));
                        prj.AccountManager = Database.Person.LoadUser(Convert.ToInt32(row["AccountManagerID"]));
                        prj.DeliveryManager = Database.Person.LoadUser(Convert.ToInt32(row["DeliverManagerID"]));
                        prj.SogetiPractitioner = Database.Person.LoadUser(Convert.ToInt32(row["SogetiPractitionerID"]));
                        prjList.Add(prj);
                    }
                }
            }

            return prjList;
        }
    }
}
