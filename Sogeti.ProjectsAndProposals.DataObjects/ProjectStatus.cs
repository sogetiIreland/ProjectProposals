 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class ProjectStatus
    {
        #region Constructors
        public ProjectStatus()
        {
        }

        public ProjectStatus(int id, List<StatusCategory> category, DateTime date, string comment)
        {
            this.Id = id;
            this.Category = category;
            this.Date = date;
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public List<StatusCategory> Category { get; set; }
        public DateTime Date { get; set; }
        #endregion
    }
}
