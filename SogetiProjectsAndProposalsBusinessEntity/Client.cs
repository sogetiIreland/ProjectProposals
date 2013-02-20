using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SogetiProjectsAndProposalsBusinessEntity
{
    public class Client
    {
        public int clientID { get; set; }
        public string clientName { get; set; }
        public string clientAddress { get; set; }
        public string clientContactNumber { get; set; }

        public static List<Client> getAllClients() 
        {
            List<Client> clientList = new List<Client>();

            // Populate clientList

            return clientList;
        }
    }
}
