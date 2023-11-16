using Fluent_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Fluent_API.DataAcsess
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public virtual DbSet<Person>Persons { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
    }
}
