using BA2.Entity;
using Microsoft.EntityFrameworkCore;

namespace BA2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Prand> Prands { get; set; }

        
    }
}
