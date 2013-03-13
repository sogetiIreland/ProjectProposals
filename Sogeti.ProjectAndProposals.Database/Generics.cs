using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sogeti.ProjectsAndProposals.Database
{
    public class Generics
    {
        public static string ConnectionString
        {
            get
            {
                //return "Data Source=localhost;Initial Catalog=ProjectsAndProposals;User ID=amabbasi;Password=SogetiIreland;Integrated Security=True";
                return "Server=tcp:dufpnqhji7.database.windows.net,1433;Database=ProjectsAndProposals;User Id=amabbasi@dufpnqhji7;Password=SogetiIreland16;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
            }
        }

        public DataSet GetDataFromDB(string query, CommandType type)
        {
            return GetDataFromDB(query, type, null);
        }

        public DataSet GetDataFromDB(string query, CommandType type, List<SqlParameter> parameters)
        {
            DataSet dsResults = new DataSet();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    return dsResults;
                }

                if (conn.State != ConnectionState.Open)
                    return dsResults;

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.CommandType = type;
                    cmd.Parameters.Clear();

                    if ((parameters != null) && (parameters.Count > 0))
                    {
                        foreach (SqlParameter param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dsResults);
                    }
                }

                return dsResults;
            }

        }
    }
}
