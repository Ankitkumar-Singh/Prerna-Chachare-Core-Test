using Microsoft.EntityFrameworkCore;
using ProjectManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagement.Repository
{
    public class ProjectManagerRepository: IProjectManagerRepository
    {
        #region Database context
        // Database context
        private readonly ProjectDBContext _context;
        #endregion

        #region Constructor of class ProjectManagerRepository
        // Constructor of ProjectManagerRepository class
        public ProjectManagerRepository(ProjectDBContext context) => _context = context;
        #endregion

        #region Method to get list of all Project Managers
        // Method to get list of project managers
        public IEnumerable<ProjectManager> GetAllProjectManagers() => _context.ProjectManager;
        #endregion

        #region Method to get details of specific Project Manager
        // Method to get details of project manager 
        public ProjectManager GetProjectManagerDetails(int id) => 
            _context.ProjectManager.SingleOrDefault(x => x.Id == id);
        #endregion

        #region Method to Save a Project Manager
        // Method to add and edit a project manager
        public ProjectManager SaveProjectManager(ProjectManager projectManager)
        {
            if (projectManager != null)
            {
                if (projectManager.Id == 0)
                    _context.ProjectManager.Add(projectManager);
                else
                    _context.Entry(projectManager).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return _context.ProjectManager.Where(x => x.FirstName == projectManager.FirstName).FirstOrDefault();
        }
        #endregion

        #region Method to Delete a Project Manager
        // Method to delete a project manager
        public ProjectManager DeleteProjectManager(int id)
        {
            ProjectManager projectManager = _context.ProjectManager.Where(e => e.Id == id).SingleOrDefault();
            if (projectManager != null)
            {
                _context.ProjectManager.Remove(projectManager);
                _context.SaveChanges();
            }
            return projectManager;
        }
        #endregion

        #region Method to Search a Project Manager 
        // Method to Search a Project Manager by First Name, Last Name, Email or Contact
        public IEnumerable<ProjectManager> SearchProjectManager(string search) => 
            _context.ProjectManager.Where(p => p.FirstName == search || p.LastName == search || p.Email == search || p.Contact == search);
        #endregion

        #region Method to get email of Project Manager
        // Method to get email of Project Manager to check duplicate email
        public ProjectManager GetEmail(string email) => 
            _context.ProjectManager.Where(w => w.Email == email).SingleOrDefault();
        #endregion

        #region Method to get contact of Project Manager
        // Method to get contact of Project Manager to check duplicate contact
        public ProjectManager GetContact(string contact) => 
            _context.ProjectManager.Where(w => w.Contact == contact).SingleOrDefault();
        #endregion
    }
}
