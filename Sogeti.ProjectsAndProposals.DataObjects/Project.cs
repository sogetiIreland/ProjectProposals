using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class Project
    {
        #region Properties
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Client Client { get; set; }
        public Person SogetiPractitioner { get; set; }
        public Person AccountManager { get; set; }
        public Person DeliveryManager { get; set; }
        public Person Administrator { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RevisedDate { get; set; }
        public List<ProjectStatus> ProjectStatus { get; set; }
        #endregion

        #region Methods
        public bool loadProject() 
        {
            // Add logic
            return false;
        }

        public bool saveProject()
        {
            // Add logic
            return false;
        }

        public bool updateProject()
        {
            // Add logic
            return false;
        }

        public static List<Project> getAllProject() 
        {
            List<Project> projectList = new List<Project>();

            // Populate projectList

            return projectList;
        }
        #endregion
    }
}
