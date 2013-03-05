using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sogeti.ProjectsAndProposals.UI.Models
{
    public class StatusItemModel
    {
        public string name { get; set; }
        public int state { get; set; }
        public string comment { get; set; }

        public StatusItemModel()
        {
        }

        public StatusItemModel(string name, int state, string comment)
        {
            this.name = name;
            this.state = state;
            this.comment = comment;
        }
    }
}