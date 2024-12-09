using Dataccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dataccess.Repositories.Feedbacks
{
    public class FeedbackRepository : IFeedbackRepository
    {
        public FeedbackRepository(FeedbackDbContext context, DbSet<Feedback> dbSet) 
        {

        }

        public Task AddAsync(Feedback feedback)
        {
            throw new NotImplementedException();
        }

        public Task<Feedback?> GetByIdAsync(int feedbackId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Feedback>> GetByProductIdAsync(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
