using Health_Center.Models;
using Microsoft.EntityFrameworkCore;

namespace Health_Center.Data
{
    public class AppDbContext: DbContext
    {
        internal object Products;

        public AppDbContext(DbContextOptions<AppDbContext>options ) :base (options)
        {}

        public DbSet<Doctor> Doctors { get; set; } 
    }
}
