using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TavoloWebAppBLL.Models;

namespace TavoloWebAppBLL.Services
{
    public interface IProjectService
    {
        public List<Project> GetAll();
        public void Create(Project project);

        public Project GetById(int id);
        public void Delete(int id);
        public void Update(Project project);
    }
}
