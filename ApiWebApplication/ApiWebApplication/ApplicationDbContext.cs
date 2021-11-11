using ApiWebApplication.Models;

using Microsoft.EntityFrameworkCore;

namespace ApiWebApplication
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }


        public DbSet<Product> Products { get; set; }
    }
}
