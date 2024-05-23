using Microsoft.EntityFrameworkCore;
using Store.DataAccess.Entities;

namespace Store.DataAccess
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options) 
            : base(options)
        { 
        
        }

        public DbSet<Item> Items { get; set; }
    }
}
