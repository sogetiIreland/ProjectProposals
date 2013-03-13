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
    public class ProjectStatus
    {
        public static List<DataObjects.ProjectStatus> GetAllStatusOfProject(int projectID)
        {
            SqlParameter param = new SqlParameter("projectID", typeof(System.Int32));
            param.Value = projectID;
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(param);

            List<DataObjects.ProjectStatus> statusList = new List<DataObjects.ProjectStatus>();
            DataObjects.ProjectStatus status;

            Database.Generics genDB = new Generics();
            using (DataSet ds = genDB.GetDataFromDB("SELECT * FROM ProjectStatus WHERE ProjectID = @ProjectID", CommandType.Text, paramList))
            {
                if ((ds != null) && (ds.Tables.Count > 0))
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        status = new DataObjects.ProjectStatus();
                        status.Id = Convert.ToInt32(row["id"]);
                        status.Date = Convert.ToDateTime(row["date"]);
                        status.Category = Database.StatusCategory.GetAllCategories(projectID,
                            Convert.ToInt32(row["titleID"]), 
                            Convert.ToInt32(row["StatusTypeID"]));

                        statusList.Add(status);
                    }
                }
            }
            return statusList;
        }
    }
}
