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
        public static DataObjects.StatusItem GetTitle(int id, int statusID)
        {
            SqlParameter param = new SqlParameter("ID", typeof(System.Int32));
            param.Value = id;
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(param);

            DataObjects.StatusItem title = new DataObjects.StatusItem();

            Database.Generics genDB = new Generics();
            using (DataSet dsTitleDetail = genDB.GetDataFromDB("SELECT * FROM Category WHERE ID = @ID", CommandType.Text, paramList))
            {
                if ((dsTitleDetail != null) && (dsTitleDetail.Tables.Count > 0))
                {
                    title.Id = Convert.ToInt32(dsTitleDetail.Tables[0].Rows[0]["id"]);
                    title.Title = dsTitleDetail.Tables[0].Rows[0]["Description"].ToString();
                    title.Status = Database.Status.GetStatus(statusID);
                }
            }

            return title;
        }


        public static List<DataObjects.StatusItem> GetTitles(int categoryID, int statusID)
        {
            SqlParameter param = new SqlParameter("@categoryID", typeof(System.Int32));
            param.Value = categoryID;
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(param);

            List<DataObjects.StatusItem> titles = new List<DataObjects.StatusItem>();
            DataObjects.StatusItem title;

            Database.Generics genDB = new Generics();
            using (DataSet dsTitleDetail = genDB.GetDataFromDB("SELECT * FROM CategoryItem WHERE CategoryID = @categoryID", CommandType.Text, paramList))
            {
                if ((dsTitleDetail != null) && (dsTitleDetail.Tables.Count > 0))
                {
                    foreach (DataRow row in dsTitleDetail.Tables[0].Rows)
                    {
                        title = new DataObjects.StatusItem();
                        title.Id = Convert.ToInt32(row["id"]);
                        title.Title = row["Title"].ToString();
                        title.Status = Database.Status.GetStatus (statusID);

                        titles.Add(title);
                    }
                }
            }

            return titles;
        }
    }
}
