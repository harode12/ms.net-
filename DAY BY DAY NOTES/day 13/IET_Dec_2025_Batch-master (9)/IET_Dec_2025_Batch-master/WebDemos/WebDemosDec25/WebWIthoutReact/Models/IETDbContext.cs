using Microsoft.EntityFrameworkCore;

namespace WebWIthoutReact.Models
{
    public class IETDbContext:DbContext
        
    {
        public DbSet<Emp> emps { get; set; }
        public DbSet<User> users { get; set; }

        public IETDbContext(DbContextOptions options):base(options)
        { }
    }
}
