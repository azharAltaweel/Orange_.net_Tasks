using Microsoft.EntityFrameworkCore;

namespace ProductsApp_Task2.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CategoryModel> Categories { get; set; }

        public DbSet<ProductModel> Products { get; set; }
    }
}
