using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class Title
    {
        public Title()
        {
        }

        public Title(long id, string description, Status status)
        {
            this.id = id;
            this.description = description;
            this.status = status;
        }

        public long id { get; set; }
        public string description { get; set; }
        public Status status { get; set; }
    }
}
