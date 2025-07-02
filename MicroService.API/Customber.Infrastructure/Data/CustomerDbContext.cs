using Microsoft.EntityFrameworkCore;

namespace Customer.Microservice.API.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {

        }
        public DbSet<Entities.Model.Customer> Customers { get; set; }  
    }
}
 