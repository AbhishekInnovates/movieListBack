using Microsoft.EntityFrameworkCore;
using movieListBack.Data.Entities;

namespace movieListBack.Data
{
    public class testDatabaseContext : DbContext
    {
        public testDatabaseContext(DbContextOptions<testDatabaseContext> context) : base(context)
        {

        }
        public DbSet<MovieList> Movies { get; set; }
    }
}
