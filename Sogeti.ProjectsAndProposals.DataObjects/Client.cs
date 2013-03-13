using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class Client
    {
        #region Constructors
        public Client()
        {
            this.ClientID = 0;
            this.ClientName = "";
            this.ClientAddress = "";
            this.ClientContactNumber = "";
            this.ClientShortName = "";
        }
        public Client(int id, string name, string contact, string address, string shortName)
        {
            this.ClientID = id;
            this.ClientName = name;
            this.ClientContactNumber = contact;
            this.ClientAddress = address;
            this.ClientShortName = shortName;
        }
        #endregion

        #region Properties
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientContactNumber { get; set; }
        public string ClientShortName { get; set; }
        #endregion

        #region Methods
        public static List<Client> getAllClients()
        {
            List<Client> clientList = new List<Client>();

            // Populate clientList

            return clientList;
        }
        #endregion
    }
}
