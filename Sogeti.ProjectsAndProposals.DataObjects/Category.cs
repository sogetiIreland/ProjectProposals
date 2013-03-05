using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class Category
    {
        public Category()
        {
        }

        public Category(int id, List<Title> title, string description)
        {
            this.id = id;
            this.title = title;
            this.description = description;
        }

        public int id { get; set; }
        public List<Title> title { get; set; }
        public string description { get; set; }
    }
}
