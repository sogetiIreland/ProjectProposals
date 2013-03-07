using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sogeti.ProjectsAndProposals.UI.Models
{
    public class BusinessDevelopmentModel
    {
        public StatusItemModel knownOpportunity { get; set; }
        public StatusItemModel clientContact { get; set; }

        public BusinessDevelopmentModel()
        {
        }

        public BusinessDevelopmentModel(StatusItemModel knownOpportunity, StatusItemModel clientContact)
        {
            this.knownOpportunity = knownOpportunity;
            this.clientContact = clientContact;
        }
    }
}