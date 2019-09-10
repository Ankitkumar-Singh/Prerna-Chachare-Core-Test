using Microsoft.AspNetCore.Mvc;
using PagedList.Core;
using ProjectManagement.Models;
using ProjectManagement.Repository;

namespace ProjectManagement.Controllers
{
    [Route("[controller]")]
    public class ProjectManagerController : Controller
    {
        #region Global Declaration
        // Global Declaration of variables
        readonly IProjectManagerRepository _projectManagerRepository;
        #endregion

        #region ProjectManagerController Constructor
        // Constructor of ProjectController
        public ProjectManagerController(IProjectManagerRepository projectManagerRepository) =>
            _projectManagerRepository = projectManagerRepository;
        #endregion

        #region Action to List Project Managers
        // Action to list project managers
        [Route("[action]")]
        public IActionResult Index(int page = 1, int pageSize = 5, string search = null)
        {
            if (!string.IsNullOrEmpty(search))
            {
                PagedList<ProjectManager> foundProjectManagers = new PagedList<ProjectManager>(_projectManagerRepository.SearchProjectManager(search), page, pageSize);
                return View("Index", foundProjectManagers);
            }
            PagedList<ProjectManager> projectManagers = new PagedList<ProjectManager>(_projectManagerRepository.GetAllProjectManagers(), page, pageSize);
            return View("Index", projectManagers);
        }
        #endregion

        #region Action to view details of Project Manager
        // Action to view details of project manager
        [Route("[action]")]
        public IActionResult Details(int id)
        {
            var projectManager = _projectManagerRepository.GetProjectManagerDetails(id);
            if (projectManager == null)
                return View("ProjectManagerNotFound");
            return View(projectManager);
        }
        #endregion

        #region Action to save Project Manager
        // Action to add and edit project manager
        [Route("[action]")]
        public IActionResult Save(int id)
        {
            var projectManager = _projectManagerRepository.GetProjectManagerDetails(id);
            if (id == 0)
                projectManager = new ProjectManager();
            else if (projectManager == null)
                return View("ProjectManagerNotFound");
            return View(projectManager);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Save(ProjectManager projectManager)
        {
            if (projectManager.Id == 0)
            {
                if (_projectManagerRepository.GetEmail(projectManager.Email) != null)
                {
                    ModelState.AddModelError("Email", "Email already exists.");
                    return View(projectManager);
                }
                else if (_projectManagerRepository.GetContact(projectManager.Contact) != null)
                {
                    ModelState.AddModelError("Contact", "Contact already exists.");
                    return View(projectManager);
                }
            }
            if (ModelState.IsValid)
            {
                _projectManagerRepository.SaveProjectManager(projectManager);
                return RedirectToAction("Index");
            }
            ModelState.Clear();
            return View();
        }
        #endregion

        #region Action to delete Project Manager
        // Action to delete project manager
        [Route("[action]")]
        public IActionResult Delete(int id)
        {
            var projectManager = _projectManagerRepository.GetProjectManagerDetails(id);
            if (projectManager == null)
                return View("ProjectManagerNotFound");
            return View(projectManager);
        }

        [HttpPost, ActionName("Delete")]
        [Route("[action]")]
        public IActionResult DeleteConfirmed(int id)
        {
            _projectManagerRepository.DeleteProjectManager(id);
            return RedirectToAction("Index");
        }
        #endregion
    }
}