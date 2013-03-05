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
    public class Category
    {
        public static DataObjects.Category GetCategory(int id)
        {
            SqlParameter param = new SqlParameter("ID", typeof(System.Int32));
            param.Value = id;
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(param);
            
            DataObjects.Category category = new DataObjects.Category();

            Database.Generics genDB = new Generics();
            using (DataSet dsCategory = genDB.GetDataFromDB("SELECT * FROM category WHERE ID = @id", CommandType.Text, paramList))
            {
                if ((dsCategory != null) && (dsCategory.Tables.Count > 0))
                {
                    category.id = Convert.ToInt32(dsCategory.Tables[0].Rows[0]["ID"]);
                    category.description = dsCategory.Tables[0].Rows[0]["Description"].ToString();
                }
            }

            return category;

        }

        public static List<DataObjects.Category> GetAllCategories(int ProjectID, int titleID, int statusID)
        {
            List<DataObjects.Category> categoryList = new List<DataObjects.Category>();
            DataObjects.Category category;

            Database.Generics genDB = new Generics();
            using (DataSet dsCategory = genDB.GetDataFromDB("SELECT * FROM category", CommandType.Text))
            {
                if ((dsCategory != null) && (dsCategory.Tables.Count > 0))
                {
                    foreach (DataRow row in dsCategory.Tables[0].Rows)
                    {
                        category = new DataObjects.Category();
                        category.id = Convert.ToInt32(row["id"]);
                        category.description = row["Description"].ToString();
                        category.title = Database.Title.GetTitles(category.id, statusID);
                        categoryList.Add(category);
                    }
                }
            }

            return categoryList;
        }
    }
}
