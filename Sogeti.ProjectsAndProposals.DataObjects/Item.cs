using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class Item
    {
        public long id { get; set; }
        public string description { get; set; }
        public Status status { get; set; }
    }
}
