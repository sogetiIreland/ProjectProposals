using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class StatusItem
    {
        #region Constructors
        public StatusItem()
        {
        }

        public StatusItem(int id, string title, Status status)
        {
            this.Id = id;
            this.Title = title;
            this.Status = status;
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public Status Status { get; set; }
        #endregion
    }
}
