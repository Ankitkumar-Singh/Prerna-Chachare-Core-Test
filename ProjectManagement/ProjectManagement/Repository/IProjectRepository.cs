using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectManagement.Models;
using System.Collections.Generic;

namespace ProjectManagement.Repository
{
    public interface IProjectRepository
    {
        // Method Declaration to get details of a single project
        Project GetProjectDetails(int id);

        // Method Declaration to get list of all projects
        IEnumerable<Project> GetAllProjects();

        // Method Declaration to Add or Edit project
        Project SaveProject(Project project);

        // Method Declaration to delete a project
        Project DeleteProject(int id);

        // Method Declaration to search a project
        IEnumerable<Project> SearchProject(string search);

        // Method Declaration to get project name 
        Project GetProjectName(string name);

        // Method Declaration to get Project Managers List
        List<SelectListItem> GetManagerList();
    }
}
