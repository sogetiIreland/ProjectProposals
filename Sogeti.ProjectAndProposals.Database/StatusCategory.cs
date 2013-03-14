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
    public class StatusCategory
    {
        public static DataObjects.StatusCategory GetCategory(int id)
        {
            SqlParameter param = new SqlParameter("ID", typeof(System.Int32));
            param.Value = id;
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(param);

            DataObjects.StatusCategory category = new DataObjects.StatusCategory();

            Database.Generics genDB = new Generics();
            using (DataSet dsCategory = genDB.GetDataFromDB("SELECT * FROM category WHERE ID = @id", CommandType.Text, paramList))
            {
                if ((dsCategory != null) && (dsCategory.Tables.Count > 0))
                {
                    category.Id = Convert.ToInt32(dsCategory.Tables[0].Rows[0]["ID"]);
                    category.Description = dsCategory.Tables[0].Rows[0]["Description"].ToString();
                }
            }

            return category;

        }

        public static List<DataObjects.StatusCategory> GetAllCategories(int ProjectID, int titleID, int statusID)
        {
            List<DataObjects.StatusCategory> categoryList = new List<DataObjects.StatusCategory>();
            DataObjects.StatusCategory category;

            Database.Generics genDB = new Generics();
            using (DataSet dsCategory = genDB.GetDataFromDB("SELECT * FROM statusCategory", CommandType.Text))
            {
                if ((dsCategory != null) && (dsCategory.Tables.Count > 0))
                {
                    foreach (DataRow row in dsCategory.Tables[0].Rows)
                    {
                        category = new DataObjects.StatusCategory();
                        category.Id = Convert.ToInt32(row["id"]);
                        category.Description = row["Description"].ToString();
                        category.Title = Database.Title.GetTitles(category.Id, statusID);
                        categoryList.Add(category);
                    }
                }
            }

            return categoryList;
        }
    }
}
