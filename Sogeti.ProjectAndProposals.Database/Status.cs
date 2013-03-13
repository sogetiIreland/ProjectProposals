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
    public class Status
    {
        public static DataObjects.Status GetStatus(int id)
        {
            Database.Generics genDB = new Generics();

            SqlParameter param = new SqlParameter("ID", typeof(System.Int32));
            param.Value = id;

            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(param);

            DataObjects.Status status = new DataObjects.Status();

            using (DataSet dsStatusDetail = genDB.GetDataFromDB("SELECT * FROM StatusType WHERE ID = @ID", CommandType.Text, paramList))
            {
                if ((dsStatusDetail != null) && (dsStatusDetail.Tables.Count > 0))
                {
                    status.Id = Convert.ToInt32(dsStatusDetail.Tables[0].Rows[0]["ID"]);
                    status.Description = dsStatusDetail.Tables[0].Rows[0]["Description"].ToString();
                }
            }

            return status;
        }

        public static List<DataObjects.Status> GetAllStatus()
        {
            Database.Generics genDB = new Generics();

            List<DataObjects.Status> statusList = new List<DataObjects.Status>();
            DataObjects.Status status;

            using (DataSet dsStatusDetails = genDB.GetDataFromDB("SELECT * FROM StatusType", CommandType.Text))
            {
                if ((dsStatusDetails != null) && (dsStatusDetails.Tables.Count > 0))
                {
                    foreach (DataRow row in dsStatusDetails.Tables[0].Rows)
                    {
                        status = new DataObjects.Status();
                        status.Id = Convert.ToInt32(row["id"]);
                        status.Description = row["Description"].ToString();

                        statusList.Add(status);
                    }
                }
            }

            return statusList;
        }
    }
}