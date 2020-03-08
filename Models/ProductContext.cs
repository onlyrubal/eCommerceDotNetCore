using Microsoft.EntityFrameworkCore;
namespace eCommerceDotNetCore.Models
{
    public class ProductContext : DbContext
    {
        //Default Constructor
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> ProductItems { get; set; }

        // Setting up the default field value in CreatedDate Column.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Product>()
                .Property(e => e.CreatedDate)
                .HasDefaultValueSql("getdate()");
        }
    }
}