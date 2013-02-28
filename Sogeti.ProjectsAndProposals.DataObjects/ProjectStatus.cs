using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class ProjectStatus
    {
        public ProjectStatus()
        {
        }

        public ProjectStatus(long id, Category category, DateTime date)
        {
            this.id = id;
            this.category = category;
            this.date = date;
        }

        public long id { get; set; }
        public Category category { get; set; }
        public DateTime date { get; set; }
    }
}
