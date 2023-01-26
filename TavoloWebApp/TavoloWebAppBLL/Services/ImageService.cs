using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TavoloWebAppBLL.Models;
using TavoloWebAppBLL.Repositories.IRepositories;
using TavoloWebAppBLL.Services.IServices;

namespace TavoloWebAppBLL.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;

        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public void Create(Image image)
        {
            _imageRepository.Create(image);
        }
    }
}
