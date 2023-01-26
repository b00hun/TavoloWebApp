using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TavoloWebAppBLL.Models;
using TavoloWebAppBLL.Services;

namespace TavoloWebAppBLL.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        // GET: ProjectController
        public ActionResult Index()
        {
            var model =_projectService.GetAll();

            return View(model);
        }

        // GET: ProjectController/Details/5
        public ActionResult Details(int id)
        {
            var model = _projectService.GetById(id);

            return View(model);
        }

        // GET: ProjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Project model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(model);
                }
                
                _projectService.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _projectService.GetById(id);
            return View(model);
        }

        // POST: ProjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Project model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                _projectService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _projectService.GetById(id);
            return View(model);
        }

        // POST: ProjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _projectService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
