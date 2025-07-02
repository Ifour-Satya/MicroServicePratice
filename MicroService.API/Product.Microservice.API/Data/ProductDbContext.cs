using Microsoft.EntityFrameworkCore;

namespace Product.Microservice.API.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Model.Product> Products { get; set; }
    }
}
