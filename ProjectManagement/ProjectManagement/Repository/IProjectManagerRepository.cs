using ProjectManagement.Models;
using System.Collections.Generic;

namespace ProjectManagement.Repository
{
    public interface IProjectManagerRepository
    {
        // Method Declaration to get details of a single project manager
        ProjectManager GetProjectManagerDetails(int id);

        // Method Declaration to get list of all project managers
        IEnumerable<ProjectManager> GetAllProjectManagers();

        // Method Declaration to Add or Edit project manager
        ProjectManager SaveProjectManager(ProjectManager projectManager);

        // Method Declaration to delete a project manager
        ProjectManager DeleteProjectManager(int id);

        // Method Declaration to search a project manager
        IEnumerable<ProjectManager> SearchProjectManager(string search);

        // Method Declaration to get email of project manager
        ProjectManager GetEmail(string email);

        // Method Declaration to get contact of project manager
        ProjectManager GetContact(string contact);
    }
}
