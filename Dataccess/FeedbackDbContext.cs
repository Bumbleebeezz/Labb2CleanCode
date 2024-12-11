using Dataccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dataccess
{
    public class FeedbackDbContext : DbContext
    {
        public DbSet<Feedback> Feedbacks { get; set; }

        public FeedbackDbContext() { }
        public FeedbackDbContext(DbContextOptions<FeedbackDbContext> options) : base(options) { }

    }
}
