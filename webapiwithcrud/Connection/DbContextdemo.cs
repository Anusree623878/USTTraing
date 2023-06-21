using Microsoft.EntityFrameworkCore;

namespace webapiwithcrud.Connection
{
    public class DbContextdemo:DbContext

    {
        public DbContextdemo(DbContextOptions<DbContextdemo> options):base(options)
        { 

        }
        public DbSet<DbContextdemo> DbContextdemos { get; set; }

    }
}
