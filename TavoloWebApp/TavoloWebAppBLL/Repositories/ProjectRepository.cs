using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TavoloWebAppBLL.Data;
using TavoloWebAppBll.Models;
using TavoloWebAppBLL.Repositories.IRepositories;
using TavoloWebAppBLL.Models;

namespace TavoloWebAppBLL.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _context;
        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Project GetById(int id)
        {
            var project = _context.Projects.Include(p=>p.Images).FirstOrDefault(p => p.Id == id);

            return project;
        }

        public void Create(Project project)
        {
            _context.Add(project);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var project = GetById(id);
            _context.Remove(project);
            _context.SaveChanges();
        }

        public List<Project> GetAll()
        {
            var projects = _context.Projects.Include(p=>p.Images).ToList();

            return projects; 
        }

        

        public void Update(Project project)
        {
            var model = GetById(project.Id);
            model.Name= project.Name;
            model.Description= project.Description;
            model.Material= project.Material;
            model.TimeOfWork= project.TimeOfWork;
            _context.SaveChanges();

        }
    }
}
