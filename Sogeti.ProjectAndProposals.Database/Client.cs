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
    public class Client
    {
        public static List<DataObjects.Client> GetAllClients()
        {
            List<DataObjects.Client> clientele = new List<DataObjects.Client>();

            DataObjects.Client c1 = new DataObjects.Client();
            c1.ClientID = 1;
            c1.ClientName = "Vodafone";
            c1.ClientAddress = "Dublin, Ireland";
            c1.ClientContactNumber = "0871234";
            clientele.Add(c1);

            DataObjects.Client c2 = new DataObjects.Client();
            c2.ClientID = 2;
            c2.ClientName = "O2";
            c2.ClientAddress = "Cork, Ireland";
            c2.ClientContactNumber = "0861234";
            clientele.Add(c2);

            return clientele;
        }

        public static DataObjects.Client GetClient(int clientID)
        {
            DataObjects.Client client = new DataObjects.Client();
            Database.Generics gen = new Generics();
            SqlParameter parm = new SqlParameter("@clientID", typeof(System.Int32));
            parm.Value = clientID;
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(parm);

            using (DataSet dsClientDetails = gen.GetDataFromDB("SELECT * FROM SelectClientDetails(@ClientID)", CommandType.Text, param))
            {
                if ((dsClientDetails.Tables.Count > 0) && (dsClientDetails.Tables[0].Rows.Count > 0))
                {
                    client = new DataObjects.Client(Convert.ToInt32(dsClientDetails.Tables[0].Rows[0]["ClientID"]),
                                                  dsClientDetails.Tables[0].Rows[0]["ClientName"].ToString(),
                                                  dsClientDetails.Tables[0].Rows[0]["ClientAddress"].ToString(),
                                                  dsClientDetails.Tables[0].Rows[0]["ClientContactNumber"].ToString(),
                                                  dsClientDetails.Tables[0].Rows[0]["ShortName"].ToString());
                }
            }

            return client;
        }

    }
}
