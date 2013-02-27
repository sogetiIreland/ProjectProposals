using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class ProjectStatus
    {
        public long id { get; set; }
        public Category category { get; set; }
        public DateTime date { get; set; }
    }
}
