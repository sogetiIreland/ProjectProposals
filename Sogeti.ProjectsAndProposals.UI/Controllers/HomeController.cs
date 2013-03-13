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
            ViewBag.Message = ".Net MVC 4 Prototype Testing Azure.";

            List<SelectListItem> projects = new List<SelectListItem>();

            List<Models.ProjectIDModel> projectIDlist = GetAllProjectIDs();


            foreach (Models.ProjectIDModel prj in projectIDlist)
            {
                projects.Add(new SelectListItem { Text = prj.name, Value = prj.projectID.ToString() });
            }

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
            DataObjects.Project project = new BusinessEntity.Project().LoadProject(Int32.Parse(ProjectList));
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

                Models.ProjectIDModel prjIDMod = new Models.ProjectIDModel(projectList[i].ProjectID, projectList[i].Name);
                prjIDModelList.Add(prjIDMod);
            }

            return prjIDModelList;
        }

    }
}
