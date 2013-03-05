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

        public Title(int id, string description, Category category)
        {
            this.id = id;
            this.description = description;
            this.status = status;
        }

        public int id { get; set; }
        public string description { get; set; }
        public Status status { get; set; }
    }
}
