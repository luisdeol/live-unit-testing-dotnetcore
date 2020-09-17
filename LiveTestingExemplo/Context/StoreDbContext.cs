using LiveTestingExemplo.Entities;
using Microsoft.EntityFrameworkCore;

namespace LiveTestingExemplo.Context
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
