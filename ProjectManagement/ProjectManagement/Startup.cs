using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectManagement.Models;
using ProjectManagement.Repository;

namespace ProjectManagement
{
    public class Startup
    {
        IConfiguration _configuration;

        public Startup(IConfiguration configuration) =>
            _configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped(typeof(IProjectRepository), typeof(ProjectRepository));
            services.AddScoped(typeof(IProjectManagerRepository), typeof(ProjectManagerRepository));
            services.AddDbContextPool<ProjectDBContext>(
                options => options.UseSqlServer(_configuration.GetConnectionString("ProjectDBConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseStatusCodePagesWithRedirects("/Error/{0}");

            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();
        }
    }
}
