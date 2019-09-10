using Microsoft.AspNetCore.Mvc;
using PagedList.Core;
using ProjectManagement.Models;
using ProjectManagement.Repository;

namespace ProjectManagement.Controllers
{
    [Route("[controller]")]
    public class ProjectController : Controller
    {
        #region Global Declaration
        // Global Declaration of variables
        readonly IProjectRepository _projectRepository;
        #endregion

        #region ProjectController Constructor
        // Constructor of ProjectController
        public ProjectController(IProjectRepository projectRepository) => _projectRepository = projectRepository;
        #endregion

        #region Action to List Projects
        // Action to list projects
        [Route("[action]")]
        public IActionResult Index(int page = 1, int pageSize = 3, string search = null)
        {
            if (!string.IsNullOrEmpty(search))
            {
                PagedList<Project> foundProjects = new PagedList<Project>(_projectRepository.SearchProject(search), page, pageSize);
                return View("Index", foundProjects);
            }
            PagedList<Project> projects = new PagedList<Project>(_projectRepository.GetAllProjects(), page, pageSize);
            return View("Index", projects);
        }
        #endregion

        #region Action to view details of Project
        // Action to view details of project
        [Route("[action]")]
        public IActionResult Details(int id)
        {
            var project = _projectRepository.GetProjectDetails(id);
            if (project == null)
            {
                Response.StatusCode = 404;
                return RedirectToAction("Error", "Home");
            }
            return View(project);
        }
        #endregion

        #region Action to save Project
        // Action to add and edit project
        [Route("[action]")]
        public IActionResult Save(int id)
        {
            ViewBag.ProjectManagerId = _projectRepository.GetManagerList();
            var project = _projectRepository.GetProjectDetails(id);
            if (project == null)
                project = new Project();
            return View(project);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Save(Project project)
        {
            ViewBag.ProjectManagerId = _projectRepository.GetManagerList();
            if (project.Id == 0)
            {
                if (_projectRepository.GetProjectName(project.Name) != null)
                {
                    ModelState.AddModelError("Name", "Project already exists.");
                    return View(project);
                }
            }

            if (ModelState.IsValid)
            {
                _projectRepository.SaveProject(project);
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        #region Action to delete Project
        // Action to delete project
        [Route("[action]")]
        public IActionResult Delete(int id)
        {
            var project = _projectRepository.GetProjectDetails(id);
            if (project == null)
            {
                Response.StatusCode = 404;
                return RedirectToAction("Error", "Home");
            }
            return View(project);
        }

        [HttpPost, ActionName("Delete")]
        [Route("[action]")]
        public IActionResult DeleteConfirmed(int id)
        {
            _projectRepository.DeleteProject(id);
            return RedirectToAction("Index");
        }
        #endregion
    }
}