using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class ProjectSummary
    {
        public long id { get; set; }
        public string name { get; set; }

        public ProjectSummary()
        {
        }

        public ProjectSummary(long id, string name)
        {
            this.id = id;
            this.name = name;
        }

    }
}
