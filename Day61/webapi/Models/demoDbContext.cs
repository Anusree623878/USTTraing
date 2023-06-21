using Microsoft.EntityFrameworkCore;

namespace webapi.Models
{
    public class demoDbContext : DbContext
    {
        public demoDbContext(DbContextOptions<demoDbContext> options ):base(options)
        {

        }
        public DbSet<Product> Products { get; set; } = null!;
    }
}
