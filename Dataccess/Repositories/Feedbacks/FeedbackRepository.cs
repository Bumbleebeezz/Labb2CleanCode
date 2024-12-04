using Dataccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dataccess.Repositories.Feedbacks
{
    public class FeedbackRepository : Repository<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(FeedbackDbContext context, DbSet<Feedback> dbSet) : base(context, dbSet){ }
        
    }
}
