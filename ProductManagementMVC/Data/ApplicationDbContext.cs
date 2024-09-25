using Microsoft.EntityFrameworkCore;
using ProductManagementMVC.Models;

namespace ProductManagementMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
