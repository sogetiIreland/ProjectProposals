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

        public ProjectStatus(int id, List<Category> category, DateTime date, string comment)
        {
            this.id = id;
            this.category = category;
            this.date = date;
            this.comment = comment;
        }

        public int id { get; set; }
        public List<Category> category { get; set; }
        public DateTime date { get; set; }
        public string comment { get; set; }
    }
}
