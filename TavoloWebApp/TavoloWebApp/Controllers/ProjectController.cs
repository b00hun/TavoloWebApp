using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TavoloWebAppBLL.Models;
using TavoloWebAppBLL.Services;
using TavoloWebAppBLL.Services.IServices;

namespace TavoloWebAppBLL.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;
        private readonly IImageService _imageService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProjectController(IProjectService projectService,IImageService imageService, IWebHostEnvironment webHostEnvironment)
        {
            _projectService = projectService;
            _webHostEnvironment = webHostEnvironment;
            _imageService = imageService;
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
        public ActionResult Create(Project model,IFormFileCollection? files)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(model);
                }
                _projectService.Create(model);

                string webRootPath = _webHostEnvironment.WebRootPath;
                
                if (files.Count() > 0)
                {
                    foreach (var file in files)
                    {
                        string filename = Guid.NewGuid().ToString();
                        var uploads = Path.Combine(webRootPath, @"Images");
                        var extension = Path.GetExtension(file.FileName);

                        using(var filestreams = new FileStream(Path.Combine(uploads,filename+ extension),FileMode.Create))
                        {
                            file.CopyTo(filestreams);
                        }

                        _imageService.Create(new Image { ImageUrl= @"Images\"+ filename + extension, Project_Id =model.Id });
                        
                    }
                }

                
                
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
