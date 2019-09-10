using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagement.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        #region Database context
        // Database context
        private readonly ProjectDBContext _context;
        #endregion

        #region Constructor of class ProjectRepository
        // Constructor of ProjectRepository class
        public ProjectRepository(ProjectDBContext context) => _context = context;
        #endregion

        #region Method to get list of all Projects
        // Method to get list of projects from database
        public IEnumerable<Project> GetAllProjects() => _context.Project.Include(x => x.ProjectManager);
        #endregion

        #region Method to get details of specific project
        // Method to get details of a project
        public Project GetProjectDetails(int id) => _context.Project.Include(x => x.ProjectManager).SingleOrDefault(x => x.Id == id);
        #endregion

        #region Method to Save a Project
        // Method to add and edit a project
        public Project SaveProject(Project project)
        {
            if (project != null)
            {
                if (project.Id == 0)
                    _context.Project.Add(project);
                else
                    _context.Entry(project).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return _context.Project.Where(x => x.Name == project.Name).FirstOrDefault();
        }
        #endregion

        #region Method to Delete a Project
        // Method to delete a project
        public Project DeleteProject(int id)
        {
            Project project = _context.Project.Where(e => e.Id == id).SingleOrDefault();
            if (project != null)
            {
                _context.Project.Remove(project);
                _context.SaveChanges();
            }
            return project;
        }
        #endregion

        #region Method to Search a Project 
        // Method to search a project by name, manager name or project type
        public IEnumerable<Project> SearchProject(string search) => 
            _context.Project.Include(p => p.ProjectManager).Where(p => p.Name == search || p.ProjectManager.FirstName == search || p.Type == search);
        #endregion

        #region Method to Check Project Name
        // Method to check whether project name already exists
        public Project GetProjectName(string name) => 
            _context.Project.Where(p => p.Name == name).SingleOrDefault();
        #endregion

        #region Method to get manager list
        // Method to get managers list and display in viewbag
        public List<SelectListItem> GetManagerList() => 
            _context.ProjectManager.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.FirstName
            }).ToList();
        #endregion
    }
}
