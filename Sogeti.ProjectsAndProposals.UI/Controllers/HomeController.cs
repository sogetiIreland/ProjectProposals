using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sogeti.ProjectsAndProposals.BusinessEntity;

namespace Sogeti.ProjectsAndProposals.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = ".Net MVC 4 Prototype.";

            List<SelectListItem> projects = new List<SelectListItem>();

            List<Models.ProjectIDModel> projectIDlist = GetAllProjectIDs();

            
#if DEBUG
                projects.Add(new SelectListItem { Text = "Mock Debug Project", Value = "5" });
#else
            for (int i = 0; i < projectIDlist.Count; i++)
            {
                projects.Add(new SelectListItem { Text = projectIDlist[i].name, Value = projectIDlist[i].projectID.ToString() });
            }
#endif
            ViewBag.ProjectList = projects;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProjectDetails(string ProjectList)
        {
            ViewBag.Message = "Project Details";
#if DEBUG
            DataObjects.Project project = new DataObjects.Project();

            project.projectID = 5;
            project.name = "Debug Mock Project";
            project.client = new DataObjects.Client();
            project.deliveryManager = new DataObjects.Person(34, "Del", "Man");
            project.description = "Just a mock project for dev.";
            project.startDate = new DateTime();
            project.endDate = new DateTime();
            project.revisedDate = new DateTime();
            project.sogetiPractitioner = new DataObjects.Person(35, "Sog", "Pract");
            project.accountManager = new DataObjects.Person(36, "Acc", "Man");
            project.administrator = new DataObjects.Person(37, "Ad", "Min");

            List<DataObjects.Title> titles = new List<DataObjects.Title>();
            DataObjects.Category businessDevelopment = new DataObjects.Category();

            DataObjects.Title title = new DataObjects.Title(1, "Deliverables and Results", businessDevelopment);
            titles.Add(title);

            title = new DataObjects.Title(2, "Schedule", businessDevelopment);
            titles.Add(title);

            title = new DataObjects.Title(3, "Capacity / Resources", businessDevelopment);
            titles.Add(title);

            title = new DataObjects.Title(4, "Scope", businessDevelopment);
            titles.Add(title);

            title = new DataObjects.Title(5, "Client Satisfaction", businessDevelopment);
            titles.Add(title);

            title = new DataObjects.Title(6, "Issues & Risks", businessDevelopment);
            titles.Add(title);

            title = new DataObjects.Title(7, "Use of Test Control", businessDevelopment);
            titles.Add(title);

            title = new DataObjects.Title(8, "Employee Satisfaction / Issues", businessDevelopment);
            titles.Add(title);

            businessDevelopment.id = 1;
            businessDevelopment.title = titles;
            businessDevelopment.description = "Delivery";

            List<DataObjects.Title> titles2 = new List<DataObjects.Title>();

            DataObjects.Category delivery = new DataObjects.Category();

            title = new DataObjects.Title(1, "Known Opportunity", delivery);
            titles2.Add(title);

            title = new DataObjects.Title(2, "Client Contact", delivery);
            titles2.Add(title);

            delivery.id = 2;
            delivery.title = titles2;
            delivery.description = "Delivery Description";

            List<DataObjects.Category> categoryList = new List<DataObjects.Category>();
            categoryList.Add(businessDevelopment);
            categoryList.Add(delivery);

            List<DataObjects.ProjectStatus> projectStatusList = new List<DataObjects.ProjectStatus>();
            projectStatusList.Add(new DataObjects.ProjectStatus(1, categoryList, new DateTime(), "Project Status Comment"));

            project.projectStatus = projectStatusList;
            
            // Table Header
            //project.projectStatus[0].category[0].description;
            //int i = project.projectStatus[0].category[0].title;

            // Column Header
            //project.projectStatus[0].category[0].title[0].description; status is Normal etc and should be and enum

#else
            DataObjects.Project project = new BusinessEntity.Project().LoadProject(Int32.Parse(ProjectList));
#endif
            ViewBag.SelectedProject = project;

            return View();
        }

        public static List<Models.ProjectIDModel> GetAllProjectIDs()
        {
            BusinessEntity.Project project = new BusinessEntity.Project();
            List<DataObjects.Project> projectList = project.GetAllProjects();
            List<Models.ProjectIDModel> prjIDModelList = new List<Models.ProjectIDModel>();

            for (int i = 0; i < projectList.Count; i++)
            {

                Models.ProjectIDModel prjIDMod = new Models.ProjectIDModel(projectList[i].projectID, projectList[i].name);
                prjIDModelList.Add(prjIDMod);
            }

            return prjIDModelList;
        }

    }
}
