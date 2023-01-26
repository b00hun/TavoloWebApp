using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TavoloWebAppBLL.Data;
using TavoloWebAppBLL.Models;
using TavoloWebAppBLL.Repositories.IRepositories;

namespace TavoloWebAppBLL.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly ApplicationDbContext _context;

        public ImageRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Image image)
        {
            _context.Images.Add(image);
            _context.SaveChanges();
        }
    }
}
