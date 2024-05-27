using Microsoft.EntityFrameworkCore;

namespace M_Media.Models
{
    public class MMediaDbContext : DbContext
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<GameModel> Games { get; set; }

        public MMediaDbContext(DbContextOptions<MMediaDbContext> options) : 
            base(options)
        {
        }

    }
}
