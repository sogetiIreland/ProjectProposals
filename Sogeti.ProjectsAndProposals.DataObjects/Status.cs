using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class Status
    {
        #region Constructors
        public Status()
        {
        }

        public Status(int id, string description)
        {
            this.Id = id;
            this.Description = description;
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Description { get; set; }
        #endregion Properties
    }
}
