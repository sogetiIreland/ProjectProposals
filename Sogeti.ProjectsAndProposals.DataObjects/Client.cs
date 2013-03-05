using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class Client
    {
        public Client()
        {
            this.clientID = 0;
            this.clientName = "";
            this.clientAddress = "";
            this.clientContactNumber = "";
            this.clientShortName = "";
        }
        public Client(int id, string name, string contact, string address, string shortName)
        {
            this.clientID = id;
            this.clientName = name;
            this.clientContactNumber = contact;
            this.clientAddress = address;
            this.clientShortName = shortName;
        }

        public int clientID { get; set; }
        public string clientName { get; set; }
        public string clientAddress { get; set; }
        public string clientContactNumber { get; set; }
        public string clientShortName { get; set; }

        public static List<Client> getAllClients() 
        {
            List<Client> clientList = new List<Client>();

            // Populate clientList

            return clientList;
        }
    }
}
