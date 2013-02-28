using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class Status
    {
        public Status()
        {
        }

        public Status(long id, string description)
        {
            this.id = id;
            this.description = description;
        }

        public long id { get; set; }
        public string description { get; set; }
    }
}
