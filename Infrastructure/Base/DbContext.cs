using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AppContext: DbContext
    {
        public AppContext(DbContextOptions contextOptions): base(contextOptions)
        {
            
        }

        public DbSet<Detail> Details { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }

    }
}