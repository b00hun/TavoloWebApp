using Microsoft.EntityFrameworkCore;
using TavoloWebAppBLL.Models;

namespace TavoloWebAppBLL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Image> Images { get; set; }



    }

}
