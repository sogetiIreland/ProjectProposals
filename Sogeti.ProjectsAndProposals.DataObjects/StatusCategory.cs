using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class StatusCategory
    {
        #region Constructors
        public StatusCategory()
        {
        }

        public StatusCategory(int id, List<StatusItem> title, string description)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public List<StatusItem> Title { get; set; }
        public string Description { get; set; }
        #endregion
    }
}
