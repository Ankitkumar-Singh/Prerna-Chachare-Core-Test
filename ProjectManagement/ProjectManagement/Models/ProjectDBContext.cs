using Microsoft.EntityFrameworkCore;

namespace ProjectManagement.Models
{
    public class ProjectDBContext: DbContext
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options)
        : base(options)
        {
        }

        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectManager> ProjectManager { get; set; }
    }
}
