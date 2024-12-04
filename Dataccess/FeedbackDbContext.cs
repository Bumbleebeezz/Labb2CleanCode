using Microsoft.EntityFrameworkCore;

namespace Dataccess
{
    public class FeedbackDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public FeedbackDbContext() { }
        public FeedbackDbContext(DbContextOptions<FeedbackDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}
