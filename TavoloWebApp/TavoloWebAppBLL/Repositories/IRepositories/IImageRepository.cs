using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TavoloWebAppBLL.Models;

namespace TavoloWebAppBLL.Repositories.IRepositories
{
    public interface IImageRepository
    {
        public void Create(Image image);
    }
}
