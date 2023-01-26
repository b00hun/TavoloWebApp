using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TavoloWebAppBll.Models;
using TavoloWebAppBLL.Models;
using TavoloWebAppBLL.Repositories.IRepositories;

namespace TavoloWebAppBLL.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void Create(Project project)
        {
            _projectRepository.Create(project);
        }

        public void Delete(int id)
        {
            _projectRepository.Delete(id);
        }

        public List<Project> GetAll()
        {
           return _projectRepository.GetAll();
        }

        public Project GetById(int id)
        {
            return _projectRepository.GetById(id);
        }

        public void Update(Project project)
        {
            _projectRepository.Update(project);
        }
    }
}
