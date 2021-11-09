using Microsoft.EntityFrameworkCore;

namespace DotNetSixApiCrudApp.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions dbContext):base(dbContext)
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
