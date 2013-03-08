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
    public class Title
    {
        public static DataObjects.Title GetTitle(int id, int statusID)
        {
            SqlParameter param = new SqlParameter("ID", typeof(System.Int32));
            param.Value = id;
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(param);

            DataObjects.Title title = new DataObjects.Title();

            Database.Generics genDB = new Generics();
            using (DataSet dsTitleDetail = genDB.GetDataFromDB("SELECT * FROM Category WHERE ID = @ID", CommandType.Text, paramList))
            {
                if ((dsTitleDetail != null) && (dsTitleDetail.Tables.Count > 0))
                {
                    title.id = Convert.ToInt32(dsTitleDetail.Tables[0].Rows[0]["id"]);
                    title.description = dsTitleDetail.Tables[0].Rows[0]["Description"].ToString();
                    title.status = Database.Status.GetStatus(statusID);
                }
            }

            return title;
        }


        public static List<DataObjects.Title> GetTitles(int categoryID, int statusID)
        {
            SqlParameter param = new SqlParameter("@categoryID", typeof(System.Int32));
            param.Value = categoryID;
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(param);

            List<DataObjects.Title> titles = new List<DataObjects.Title>();
            DataObjects.Title title;

            Database.Generics genDB = new Generics();
            using (DataSet dsTitleDetail = genDB.GetDataFromDB("SELECT * FROM Title WHERE CategoryID = @categoryID", CommandType.Text, paramList))
            {
                if ((dsTitleDetail != null) && (dsTitleDetail.Tables.Count > 0))
                {
                    foreach (DataRow row in dsTitleDetail.Tables[0].Rows)
                    {
                        title = new DataObjects.Title();
                        title.id = Convert.ToInt32(row["id"]);
                        title.description = row["Description"].ToString();
                        title.status = Database.Status.GetStatus (statusID);

                        titles.Add(title);
                    }
                }
            }

            return titles;
        }
    }
}
