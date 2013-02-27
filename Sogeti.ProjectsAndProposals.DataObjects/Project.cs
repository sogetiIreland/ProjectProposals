using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sogeti.ProjectsAndProposals.DataObjects
{
    public class Project
    {
        public long projectID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Client client { get; set; }
        public Person sogetiPractitioner { get; set; }
        public Person accountManager { get; set; }
        public Person deliveryManager { get; set; }
        public Person administrator { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime revisedDate { get; set; }
        public List<ProjectStatus> projectStatus { get; set; }

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
    }
}
