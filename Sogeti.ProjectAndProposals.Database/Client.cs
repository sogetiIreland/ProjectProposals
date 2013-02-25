using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Sogeti.ProjectsAndProposals.DataObjects;

namespace Sogeti.ProjectsAndProposals.Database
{
    public class Client
    {
        public static List<DataObjects.Client> GetAllClients()
        {
            List<DataObjects.Client> clientele = new List<DataObjects.Client>();

            DataObjects.Client c1 = new DataObjects.Client();
            c1.clientID = 1;
            c1.clientName = "Vodafone";
            c1.clientAddress = "Dublin, Ireland";
            c1.clientContactNumber = "0871234";
            clientele.Add(c1);

            DataObjects.Client c2 = new DataObjects.Client();
            c2.clientID = 2;
            c2.clientName = "O2";
            c2.clientAddress = "Cork, Ireland";
            c2.clientContactNumber = "0861234";
            clientele.Add(c2);

            return clientele;
        }

    }
}
